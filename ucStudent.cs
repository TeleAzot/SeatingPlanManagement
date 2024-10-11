using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeatingPlanManagement
{
    public partial class ucStudent : UserControl
    {
        private bool _defaultPicture = true;

        public ucStudent()
        {
            InitializeComponent();
        }

        private void ucStudent_Load(object sender, EventArgs e)
        {
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
                    picStudent.Image = Image.FromFile(fileNames[0]);
                    _defaultPicture = false;
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

            txtFirstname.Visible = false;
            txtLastname.Visible = false;

            //if student has no picture -> remove the default placeholder
            if (_defaultPicture)
            {
                picStudent.Image = null;
            }
        }

    }
}
