using SeatingPlanManagement.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeatingPlanManagement.Data
{
    internal class ClasslistImport
    {
        string _rawText;
        ListView _lv;

        public ClasslistImport(string rawText)
        {
            _rawText = rawText;
        }

        public void InsertIntoListView(ListView lv)
        {
            _lv = lv;
            lv.Items.Clear();

            var lines = _rawText.Split('\n');

            List<Student> students = new List<Student>();
            foreach (string line in lines)
            {
                if (GetStudentFromLine(line, out Student student))
                {
                    students.Add(student);
                    continue;
                }
                MessageBox.Show("Die Liste muss im Format\n<Spalte Vorname, Spalte Nachname>\nimportiert werden.", "Fehler beim Importieren der Klassenliste",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InsertStudentsIntoListView(students);
        }

        private bool GetStudentFromLine(string line, out Student student)
        {
            //sometimes empty lines are imported -> student is null but validation is true
            if (!string.IsNullOrEmpty(line))
            {
                try
                {
                    student = new Student { Firstname = line.Split('\t')[0], Lastname = line.Split('\t')[1].Split('\r')[0] };
                    return true;
                }
                catch (Exception ex)
                {
                    student = null;
                    return false;
                }
            }
            student = null;
            return true;            
        }

        private void InsertStudentsIntoListView(List<Student> students)
        {
            foreach (Student student in students)
            {
                if (student == null)
                    continue;

                ListViewItem lvItem = new ListViewItem(student.Firstname);
                lvItem.SubItems.Add(student.Lastname);
                _lv.Items.Add(lvItem);
            }
        }
    }

    public class Student
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
