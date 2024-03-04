namespace Student
{
    partial class printCourse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_printCourse = new System.Windows.Forms.Panel();
            this.label_printCourse = new System.Windows.Forms.Label();
            this.panel_form = new System.Windows.Forms.Panel();
            this.comboBox_class = new System.Windows.Forms.ComboBox();
            this.label_selectClass = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.button_print = new System.Windows.Forms.Button();
            this.DataGrid_course = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel_printCourse.SuspendLayout();
            this.panel_form.SuspendLayout();
            this.panel_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_course)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_printCourse
            // 
            this.panel_printCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_printCourse.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_printCourse.Controls.Add(this.label_printCourse);
            this.panel_printCourse.Location = new System.Drawing.Point(-13, 2);
            this.panel_printCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_printCourse.Name = "panel_printCourse";
            this.panel_printCourse.Size = new System.Drawing.Size(999, 44);
            this.panel_printCourse.TabIndex = 0;
            // 
            // label_printCourse
            // 
            this.label_printCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_printCourse.AutoSize = true;
            this.label_printCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_printCourse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_printCourse.Location = new System.Drawing.Point(400, 11);
            this.label_printCourse.Name = "label_printCourse";
            this.label_printCourse.Size = new System.Drawing.Size(177, 31);
            this.label_printCourse.TabIndex = 8;
            this.label_printCourse.Text = "Print Course";
            // 
            // panel_form
            // 
            this.panel_form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_form.Controls.Add(this.comboBox_class);
            this.panel_form.Controls.Add(this.label_selectClass);
            this.panel_form.Controls.Add(this.button_search);
            this.panel_form.Controls.Add(this.textBox_search);
            this.panel_form.Controls.Add(this.panel_footer);
            this.panel_form.Controls.Add(this.DataGrid_course);
            this.panel_form.Controls.Add(this.panel_printCourse);
            this.panel_form.Location = new System.Drawing.Point(-5, -2);
            this.panel_form.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(960, 587);
            this.panel_form.TabIndex = 3;
            // 
            // comboBox_class
            // 
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Location = new System.Drawing.Point(167, 52);
            this.comboBox_class.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.Size = new System.Drawing.Size(137, 24);
            this.comboBox_class.TabIndex = 24;
            // 
            // label_selectClass
            // 
            this.label_selectClass.AutoSize = true;
            this.label_selectClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_selectClass.Location = new System.Drawing.Point(27, 52);
            this.label_selectClass.Name = "label_selectClass";
            this.label_selectClass.Size = new System.Drawing.Size(128, 25);
            this.label_selectClass.TabIndex = 23;
            this.label_selectClass.Text = "Select class :";
            // 
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_search.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_search.Location = new System.Drawing.Point(857, 48);
            this.button_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.textBox_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(173, 22);
            this.textBox_search.TabIndex = 21;
            // 
            // panel_footer
            // 
            this.panel_footer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_footer.Controls.Add(this.button_print);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 522);
            this.panel_footer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(960, 65);
            this.panel_footer.TabIndex = 2;
            this.panel_footer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button_print
            // 
            this.button_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_print.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_print.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_print.Location = new System.Drawing.Point(857, 11);
            this.button_print.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(93, 36);
            this.button_print.TabIndex = 19;
            this.button_print.Text = "Print";
            this.button_print.UseVisualStyleBackColor = false;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // DataGrid_course
            // 
            this.DataGrid_course.AllowUserToAddRows = false;
            this.DataGrid_course.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DataGrid_course.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGrid_course.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid_course.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_course.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGrid_course.ColumnHeadersHeight = 24;
            this.DataGrid_course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_course.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGrid_course.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid_course.Location = new System.Drawing.Point(3, 85);
            this.DataGrid_course.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGrid_course.Name = "DataGrid_course";
            this.DataGrid_course.RowHeadersVisible = false;
            this.DataGrid_course.RowHeadersWidth = 51;
            this.DataGrid_course.RowTemplate.Height = 80;
            this.DataGrid_course.Size = new System.Drawing.Size(959, 432);
            this.DataGrid_course.TabIndex = 1;
            this.DataGrid_course.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_course.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGrid_course.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGrid_course.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGrid_course.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGrid_course.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.DataGrid_course.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid_course.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGrid_course.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_course.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGrid_course.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGrid_course.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGrid_course.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGrid_course.ThemeStyle.ReadOnly = false;
            this.DataGrid_course.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_course.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGrid_course.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGrid_course.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGrid_course.ThemeStyle.RowsStyle.Height = 80;
            this.DataGrid_course.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid_course.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // printCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 581);
            this.Controls.Add(this.panel_form);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "printCourse";
            this.Text = "printCourse";
            this.Load += new System.EventHandler(this.printCourse_Load);
            this.panel_printCourse.ResumeLayout(false);
            this.panel_printCourse.PerformLayout();
            this.panel_form.ResumeLayout(false);
            this.panel_form.PerformLayout();
            this.panel_footer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_course)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_printCourse;
        private System.Windows.Forms.Label label_printCourse;
        private System.Windows.Forms.Panel panel_form;
        private System.Windows.Forms.ComboBox comboBox_class;
        private System.Windows.Forms.Label label_selectClass;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private Guna.UI2.WinForms.Guna2DataGridView DataGrid_course;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.Button button_print;
    }
}