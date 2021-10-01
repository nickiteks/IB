
namespace IB_form
{
    partial class Form_Password_Replacement
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
            this.label_password_repeat = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_password_repeat = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_cansel = new System.Windows.Forms.Button();
            this.label_old_password = new System.Windows.Forms.Label();
            this.textBox_old_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_password_repeat
            // 
            this.label_password_repeat.AutoSize = true;
            this.label_password_repeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label_password_repeat.Location = new System.Drawing.Point(17, 116);
            this.label_password_repeat.Name = "label_password_repeat";
            this.label_password_repeat.Size = new System.Drawing.Size(103, 13);
            this.label_password_repeat.TabIndex = 8;
            this.label_password_repeat.Text = "Повторите пароль:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label_password.Location = new System.Drawing.Point(33, 70);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(83, 13);
            this.label_password.TabIndex = 7;
            this.label_password.Text = "Новый пароль:";
            // 
            // textBox_password_repeat
            // 
            this.textBox_password_repeat.Location = new System.Drawing.Point(122, 113);
            this.textBox_password_repeat.Name = "textBox_password_repeat";
            this.textBox_password_repeat.PasswordChar = '*';
            this.textBox_password_repeat.Size = new System.Drawing.Size(254, 20);
            this.textBox_password_repeat.TabIndex = 6;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(122, 67);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(254, 20);
            this.textBox_password.TabIndex = 5;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(122, 172);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 9;
            this.button_OK.Text = "ОК";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_cansel
            // 
            this.button_cansel.Location = new System.Drawing.Point(249, 172);
            this.button_cansel.Name = "button_cansel";
            this.button_cansel.Size = new System.Drawing.Size(75, 23);
            this.button_cansel.TabIndex = 10;
            this.button_cansel.Text = "Отмена";
            this.button_cansel.UseVisualStyleBackColor = true;
            this.button_cansel.Click += new System.EventHandler(this.button_cansel_Click);
            // 
            // label_old_password
            // 
            this.label_old_password.AutoSize = true;
            this.label_old_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label_old_password.Location = new System.Drawing.Point(33, 26);
            this.label_old_password.Name = "label_old_password";
            this.label_old_password.Size = new System.Drawing.Size(87, 13);
            this.label_old_password.TabIndex = 12;
            this.label_old_password.Text = "Старый пароль:";
            // 
            // textBox_old_password
            // 
            this.textBox_old_password.Location = new System.Drawing.Point(122, 23);
            this.textBox_old_password.Name = "textBox_old_password";
            this.textBox_old_password.Size = new System.Drawing.Size(254, 20);
            this.textBox_old_password.TabIndex = 11;
            // 
            // Form_Password_Replacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 222);
            this.Controls.Add(this.label_old_password);
            this.Controls.Add(this.textBox_old_password);
            this.Controls.Add(this.button_cansel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_password_repeat);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_password_repeat);
            this.Controls.Add(this.textBox_password);
            this.Name = "Form_Password_Replacement";
            this.Text = "Замена пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_password_repeat;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_password_repeat;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_cansel;
        private System.Windows.Forms.Label label_old_password;
        private System.Windows.Forms.TextBox textBox_old_password;
    }
}