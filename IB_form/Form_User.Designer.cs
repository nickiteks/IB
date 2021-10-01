
namespace IB_form
{
    partial class Form_User
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
            this.button_change = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(89, 32);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(139, 40);
            this.button_change.TabIndex = 0;
            this.button_change.Text = "Сменить пароль";
            this.button_change.UseVisualStyleBackColor = true;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(89, 91);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(139, 40);
            this.button_exit.TabIndex = 1;
            this.button_exit.Text = "Выход";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // Form_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 192);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_change);
            this.Name = "Form_User";
            this.Text = "Главная";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Button button_exit;
    }
}