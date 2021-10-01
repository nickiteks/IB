
namespace IB_form
{
    partial class Form_Main_Admin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_change_password = new System.Windows.Forms.Button();
            this.button_add_username = new System.Windows.Forms.Button();
            this.button_block = new System.Windows.Forms.Button();
            this.button_limit_on = new System.Windows.Forms.Button();
            this.button_limit_off = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(906, 377);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1106, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // button_change_password
            // 
            this.button_change_password.Location = new System.Drawing.Point(955, 40);
            this.button_change_password.Name = "button_change_password";
            this.button_change_password.Size = new System.Drawing.Size(139, 33);
            this.button_change_password.TabIndex = 2;
            this.button_change_password.Text = "Изменить пароль";
            this.button_change_password.UseVisualStyleBackColor = true;
            this.button_change_password.Click += new System.EventHandler(this.button_change_password_Click);
            // 
            // button_add_username
            // 
            this.button_add_username.Location = new System.Drawing.Point(955, 93);
            this.button_add_username.Name = "button_add_username";
            this.button_add_username.Size = new System.Drawing.Size(139, 39);
            this.button_add_username.TabIndex = 3;
            this.button_add_username.Text = "Добавить имя пользователя";
            this.button_add_username.UseVisualStyleBackColor = true;
            // 
            // button_block
            // 
            this.button_block.Location = new System.Drawing.Point(955, 151);
            this.button_block.Name = "button_block";
            this.button_block.Size = new System.Drawing.Size(139, 39);
            this.button_block.TabIndex = 4;
            this.button_block.Text = "Заблокировать";
            this.button_block.UseVisualStyleBackColor = true;
            // 
            // button_limit_on
            // 
            this.button_limit_on.Location = new System.Drawing.Point(955, 217);
            this.button_limit_on.Name = "button_limit_on";
            this.button_limit_on.Size = new System.Drawing.Size(139, 44);
            this.button_limit_on.TabIndex = 5;
            this.button_limit_on.Text = "Включить ограничения";
            this.button_limit_on.UseVisualStyleBackColor = true;
            // 
            // button_limit_off
            // 
            this.button_limit_off.Location = new System.Drawing.Point(955, 279);
            this.button_limit_off.Name = "button_limit_off";
            this.button_limit_off.Size = new System.Drawing.Size(139, 44);
            this.button_limit_off.TabIndex = 6;
            this.button_limit_off.Text = "Выключить ограничения";
            this.button_limit_off.UseVisualStyleBackColor = true;
            // 
            // Form_Main_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 545);
            this.Controls.Add(this.button_limit_off);
            this.Controls.Add(this.button_limit_on);
            this.Controls.Add(this.button_block);
            this.Controls.Add(this.button_add_username);
            this.Controls.Add(this.button_change_password);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form_Main_Admin";
            this.Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button button_change_password;
        private System.Windows.Forms.Button button_add_username;
        private System.Windows.Forms.Button button_block;
        private System.Windows.Forms.Button button_limit_on;
        private System.Windows.Forms.Button button_limit_off;
    }
}