namespace Student
{
    partial class Student_Manage
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
            this.label_manageStudent = new System.Windows.Forms.Label();
            this.DataGrid_student = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox_sex = new System.Windows.Forms.ComboBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.label_DOB = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_sex = new System.Windows.Forms.Label();
            this.label_lastName = new System.Windows.Forms.Label();
            this.label_firstName = new System.Windows.Forms.Label();
            this.button_upload = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.pictureBox_img = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.panel_registration = new System.Windows.Forms.Panel();
            this.panel_form = new System.Windows.Forms.Panel();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_registration.SuspendLayout();
            this.panel_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_manageStudent
            // 
            this.label_manageStudent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_manageStudent.AutoSize = true;
            this.label_manageStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_manageStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_manageStudent.Location = new System.Drawing.Point(427, 10);
            this.label_manageStudent.Name = "label_manageStudent";
            this.label_manageStudent.Size = new System.Drawing.Size(145, 24);
            this.label_manageStudent.TabIndex = 8;
            this.label_manageStudent.Text = "Manage student";
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
            this.DataGrid_student.Size = new System.Drawing.Size(959, 309);
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
            this.DataGrid_student.Click += new System.EventHandler(this.DataGrid_student_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker.Location = new System.Drawing.Point(141, 57);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(192, 22);
            this.dateTimePicker.TabIndex = 18;
            // 
            // comboBox_sex
            // 
            this.comboBox_sex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_sex.FormattingEnabled = true;
            this.comboBox_sex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.comboBox_sex.Location = new System.Drawing.Point(605, 20);
            this.comboBox_sex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_sex.Name = "comboBox_sex";
            this.comboBox_sex.Size = new System.Drawing.Size(77, 24);
            this.comboBox_sex.TabIndex = 17;
            // 
            // textBox_address
            // 
            this.textBox_address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_address.Location = new System.Drawing.Point(141, 96);
            this.textBox_address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(541, 101);
            this.textBox_address.TabIndex = 16;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_phone.Location = new System.Drawing.Point(431, 59);
            this.textBox_phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(252, 22);
            this.textBox_phone.TabIndex = 15;
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_lastName.Location = new System.Drawing.Point(399, 20);
            this.textBox_lastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(147, 22);
            this.textBox_lastName.TabIndex = 14;
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_firstName.Location = new System.Drawing.Point(141, 17);
            this.textBox_firstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(145, 22);
            this.textBox_firstName.TabIndex = 13;
            // 
            // label_DOB
            // 
            this.label_DOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_DOB.AutoSize = true;
            this.label_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DOB.Location = new System.Drawing.Point(72, 59);
            this.label_DOB.Name = "label_DOB";
            this.label_DOB.Size = new System.Drawing.Size(48, 16);
            this.label_DOB.TabIndex = 12;
            this.label_DOB.Text = "D.O.B :";
            // 
            // label_address
            // 
            this.label_address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.Location = new System.Drawing.Point(47, 96);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(67, 16);
            this.label_address.TabIndex = 11;
            this.label_address.Text = "Address  :";
            // 
            // label_phone
            // 
            this.label_phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.Location = new System.Drawing.Point(356, 59);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(52, 16);
            this.label_phone.TabIndex = 10;
            this.label_phone.Text = "Phone :";
            // 
            // label_sex
            // 
            this.label_sex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_sex.AutoSize = true;
            this.label_sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sex.Location = new System.Drawing.Point(552, 25);
            this.label_sex.Name = "label_sex";
            this.label_sex.Size = new System.Drawing.Size(36, 16);
            this.label_sex.TabIndex = 9;
            this.label_sex.Text = "Sex :";
            // 
            // label_lastName
            // 
            this.label_lastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_lastName.AutoSize = true;
            this.label_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lastName.Location = new System.Drawing.Point(293, 22);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(75, 16);
            this.label_lastName.TabIndex = 8;
            this.label_lastName.Text = "Last name :";
            // 
            // label_firstName
            // 
            this.label_firstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_firstName.AutoSize = true;
            this.label_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firstName.Location = new System.Drawing.Point(36, 21);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(75, 16);
            this.label_firstName.TabIndex = 7;
            this.label_firstName.Text = "First name :";
            // 
            // button_upload
            // 
            this.button_upload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_upload.Location = new System.Drawing.Point(828, 163);
            this.button_upload.Margin = new System.Windows.Forms.Padding(4);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(100, 28);
            this.button_upload.TabIndex = 22;
            this.button_upload.Text = "Upload";
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_clear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_clear.Location = new System.Drawing.Point(701, 118);
            this.button_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(93, 37);
            this.button_clear.TabIndex = 5;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_update
            // 
            this.button_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_update.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button_update.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_update.Location = new System.Drawing.Point(700, 158);
            this.button_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(95, 39);
            this.button_update.TabIndex = 4;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // pictureBox_img
            // 
            this.pictureBox_img.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_img.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox_img.Location = new System.Drawing.Point(812, 20);
            this.pictureBox_img.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_img.Name = "pictureBox_img";
            this.pictureBox_img.Size = new System.Drawing.Size(132, 135);
            this.pictureBox_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_img.TabIndex = 3;
            this.pictureBox_img.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.textBox_id);
            this.panel2.Controls.Add(this.label_id);
            this.panel2.Controls.Add(this.button_delete);
            this.panel2.Controls.Add(this.dateTimePicker);
            this.panel2.Controls.Add(this.comboBox_sex);
            this.panel2.Controls.Add(this.textBox_address);
            this.panel2.Controls.Add(this.textBox_phone);
            this.panel2.Controls.Add(this.textBox_lastName);
            this.panel2.Controls.Add(this.textBox_firstName);
            this.panel2.Controls.Add(this.label_DOB);
            this.panel2.Controls.Add(this.label_address);
            this.panel2.Controls.Add(this.label_phone);
            this.panel2.Controls.Add(this.label_sex);
            this.panel2.Controls.Add(this.label_lastName);
            this.panel2.Controls.Add(this.label_firstName);
            this.panel2.Controls.Add(this.button_upload);
            this.panel2.Controls.Add(this.button_clear);
            this.panel2.Controls.Add(this.button_update);
            this.panel2.Controls.Add(this.pictureBox_img);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 381);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 209);
            this.panel2.TabIndex = 2;
            // 
            // textBox_id
            // 
            this.textBox_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_id.Location = new System.Drawing.Point(731, 22);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(53, 22);
            this.textBox_id.TabIndex = 21;
            // 
            // label_id
            // 
            this.label_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(697, 25);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(21, 16);
            this.label_id.TabIndex = 20;
            this.label_id.Text = "Id:";
            // 
            // button_delete
            // 
            this.button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_delete.BackColor = System.Drawing.Color.Red;
            this.button_delete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_delete.Location = new System.Drawing.Point(701, 76);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(93, 39);
            this.button_delete.TabIndex = 19;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // panel_registration
            // 
            this.panel_registration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_registration.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_registration.Controls.Add(this.label_manageStudent);
            this.panel_registration.Location = new System.Drawing.Point(-13, 0);
            this.panel_registration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_registration.Name = "panel_registration";
            this.panel_registration.Size = new System.Drawing.Size(999, 43);
            this.panel_registration.TabIndex = 0;
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
            this.panel_form.Location = new System.Drawing.Point(-4, -1);
            this.panel_form.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(960, 590);
            this.panel_form.TabIndex = 1;
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
            this.button_search.Click += new System.EventHandler(this.button_search_Click_1);
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
            // Student_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 586);
            this.Controls.Add(this.panel_form);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Student_Manage";
            this.Text = "Student_Manage";
            this.Load += new System.EventHandler(this.Student_Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_registration.ResumeLayout(false);
            this.panel_registration.PerformLayout();
            this.panel_form.ResumeLayout(false);
            this.panel_form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_manageStudent;
        private Guna.UI2.WinForms.Guna2DataGridView DataGrid_student;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBox_sex;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.Label label_DOB;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_sex;
        private System.Windows.Forms.Label label_lastName;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.PictureBox pictureBox_img;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_registration;
        private System.Windows.Forms.Panel panel_form;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_search;
    }
}