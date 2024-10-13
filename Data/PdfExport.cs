using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeatingPlanManagement.Data
{
    internal class PdfExport
    {
        private TableLayoutPanel _gridLeft;
        private TableLayoutPanel _gridRight;
        private Label _pult;
        private string _pathToSave;

        private readonly string _pathToTmpBmp;

        public PdfExport(TableLayoutPanel gridLeft, TableLayoutPanel gridRight, Label lblPult, string pathToSave)
        {
            _pathToTmpBmp = $@"C:\Users\{Environment.UserName}\AppData\Local\SeatingPlanManagement\tmp\";
            Directory.CreateDirectory(_pathToTmpBmp);

            //get the controls that are needed for export
            _gridLeft = gridLeft;
            _gridRight = gridRight;
            _pult = lblPult;
            _pathToSave = pathToSave;
        }

        public bool Export()
        {
            try
            {
                Bitmap bmp = GenerateBmp();
                //save bmp so that pdfsharp can access it for drawing on page
                if (File.Exists(_pathToTmpBmp + "tmp.png"))
                    File.Delete(_pathToTmpBmp + "tmp.png");

                bmp.Save(_pathToTmpBmp + "tmp.png");

                PdfDocument document = new PdfDocument();

                // Create an empty page and make it horizontal
                PdfPage page = document.AddPage();
                page.Orientation = PdfSharp.PageOrientation.Landscape;

                // Get an XGraphics object for drawing
                XGraphics gfx = XGraphics.FromPdfPage(page);
                DrawImageOnPage(gfx);

                document.Save(_pathToSave);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler beim Exportieren!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private Bitmap GenerateBmp()
        {
            //final bmp
            Bitmap bmpEverything = new Bitmap(_gridLeft.Width + _gridRight.Width + 110, _gridLeft.Height + _pult.Height + 50);

            //bmp of left grid
            Bitmap bmpGridLeft = new Bitmap(_gridLeft.Width, _gridLeft.Height);
            _gridLeft.DrawToBitmap(bmpGridLeft, new Rectangle(0, 0, bmpGridLeft.Width, bmpGridLeft.Height));

            //bmp of right grid
            Bitmap bmpGridRight = new Bitmap(_gridRight.Width, _gridRight.Height);
            _gridRight.DrawToBitmap(bmpGridRight, new Rectangle(0, 0, bmpGridRight.Width, bmpGridRight.Height));

            //bmp of pult
            Bitmap bmpPult = new Bitmap(_pult.Width, _pult.Height);
            _pult.DrawToBitmap(bmpPult, new Rectangle(0, 0, _pult.Width, _pult.Height));

            //concat all bmps
            using (Graphics g = Graphics.FromImage(bmpEverything))
            {
                g.DrawImage(bmpGridLeft, 0, 0);
                g.DrawImage(bmpGridRight, _gridRight.Location.X, 0);
                g.DrawImage(bmpPult, _pult.Location.X, _pult.Location.Y);
            }

            return bmpEverything;
        }

        private void DrawImageOnPage(XGraphics gfx)
        {
            XImage image = XImage.FromFile(_pathToTmpBmp + "tmp.png");

            //resize the image to fit on the page
            double width = image.PixelWidth * 0.63;
            double height = image.PixelHeight * 0.63;

            gfx.DrawImage(image, 50, 50, width, height);
        }
    }
}
