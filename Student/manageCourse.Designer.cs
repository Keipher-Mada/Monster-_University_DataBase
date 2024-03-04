namespace Student
{
    partial class manageCourse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_courseId = new System.Windows.Forms.TextBox();
            this.label_courseId = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_details = new System.Windows.Forms.TextBox();
            this.textBox_hours = new System.Windows.Forms.TextBox();
            this.textBox_courseName = new System.Windows.Forms.TextBox();
            this.label_details = new System.Windows.Forms.Label();
            this.label_hours = new System.Windows.Forms.Label();
            this.label_Course = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.panel_registration = new System.Windows.Forms.Panel();
            this.label_manageCourse = new System.Windows.Forms.Label();
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
            this.panel2.Controls.Add(this.textBox_courseId);
            this.panel2.Controls.Add(this.label_courseId);
            this.panel2.Controls.Add(this.button_clear);
            this.panel2.Controls.Add(this.textBox_details);
            this.panel2.Controls.Add(this.textBox_hours);
            this.panel2.Controls.Add(this.textBox_courseName);
            this.panel2.Controls.Add(this.label_details);
            this.panel2.Controls.Add(this.label_hours);
            this.panel2.Controls.Add(this.label_Course);
            this.panel2.Controls.Add(this.button_update);
            this.panel2.Controls.Add(this.button_delete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 397);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 193);
            this.panel2.TabIndex = 2;
            // 
            // textBox_courseId
            // 
            this.textBox_courseId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_courseId.Location = new System.Drawing.Point(512, 16);
            this.textBox_courseId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_courseId.Name = "textBox_courseId";
            this.textBox_courseId.Size = new System.Drawing.Size(227, 22);
            this.textBox_courseId.TabIndex = 19;
            // 
            // label_courseId
            // 
            this.label_courseId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_courseId.AutoSize = true;
            this.label_courseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_courseId.Location = new System.Drawing.Point(413, 17);
            this.label_courseId.Name = "label_courseId";
            this.label_courseId.Size = new System.Drawing.Size(91, 20);
            this.label_courseId.TabIndex = 18;
            this.label_courseId.Text = "Course Id :";
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_clear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_clear.Location = new System.Drawing.Point(627, 121);
            this.button_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(99, 53);
            this.button_clear.TabIndex = 17;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBox_details
            // 
            this.textBox_details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_details.Location = new System.Drawing.Point(116, 92);
            this.textBox_details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_details.Multiline = true;
            this.textBox_details.Name = "textBox_details";
            this.textBox_details.Size = new System.Drawing.Size(439, 82);
            this.textBox_details.TabIndex = 16;
            // 
            // textBox_hours
            // 
            this.textBox_hours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_hours.Location = new System.Drawing.Point(116, 49);
            this.textBox_hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_hours.Name = "textBox_hours";
            this.textBox_hours.Size = new System.Drawing.Size(228, 22);
            this.textBox_hours.TabIndex = 15;
            // 
            // textBox_courseName
            // 
            this.textBox_courseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_courseName.Location = new System.Drawing.Point(116, 11);
            this.textBox_courseName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_courseName.Name = "textBox_courseName";
            this.textBox_courseName.Size = new System.Drawing.Size(227, 22);
            this.textBox_courseName.TabIndex = 13;
            // 
            // label_details
            // 
            this.label_details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_details.AutoSize = true;
            this.label_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_details.Location = new System.Drawing.Point(33, 92);
            this.label_details.Name = "label_details";
            this.label_details.Size = new System.Drawing.Size(77, 20);
            this.label_details.TabIndex = 11;
            this.label_details.Text = "Details  :";
            // 
            // label_hours
            // 
            this.label_hours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_hours.AutoSize = true;
            this.label_hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hours.Location = new System.Drawing.Point(45, 49);
            this.label_hours.Name = "label_hours";
            this.label_hours.Size = new System.Drawing.Size(65, 20);
            this.label_hours.TabIndex = 10;
            this.label_hours.Text = "Hours :";
            // 
            // label_Course
            // 
            this.label_Course.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Course.AutoSize = true;
            this.label_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Course.Location = new System.Drawing.Point(36, 16);
            this.label_Course.Name = "label_Course";
            this.label_Course.Size = new System.Drawing.Size(73, 20);
            this.label_Course.TabIndex = 7;
            this.label_Course.Text = "Course :";
            // 
            // button_update
            // 
            this.button_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_update.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_update.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_update.Location = new System.Drawing.Point(835, 123);
            this.button_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(111, 53);
            this.button_update.TabIndex = 5;
            this.button_update.Text = "update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_delete.BackColor = System.Drawing.Color.Red;
            this.button_delete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_delete.Location = new System.Drawing.Point(732, 122);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(97, 53);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // panel_registration
            // 
            this.panel_registration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_registration.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_registration.Controls.Add(this.label_manageCourse);
            this.panel_registration.Location = new System.Drawing.Point(-13, 0);
            this.panel_registration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_registration.Name = "panel_registration";
            this.panel_registration.Size = new System.Drawing.Size(999, 50);
            this.panel_registration.TabIndex = 0;
            // 
            // label_manageCourse
            // 
            this.label_manageCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_manageCourse.AutoSize = true;
            this.label_manageCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_manageCourse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_manageCourse.Location = new System.Drawing.Point(401, 10);
            this.label_manageCourse.Name = "label_manageCourse";
            this.label_manageCourse.Size = new System.Drawing.Size(184, 29);
            this.label_manageCourse.TabIndex = 8;
            this.label_manageCourse.Text = "Manage Course";
            // 
            // panel_form
            // 
            this.panel_form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_form.Controls.Add(this.panel2);
            this.panel_form.Controls.Add(this.DataGrid_course);
            this.panel_form.Controls.Add(this.panel_registration);
            this.panel_form.Location = new System.Drawing.Point(-1, -4);
            this.panel_form.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(960, 590);
            this.panel_form.TabIndex = 3;
            // 
            // DataGrid_course
            // 
            this.DataGrid_course.AllowUserToAddRows = false;
            this.DataGrid_course.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGrid_course.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGrid_course.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid_course.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_course.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGrid_course.ColumnHeadersHeight = 24;
            this.DataGrid_course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_course.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGrid_course.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid_course.Location = new System.Drawing.Point(0, 42);
            this.DataGrid_course.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGrid_course.Name = "DataGrid_course";
            this.DataGrid_course.RowHeadersVisible = false;
            this.DataGrid_course.RowHeadersWidth = 51;
            this.DataGrid_course.RowTemplate.Height = 80;
            this.DataGrid_course.Size = new System.Drawing.Size(961, 350);
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
            this.DataGrid_course.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_course_CellContentClick);
            // 
            // manageCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 581);
            this.Controls.Add(this.panel_form);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "manageCourse";
            this.Text = "manageCourse";
            this.Load += new System.EventHandler(this.manageCourse_Load);
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
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Panel panel_registration;
        private System.Windows.Forms.Label label_manageCourse;
        private System.Windows.Forms.Panel panel_form;
        private Guna.UI2.WinForms.Guna2DataGridView DataGrid_course;
        private System.Windows.Forms.TextBox textBox_courseId;
        private System.Windows.Forms.Label label_courseId;
        private System.Windows.Forms.Button button_clear;
    }
}