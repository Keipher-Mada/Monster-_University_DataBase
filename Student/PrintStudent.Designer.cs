namespace Student
{
    partial class PrintStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_print = new System.Windows.Forms.Button();
            this.comboBox_sex = new System.Windows.Forms.ComboBox();
            this.label_sex = new System.Windows.Forms.Label();
            this.panel_registration = new System.Windows.Forms.Panel();
            this.label_status = new System.Windows.Forms.Label();
            this.panel_form = new System.Windows.Forms.Panel();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.DataGrid_student = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2.SuspendLayout();
            this.panel_registration.SuspendLayout();
            this.panel_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_student)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.button_print);
            this.panel2.Controls.Add(this.comboBox_sex);
            this.panel2.Controls.Add(this.label_sex);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 523);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 67);
            this.panel2.TabIndex = 2;
            // 
            // button_print
            // 
            this.button_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_print.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_print.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_print.Location = new System.Drawing.Point(857, 12);
            this.button_print.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(93, 36);
            this.button_print.TabIndex = 19;
            this.button_print.Text = "Print";
            this.button_print.UseVisualStyleBackColor = false;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // comboBox_sex
            // 
            this.comboBox_sex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_sex.FormattingEnabled = true;
            this.comboBox_sex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.comboBox_sex.Location = new System.Drawing.Point(89, 21);
            this.comboBox_sex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_sex.Name = "comboBox_sex";
            this.comboBox_sex.Size = new System.Drawing.Size(77, 24);
            this.comboBox_sex.TabIndex = 17;
            // 
            // label_sex
            // 
            this.label_sex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_sex.AutoSize = true;
            this.label_sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sex.Location = new System.Drawing.Point(27, 21);
            this.label_sex.Name = "label_sex";
            this.label_sex.Size = new System.Drawing.Size(62, 26);
            this.label_sex.TabIndex = 9;
            this.label_sex.Text = "Sex :";
            // 
            // panel_registration
            // 
            this.panel_registration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_registration.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_registration.Controls.Add(this.label_status);
            this.panel_registration.Location = new System.Drawing.Point(-13, 0);
            this.panel_registration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_registration.Name = "panel_registration";
            this.panel_registration.Size = new System.Drawing.Size(999, 43);
            this.panel_registration.TabIndex = 0;
            // 
            // label_status
            // 
            this.label_status.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_status.Location = new System.Drawing.Point(461, 11);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(98, 31);
            this.label_status.TabIndex = 8;
            this.label_status.Text = "Status";
            // 
            // panel_form
            // 
            this.panel_form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_form.Controls.Add(this.button_search);
            this.panel_form.Controls.Add(this.textBox_search);
            this.panel_form.Controls.Add(this.panel2);
            this.panel_form.Controls.Add(this.DataGrid_student);
            this.panel_form.Controls.Add(this.panel_registration);
            this.panel_form.Location = new System.Drawing.Point(-3, -2);
            this.panel_form.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(960, 590);
            this.panel_form.TabIndex = 2;
            // 
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_search.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_search.Location = new System.Drawing.Point(857, 48);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(91, 31);
            this.button_search.TabIndex = 22;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_search.Location = new System.Drawing.Point(677, 52);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(173, 22);
            this.textBox_search.TabIndex = 21;
            // 
            // DataGrid_student
            // 
            this.DataGrid_student.AllowUserToAddRows = false;
            this.DataGrid_student.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGrid_student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_student.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid_student.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_student.ColumnHeadersHeight = 24;
            this.DataGrid_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_student.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid_student.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid_student.Location = new System.Drawing.Point(3, 85);
            this.DataGrid_student.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGrid_student.Name = "DataGrid_student";
            this.DataGrid_student.RowHeadersVisible = false;
            this.DataGrid_student.RowHeadersWidth = 51;
            this.DataGrid_student.RowTemplate.Height = 80;
            this.DataGrid_student.Size = new System.Drawing.Size(959, 434);
            this.DataGrid_student.TabIndex = 1;
            this.DataGrid_student.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_student.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGrid_student.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGrid_student.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGrid_student.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGrid_student.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.DataGrid_student.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid_student.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGrid_student.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_student.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGrid_student.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGrid_student.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGrid_student.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGrid_student.ThemeStyle.ReadOnly = false;
            this.DataGrid_student.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_student.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGrid_student.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGrid_student.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGrid_student.ThemeStyle.RowsStyle.Height = 80;
            this.DataGrid_student.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid_student.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // PrintStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 586);
            this.Controls.Add(this.panel_form);
            this.Name = "PrintStudent";
            this.Text = "PrintStudent";
            this.Load += new System.EventHandler(this.PrintStudent_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_registration.ResumeLayout(false);
            this.panel_registration.PerformLayout();
            this.panel_form.ResumeLayout(false);
            this.panel_form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.ComboBox comboBox_sex;
        private System.Windows.Forms.Panel panel_registration;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Panel panel_form;
        private Guna.UI2.WinForms.Guna2DataGridView DataGrid_student;
        private System.Windows.Forms.Label label_sex;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
    }
}