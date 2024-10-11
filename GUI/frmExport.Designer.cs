namespace SeatingPlanManagement.GUI
{
    partial class frmExport
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
            lblExportHeader = new Label();
            rbPngFormat = new RadioButton();
            rbPdfFormat = new RadioButton();
            lblFileFormat = new Label();
            btnExport = new Button();
            btnCancel = new LinkLabel();
            lblPath = new Label();
            txtFilePath = new TextBox();
            btnChooseFilePath = new Button();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // lblExportHeader
            // 
            lblExportHeader.AutoSize = true;
            lblExportHeader.BackColor = Color.Transparent;
            lblExportHeader.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExportHeader.Location = new Point(12, 9);
            lblExportHeader.Name = "lblExportHeader";
            lblExportHeader.Size = new Size(206, 30);
            lblExportHeader.TabIndex = 0;
            lblExportHeader.Text = "Sitzplan exportieren";
            // 
            // rbPngFormat
            // 
            rbPngFormat.AutoSize = true;
            rbPngFormat.ForeColor = Color.Black;
            rbPngFormat.Location = new Point(21, 79);
            rbPngFormat.Name = "rbPngFormat";
            rbPngFormat.Size = new Size(49, 19);
            rbPngFormat.TabIndex = 1;
            rbPngFormat.TabStop = true;
            rbPngFormat.Text = "PNG";
            rbPngFormat.UseVisualStyleBackColor = true;
            rbPngFormat.CheckedChanged += rbPngFormat_CheckedChanged;
            // 
            // rbPdfFormat
            // 
            rbPdfFormat.AutoSize = true;
            rbPdfFormat.ForeColor = Color.Black;
            rbPdfFormat.Location = new Point(21, 104);
            rbPdfFormat.Name = "rbPdfFormat";
            rbPdfFormat.Size = new Size(46, 19);
            rbPdfFormat.TabIndex = 2;
            rbPdfFormat.TabStop = true;
            rbPdfFormat.Text = "PDF";
            rbPdfFormat.UseVisualStyleBackColor = true;
            // 
            // lblFileFormat
            // 
            lblFileFormat.AutoSize = true;
            lblFileFormat.ForeColor = Color.Black;
            lblFileFormat.Location = new Point(13, 55);
            lblFileFormat.Name = "lblFileFormat";
            lblFileFormat.Size = new Size(73, 15);
            lblFileFormat.TabIndex = 3;
            lblFileFormat.Text = "Dateiformat:";
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExport.BackColor = Color.MidnightBlue;
            btnExport.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnExport.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(191, 196);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(82, 29);
            btnExport.TabIndex = 4;
            btnExport.Text = "Exportieren";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.AutoSize = true;
            btnCancel.LinkBehavior = LinkBehavior.HoverUnderline;
            btnCancel.Location = new Point(13, 203);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(65, 15);
            btnCancel.TabIndex = 5;
            btnCancel.TabStop = true;
            btnCancel.Text = "Abbrechen";
            btnCancel.LinkClicked += btnCancel_LinkClicked;
            // 
            // lblPath
            // 
            lblPath.AutoSize = true;
            lblPath.ForeColor = Color.Black;
            lblPath.Location = new Point(13, 136);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(70, 15);
            lblPath.TabIndex = 6;
            lblPath.Text = "Speicherort:";
            // 
            // txtFilePath
            // 
            txtFilePath.BackColor = Color.White;
            txtFilePath.Location = new Point(13, 154);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.ReadOnly = true;
            txtFilePath.Size = new Size(203, 23);
            txtFilePath.TabIndex = 7;
            // 
            // btnChooseFilePath
            // 
            btnChooseFilePath.BackColor = Color.White;
            btnChooseFilePath.FlatAppearance.BorderColor = Color.White;
            btnChooseFilePath.FlatStyle = FlatStyle.Flat;
            btnChooseFilePath.ForeColor = Color.Black;
            btnChooseFilePath.Location = new Point(230, 154);
            btnChooseFilePath.Name = "btnChooseFilePath";
            btnChooseFilePath.Size = new Size(43, 23);
            btnChooseFilePath.TabIndex = 8;
            btnChooseFilePath.Text = "...";
            btnChooseFilePath.UseVisualStyleBackColor = false;
            btnChooseFilePath.Click += btnChooseFilePath_Click;
            // 
            // frmExport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(285, 237);
            Controls.Add(btnChooseFilePath);
            Controls.Add(txtFilePath);
            Controls.Add(lblPath);
            Controls.Add(btnCancel);
            Controls.Add(btnExport);
            Controls.Add(lblFileFormat);
            Controls.Add(rbPdfFormat);
            Controls.Add(rbPngFormat);
            Controls.Add(lblExportHeader);
            ForeColor = Color.MidnightBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmExport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmExport";
            MouseDown += frmExport_MouseDown;
            MouseMove += frmExport_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExportHeader;
        private RadioButton rbPngFormat;
        private RadioButton rbPdfFormat;
        private Label lblFileFormat;
        private Button btnExport;
        private LinkLabel btnCancel;
        private Label lblPath;
        private TextBox txtFilePath;
        private Button btnChooseFilePath;
        private SaveFileDialog saveFileDialog1;
    }
}