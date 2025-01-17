﻿namespace SeatingPlanManagement.GUI
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            gridSeatsLeft = new TableLayoutPanel();
            lblPult = new Label();
            gridSeatsRight = new TableLayoutPanel();
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            btnSave = new ToolStripButton();
            btnOpen = new ToolStripButton();
            btnExport = new ToolStripButton();
            lvClasslist = new ListView();
            colFirstname = new ColumnHeader();
            colLastname = new ColumnHeader();
            label2 = new Label();
            btnImportClassList = new PictureBox();
            hoverToolTip = new ToolTip(components);
            label3 = new Label();
            label1 = new Label();
            lblCopyright = new Label();
            chkCompany = new CheckBox();
            sfDialog = new SaveFileDialog();
            ofDialog = new OpenFileDialog();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnImportClassList).BeginInit();
            SuspendLayout();
            // 
            // gridSeatsLeft
            // 
            gridSeatsLeft.AutoSize = true;
            gridSeatsLeft.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gridSeatsLeft.BackColor = Color.White;
            gridSeatsLeft.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            gridSeatsLeft.ColumnCount = 4;
            gridSeatsLeft.ColumnStyles.Add(new ColumnStyle());
            gridSeatsLeft.ColumnStyles.Add(new ColumnStyle());
            gridSeatsLeft.ColumnStyles.Add(new ColumnStyle());
            gridSeatsLeft.ColumnStyles.Add(new ColumnStyle());
            gridSeatsLeft.Location = new Point(12, 23);
            gridSeatsLeft.Name = "gridSeatsLeft";
            gridSeatsLeft.RowCount = 4;
            gridSeatsLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            gridSeatsLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            gridSeatsLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            gridSeatsLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            gridSeatsLeft.Size = new Size(15, 15);
            gridSeatsLeft.TabIndex = 3;
            // 
            // lblPult
            // 
            lblPult.BackColor = Color.White;
            lblPult.BorderStyle = BorderStyle.FixedSingle;
            lblPult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPult.ForeColor = Color.Black;
            lblPult.Location = new Point(456, 785);
            lblPult.Name = "lblPult";
            lblPult.Size = new Size(129, 39);
            lblPult.TabIndex = 0;
            lblPult.Text = "PULT";
            lblPult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gridSeatsRight
            // 
            gridSeatsRight.AutoSize = true;
            gridSeatsRight.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gridSeatsRight.BackColor = Color.White;
            gridSeatsRight.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            gridSeatsRight.ColumnCount = 4;
            gridSeatsRight.ColumnStyles.Add(new ColumnStyle());
            gridSeatsRight.ColumnStyles.Add(new ColumnStyle());
            gridSeatsRight.ColumnStyles.Add(new ColumnStyle());
            gridSeatsRight.ColumnStyles.Add(new ColumnStyle());
            gridSeatsRight.Location = new Point(567, 23);
            gridSeatsRight.Name = "gridSeatsRight";
            gridSeatsRight.RowCount = 4;
            gridSeatsRight.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            gridSeatsRight.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            gridSeatsRight.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            gridSeatsRight.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            gridSeatsRight.Size = new Size(15, 15);
            gridSeatsRight.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.Gray;
            panel1.Location = new Point(1049, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 819);
            panel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.FromArgb(224, 224, 224);
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnSave, btnOpen, btnExport });
            toolStrip1.Location = new Point(1067, 23);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(432, 31);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(28, 28);
            btnSave.Text = "toolStripButton1";
            btnSave.ToolTipText = "Sitzplan speichern";
            btnSave.Click += btnSave_Click;
            // 
            // btnOpen
            // 
            btnOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnOpen.Image = Properties.Resources.OpenFile24;
            btnOpen.ImageTransparentColor = Color.Magenta;
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(28, 28);
            btnOpen.Text = "toolStripButton1";
            btnOpen.ToolTipText = "Sitzplan öffnen";
            btnOpen.Click += btnOpen_Click;
            // 
            // btnExport
            // 
            btnExport.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExport.Image = (Image)resources.GetObject("btnExport.Image");
            btnExport.ImageTransparentColor = Color.Magenta;
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(28, 28);
            btnExport.Text = "toolStripButton1";
            btnExport.ToolTipText = "Exportieren";
            btnExport.Click += btnExport_Click;
            // 
            // lvClasslist
            // 
            lvClasslist.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lvClasslist.Columns.AddRange(new ColumnHeader[] { colFirstname, colLastname });
            lvClasslist.FullRowSelect = true;
            lvClasslist.GridLines = true;
            lvClasslist.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvClasslist.Location = new Point(1070, 120);
            lvClasslist.Name = "lvClasslist";
            lvClasslist.Size = new Size(429, 386);
            lvClasslist.TabIndex = 5;
            lvClasslist.UseCompatibleStateImageBehavior = false;
            lvClasslist.View = View.Details;
            lvClasslist.SelectedIndexChanged += lvClasslist_SelectedIndexChanged;
            // 
            // colFirstname
            // 
            colFirstname.Text = "Vorname";
            colFirstname.Width = 207;
            // 
            // colLastname
            // 
            colLastname.Text = "Nachname";
            colLastname.Width = 207;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(1067, 87);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 6;
            label2.Text = "Klassenliste:";
            // 
            // btnImportClassList
            // 
            btnImportClassList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImportClassList.BorderStyle = BorderStyle.Fixed3D;
            btnImportClassList.Cursor = Cursors.Hand;
            btnImportClassList.Image = (Image)resources.GetObject("btnImportClassList.Image");
            btnImportClassList.Location = new Point(1143, 83);
            btnImportClassList.Name = "btnImportClassList";
            btnImportClassList.Size = new Size(28, 28);
            btnImportClassList.SizeMode = PictureBoxSizeMode.AutoSize;
            btnImportClassList.TabIndex = 7;
            btnImportClassList.TabStop = false;
            btnImportClassList.Click += btnImportClassList_Click;
            btnImportClassList.MouseHover += btnImportClassList_MouseHover;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(1121, 522);
            label3.Name = "label3";
            label3.Size = new Size(331, 66);
            label3.TabIndex = 13;
            label3.Text = "Bilder der Schüler per Drag and Drop auf die Plätze ziehen.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(1121, 619);
            label1.Name = "label1";
            label1.Size = new Size(331, 66);
            label1.TabIndex = 14;
            label1.Text = "Schüler aus der Liste markieren und per Doppelklick auf ein Textfeld eines Platzes einfügen.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCopyright
            // 
            lblCopyright.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCopyright.AutoSize = true;
            lblCopyright.Location = new Point(1353, 816);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(146, 15);
            lblCopyright.TabIndex = 15;
            lblCopyright.Text = "© Tim Stock Oktober 2024";
            // 
            // chkCompany
            // 
            chkCompany.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkCompany.AutoSize = true;
            chkCompany.Location = new Point(1391, 86);
            chkCompany.Name = "chkCompany";
            chkCompany.Size = new Size(108, 19);
            chkCompany.TabIndex = 16;
            chkCompany.Text = "Spalte \"Betrieb\"";
            chkCompany.UseVisualStyleBackColor = true;
            chkCompany.CheckedChanged += chkCompany_CheckedChanged;
            // 
            // sfDialog
            // 
            sfDialog.Filter = "Seating Plan Dateien | *.sp";
            // 
            // ofDialog
            // 
            ofDialog.Filter = "Seating Plan Dateien | *.sp";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1511, 843);
            Controls.Add(chkCompany);
            Controls.Add(lblCopyright);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(btnImportClassList);
            Controls.Add(label2);
            Controls.Add(lvClasslist);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Controls.Add(gridSeatsRight);
            Controls.Add(lblPult);
            Controls.Add(gridSeatsLeft);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1527, 882);
            Name = "frmMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seating Plan Management";
            Load += frmMain_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnImportClassList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel gridSeatsLeft;
        private Label lblPult;
        private TableLayoutPanel gridSeatsRight;
        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnSave;
        private ToolStripButton btnExport;
        private ListView lvClasslist;
        private ColumnHeader colFirstname;
        private ColumnHeader colLastname;
        private Label label2;
        private PictureBox btnImportClassList;
        private ToolTip hoverToolTip;
        private Label label3;
        private Label label1;
        private Label lblCopyright;
        private CheckBox chkCompany;
        private SaveFileDialog sfDialog;
        private ToolStripButton btnOpen;
        private OpenFileDialog ofDialog;
    }
}
