using MessageServer;
using MessageServerClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageServerClientDemo
{
    public partial class FrmMain : Form
    {
        //string baseUrl = "https://messaging.nascosoft.ly/api";
        //string baseUrl = "https://localhost:7252/api";
        //string instanceId = "instance9621";
        //string token = "rgqmekfmvkwgrwkh";
        //string referenceId = "123";
        string jwt = "";
        DateTime jwtexpirty;
        public FrmMain()
        {
            InitializeComponent();
        }

        async private void btnSEndText_Click(object sender, EventArgs e)
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
            WhatsAppClient client = new WhatsAppClient(jwt);
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

            WhatsAppClient client = new WhatsAppClient(jwt);
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
            WhatsAppClient client = new WhatsAppClient(jwt);

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
            WhatsAppClient client = new WhatsAppClient(jwt);
            var ml = await client.GetMessagesAsync(1, 100);
            messagesBindingSource.DataSource = ml;
        }

        async private void btnCheckUser_Click(object sender, EventArgs e)
        {
            WhatsAppClient client = new WhatsAppClient(jwt);
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

        async private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            var client = new WhatsAppClient(null); //jwt is not required now
            var ar = await client.Authenticate(txtUserName.Text, txtPassword.Text);

            if (ar != null)
            {
                jwt = ar.Jwt;
                jwtexpirty = ar.JwtExpiry;
                var expirtystr = $"Token valid Until {ar.JwtExpiry}\n\rSubscription valid until {ar.SubscriptionExpiryDate}";
                lblExpiry.Text = expirtystr;
            }
            else
            {
                MessageBox.Show(this, "authentication Failed");
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
    }
}
