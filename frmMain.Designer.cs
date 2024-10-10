namespace SeatingPlanManagement
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
            gridSeatsLeft = new TableLayoutPanel();
            label1 = new Label();
            gridSeatsRight = new TableLayoutPanel();
            SuspendLayout();
            // 
            // gridSeatsLeft
            // 
            gridSeatsLeft.AutoSize = true;
            gridSeatsLeft.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gridSeatsLeft.BackColor = Color.WhiteSmoke;
            gridSeatsLeft.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            gridSeatsLeft.ColumnCount = 4;
            gridSeatsLeft.ColumnStyles.Add(new ColumnStyle());
            gridSeatsLeft.ColumnStyles.Add(new ColumnStyle());
            gridSeatsLeft.ColumnStyles.Add(new ColumnStyle());
            gridSeatsLeft.ColumnStyles.Add(new ColumnStyle());
            gridSeatsLeft.Location = new Point(12, 12);
            gridSeatsLeft.Name = "gridSeatsLeft";
            gridSeatsLeft.RowCount = 4;
            gridSeatsLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            gridSeatsLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            gridSeatsLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            gridSeatsLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            gridSeatsLeft.Size = new Size(15, 15);
            gridSeatsLeft.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.SaddleBrown;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(473, 663);
            label1.Name = "label1";
            label1.Size = new Size(129, 39);
            label1.TabIndex = 2;
            label1.Text = "PULT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gridSeatsRight
            // 
            gridSeatsRight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gridSeatsRight.AutoSize = true;
            gridSeatsRight.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gridSeatsRight.BackColor = Color.WhiteSmoke;
            gridSeatsRight.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            gridSeatsRight.ColumnCount = 4;
            gridSeatsRight.ColumnStyles.Add(new ColumnStyle());
            gridSeatsRight.ColumnStyles.Add(new ColumnStyle());
            gridSeatsRight.ColumnStyles.Add(new ColumnStyle());
            gridSeatsRight.ColumnStyles.Add(new ColumnStyle());
            gridSeatsRight.Location = new Point(1053, 12);
            gridSeatsRight.Name = "gridSeatsRight";
            gridSeatsRight.RowCount = 4;
            gridSeatsRight.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            gridSeatsRight.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            gridSeatsRight.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            gridSeatsRight.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            gridSeatsRight.Size = new Size(15, 15);
            gridSeatsRight.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 721);
            Controls.Add(gridSeatsRight);
            Controls.Add(label1);
            Controls.Add(gridSeatsLeft);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seating Plan Management";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel gridSeatsLeft;
        private Label label1;
        private TableLayoutPanel gridSeatsRight;
    }
}
