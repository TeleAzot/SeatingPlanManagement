using SeatingPlanManagement.Data;
using SeatingPlanManagement.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeatingPlanManagement.GUI
{
    public partial class ucStudent : UserControl
    {
        public Guid GUID { get; set; } = Guid.NewGuid();
        public bool DefaultPicture { get; set; } = true;

        public ucStudent()
        {
            InitializeComponent();
        }

        private void ucStudent_Load(object sender, EventArgs e)
        {
            picStudent = picStudent;
            picStudent.AllowDrop = true;
        }

        private void picStudent_DragDrop(object sender, DragEventArgs e)
        {
            //get the dropped data
            var data = e.Data.GetData(DataFormats.FileDrop);

            if (data != null)
            {
                //check for content and insert to pictureBox
                string[] fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    Image newImg;
                    try
                    {
                        newImg = Image.FromFile(fileNames[0]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Das Bild ist zu groß und kann nicht eingefügt werden.", "Fehler beim Einfügen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    ImageUtility.CorrectExifOrientation(newImg);
                    picStudent.Image = newImg;
                    DefaultPicture = false;
                }
            }
        }

        private void picStudent_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        public void PrepareForExport()
        {
            //hide textboxes and show labels for better design
            lblFirstname.Text = txtFirstname.Text;
            lblFirstname.Visible = true;

            lblLastname.Text = txtLastname.Text;
            lblLastname.Visible = true;

            lblCompany.Text = txtCompany.Text;
            lblCompany.Visible = true;

            txtFirstname.Visible = false;
            txtLastname.Visible = false;
            txtCompany.Visible = false;

            //if student has no picture -> remove the default placeholder image
            if (DefaultPicture)
            {
                picStudent.Image = null;
            }
        }

        public void ReturnToEditMode()
        {
            lblFirstname.Visible = false;
            lblLastname.Visible = false;
            lblCompany.Visible = false;

            txtFirstname.Visible = true;
            txtLastname.Visible = true;
            txtCompany.Visible = true;

            if (DefaultPicture)
            {
                picStudent.Image = Resources.Drag_Drop96;
            }
        }

        private void txtFirstname_DoubleClick(object sender, EventArgs e)
        {
            txtFirstname.Text = frmMain.SelectedStudent.Firstname;
            txtLastname.Text = frmMain.SelectedStudent.Lastname;
            txtCompany.Text = frmMain.SelectedStudent.Company;
        }

        private void txtLastname_DoubleClick(object sender, EventArgs e)
        {
            txtFirstname.Text = frmMain.SelectedStudent.Firstname;
            txtLastname.Text = frmMain.SelectedStudent.Lastname;
            txtCompany.Text = frmMain.SelectedStudent.Company;
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            DefaultPicture = true;
            picStudent.Image = Resources.Drag_Drop96;
        }
    }
}
