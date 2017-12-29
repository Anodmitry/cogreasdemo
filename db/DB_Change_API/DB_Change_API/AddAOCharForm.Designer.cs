namespace DB_Change_API
{
    partial class AddAOCharForm
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
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_chName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_chValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_addChar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(286, 22);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(44, 20);
            this.tb_id.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Введите ID активного объекта";
            // 
            // tb_chName
            // 
            this.tb_chName.Location = new System.Drawing.Point(264, 60);
            this.tb_chName.Name = "tb_chName";
            this.tb_chName.Size = new System.Drawing.Size(118, 20);
            this.tb_chName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Введите имя активного объекта";
            // 
            // tb_chValue
            // 
            this.tb_chValue.Location = new System.Drawing.Point(264, 102);
            this.tb_chValue.Name = "tb_chValue";
            this.tb_chValue.Size = new System.Drawing.Size(118, 20);
            this.tb_chValue.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Введите значение характеристики";
            // 
            // but_cancel
            // 
            this.but_cancel.Location = new System.Drawing.Point(264, 142);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(105, 26);
            this.but_cancel.TabIndex = 19;
            this.but_cancel.Text = "Отменить";
            this.but_cancel.UseVisualStyleBackColor = true;
            // 
            // but_addChar
            // 
            this.but_addChar.Location = new System.Drawing.Point(74, 142);
            this.but_addChar.Name = "but_addChar";
            this.but_addChar.Size = new System.Drawing.Size(152, 26);
            this.but_addChar.TabIndex = 18;
            this.but_addChar.Text = "Добавить характеристику";
            this.but_addChar.UseVisualStyleBackColor = true;
            // 
            // AddAOCharForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 180);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_addChar);
            this.Controls.Add(this.tb_chValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_chName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddAOCharForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление характеристики активного объекта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_chName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_chValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_addChar;
    }
}