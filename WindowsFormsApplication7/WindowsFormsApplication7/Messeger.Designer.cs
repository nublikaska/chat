namespace WindowsFormsApplication7
{
    partial class Messeger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.readMessage = new System.Windows.Forms.TextBox();
            this.sendMessage = new System.Windows.Forms.TextBox();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(12, 12);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(170, 21);
            this.comboBoxUsers.TabIndex = 0;
            this.comboBoxUsers.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsers_SelectedIndexChanged);
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.Location = new System.Drawing.Point(219, 349);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(80, 67);
            this.buttonSendMessage.TabIndex = 1;
            this.buttonSendMessage.Text = "Отправить";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // readMessage
            // 
            this.readMessage.Location = new System.Drawing.Point(12, 48);
            this.readMessage.Multiline = true;
            this.readMessage.Name = "readMessage";
            this.readMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.readMessage.Size = new System.Drawing.Size(288, 295);
            this.readMessage.TabIndex = 2;
            // 
            // sendMessage
            // 
            this.sendMessage.AcceptsReturn = true;
            this.sendMessage.Location = new System.Drawing.Point(12, 349);
            this.sendMessage.Multiline = true;
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(201, 69);
            this.sendMessage.TabIndex = 3;
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Location = new System.Drawing.Point(188, 2);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(111, 40);
            this.buttonEditUser.TabIndex = 4;
            this.buttonEditUser.Text = "Изменить данные \r\n   пользователя";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            this.buttonEditUser.Click += new System.EventHandler(this.buttonEditUser_Click);
            // 
            // Messeger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 428);
            this.Controls.Add(this.buttonEditUser);
            this.Controls.Add(this.sendMessage);
            this.Controls.Add(this.readMessage);
            this.Controls.Add(this.buttonSendMessage);
            this.Controls.Add(this.comboBoxUsers);
            this.Name = "Messeger";
            this.Text = "Мессенджер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.Button buttonSendMessage;
        private System.Windows.Forms.TextBox readMessage;
        private System.Windows.Forms.TextBox sendMessage;
        private System.Windows.Forms.Button buttonEditUser;
    }
}