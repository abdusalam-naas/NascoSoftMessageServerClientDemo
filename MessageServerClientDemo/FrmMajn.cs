using MessageServer;
using MessageServerClient;
using System;
using System.IO;
using System.Windows.Forms;

namespace MessageServerClientDemo
{
    public partial class FrmMain : Form
    {
        string whatsappJwt = "";
        DateTime whatsappJwtexpirty;
        DateTime whatsappSubscriptionExpiry;
        public FrmMain()
        {
            InitializeComponent();
        }

        WhatsAppClient CreateWhatsAppClient(string jwt)
        {
            return new WhatsAppClient(new Uri("http://192.168.1.50:5252/api/whatsapp/"), jwt);
            //return new WhatsAppClient(new Uri("https://msg.nascosoft.ly/api/whatsapp/"), jwt);
        }

        async private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            var client = CreateWhatsAppClient(null);
            var ar = await client.Authenticate(txtUserName.Text, txtPassword.Text);

            if (ar != null)
            {
                whatsappJwt = ar.Jwt;
                whatsappSubscriptionExpiry = ar.SubscriptionExpiryDate;
                whatsappJwtexpirty = ar.JwtExpiry;
                var expirtystr = $"Token valid Until {ar.JwtExpiry}\n\rSubscription valid until {ar.SubscriptionExpiryDate}";
                lblExpiry.Text = expirtystr;
            }
            else
            {
                MessageBox.Show(this, "authentication Failed");
            }
        }

        async private void btnSendText_Click(object sender, EventArgs e)
        {
            if (txtPhoneNo.Text.Length < 12)
            {
                MessageBox.Show("Phone Number is too short");
                return;
            }
            if (txtMessage.Text.Length == 0)
            {
                MessageBox.Show("No Text");
                return;
            }
            var client = CreateWhatsAppClient(whatsappJwt);
            if (await client.SendTextAsync(txtPhoneNo.Text, txtMessage.Text))
            {
                MessageBox.Show("suceeeded");
            }
            else
            {
                MessageBox.Show("failed");
            }
        }

        async private void btnSendImage_Click(object sender, EventArgs e)
        {
            if (txtPhoneNo.Text.Length < 12)
            {
                MessageBox.Show("Phone Number is too short");
                return;
            }
            if (txtImageFilePath.Text.Length == 0)
            {
                MessageBox.Show("No file path");
                return;
            }
            byte[] ba;
            try
            {
                ba = File.ReadAllBytes(txtImageFilePath.Text);
            }
            catch
            {
                MessageBox.Show("error loading file");
                return;
            }

            var client = CreateWhatsAppClient(whatsappJwt);
            if (await client.SendImage(txtPhoneNo.Text, ba, txtImageCaption.Text))
            {
                MessageBox.Show("suceeded");
            }
            else
            {
                MessageBox.Show("failed");
            }
        }

        async private void btnSendDocument_Click(object sender, EventArgs e)
        {
            if (txtPhoneNo.Text.Length < 12)
            {
                MessageBox.Show("Phone Number is too short");
                return;
            }
            if (txtDocFilePath.Text.Length == 0)
            {
                MessageBox.Show("No file path");
                return;
            }
            byte[] ba;
            try
            {
                ba = File.ReadAllBytes(txtDocFilePath.Text);
            }
            catch
            {
                MessageBox.Show("error loading file");
                return;
            }

            var client = CreateWhatsAppClient(whatsappJwt);

            if (await client.SendDocument(txtPhoneNo.Text, txtFileName.Text, ba))
            {
                MessageBox.Show("suceeded");
            }
            else
            {
                MessageBox.Show("failed");
            }
        }

        async private void btnGetMessages_Click(object sender, EventArgs e)
        {
            var client = CreateWhatsAppClient(whatsappJwt);
            var ml = await client.GetMessagesAsync(1, 100);
            messagesBindingSource.DataSource = ml;
        }

        async private void btnCheckUser_Click(object sender, EventArgs e)
        {
            var client = CreateWhatsAppClient(whatsappJwt);
            if (await client.WhatsAppUserExists(txtCheckMobile.Text))
            {
                MessageBox.Show(this, $"the number: {txtCheckMobile.Text} is Valid");
            }
            else
            {
                MessageBox.Show(this, $"the number: {txtCheckMobile.Text} is not valid");
            }
        }

        private void messagesDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ViewDocument();
        }

        void ViewDocument()
        {
            var m = messagesBindingSource.Current as WhatsAppMessageDto;
            if (m != null && (m.Type == WhatsAppMessageDtoType.Image
                || m.Type == WhatsAppMessageDtoType.Document))
            {
                var f = new FrmViewer(m.Body);
                f.ShowDialog();
            }
        }



        private void btnImageFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.DefaultExt = ""
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImageFilePath.Text = ofd.FileName;
            }
        }

        private void btnDocFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtDocFilePath.Text = ofd.FileName;
            }
        }

        private void txtDocFilePath_TextChanged(object sender, EventArgs e)
        {
            txtFileName.Text = Path.GetFileName(txtDocFilePath.Text);
        }

        private void txtImageFilePath_TextChanged(object sender, EventArgs e)
        {
            txtImageCaption.Text = Path.GetFileName(txtImageFilePath.Text);
        }

        private void btnViewDoc_Click(object sender, EventArgs e)
        {
            ViewDocument();
        }

        private void btnSms_Click(object sender, EventArgs e)
        {
            var f = new FrmSms();
            f.ShowDialog();
        }

        //========================

    }
}
