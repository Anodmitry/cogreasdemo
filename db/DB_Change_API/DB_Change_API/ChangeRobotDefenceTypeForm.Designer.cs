namespace DB_Change_API
{
    partial class ChangeRobotDefenceTypeForm
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
            this.but_changeDefType = new System.Windows.Forms.Button();
            this.tb_new_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_energySpending = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_old_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_cancel
            // 
            this.but_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_cancel.Location = new System.Drawing.Point(218, 167);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(105, 26);
            this.but_cancel.TabIndex = 35;
            this.but_cancel.Text = "Отменить";
            this.but_cancel.UseVisualStyleBackColor = true;
            // 
            // but_changeDefType
            // 
            this.but_changeDefType.Location = new System.Drawing.Point(75, 167);
            this.but_changeDefType.Name = "but_changeDefType";
            this.but_changeDefType.Size = new System.Drawing.Size(105, 26);
            this.but_changeDefType.TabIndex = 34;
            this.but_changeDefType.Text = "Изменить";
            this.but_changeDefType.UseVisualStyleBackColor = true;
            this.but_changeDefType.Click += new System.EventHandler(this.but_changeDefType_Click);
            // 
            // tb_new_name
            // 
            this.tb_new_name.Location = new System.Drawing.Point(240, 59);
            this.tb_new_name.Name = "tb_new_name";
            this.tb_new_name.Size = new System.Drawing.Size(123, 20);
            this.tb_new_name.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Введите новое название";
            // 
            // tb_energySpending
            // 
            this.tb_energySpending.Location = new System.Drawing.Point(240, 106);
            this.tb_energySpending.Name = "tb_energySpending";
            this.tb_energySpending.Size = new System.Drawing.Size(71, 20);
            this.tb_energySpending.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Введите новое количество \r\nзатрачиваемой энергии";
            // 
            // tb_old_name
            // 
            this.tb_old_name.Location = new System.Drawing.Point(240, 21);
            this.tb_old_name.Name = "tb_old_name";
            this.tb_old_name.Size = new System.Drawing.Size(123, 20);
            this.tb_old_name.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Введите название действия защиты";
            // 
            // ChangeRobotDefenceTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.but_cancel;
            this.ClientSize = new System.Drawing.Size(389, 207);
            this.Controls.Add(this.tb_old_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_changeDefType);
            this.Controls.Add(this.tb_new_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_energySpending);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ChangeRobotDefenceTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменение действия защиты";
            this.Load += new System.EventHandler(this.ChangeRobotDefenceTypeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_changeDefType;
        private System.Windows.Forms.TextBox tb_new_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_energySpending;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_old_name;
        private System.Windows.Forms.Label label5;
    }
}