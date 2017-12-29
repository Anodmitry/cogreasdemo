namespace DB_Change_API
{
    partial class DelPoligonForm
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
            this.but_delPoligon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.but_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_delPoligon
            // 
            this.but_delPoligon.Location = new System.Drawing.Point(18, 67);
            this.but_delPoligon.Name = "but_delPoligon";
            this.but_delPoligon.Size = new System.Drawing.Size(105, 26);
            this.but_delPoligon.TabIndex = 12;
            this.but_delPoligon.Text = "Удалить";
            this.but_delPoligon.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Введите ID полигона";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(180, 19);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(44, 20);
            this.tb_id.TabIndex = 11;
            // 
            // but_cancel
            // 
            this.but_cancel.Location = new System.Drawing.Point(161, 67);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(105, 26);
            this.but_cancel.TabIndex = 13;
            this.but_cancel.Text = "Отменить";
            this.but_cancel.UseVisualStyleBackColor = true;
            // 
            // DelPoligonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 108);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_delPoligon);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "DelPoligonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удаление полигона";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button but_delPoligon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button but_cancel;
    }
}