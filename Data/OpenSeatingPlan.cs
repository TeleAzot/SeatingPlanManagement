using SeatingPlanManagement.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeatingPlanManagement.Data
{
    internal class OpenSeatingPlan
    {
        private readonly string _pathToFile;
        private TableLayoutPanel _gridLeft;
        private TableLayoutPanel _gridRight;

        private readonly string _pathToPictures;

        public OpenSeatingPlan(string path, TableLayoutPanel gridLeft, TableLayoutPanel gridRight)
        {
            _pathToPictures = $@"C:\Users\{Environment.UserName}\AppData\Local\SeatingPlanManagement\Images\";

            _pathToFile = path;
            _gridLeft = gridLeft;
            _gridRight = gridRight;
        }

        private void ClearAllSeats()
        {
            _gridLeft.Controls.Clear();
            _gridRight.Controls.Clear();
        }

        private void RestoreDefaultSeats(TableLayoutPanel grid)
        {
            for (int i = 0; i < 16; i++)
            {
                ucStudent student = new ucStudent();
                grid.Controls.Add(student);
            }
        }

        public void Open()
        {
            ClearAllSeats();

            List<Student> studentsLeft = new List<Student>();
            List<Student> studentsRight = new List<Student>();

            try
            {
                using (StreamReader reader = new StreamReader(_pathToFile))
                {
                    string line;
                    TableLayoutPanel currentGrid;
                    List<Student> currentSideOfStudents = new List<Student>();

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line == "#LEFT")
                        {
                            //make the left grid and list for left students the active ones
                            currentGrid = _gridLeft;
                            currentSideOfStudents = studentsLeft;
                            continue;
                        }
                        if (line == "#RIGHT")
                        {
                            //make the right grid and list for right students the active ones
                            currentGrid = _gridRight;
                            currentSideOfStudents = studentsRight;
                            continue;
                        }
                        //convert the line to student and add it to active list
                        currentSideOfStudents.Add(StudentFromFileLine(line));
                    }
                    reader.Close();
                }

                InsertStudentsIntoGrid(studentsLeft, _gridLeft);
                InsertStudentsIntoGrid(studentsRight, _gridRight);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler beim Öffnen!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAllSeats();
                RestoreDefaultSeats(_gridLeft);
                RestoreDefaultSeats(_gridRight);
            }
            
        }

        /// <summary>
        /// Converts a line in .sp-File to Student.
        /// </summary>
        private Student StudentFromFileLine(string line)
        {
            return new Student
            {
                ImageFileName = line.Split(';')[0],
                Firstname = line.Split(";")[1],
                Lastname = line.Split(";")[2],
                Company = line.Split(";")[3]
            };
        }

        private void InsertStudentsIntoGrid(IEnumerable<Student> students, TableLayoutPanel grid)
        {
            foreach (Student student in students)
            {
                //create a new ucStudent and fill the student's data into it, then add it to the grid
                ucStudent ucStudent = new ucStudent();

                //check if the student has an image and set the ucStudent's GUID and picture
                if (!string.IsNullOrEmpty(student.ImageFileName))
                {
                    ucStudent.DefaultPicture = false;
                    ucStudent.GUID = Guid.Parse(student.ImageFileName.Split(".png")[0]);
                    ucStudent.picStudent.Image = Image.FromFile(_pathToPictures + student.ImageFileName);
                }

                ucStudent.txtFirstname.Text = student.Firstname;
                ucStudent.txtLastname.Text = student.Lastname;
                ucStudent.txtCompany.Text = student.Company;

                grid.Controls.Add(ucStudent);
            }
        }
    }
}
