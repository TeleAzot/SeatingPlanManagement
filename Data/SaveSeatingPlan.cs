using PdfSharp.Pdf.IO;
using SeatingPlanManagement.GUI;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeatingPlanManagement.Data
{
    internal class SaveSeatingPlan
    {
        private string _pathToSave;
        private TableLayoutPanel _gridLeft;
        private TableLayoutPanel _gridRight;

        private readonly string _pathToPictures;

        public SaveSeatingPlan(string pathToSave, TableLayoutPanel gridLeft, TableLayoutPanel gridRight)
        {
            _pathToPictures = $@"C:\Users\{Environment.UserName}\AppData\Local\SeatingPlanManagement\Images\";

            _pathToSave = pathToSave;
            _gridLeft = gridLeft;
            _gridRight = gridRight;
        }

        public void Save()
        {
            SaveImagesInLocalAppData(_gridLeft);
            SaveImagesInLocalAppData(_gridRight);

            IEnumerable<Student> studentsLeft = StudentsInGrid(_gridLeft);
            IEnumerable<Student> studentsRight = StudentsInGrid(_gridRight);

            WriteDataToFile(studentsLeft, studentsRight);
        }

        private void SaveImagesInLocalAppData(TableLayoutPanel grid)
        {
            Directory.CreateDirectory(_pathToPictures);

            foreach (ucStudent student in grid.Controls)
            {
                if (student == null) continue;

                if (!student.DefaultPicture)
                {
                    string path = $"{_pathToPictures}{student.GUID.ToString()}.png";
                    if (!File.Exists(path))
                    {
                        student.picStudent.Image.Save(path, ImageFormat.Png);
                    }
                }
            }
        }

        /// <summary>
        /// Returns a list of all students in the grid.
        /// </summary>
        private IEnumerable<Student> StudentsInGrid(TableLayoutPanel grid)
        {
            foreach (ucStudent student in grid.Controls)
            {
                string imgFileName = "";
                if (!student.DefaultPicture)
                    imgFileName = student.GUID.ToString() + ".png";

                yield return new Student
                {
                    ImageFileName = imgFileName,
                    Firstname = student.txtFirstname.Text,
                    Lastname = student.txtLastname.Text,
                    Company = student.txtCompany.Text
                };
            }
        }

        private void WriteDataToFile(IEnumerable<Student> studentsLeft, IEnumerable<Student> studentsRight)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_pathToSave))
                {
                    writer.WriteLine("#LEFT");
                    foreach (Student student in studentsLeft)
                    {
                        //append line with ';'-seperated data of student
                        writer.WriteLine(StudentToFileLine(student));
                    }

                    writer.WriteLine("#RIGHT");
                    foreach (Student student in studentsRight)
                    {
                        //append line with ';'-seperated data of student
                        writer.WriteLine(StudentToFileLine(student));
                    }
                    writer.Close();
                }
                MessageBox.Show($"Die Datei {_pathToSave} wurde erfolgreich gespeichert.", "Speichern erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler beim Speichern!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private string StudentToFileLine(Student student)
        {
            //this is the format, a student is saved in the .sp-File
            return $"{student.ImageFileName};{student.Firstname};{student.Lastname};{student.Company}";
        }
        
    }
}
