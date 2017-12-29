namespace DB_Change_API
{
    partial class DelAOCharForm
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
            this.but_delChar = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_chName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_cancel
            // 
            this.but_cancel.Location = new System.Drawing.Point(257, 104);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(105, 26);
            this.but_cancel.TabIndex = 17;
            this.but_cancel.Text = "Отменить";
            this.but_cancel.UseVisualStyleBackColor = true;
            // 
            // but_delChar
            // 
            this.but_delChar.Location = new System.Drawing.Point(65, 104);
            this.but_delChar.Name = "but_delChar";
            this.but_delChar.Size = new System.Drawing.Size(146, 26);
            this.but_delChar.TabIndex = 16;
            this.but_delChar.Text = "Удалить характеристику";
            this.but_delChar.UseVisualStyleBackColor = true;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(264, 16);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(44, 20);
            this.tb_id.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Введите ID активного объекта";
            // 
            // tb_chName
            // 
            this.tb_chName.Location = new System.Drawing.Point(264, 56);
            this.tb_chName.Name = "tb_chName";
            this.tb_chName.Size = new System.Drawing.Size(92, 20);
            this.tb_chName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Введите название характеристики";
            // 
            // DelAOCharForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 139);
            this.Controls.Add(this.tb_chName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_delChar);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "DelAOCharForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удаление характеристики активного объекта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_delChar;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_chName;
        private System.Windows.Forms.Label label1;
    }
}