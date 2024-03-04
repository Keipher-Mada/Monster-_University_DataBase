namespace Student
{
    partial class loadingForm
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
            this.components = new System.ComponentModel.Container();
            this.label0 = new System.Windows.Forms.Label();
            this.ProgressIndicator1 = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label0.Location = new System.Drawing.Point(420, 74);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(143, 32);
            this.label0.TabIndex = 1;
            this.label0.Text = "Est. 1313";
            // 
            // ProgressIndicator1
            // 
            this.ProgressIndicator1.Location = new System.Drawing.Point(418, 359);
            this.ProgressIndicator1.Name = "ProgressIndicator1";
            this.ProgressIndicator1.ProgressColor = System.Drawing.SystemColors.Highlight;
            this.ProgressIndicator1.Size = new System.Drawing.Size(145, 140);
            this.ProgressIndicator1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pictureBox_icon
            // 
            this.pictureBox_icon.Image = global::Student.Properties.Resources.monsters_university_logo_272139423B_seeklogo_com;
            this.pictureBox_icon.Location = new System.Drawing.Point(396, 121);
            this.pictureBox_icon.Name = "pictureBox_icon";
            this.pictureBox_icon.Size = new System.Drawing.Size(191, 190);
            this.pictureBox_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_icon.TabIndex = 0;
            this.pictureBox_icon.TabStop = false;
            // 
            // loadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(988, 586);
            this.Controls.Add(this.ProgressIndicator1);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.pictureBox_icon);
            this.Name = "loadingForm";
            this.Text = "loadingForm";
            this.Load += new System.EventHandler(this.loadingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_icon;
        private System.Windows.Forms.Label label0;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator ProgressIndicator1;
        private System.Windows.Forms.Timer timer1;
    }
}