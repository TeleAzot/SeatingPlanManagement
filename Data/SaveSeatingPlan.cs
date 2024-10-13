using PdfSharp.Pdf.IO;
using SeatingPlanManagement.GUI;
using System;
using System.Collections.Generic;
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

        private readonly string pathToPictures;

        public SaveSeatingPlan(string pathToSave, TableLayoutPanel gridLeft, TableLayoutPanel gridRight)
        {
            pathToPictures = $@"C:\Users\{Environment.UserName}\AppData\Local\SeatingPlanManagement\Images\";

            _pathToSave = pathToSave;
            _gridLeft = gridLeft;
            _gridRight = gridRight;
        }

        public async Task Save()
        {
            SaveImagesInLocalAppData(_gridLeft);
            SaveImagesInLocalAppData(_gridRight);

            IEnumerable<Student> studentsLeft = StudentsInGrid(_gridLeft);
            IEnumerable<Student> studentsRight = StudentsInGrid(_gridRight);

            await WriteDataToFile(studentsLeft, studentsRight);
        }

        private void SaveImagesInLocalAppData(TableLayoutPanel grid)
        {
            Directory.CreateDirectory(pathToPictures);

            foreach (ucStudent student in grid.Controls)
            {
                if (!student.DefaultPicture)
                    student.picStudent.Image.Save(pathToPictures + student.GUID + ".png");
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

        private async Task WriteDataToFile(IEnumerable<Student> studentsLeft, IEnumerable<Student> studentsRight)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_pathToSave))
                {
                    await writer.WriteLineAsync("#LEFT");
                    foreach (Student student in studentsLeft)
                    {
                        //append line with ';'-seperated data of student
                        await writer.WriteLineAsync(StudentToFileLine(student));
                    }

                    await writer.WriteLineAsync("#RIGHT");
                    foreach (Student student in studentsRight)
                    {
                        //append line with ';'-seperated data of student
                        await writer.WriteLineAsync(StudentToFileLine(student));
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
