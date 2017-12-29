namespace DB_Change_API
{
    partial class AddActObjForm
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
            this.but_addAO = new System.Windows.Forms.Button();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_cancel
            // 
            this.but_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_cancel.Location = new System.Drawing.Point(222, 109);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(105, 26);
            this.but_cancel.TabIndex = 11;
            this.but_cancel.Text = "Отменить";
            this.but_cancel.UseVisualStyleBackColor = true;
            // 
            // but_addAO
            // 
            this.but_addAO.Location = new System.Drawing.Point(79, 109);
            this.but_addAO.Name = "but_addAO";
            this.but_addAO.Size = new System.Drawing.Size(105, 26);
            this.but_addAO.TabIndex = 10;
            this.but_addAO.Text = "Добавить";
            this.but_addAO.UseVisualStyleBackColor = true;
            this.but_addAO.Click += new System.EventHandler(this.but_addAO_Click);
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(222, 59);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(136, 20);
            this.tb_type.TabIndex = 9;
            this.tb_type.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_type_MouseClick);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(222, 16);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(136, 20);
            this.tb_name.TabIndex = 8;
            this.tb_name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_name_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите тип активного объекта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите имя активного объекта";
            // 
            // AddActObjForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.but_cancel;
            this.ClientSize = new System.Drawing.Size(403, 151);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_addAO);
            this.Controls.Add(this.tb_type);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddActObjForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить активный объект";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddActObjForm_FormClosing);
            this.Load += new System.EventHandler(this.AddActObjForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_addAO;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}