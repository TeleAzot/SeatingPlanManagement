using SeatingPlanManagement.Data;
using System.Drawing;

namespace SeatingPlanManagement.GUI
{
    public partial class frmMain : Form
    {
        public static Student SelectedStudent { get; private set; } = new Student();

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
                grid.Controls.Add(student);
            }
        }

        private void btnImportClassList_MouseHover(object sender, EventArgs e)
        {
            hoverToolTip.SetToolTip(btnImportClassList, "Klassenliste aus Zwischenablage importieren");
        }

        private void btnImportClassList_Click(object sender, EventArgs e)
        {
            ClasslistImport import = new ClasslistImport(Clipboard.GetText());
            import.InsertIntoListView(lvClasslist);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            foreach (ucStudent student in gridSeatsLeft.Controls)
            {
                student.PrepareForExport();
            }

            foreach (ucStudent student in gridSeatsRight.Controls)
            {
                student.PrepareForExport();
            }

            frmExport frm = new frmExport(gridSeatsLeft, gridSeatsRight, lblPult);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Der Sitzplan wurde erfolgreich exportiert.", "Export erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            foreach (ucStudent student in gridSeatsLeft.Controls)
            {
                student.ReturnToEditMode();
            }

            foreach (ucStudent student in gridSeatsRight.Controls)
            {
                student.ReturnToEditMode();
            }
        }

        private void lvClasslist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvClasslist.SelectedItems.Count > 0)
            {
                //get the currently selected Student in the classlist
                SelectedStudent.Firstname = lvClasslist.SelectedItems[0].Text;
                SelectedStudent.Lastname = lvClasslist.SelectedItems[0].SubItems[1].Text;
            }            
        }
    }
}
