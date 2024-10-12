using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeatingPlanManagement.Data
{
    internal class PngExport
    {
        private TableLayoutPanel _gridLeft;
        private TableLayoutPanel _gridRight;
        private Label _pult;
        private string _pathToSave;

        public PngExport(TableLayoutPanel gridLeft, TableLayoutPanel gridRight, Label lblPult, string pathToSave)
        {
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

                //concat all bmps and save
                using (Graphics g = Graphics.FromImage(bmpEverything))
                {
                    g.DrawImage(bmpGridLeft, 0, 0);
                    g.DrawImage(bmpGridRight, _gridRight.Location.X, 0);
                    g.DrawImage(bmpPult, _pult.Location.X, _pult.Location.Y);
                }

                bmpEverything.Save(_pathToSave);
                return true;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler beim Exportieren!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }            
        }
    }
}
