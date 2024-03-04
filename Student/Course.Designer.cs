namespace Student
{
    partial class Course
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_details = new System.Windows.Forms.TextBox();
            this.textBox_hours = new System.Windows.Forms.TextBox();
            this.textBox_courseName = new System.Windows.Forms.TextBox();
            this.label_details = new System.Windows.Forms.Label();
            this.label_hours = new System.Windows.Forms.Label();
            this.label_Course = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.panel_registration = new System.Windows.Forms.Panel();
            this.label_newCourse = new System.Windows.Forms.Label();
            this.panel_form = new System.Windows.Forms.Panel();
            this.DataGrid_course = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2.SuspendLayout();
            this.panel_registration.SuspendLayout();
            this.panel_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_course)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.textBox_details);
            this.panel2.Controls.Add(this.textBox_hours);
            this.panel2.Controls.Add(this.textBox_courseName);
            this.panel2.Controls.Add(this.label_details);
            this.panel2.Controls.Add(this.label_hours);
            this.panel2.Controls.Add(this.label_Course);
            this.panel2.Controls.Add(this.button_clear);
            this.panel2.Controls.Add(this.button_add);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 322);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 157);
            this.panel2.TabIndex = 2;
            // 
            // textBox_details
            // 
            this.textBox_details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_details.Location = new System.Drawing.Point(106, 76);
            this.textBox_details.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_details.Multiline = true;
            this.textBox_details.Name = "textBox_details";
            this.textBox_details.Size = new System.Drawing.Size(330, 67);
            this.textBox_details.TabIndex = 16;
            // 
            // textBox_hours
            // 
            this.textBox_hours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_hours.Location = new System.Drawing.Point(106, 41);
            this.textBox_hours.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_hours.Name = "textBox_hours";
            this.textBox_hours.Size = new System.Drawing.Size(172, 20);
            this.textBox_hours.TabIndex = 15;
            // 
            // textBox_courseName
            // 
            this.textBox_courseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_courseName.Location = new System.Drawing.Point(106, 10);
            this.textBox_courseName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_courseName.Name = "textBox_courseName";
            this.textBox_courseName.Size = new System.Drawing.Size(171, 20);
            this.textBox_courseName.TabIndex = 13;
            // 
            // label_details
            // 
            this.label_details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_details.AutoSize = true;
            this.label_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_details.Location = new System.Drawing.Point(44, 76);
            this.label_details.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_details.Name = "label_details";
            this.label_details.Size = new System.Drawing.Size(58, 16);
            this.label_details.TabIndex = 11;
            this.label_details.Text = "Details  :";
            // 
            // label_hours
            // 
            this.label_hours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_hours.AutoSize = true;
            this.label_hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hours.Location = new System.Drawing.Point(53, 41);
            this.label_hours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_hours.Name = "label_hours";
            this.label_hours.Size = new System.Drawing.Size(49, 16);
            this.label_hours.TabIndex = 10;
            this.label_hours.Text = "Hours :";
            // 
            // label_Course
            // 
            this.label_Course.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Course.AutoSize = true;
            this.label_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Course.Location = new System.Drawing.Point(46, 14);
            this.label_Course.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Course.Name = "label_Course";
            this.label_Course.Size = new System.Drawing.Size(56, 16);
            this.label_Course.TabIndex = 7;
            this.label_Course.Text = "Course :";
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_clear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_clear.Location = new System.Drawing.Point(547, 110);
            this.button_clear.Margin = new System.Windows.Forms.Padding(2);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(70, 35);
            this.button_clear.TabIndex = 5;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_add.Location = new System.Drawing.Point(638, 110);
            this.button_add.Margin = new System.Windows.Forms.Padding(2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(76, 35);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // panel_registration
            // 
            this.panel_registration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_registration.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_registration.Controls.Add(this.label_newCourse);
            this.panel_registration.Location = new System.Drawing.Point(-10, 0);
            this.panel_registration.Margin = new System.Windows.Forms.Padding(2);
            this.panel_registration.Name = "panel_registration";
            this.panel_registration.Size = new System.Drawing.Size(749, 41);
            this.panel_registration.TabIndex = 0;
            // 
            // label_newCourse
            // 
            this.label_newCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_newCourse.AutoSize = true;
            this.label_newCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_newCourse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_newCourse.Location = new System.Drawing.Point(319, 8);
            this.label_newCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_newCourse.Name = "label_newCourse";
            this.label_newCourse.Size = new System.Drawing.Size(115, 24);
            this.label_newCourse.TabIndex = 8;
            this.label_newCourse.Text = "New Course";
            // 
            // panel_form
            // 
            this.panel_form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_form.Controls.Add(this.panel2);
            this.panel_form.Controls.Add(this.DataGrid_course);
            this.panel_form.Controls.Add(this.panel_registration);
            this.panel_form.Location = new System.Drawing.Point(-1, -2);
            this.panel_form.Margin = new System.Windows.Forms.Padding(2);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(720, 479);
            this.panel_form.TabIndex = 2;
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
            this.DataGrid_course.Location = new System.Drawing.Point(0, 34);
            this.DataGrid_course.Margin = new System.Windows.Forms.Padding(2);
            this.DataGrid_course.Name = "DataGrid_course";
            this.DataGrid_course.RowHeadersVisible = false;
            this.DataGrid_course.RowHeadersWidth = 51;
            this.DataGrid_course.RowTemplate.Height = 80;
            this.DataGrid_course.Size = new System.Drawing.Size(721, 284);
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
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 474);
            this.Controls.Add(this.panel_form);
            this.Name = "Course";
            this.Text = "Course";
            this.Load += new System.EventHandler(this.Course_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_registration.ResumeLayout(false);
            this.panel_registration.PerformLayout();
            this.panel_form.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_course)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_details;
        private System.Windows.Forms.TextBox textBox_hours;
        private System.Windows.Forms.TextBox textBox_courseName;
        private System.Windows.Forms.Label label_details;
        private System.Windows.Forms.Label label_hours;
        private System.Windows.Forms.Label label_Course;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Panel panel_registration;
        private System.Windows.Forms.Label label_newCourse;
        private System.Windows.Forms.Panel panel_form;
        private Guna.UI2.WinForms.Guna2DataGridView DataGrid_course;
    }
}