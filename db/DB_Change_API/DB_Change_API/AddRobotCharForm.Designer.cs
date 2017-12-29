namespace DB_Change_API
{
    partial class AddRobotCharForm
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
            this.but_addChar = new System.Windows.Forms.Button();
            this.tb_chValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_chName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_cancel
            // 
            this.but_cancel.Location = new System.Drawing.Point(228, 100);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(105, 26);
            this.but_cancel.TabIndex = 25;
            this.but_cancel.Text = "Отменить";
            this.but_cancel.UseVisualStyleBackColor = true;
            // 
            // but_addChar
            // 
            this.but_addChar.Location = new System.Drawing.Point(38, 100);
            this.but_addChar.Name = "but_addChar";
            this.but_addChar.Size = new System.Drawing.Size(152, 26);
            this.but_addChar.TabIndex = 24;
            this.but_addChar.Text = "Добавить характеристику";
            this.but_addChar.UseVisualStyleBackColor = true;
            this.but_addChar.Click += new System.EventHandler(this.but_addChar_Click);
            // 
            // tb_chValue
            // 
            this.tb_chValue.Location = new System.Drawing.Point(228, 60);
            this.tb_chValue.Name = "tb_chValue";
            this.tb_chValue.Size = new System.Drawing.Size(118, 20);
            this.tb_chValue.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Введите значение характеристики";
            // 
            // tb_chName
            // 
            this.tb_chName.Location = new System.Drawing.Point(228, 18);
            this.tb_chName.Name = "tb_chName";
            this.tb_chName.Size = new System.Drawing.Size(118, 20);
            this.tb_chName.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Введите название характеристики";
            // 
            // AddRobotCharForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.but_cancel;
            this.ClientSize = new System.Drawing.Size(375, 136);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_addChar);
            this.Controls.Add(this.tb_chValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_chName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddRobotCharForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление характеристики робота";
            this.Load += new System.EventHandler(this.AddRobotCharForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_addChar;
        private System.Windows.Forms.TextBox tb_chValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_chName;
        private System.Windows.Forms.Label label1;
    }
}