namespace DB_Change_API
{
    partial class ModifyInteractionTypes
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
            this.tb_var_name = new System.Windows.Forms.TextBox();
            this.label_new_name = new System.Windows.Forms.Label();
            this.rb_rename = new System.Windows.Forms.RadioButton();
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_ok = new System.Windows.Forms.Button();
            this.tb_name_action = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_delete = new System.Windows.Forms.RadioButton();
            this.rb_add = new System.Windows.Forms.RadioButton();
            this.tb_new_var = new System.Windows.Forms.TextBox();
            this.label_new_var = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_var_name
            // 
            this.tb_var_name.Location = new System.Drawing.Point(204, 99);
            this.tb_var_name.Name = "tb_var_name";
            this.tb_var_name.Size = new System.Drawing.Size(94, 20);
            this.tb_var_name.TabIndex = 58;
            this.tb_var_name.Click += new System.EventHandler(this.tb_var_name_Click);
            // 
            // label_new_name
            // 
            this.label_new_name.AutoSize = true;
            this.label_new_name.Location = new System.Drawing.Point(21, 102);
            this.label_new_name.Name = "label_new_name";
            this.label_new_name.Size = new System.Drawing.Size(151, 13);
            this.label_new_name.TabIndex = 57;
            this.label_new_name.Text = "Введите название вариации";
            // 
            // rb_rename
            // 
            this.rb_rename.AutoSize = true;
            this.rb_rename.Location = new System.Drawing.Point(130, 15);
            this.rb_rename.Name = "rb_rename";
            this.rb_rename.Size = new System.Drawing.Size(76, 30);
            this.rb_rename.TabIndex = 56;
            this.rb_rename.TabStop = true;
            this.rb_rename.Text = "Изменить\r\nвариацию";
            this.rb_rename.UseVisualStyleBackColor = true;
            this.rb_rename.CheckedChanged += new System.EventHandler(this.rb_rename_CheckedChanged);
            // 
            // but_cancel
            // 
            this.but_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_cancel.Location = new System.Drawing.Point(186, 178);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(105, 26);
            this.but_cancel.TabIndex = 55;
            this.but_cancel.Text = "Отменить";
            this.but_cancel.UseVisualStyleBackColor = true;
            // 
            // but_ok
            // 
            this.but_ok.Location = new System.Drawing.Point(43, 178);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(105, 26);
            this.but_ok.TabIndex = 54;
            this.but_ok.Text = "Применить";
            this.but_ok.UseVisualStyleBackColor = true;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // tb_name_action
            // 
            this.tb_name_action.Location = new System.Drawing.Point(204, 61);
            this.tb_name_action.Name = "tb_name_action";
            this.tb_name_action.Size = new System.Drawing.Size(94, 20);
            this.tb_name_action.TabIndex = 53;
            this.tb_name_action.Click += new System.EventHandler(this.tb_name_action_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Введите название действия";
            // 
            // rb_delete
            // 
            this.rb_delete.AutoSize = true;
            this.rb_delete.Enabled = false;
            this.rb_delete.Location = new System.Drawing.Point(240, 22);
            this.rb_delete.Name = "rb_delete";
            this.rb_delete.Size = new System.Drawing.Size(68, 17);
            this.rb_delete.TabIndex = 51;
            this.rb_delete.TabStop = true;
            this.rb_delete.Text = "Удалить";
            this.rb_delete.UseVisualStyleBackColor = true;
            // 
            // rb_add
            // 
            this.rb_add.AutoSize = true;
            this.rb_add.Location = new System.Drawing.Point(26, 22);
            this.rb_add.Name = "rb_add";
            this.rb_add.Size = new System.Drawing.Size(75, 17);
            this.rb_add.TabIndex = 50;
            this.rb_add.TabStop = true;
            this.rb_add.Text = "Добавить";
            this.rb_add.UseVisualStyleBackColor = true;
            this.rb_add.CheckedChanged += new System.EventHandler(this.rb_add_CheckedChanged);
            // 
            // tb_new_var
            // 
            this.tb_new_var.Location = new System.Drawing.Point(204, 137);
            this.tb_new_var.Name = "tb_new_var";
            this.tb_new_var.Size = new System.Drawing.Size(94, 20);
            this.tb_new_var.TabIndex = 60;
            // 
            // label_new_var
            // 
            this.label_new_var.AutoSize = true;
            this.label_new_var.Location = new System.Drawing.Point(21, 140);
            this.label_new_var.Name = "label_new_var";
            this.label_new_var.Size = new System.Drawing.Size(136, 13);
            this.label_new_var.TabIndex = 59;
            this.label_new_var.Text = "Введите новую вариацию";
            // 
            // ModifyInteractionTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.but_cancel;
            this.ClientSize = new System.Drawing.Size(326, 215);
            this.Controls.Add(this.tb_new_var);
            this.Controls.Add(this.label_new_var);
            this.Controls.Add(this.tb_var_name);
            this.Controls.Add(this.label_new_name);
            this.Controls.Add(this.rb_rename);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_ok);
            this.Controls.Add(this.tb_name_action);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rb_delete);
            this.Controls.Add(this.rb_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ModifyInteractionTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Модификация типов взаимодействия";
            this.Load += new System.EventHandler(this.ModifyInteractionTypes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_var_name;
        private System.Windows.Forms.Label label_new_name;
        private System.Windows.Forms.RadioButton rb_rename;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_ok;
        private System.Windows.Forms.TextBox tb_name_action;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_delete;
        private System.Windows.Forms.RadioButton rb_add;
        private System.Windows.Forms.TextBox tb_new_var;
        private System.Windows.Forms.Label label_new_var;
    }
}