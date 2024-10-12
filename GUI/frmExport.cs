using SeatingPlanManagement.Data;
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
    public partial class frmExport : Form
    {
        private Point _mouseLocation;
        private FileFormat _selectedFileFormat;
        private string _selectedFileName;

        private TableLayoutPanel _gridLeft;
        private TableLayoutPanel _gridRight;
        private Label _pult;

        enum FileFormat
        {
            PNG, PDF
        }

        public frmExport(TableLayoutPanel gridLeft, TableLayoutPanel gridRight, Label lblPult)
        {
            //get the controls that are needed for export from frmMain
            _gridLeft = gridLeft;
            _gridRight = gridRight;
            _pult = lblPult;

            InitializeComponent();
        }
        private void frmExport_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLocation = new Point(-e.X, -e.Y);
        }

        private void rbPngFormat_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPngFormat.Checked)
                _selectedFileFormat = FileFormat.PNG;
            else
                _selectedFileFormat = FileFormat.PDF;
        }
        private void btnChooseFilePath_Click(object sender, EventArgs e)
        {
            //show SaveFileDialog with the right filter
            if (_selectedFileFormat == FileFormat.PNG)
                saveFileDialog1.Filter = "Portable Network Graphics | *.png";
            else
                saveFileDialog1.Filter = "Portable Document | *.pdf";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //get selected path
                _selectedFileName = saveFileDialog1.FileName;
                txtFilePath.Text = _selectedFileName;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_selectedFileName))
            {
                switch (_selectedFileFormat)
                {
                    case FileFormat.PNG:
                        PngExport pngExport = new PngExport(_gridLeft, _gridRight, _pult, _selectedFileName);
                        if (pngExport.Export())
                        {
                            DialogResult = DialogResult.OK;
                            Close();
                        }                        
                        break;
                    case FileFormat.PDF:
                        PdfExport pdfExport = new PdfExport(_gridLeft, _gridRight, _pult, _selectedFileName);
                        if (pdfExport.Export())
                        {
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Es muss ein Dateipfad ausgewählt sein!", "Kein Pfad ausgewählt!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        //---------------------------------------------------------------
        //code for movable form
        private void frmExport_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(_mouseLocation.X, _mouseLocation.Y);
                Location = mousePos;
            }
        }

    }
}
