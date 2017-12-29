namespace DB_Change_API
{
    partial class ChangeRobotCharForm
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_newval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_changeRobotChar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(232, 18);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(120, 20);
            this.tb_name.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Введите название характеристики";
            // 
            // tb_newval
            // 
            this.tb_newval.Location = new System.Drawing.Point(232, 54);
            this.tb_newval.Name = "tb_newval";
            this.tb_newval.Size = new System.Drawing.Size(120, 20);
            this.tb_newval.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Введите новое значение";
            // 
            // but_cancel
            // 
            this.but_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_cancel.Location = new System.Drawing.Point(225, 100);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(105, 26);
            this.but_cancel.TabIndex = 17;
            this.but_cancel.Text = "Отменить";
            this.but_cancel.UseVisualStyleBackColor = true;
            // 
            // but_changeRobotChar
            // 
            this.but_changeRobotChar.Location = new System.Drawing.Point(43, 100);
            this.but_changeRobotChar.Name = "but_changeRobotChar";
            this.but_changeRobotChar.Size = new System.Drawing.Size(149, 26);
            this.but_changeRobotChar.TabIndex = 16;
            this.but_changeRobotChar.Text = "Изменить характеристику";
            this.but_changeRobotChar.UseVisualStyleBackColor = true;
            this.but_changeRobotChar.Click += new System.EventHandler(this.but_changeRobotChar_Click);
            // 
            // ChangeRobotCharForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.but_cancel;
            this.ClientSize = new System.Drawing.Size(375, 139);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_changeRobotChar);
            this.Controls.Add(this.tb_newval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ChangeRobotCharForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменение характеристики робота";
            this.Load += new System.EventHandler(this.ChangeRobotCharForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_newval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_changeRobotChar;
    }
}