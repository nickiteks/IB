
namespace IB_form
{
    partial class Form_Add_Username
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
            this.button_OK = new System.Windows.Forms.Button();
            this.button_cansel = new System.Windows.Forms.Button();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(99, 69);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            // 
            // button_cansel
            // 
            this.button_cansel.Location = new System.Drawing.Point(199, 69);
            this.button_cansel.Name = "button_cansel";
            this.button_cansel.Size = new System.Drawing.Size(75, 23);
            this.button_cansel.TabIndex = 1;
            this.button_cansel.Text = "Отмена";
            this.button_cansel.UseVisualStyleBackColor = true;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(99, 24);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(228, 20);
            this.textBox_username.TabIndex = 2;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_username.Location = new System.Drawing.Point(54, 24);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(39, 17);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "Имя:";
            // 
            // Form_Add_Username
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 104);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.button_cansel);
            this.Controls.Add(this.button_OK);
            this.Name = "Form_Add_Username";
            this.Text = "Добавить имя пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_cansel;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_username;
    }
}