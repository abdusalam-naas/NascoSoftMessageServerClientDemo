using MessageServerClient;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageServerClientDemo
{
    public partial class FrmSms : Form
    {
        string smsJwt = "";
        DateTime smsJwtexpirty;
        DateTime smsSubscriptionExpiry;
        const string smsApiServer = "https://msg.nascosoft.ly";
        //const string smsApiServer = "http://192.168.1.50:5252";
        HubConnection connection;

        public FrmSms()
        {
            InitializeComponent();
        }

        
        async void StartConnection()
        {
            var signalRUrl = $"{smsApiServer}/smshub";
            connection = new HubConnectionBuilder()
                .WithUrl(signalRUrl, options =>
                {
                    options.AccessTokenProvider = ()=> Task.FromResult(smsJwt);
                })
                .Build();
            connection.On("SendClientInfo", () =>
            {
                connection.SendAsync("ReceiveClientInfo", "Abdusalam pc");
            });
            //connection.ServerTimeout = new TimeSpan(0, 0, 2);
            try
            {
                await connection.StartAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartConnection();
        }

        async private void button2_Click(object sender, EventArgs e)
        {
            await connection.StopAsync();
        }

        SmsClient CreateSmsClient(string jwt)
        {
            var smsapiurl = $"{smsApiServer}/api/sms/";
            return new SmsClient(new Uri(smsapiurl), jwt);
        }


        async private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            var client = CreateSmsClient(null);
            var ar = await client.Authenticate(txtUserName.Text, txtPassword.Text);

            if (ar != null)
            {
                smsJwt = ar.Jwt;
                smsSubscriptionExpiry = ar.SubscriptionExpiryDate;
                smsJwtexpirty = ar.JwtExpiry;
                var expirtystr = $"Token valid Until {ar.JwtExpiry}\n\rSubscription valid until {ar.SubscriptionExpiryDate}";
                lblExpiry.Text = expirtystr;
            }
            else
            {
                MessageBox.Show(this, "authentication Failed");
            }
        }

        async private void btnSEndText_Click(object sender, EventArgs e)
        {
            var client = CreateSmsClient(smsJwt);
            await client.SendTextAsync(txtPhoneNo.Text, txtMessage.Text);
        }
    }
}
