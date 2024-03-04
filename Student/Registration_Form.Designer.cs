using System;

namespace Student
{
    partial class Registration_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_form = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.button_add = new System.Windows.Forms.Button();
            this.pictureBox_img = new System.Windows.Forms.PictureBox();
            this.DataGrid_student = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel_registration = new System.Windows.Forms.Panel();
            this.label_registeration = new System.Windows.Forms.Label();
            this.panel_form.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_student)).BeginInit();
            this.panel_registration.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_form
            // 
            this.panel_form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_form.Controls.Add(this.panel2);
            this.panel_form.Controls.Add(this.DataGrid_student);
            this.panel_form.Controls.Add(this.panel_registration);
            this.panel_form.Location = new System.Drawing.Point(0, 0);
            this.panel_form.Margin = new System.Windows.Forms.Padding(2);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(694, 479);
            this.panel_form.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.panel2.Controls.Add(this.button_add);
            this.panel2.Controls.Add(this.pictureBox_img);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 309);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 170);
            this.panel2.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker.Location = new System.Drawing.Point(120, 45);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker.TabIndex = 18;
            // 
            // comboBox_sex
            // 
            this.comboBox_sex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_sex.FormattingEnabled = true;
            this.comboBox_sex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.comboBox_sex.Location = new System.Drawing.Point(506, 16);
            this.comboBox_sex.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_sex.Name = "comboBox_sex";
            this.comboBox_sex.Size = new System.Drawing.Size(58, 21);
            this.comboBox_sex.TabIndex = 17;
            // 
            // textBox_address
            // 
            this.textBox_address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_address.Location = new System.Drawing.Point(120, 78);
            this.textBox_address.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(368, 76);
            this.textBox_address.TabIndex = 16;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_phone.Location = new System.Drawing.Point(326, 45);
            this.textBox_phone.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(162, 20);
            this.textBox_phone.TabIndex = 15;
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_lastName.Location = new System.Drawing.Point(313, 14);
            this.textBox_lastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(144, 20);
            this.textBox_lastName.TabIndex = 14;
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_firstName.Location = new System.Drawing.Point(120, 12);
            this.textBox_firstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(106, 20);
            this.textBox_firstName.TabIndex = 13;
            // 
            // label_DOB
            // 
            this.label_DOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_DOB.AutoSize = true;
            this.label_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DOB.Location = new System.Drawing.Point(57, 47);
            this.label_DOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DOB.Name = "label_DOB";
            this.label_DOB.Size = new System.Drawing.Size(57, 18);
            this.label_DOB.TabIndex = 12;
            this.label_DOB.Text = "D.O.B :";
            // 
            // label_address
            // 
            this.label_address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.Location = new System.Drawing.Point(40, 78);
            this.label_address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(74, 18);
            this.label_address.TabIndex = 11;
            this.label_address.Text = "Address  :";
            // 
            // label_phone
            // 
            this.label_phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.Location = new System.Drawing.Point(263, 45);
            this.label_phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(59, 18);
            this.label_phone.TabIndex = 10;
            this.label_phone.Text = "Phone :";
            // 
            // label_sex
            // 
            this.label_sex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_sex.AutoSize = true;
            this.label_sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sex.Location = new System.Drawing.Point(461, 16);
            this.label_sex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_sex.Name = "label_sex";
            this.label_sex.Size = new System.Drawing.Size(41, 18);
            this.label_sex.TabIndex = 9;
            this.label_sex.Text = "Sex :";
            // 
            // label_lastName
            // 
            this.label_lastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_lastName.AutoSize = true;
            this.label_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lastName.Location = new System.Drawing.Point(230, 14);
            this.label_lastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(85, 18);
            this.label_lastName.TabIndex = 8;
            this.label_lastName.Text = "Last name :";
            // 
            // label_firstName
            // 
            this.label_firstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_firstName.AutoSize = true;
            this.label_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firstName.Location = new System.Drawing.Point(30, 12);
            this.label_firstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(86, 18);
            this.label_firstName.TabIndex = 7;
            this.label_firstName.Text = "First name :";
            // 
            // button_upload
            // 
            this.button_upload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_upload.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_upload.Location = new System.Drawing.Point(589, 132);
            this.button_upload.Margin = new System.Windows.Forms.Padding(2);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(92, 28);
            this.button_upload.TabIndex = 6;
            this.button_upload.Text = "Upload";
            this.button_upload.UseVisualStyleBackColor = true;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click_1);
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_clear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_clear.Location = new System.Drawing.Point(492, 78);
            this.button_clear.Margin = new System.Windows.Forms.Padding(2);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(81, 38);
            this.button_clear.TabIndex = 5;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click_2);
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_add.Location = new System.Drawing.Point(492, 116);
            this.button_add.Margin = new System.Windows.Forms.Padding(2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(81, 38);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click_1);
            // 
            // pictureBox_img
            // 
            this.pictureBox_img.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_img.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox_img.Location = new System.Drawing.Point(582, 16);
            this.pictureBox_img.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_img.Name = "pictureBox_img";
            this.pictureBox_img.Size = new System.Drawing.Size(99, 110);
            this.pictureBox_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_img.TabIndex = 3;
            this.pictureBox_img.TabStop = false;
            // 
            // DataGrid_student
            // 
            this.DataGrid_student.AllowUserToAddRows = false;
            this.DataGrid_student.AllowUserToDeleteRows = false;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            this.DataGrid_student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.DataGrid_student.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid_student.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.DataGrid_student.ColumnHeadersHeight = 24;
            this.DataGrid_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_student.DefaultCellStyle = dataGridViewCellStyle30;
            this.DataGrid_student.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid_student.Location = new System.Drawing.Point(0, 33);
            this.DataGrid_student.Margin = new System.Windows.Forms.Padding(2);
            this.DataGrid_student.Name = "DataGrid_student";
            this.DataGrid_student.RowHeadersVisible = false;
            this.DataGrid_student.RowHeadersWidth = 51;
            this.DataGrid_student.RowTemplate.Height = 80;
            this.DataGrid_student.Size = new System.Drawing.Size(693, 280);
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
            this.DataGrid_student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // panel_registration
            // 
            this.panel_registration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_registration.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_registration.Controls.Add(this.label_registeration);
            this.panel_registration.Location = new System.Drawing.Point(-10, 0);
            this.panel_registration.Margin = new System.Windows.Forms.Padding(2);
            this.panel_registration.Name = "panel_registration";
            this.panel_registration.Size = new System.Drawing.Size(723, 35);
            this.panel_registration.TabIndex = 0;
            // 
            // label_registeration
            // 
            this.label_registeration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_registeration.AutoSize = true;
            this.label_registeration.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_registeration.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_registeration.Location = new System.Drawing.Point(279, 7);
            this.label_registeration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_registeration.Name = "label_registeration";
            this.label_registeration.Size = new System.Drawing.Size(150, 24);
            this.label_registeration.TabIndex = 8;
            this.label_registeration.Text = "Registration form";
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(689, 476);
            this.Controls.Add(this.panel_form);
            this.Name = "Registration_Form";
            this.Text = "Registration_Form";
            this.Load += new System.EventHandler(this.Registration_Form_Load);
            this.panel_form.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_student)).EndInit();
            this.panel_registration.ResumeLayout(false);
            this.panel_registration.PerformLayout();
            this.ResumeLayout(false);

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel_form;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView DataGrid_student;
        private System.Windows.Forms.Panel panel_registration;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.PictureBox pictureBox_img;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_sex;
        private System.Windows.Forms.Label label_lastName;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBox_sex;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.Label label_DOB;
        private System.Windows.Forms.Label label_registeration;
    }
}