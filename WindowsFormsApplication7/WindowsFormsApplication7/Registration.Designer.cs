namespace WindowsFormsApplication7
{
    partial class Registration
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.NameLable = new System.Windows.Forms.Label();
            this.LoginLable = new System.Windows.Forms.Label();
            this.PasswordLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(69, 34);
            this.NameBox.MaxLength = 10;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 0;
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(69, 70);
            this.LoginBox.MaxLength = 10;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(100, 20);
            this.LoginBox.TabIndex = 1;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(69, 107);
            this.PasswordBox.MaxLength = 10;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Location = new System.Drawing.Point(202, 41);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(29, 13);
            this.NameLable.TabIndex = 5;
            this.NameLable.Text = "Имя";
            // 
            // LoginLable
            // 
            this.LoginLable.AutoSize = true;
            this.LoginLable.Location = new System.Drawing.Point(202, 77);
            this.LoginLable.Name = "LoginLable";
            this.LoginLable.Size = new System.Drawing.Size(38, 13);
            this.LoginLable.TabIndex = 6;
            this.LoginLable.Text = "Логин";
            // 
            // PasswordLable
            // 
            this.PasswordLable.AutoSize = true;
            this.PasswordLable.Location = new System.Drawing.Point(202, 114);
            this.PasswordLable.Name = "PasswordLable";
            this.PasswordLable.Size = new System.Drawing.Size(45, 13);
            this.PasswordLable.TabIndex = 7;
            this.PasswordLable.Text = "Пароль";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 206);
            this.Controls.Add(this.PasswordLable);
            this.Controls.Add(this.LoginLable);
            this.Controls.Add(this.NameLable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.NameBox);
            this.Name = "Registration";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.Label LoginLable;
        private System.Windows.Forms.Label PasswordLable;
    }
}