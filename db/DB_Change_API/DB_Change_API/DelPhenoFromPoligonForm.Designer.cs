namespace DB_Change_API
{
    partial class DelPhenoFromPoligonForm
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
            this.tb_idStr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_delPhenoFromPoligon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_idStr
            // 
            this.tb_idStr.Location = new System.Drawing.Point(202, 23);
            this.tb_idStr.Name = "tb_idStr";
            this.tb_idStr.Size = new System.Drawing.Size(44, 20);
            this.tb_idStr.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Введите ID строки";
            // 
            // but_cancel
            // 
            this.but_cancel.Location = new System.Drawing.Point(166, 63);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(105, 26);
            this.but_cancel.TabIndex = 21;
            this.but_cancel.Text = "Отменить";
            this.but_cancel.UseVisualStyleBackColor = true;
            // 
            // but_delPhenoFromPoligon
            // 
            this.but_delPhenoFromPoligon.Location = new System.Drawing.Point(23, 63);
            this.but_delPhenoFromPoligon.Name = "but_delPhenoFromPoligon";
            this.but_delPhenoFromPoligon.Size = new System.Drawing.Size(105, 26);
            this.but_delPhenoFromPoligon.TabIndex = 20;
            this.but_delPhenoFromPoligon.Text = "Удалить явление";
            this.but_delPhenoFromPoligon.UseVisualStyleBackColor = true;
            // 
            // DelPhenoFromPoligonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 103);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_delPhenoFromPoligon);
            this.Controls.Add(this.tb_idStr);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "DelPhenoFromPoligonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удаление явления с полигона";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_idStr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_delPhenoFromPoligon;
    }
}