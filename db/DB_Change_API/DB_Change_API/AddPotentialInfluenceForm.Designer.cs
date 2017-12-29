namespace DB_Change_API
{
    partial class AddPotentialInfluenceForm
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
            this.tb_ch_param = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_radius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_max_part = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chbox_depend_dist = new System.Windows.Forms.CheckBox();
            this.tb_change_type = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_var_name = new System.Windows.Forms.TextBox();
            this.label_new_name = new System.Windows.Forms.Label();
            this.tb_name_action = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_ch_param
            // 
            this.tb_ch_param.Location = new System.Drawing.Point(237, 26);
            this.tb_ch_param.Name = "tb_ch_param";
            this.tb_ch_param.Size = new System.Drawing.Size(123, 20);
            this.tb_ch_param.TabIndex = 55;
            this.tb_ch_param.Click += new System.EventHandler(this.tb_ch_param_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Введите название параметра робота";
            // 
            // tb_radius
            // 
            this.tb_radius.Location = new System.Drawing.Point(237, 65);
            this.tb_radius.Name = "tb_radius";
            this.tb_radius.Size = new System.Drawing.Size(54, 20);
            this.tb_radius.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Введите максимальный радиус";
            // 
            // tb_max_part
            // 
            this.tb_max_part.Location = new System.Drawing.Point(237, 102);
            this.tb_max_part.Name = "tb_max_part";
            this.tb_max_part.Size = new System.Drawing.Size(54, 20);
            this.tb_max_part.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Введите максимальный урон";
            // 
            // chbox_depend_dist
            // 
            this.chbox_depend_dist.AutoSize = true;
            this.chbox_depend_dist.Location = new System.Drawing.Point(81, 143);
            this.chbox_depend_dist.Name = "chbox_depend_dist";
            this.chbox_depend_dist.Size = new System.Drawing.Size(223, 17);
            this.chbox_depend_dist.TabIndex = 60;
            this.chbox_depend_dist.Text = "Размера урона зависит от расстояния";
            this.chbox_depend_dist.UseVisualStyleBackColor = true;
            // 
            // tb_change_type
            // 
            this.tb_change_type.Location = new System.Drawing.Point(237, 180);
            this.tb_change_type.Name = "tb_change_type";
            this.tb_change_type.Size = new System.Drawing.Size(123, 20);
            this.tb_change_type.TabIndex = 62;
            this.tb_change_type.Click += new System.EventHandler(this.tb_change_type_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Введите тип изменения параметра";
            // 
            // tb_var_name
            // 
            this.tb_var_name.Location = new System.Drawing.Point(237, 259);
            this.tb_var_name.Name = "tb_var_name";
            this.tb_var_name.Size = new System.Drawing.Size(123, 20);
            this.tb_var_name.TabIndex = 66;
            this.tb_var_name.Click += new System.EventHandler(this.tb_var_name_Click);
            // 
            // label_new_name
            // 
            this.label_new_name.AutoSize = true;
            this.label_new_name.Location = new System.Drawing.Point(23, 262);
            this.label_new_name.Name = "label_new_name";
            this.label_new_name.Size = new System.Drawing.Size(151, 13);
            this.label_new_name.TabIndex = 65;
            this.label_new_name.Text = "Введите название вариации";
            // 
            // tb_name_action
            // 
            this.tb_name_action.Location = new System.Drawing.Point(237, 221);
            this.tb_name_action.Name = "tb_name_action";
            this.tb_name_action.Size = new System.Drawing.Size(123, 20);
            this.tb_name_action.TabIndex = 64;
            this.tb_name_action.Click += new System.EventHandler(this.tb_name_action_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Введите название действия";
            // 
            // but_cancel
            // 
            this.but_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_cancel.Location = new System.Drawing.Point(214, 301);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(105, 26);
            this.but_cancel.TabIndex = 68;
            this.but_cancel.Text = "Отменить";
            this.but_cancel.UseVisualStyleBackColor = true;
            // 
            // but_ok
            // 
            this.but_ok.Location = new System.Drawing.Point(71, 301);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(105, 26);
            this.but_ok.TabIndex = 67;
            this.but_ok.Text = "Добавить";
            this.but_ok.UseVisualStyleBackColor = true;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // AddPotentialInfluenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.but_cancel;
            this.ClientSize = new System.Drawing.Size(392, 339);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_ok);
            this.Controls.Add(this.tb_var_name);
            this.Controls.Add(this.label_new_name);
            this.Controls.Add(this.tb_name_action);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_change_type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chbox_depend_dist);
            this.Controls.Add(this.tb_max_part);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_radius);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ch_param);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddPotentialInfluenceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление потенциального воздействия";
            this.Load += new System.EventHandler(this.AddPotencialInfluenceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ch_param;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_radius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_max_part;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbox_depend_dist;
        private System.Windows.Forms.TextBox tb_change_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_var_name;
        private System.Windows.Forms.Label label_new_name;
        private System.Windows.Forms.TextBox tb_name_action;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_ok;
    }
}