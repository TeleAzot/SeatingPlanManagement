namespace SeatingPlanManagement
{
    partial class ucStudent
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucStudent));
            picStudent = new PictureBox();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            lblFirstname = new Label();
            lblLastname = new Label();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            SuspendLayout();
            // 
            // picStudent
            // 
            picStudent.BackColor = Color.Transparent;
            picStudent.Image = (Image)resources.GetObject("picStudent.Image");
            picStudent.Location = new Point(3, 3);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(100, 89);
            picStudent.SizeMode = PictureBoxSizeMode.Zoom;
            picStudent.TabIndex = 0;
            picStudent.TabStop = false;
            picStudent.DragDrop += picStudent_DragDrop;
            picStudent.DragEnter += picStudent_DragEnter;
            // 
            // txtFirstname
            // 
            txtFirstname.Font = new Font("Segoe UI", 8.25F);
            txtFirstname.Location = new Point(3, 98);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.PlaceholderText = "Vorname";
            txtFirstname.Size = new Size(100, 22);
            txtFirstname.TabIndex = 1;
            txtFirstname.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLastname
            // 
            txtLastname.Font = new Font("Segoe UI", 8.25F);
            txtLastname.Location = new Point(3, 124);
            txtLastname.Name = "txtLastname";
            txtLastname.PlaceholderText = "Nachname";
            txtLastname.Size = new Size(100, 22);
            txtLastname.TabIndex = 2;
            txtLastname.TextAlign = HorizontalAlignment.Center;
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstname.Location = new Point(3, 100);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(0, 13);
            lblFirstname.TabIndex = 3;
            lblFirstname.TextAlign = ContentAlignment.MiddleCenter;
            lblFirstname.Visible = false;
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastname.Location = new Point(3, 126);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(0, 13);
            lblLastname.TabIndex = 4;
            lblLastname.TextAlign = ContentAlignment.MiddleCenter;
            lblLastname.Visible = false;
            // 
            // ucStudent
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblLastname);
            Controls.Add(lblFirstname);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Controls.Add(picStudent);
            Name = "ucStudent";
            Size = new Size(106, 149);
            Load += ucStudent_Load;
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox picStudent;
        public TextBox txtFirstname;
        public TextBox txtLastname;
        private Label lblFirstname;
        private Label lblLastname;
    }
}
