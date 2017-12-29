namespace DB_Change_API
{
    partial class RenameForm
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
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_rename = new System.Windows.Forms.Button();
            this.tb_old_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_new_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_cancel
            // 
            this.but_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_cancel.Location = new System.Drawing.Point(179, 113);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(105, 26);
            this.but_cancel.TabIndex = 13;
            this.but_cancel.Text = "Отменить";
            this.but_cancel.UseVisualStyleBackColor = true;
            // 
            // but_rename
            // 
            this.but_rename.Location = new System.Drawing.Point(38, 113);
            this.but_rename.Name = "but_rename";
            this.but_rename.Size = new System.Drawing.Size(105, 26);
            this.but_rename.TabIndex = 12;
            this.but_rename.Text = "Переименовать";
            this.but_rename.UseVisualStyleBackColor = true;
            this.but_rename.Click += new System.EventHandler(this.but_rename_Click);
            // 
            // tb_old_name
            // 
            this.tb_old_name.Location = new System.Drawing.Point(164, 21);
            this.tb_old_name.Name = "tb_old_name";
            this.tb_old_name.Size = new System.Drawing.Size(122, 20);
            this.tb_old_name.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Введите старое имя";
            // 
            // tb_new_name
            // 
            this.tb_new_name.Location = new System.Drawing.Point(164, 62);
            this.tb_new_name.Name = "tb_new_name";
            this.tb_new_name.Size = new System.Drawing.Size(122, 20);
            this.tb_new_name.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Введите новое имя";
            // 
            // RenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.but_cancel;
            this.ClientSize = new System.Drawing.Size(327, 155);
            this.Controls.Add(this.tb_new_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_rename);
            this.Controls.Add(this.tb_old_name);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RenameForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Переименование";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RenameForm_FormClosing);
            this.Load += new System.EventHandler(this.RenameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_rename;
        private System.Windows.Forms.TextBox tb_old_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_new_name;
        private System.Windows.Forms.Label label1;
    }
}