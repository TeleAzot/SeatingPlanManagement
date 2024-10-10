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
                student.picStudent.Image = Image.FromFile(@"D:\Coding\_Resources\Info.png");

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
    }
}
