
namespace IB_form
{
    partial class Form_Login
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
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(105, 128);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(129, 39);
            this.button_login.TabIndex = 0;
            this.button_login.Text = "Войти";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(105, 41);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(254, 20);
            this.textBox_login.TabIndex = 1;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(105, 87);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(254, 20);
            this.textBox_password.TabIndex = 2;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_login.Location = new System.Drawing.Point(37, 35);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(62, 26);
            this.label_login.TabIndex = 3;
            this.label_login.Text = "Имя:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_password.Location = new System.Drawing.Point(7, 81);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(95, 26);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Пароль:";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 185);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.button_login);
            this.Name = "Form_Login";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_password;
    }
}