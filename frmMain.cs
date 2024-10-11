using System.Drawing;

namespace SeatingPlanManagement
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CreateSeats(gridSeatsLeft);
            CreateSeats(gridSeatsRight);
        }

        private void CreateSeats(TableLayoutPanel grid)
        {
            for (int i = 0; i < 16; i++)
            {
                ucStudent student = new ucStudent();
                //student.picStudent.Image = Image.FromFile(@"D:\Coding\_Resources\Info.png");

                grid.Controls.Add(student);
            }
        }

        private void btnImportClassList_MouseHover(object sender, EventArgs e)
        {
            hoverToolTip.SetToolTip(btnImportClassList, "Klassenliste aus Zwischenablage importieren");
        }

        private void btnImportClassList_Click(object sender, EventArgs e)
        {
            var data = Clipboard.GetText();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //toBitmap for testing

            foreach(ucStudent student in gridSeatsLeft.Controls)
            {
                student.PrepareForExport();
            }

            foreach (ucStudent student in gridSeatsRight.Controls)
            {
                student.PrepareForExport();
            }

            Bitmap bmpEverything = new Bitmap(gridSeatsLeft.Width + gridSeatsRight.Width + 110, gridSeatsLeft.Height + lblPult.Height + 50);
            //gridSeatsLeft.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            
            Bitmap bmpGridLeft = new Bitmap(gridSeatsLeft.Width, gridSeatsLeft.Height);
            gridSeatsLeft.DrawToBitmap(bmpGridLeft, new Rectangle(0, 0, bmpGridLeft.Width, bmpGridLeft.Height));

            Bitmap bmpGridRight = new Bitmap(gridSeatsRight.Width, gridSeatsRight.Height);
            gridSeatsRight.DrawToBitmap(bmpGridRight, new Rectangle(0, 0, bmpGridRight.Width, bmpGridRight.Height));

            Bitmap bmpPult = new Bitmap(lblPult.Width, lblPult.Height);
            lblPult.DrawToBitmap(bmpPult, new Rectangle(0, 0, lblPult.Width, lblPult.Height));

            using (Graphics g = Graphics.FromImage(bmpEverything))
            {
                g.DrawImage(bmpGridLeft, 0, 0);
                g.DrawImage(bmpGridRight, gridSeatsRight.Location.X, 0);
                g.DrawImage(bmpPult, lblPult.Location.X, lblPult.Location.Y);
            }

            bmpEverything.Save(@"D:\Coding\_Resources\bmp.png");
        }
    }
}
