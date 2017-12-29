namespace DB_Change_API
{
    partial class DelRobotDefenceTypeForm
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
            this.but_delRobotChar = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_cancel
            // 
            this.but_cancel.Location = new System.Drawing.Point(220, 72);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(105, 26);
            this.but_cancel.TabIndex = 17;
            this.but_cancel.Text = "Отменить";
            this.but_cancel.UseVisualStyleBackColor = true;
            // 
            // but_delRobotChar
            // 
            this.but_delRobotChar.Location = new System.Drawing.Point(77, 72);
            this.but_delRobotChar.Name = "but_delRobotChar";
            this.but_delRobotChar.Size = new System.Drawing.Size(105, 26);
            this.but_delRobotChar.TabIndex = 16;
            this.but_delRobotChar.Text = "Удалить";
            this.but_delRobotChar.UseVisualStyleBackColor = true;
            this.but_delRobotChar.Click += new System.EventHandler(this.but_delRobotChar_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(230, 25);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(152, 20);
            this.tb_name.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Введите название действия защиты";
            // 
            // DelRobotDefenceTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.but_cancel;
            this.ClientSize = new System.Drawing.Size(406, 110);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_delRobotChar);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "DelRobotDefenceTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удаление действия защиты";
            this.Load += new System.EventHandler(this.DelRobotDefenceTypeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_delRobotChar;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
    }
}