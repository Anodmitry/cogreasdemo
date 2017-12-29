namespace DB_Change_API
{
    partial class DeletePhenoForm
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
            this.but_delPheno = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_cancel
            // 
            this.but_cancel.Location = new System.Drawing.Point(164, 69);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(105, 26);
            this.but_cancel.TabIndex = 9;
            this.but_cancel.Text = "Отменить";
            this.but_cancel.UseVisualStyleBackColor = true;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // but_delPheno
            // 
            this.but_delPheno.Location = new System.Drawing.Point(21, 69);
            this.but_delPheno.Name = "but_delPheno";
            this.but_delPheno.Size = new System.Drawing.Size(105, 26);
            this.but_delPheno.TabIndex = 8;
            this.but_delPheno.Text = "Удалить";
            this.but_delPheno.UseVisualStyleBackColor = true;
            this.but_delPheno.Click += new System.EventHandler(this.but_delPheno_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(147, 18);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(122, 20);
            this.tb_name.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите имя явления";
            // 
            // DeletePhenoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 117);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_delPheno);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "DeletePhenoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удаление явления";
            this.Load += new System.EventHandler(this.DeletePhenoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_delPheno;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
    }
}