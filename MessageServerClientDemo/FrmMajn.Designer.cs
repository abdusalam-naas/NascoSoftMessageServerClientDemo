
namespace MessageServerClientDemo
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnGetMessages = new System.Windows.Forms.Button();
            this.messagesDataGridView = new System.Windows.Forms.DataGridView();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sentAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AckStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCheckUser = new System.Windows.Forms.Button();
            this.btnAuthenticate = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCheckMobile = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImageCaption = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDocFileDialog = new System.Windows.Forms.Button();
            this.btnImageFileDialog = new System.Windows.Forms.Button();
            this.txtDocFilePath = new System.Windows.Forms.TextBox();
            this.txtImageFilePath = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.btnSendDocument = new System.Windows.Forms.Button();
            this.btnSendImage = new System.Windows.Forms.Button();
            this.btnSEndText = new System.Windows.Forms.Button();
            this.btnViewDoc = new System.Windows.Forms.Button();
            this.lblExpiry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.messagesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetMessages
            // 
            this.btnGetMessages.Location = new System.Drawing.Point(35, 260);
            this.btnGetMessages.Name = "btnGetMessages";
            this.btnGetMessages.Size = new System.Drawing.Size(129, 20);
            this.btnGetMessages.TabIndex = 6;
            this.btnGetMessages.Text = "Get Messages";
            this.btnGetMessages.UseVisualStyleBackColor = true;
            this.btnGetMessages.Click += new System.EventHandler(this.btnGetMessages_Click);
            // 
            // messagesDataGridView
            // 
            this.messagesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messagesDataGridView.AutoGenerateColumns = false;
            this.messagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CreatedAt,
            this.sentAtDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.toDataGridViewTextBoxColumn,
            this.bodyDataGridViewTextBoxColumn,
            this.AckStatus,
            this.statusDataGridViewTextBoxColumn});
            this.messagesDataGridView.DataSource = this.messagesBindingSource;
            this.messagesDataGridView.Location = new System.Drawing.Point(35, 286);
            this.messagesDataGridView.Name = "messagesDataGridView";
            this.messagesDataGridView.RowHeadersWidth = 51;
            this.messagesDataGridView.Size = new System.Drawing.Size(782, 200);
            this.messagesDataGridView.TabIndex = 14;
            this.messagesDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.messagesDataGridView_RowHeaderMouseDoubleClick);
            // 
            // CreatedAt
            // 
            this.CreatedAt.DataPropertyName = "CreatedAt";
            this.CreatedAt.HeaderText = "CreatedAt";
            this.CreatedAt.MinimumWidth = 6;
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            this.CreatedAt.Width = 125;
            // 
            // sentAtDataGridViewTextBoxColumn
            // 
            this.sentAtDataGridViewTextBoxColumn.DataPropertyName = "SentAt";
            this.sentAtDataGridViewTextBoxColumn.HeaderText = "SentAt";
            this.sentAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sentAtDataGridViewTextBoxColumn.Name = "sentAtDataGridViewTextBoxColumn";
            this.sentAtDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // toDataGridViewTextBoxColumn
            // 
            this.toDataGridViewTextBoxColumn.DataPropertyName = "To";
            this.toDataGridViewTextBoxColumn.HeaderText = "To";
            this.toDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toDataGridViewTextBoxColumn.Name = "toDataGridViewTextBoxColumn";
            this.toDataGridViewTextBoxColumn.Width = 125;
            // 
            // bodyDataGridViewTextBoxColumn
            // 
            this.bodyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bodyDataGridViewTextBoxColumn.DataPropertyName = "Body";
            this.bodyDataGridViewTextBoxColumn.HeaderText = "Body";
            this.bodyDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.bodyDataGridViewTextBoxColumn.Name = "bodyDataGridViewTextBoxColumn";
            // 
            // AckStatus
            // 
            this.AckStatus.DataPropertyName = "AckStatus";
            this.AckStatus.HeaderText = "AckStatus";
            this.AckStatus.MinimumWidth = 6;
            this.AckStatus.Name = "AckStatus";
            this.AckStatus.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // messagesBindingSource
            // 
            this.messagesBindingSource.DataSource = typeof(MessageServer.WhatsAppMessageDto);
            // 
            // btnCheckUser
            // 
            this.btnCheckUser.Location = new System.Drawing.Point(140, 216);
            this.btnCheckUser.Name = "btnCheckUser";
            this.btnCheckUser.Size = new System.Drawing.Size(166, 23);
            this.btnCheckUser.TabIndex = 15;
            this.btnCheckUser.Text = "Check number in whatsapp";
            this.btnCheckUser.UseVisualStyleBackColor = true;
            this.btnCheckUser.Click += new System.EventHandler(this.btnCheckUser_Click);
            // 
            // btnAuthenticate
            // 
            this.btnAuthenticate.Location = new System.Drawing.Point(92, 65);
            this.btnAuthenticate.Name = "btnAuthenticate";
            this.btnAuthenticate.Size = new System.Drawing.Size(101, 23);
            this.btnAuthenticate.TabIndex = 22;
            this.btnAuthenticate.Text = "Authenticate";
            this.btnAuthenticate.UseVisualStyleBackColor = true;
            this.btnAuthenticate.Click += new System.EventHandler(this.btnAuthenticate_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MessageServerClientDemo.Properties.Settings.Default, "UserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtUserName.Location = new System.Drawing.Point(92, 13);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(101, 20);
            this.txtUserName.TabIndex = 23;
            this.txtUserName.Text = global::MessageServerClientDemo.Properties.Settings.Default.UserName;
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MessageServerClientDemo.Properties.Settings.Default, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPassword.Location = new System.Drawing.Point(92, 39);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(101, 20);
            this.txtPassword.TabIndex = 24;
            this.txtPassword.Text = global::MessageServerClientDemo.Properties.Settings.Default.Password;
            // 
            // txtCheckMobile
            // 
            this.txtCheckMobile.Location = new System.Drawing.Point(34, 216);
            this.txtCheckMobile.Name = "txtCheckMobile";
            this.txtCheckMobile.Size = new System.Drawing.Size(100, 20);
            this.txtCheckMobile.TabIndex = 25;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "File Name:";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(440, 241);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(209, 20);
            this.txtFileName.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Image Caption:";
            // 
            // txtImageCaption
            // 
            this.txtImageCaption.Location = new System.Drawing.Point(440, 172);
            this.txtImageCaption.Name = "txtImageCaption";
            this.txtImageCaption.Size = new System.Drawing.Size(149, 20);
            this.txtImageCaption.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Message:";
            // 
            // btnDocFileDialog
            // 
            this.btnDocFileDialog.Location = new System.Drawing.Point(338, 217);
            this.btnDocFileDialog.Name = "btnDocFileDialog";
            this.btnDocFileDialog.Size = new System.Drawing.Size(96, 23);
            this.btnDocFileDialog.TabIndex = 66;
            this.btnDocFileDialog.Text = "Select Document";
            this.btnDocFileDialog.UseVisualStyleBackColor = true;
            this.btnDocFileDialog.Click += new System.EventHandler(this.btnDocFileDialog_Click);
            // 
            // btnImageFileDialog
            // 
            this.btnImageFileDialog.Location = new System.Drawing.Point(338, 147);
            this.btnImageFileDialog.Name = "btnImageFileDialog";
            this.btnImageFileDialog.Size = new System.Drawing.Size(96, 23);
            this.btnImageFileDialog.TabIndex = 65;
            this.btnImageFileDialog.Text = "Select Image";
            this.btnImageFileDialog.UseVisualStyleBackColor = true;
            this.btnImageFileDialog.Click += new System.EventHandler(this.btnImageFileDialog_Click);
            // 
            // txtDocFilePath
            // 
            this.txtDocFilePath.Location = new System.Drawing.Point(440, 218);
            this.txtDocFilePath.Name = "txtDocFilePath";
            this.txtDocFilePath.Size = new System.Drawing.Size(209, 20);
            this.txtDocFilePath.TabIndex = 64;
            this.txtDocFilePath.TextChanged += new System.EventHandler(this.txtDocFilePath_TextChanged);
            // 
            // txtImageFilePath
            // 
            this.txtImageFilePath.Location = new System.Drawing.Point(440, 146);
            this.txtImageFilePath.Name = "txtImageFilePath";
            this.txtImageFilePath.Size = new System.Drawing.Size(209, 20);
            this.txtImageFilePath.TabIndex = 63;
            this.txtImageFilePath.TextChanged += new System.EventHandler(this.txtImageFilePath_TextChanged);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(440, 55);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(209, 76);
            this.txtMessage.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Phone No:";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(440, 18);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(149, 20);
            this.txtPhoneNo.TabIndex = 60;
            // 
            // btnSendDocument
            // 
            this.btnSendDocument.Location = new System.Drawing.Point(655, 218);
            this.btnSendDocument.Name = "btnSendDocument";
            this.btnSendDocument.Size = new System.Drawing.Size(96, 20);
            this.btnSendDocument.TabIndex = 59;
            this.btnSendDocument.Text = "Send Document";
            this.btnSendDocument.UseVisualStyleBackColor = true;
            this.btnSendDocument.Click += new System.EventHandler(this.btnSendDocument_Click);
            // 
            // btnSendImage
            // 
            this.btnSendImage.Location = new System.Drawing.Point(655, 147);
            this.btnSendImage.Name = "btnSendImage";
            this.btnSendImage.Size = new System.Drawing.Size(96, 20);
            this.btnSendImage.TabIndex = 58;
            this.btnSendImage.Text = "Send Image";
            this.btnSendImage.UseVisualStyleBackColor = true;
            this.btnSendImage.Click += new System.EventHandler(this.btnSendImage_Click);
            // 
            // btnSEndText
            // 
            this.btnSEndText.Location = new System.Drawing.Point(655, 57);
            this.btnSEndText.Name = "btnSEndText";
            this.btnSEndText.Size = new System.Drawing.Size(86, 20);
            this.btnSEndText.TabIndex = 57;
            this.btnSEndText.Text = "Send Text";
            this.btnSEndText.UseVisualStyleBackColor = true;
            this.btnSEndText.Click += new System.EventHandler(this.btnSendText_Click);
            // 
            // btnViewDoc
            // 
            this.btnViewDoc.Location = new System.Drawing.Point(192, 259);
            this.btnViewDoc.Name = "btnViewDoc";
            this.btnViewDoc.Size = new System.Drawing.Size(144, 23);
            this.btnViewDoc.TabIndex = 72;
            this.btnViewDoc.Text = "View Image or Document";
            this.btnViewDoc.UseVisualStyleBackColor = true;
            this.btnViewDoc.Click += new System.EventHandler(this.btnViewDoc_Click);
            // 
            // lblExpiry
            // 
            this.lblExpiry.AutoSize = true;
            this.lblExpiry.Location = new System.Drawing.Point(32, 101);
            this.lblExpiry.Name = "lblExpiry";
            this.lblExpiry.Size = new System.Drawing.Size(95, 13);
            this.lblExpiry.TabIndex = 73;
            this.lblExpiry.Text = "Not Authenticated";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 513);
            this.Controls.Add(this.lblExpiry);
            this.Controls.Add(this.btnViewDoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtImageCaption);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDocFileDialog);
            this.Controls.Add(this.btnImageFileDialog);
            this.Controls.Add(this.txtDocFilePath);
            this.Controls.Add(this.txtImageFilePath);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.btnSendDocument);
            this.Controls.Add(this.btnSendImage);
            this.Controls.Add(this.btnSEndText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCheckMobile);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnAuthenticate);
            this.Controls.Add(this.btnCheckUser);
            this.Controls.Add(this.messagesDataGridView);
            this.Controls.Add(this.btnGetMessages);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message Server Client Demo";
            ((System.ComponentModel.ISupportInitialize)(this.messagesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGetMessages;
        private System.Windows.Forms.BindingSource messagesBindingSource;
        private System.Windows.Forms.DataGridView messagesDataGridView;
        private System.Windows.Forms.Button btnCheckUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btnAuthenticate;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCheckMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sentAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AckStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImageCaption;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDocFileDialog;
        private System.Windows.Forms.Button btnImageFileDialog;
        private System.Windows.Forms.TextBox txtDocFilePath;
        private System.Windows.Forms.TextBox txtImageFilePath;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Button btnSendDocument;
        private System.Windows.Forms.Button btnSendImage;
        private System.Windows.Forms.Button btnSEndText;
        private System.Windows.Forms.Button btnViewDoc;
        private System.Windows.Forms.Label lblExpiry;
    }
}

