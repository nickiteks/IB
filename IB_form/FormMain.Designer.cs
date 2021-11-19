
namespace IB_form
{
    partial class FormMain
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
            this.button_save = new System.Windows.Forms.Button();
            this.button_choose_file = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.button_password_from_file = new System.Windows.Forms.Button();
            this.richTextBoxOriginal = new System.Windows.Forms.RichTextBox();
            this.richTextBoxCrypt = new System.Windows.Forms.RichTextBox();
            this.richTextBoxEncrypt = new System.Windows.Forms.RichTextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_variant = new System.Windows.Forms.Label();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.button_decipher = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(579, 201);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(138, 25);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_choose_file
            // 
            this.button_choose_file.Location = new System.Drawing.Point(579, 113);
            this.button_choose_file.Name = "button_choose_file";
            this.button_choose_file.Size = new System.Drawing.Size(138, 24);
            this.button_choose_file.TabIndex = 1;
            this.button_choose_file.Text = "Выбрать файл";
            this.button_choose_file.UseVisualStyleBackColor = true;
            this.button_choose_file.Click += new System.EventHandler(this.button_choose_file_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(126, 68);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(100, 20);
            this.textBox_Password.TabIndex = 5;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_password.Location = new System.Drawing.Point(44, 68);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(71, 20);
            this.label_password.TabIndex = 6;
            this.label_password.Text = "Пароль:";
            // 
            // button_password_from_file
            // 
            this.button_password_from_file.Location = new System.Drawing.Point(126, 146);
            this.button_password_from_file.Name = "button_password_from_file";
            this.button_password_from_file.Size = new System.Drawing.Size(189, 21);
            this.button_password_from_file.TabIndex = 7;
            this.button_password_from_file.Text = "Пароль из файла";
            this.button_password_from_file.UseVisualStyleBackColor = true;
            this.button_password_from_file.Click += new System.EventHandler(this.button_password_from_file_Click);
            // 
            // richTextBoxOriginal
            // 
            this.richTextBoxOriginal.Location = new System.Drawing.Point(12, 354);
            this.richTextBoxOriginal.Name = "richTextBoxOriginal";
            this.richTextBoxOriginal.Size = new System.Drawing.Size(100, 96);
            this.richTextBoxOriginal.TabIndex = 8;
            this.richTextBoxOriginal.Text = "";
            // 
            // richTextBoxCrypt
            // 
            this.richTextBoxCrypt.Location = new System.Drawing.Point(126, 354);
            this.richTextBoxCrypt.Name = "richTextBoxCrypt";
            this.richTextBoxCrypt.Size = new System.Drawing.Size(100, 96);
            this.richTextBoxCrypt.TabIndex = 9;
            this.richTextBoxCrypt.Text = "";
            // 
            // richTextBoxEncrypt
            // 
            this.richTextBoxEncrypt.Location = new System.Drawing.Point(232, 354);
            this.richTextBoxEncrypt.Name = "richTextBoxEncrypt";
            this.richTextBoxEncrypt.Size = new System.Drawing.Size(100, 96);
            this.richTextBoxEncrypt.TabIndex = 10;
            this.richTextBoxEncrypt.Text = "";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(12, 201);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 11;
            this.label_name.Text = "label1";
            // 
            // label_variant
            // 
            this.label_variant.AutoSize = true;
            this.label_variant.Location = new System.Drawing.Point(246, 201);
            this.label_variant.Name = "label_variant";
            this.label_variant.Size = new System.Drawing.Size(35, 13);
            this.label_variant.TabIndex = 12;
            this.label_variant.Text = "label1";
            // 
            // button_encrypt
            // 
            this.button_encrypt.Location = new System.Drawing.Point(579, 143);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(138, 23);
            this.button_encrypt.TabIndex = 13;
            this.button_encrypt.Text = "Зашифровать";
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // button_decipher
            // 
            this.button_decipher.Location = new System.Drawing.Point(579, 172);
            this.button_decipher.Name = "button_decipher";
            this.button_decipher.Size = new System.Drawing.Size(138, 23);
            this.button_decipher.TabIndex = 14;
            this.button_decipher.Text = "Расшифровать";
            this.button_decipher.UseVisualStyleBackColor = true;
            this.button_decipher.Click += new System.EventHandler(this.button_decipher_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 462);
            this.Controls.Add(this.button_decipher);
            this.Controls.Add(this.button_encrypt);
            this.Controls.Add(this.label_variant);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.richTextBoxEncrypt);
            this.Controls.Add(this.richTextBoxCrypt);
            this.Controls.Add(this.richTextBoxOriginal);
            this.Controls.Add(this.button_password_from_file);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.button_choose_file);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_choose_file;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_password_from_file;
        private System.Windows.Forms.RichTextBox richTextBoxOriginal;
        private System.Windows.Forms.RichTextBox richTextBoxCrypt;
        private System.Windows.Forms.RichTextBox richTextBoxEncrypt;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_variant;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.Button button_decipher;
    }
}