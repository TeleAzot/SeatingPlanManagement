using SeatingPlanManagement.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace SeatingPlanManagement.Data
{
    internal class ClasslistImport
    {
        string _rawText;
        ListView _lv;
        ClassListFormat _format;

        public ClasslistImport(string rawText, ClassListFormat format)
        {
            _rawText = rawText;
            _format = format;
        }

        public void Insert(ListView lv)
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
                //line couldn't be parsed to student
                ImportError();
                return;
            }

            InsertStudentsIntoListView(students);
        }

        private bool GetStudentFromLine(string line, out Student student)
        {
            student = null;

            //sometimes empty lines are imported -> student is null but validation is true
            if (!string.IsNullOrEmpty(line))
            {
                try
                {
                    string[] fields = line.Split('\t');
                    student = new Student { Firstname = fields[0], Lastname = fields[1].Split('\r')[0] };

                    if (_format == ClassListFormat.WithCompany)
                    {
                        student.Company = fields[2].Split('\r')[0];
                }              
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
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

                if (_format == ClassListFormat.WithCompany)
                    lvItem.SubItems.Add(student.Company);

                _lv.Items.Add(lvItem);
            }
        }

        private void ImportError()
        {
            string formatText = "";
            switch (_format)
            {
                case ClassListFormat.NameOnly:
                    formatText = "<Spalte Vorname, Spalte Nachname>";
                    break;
                case ClassListFormat.WithCompany:
                    formatText = "<Spalte Vorname, Spalte Nachname, Spalte Betrieb>";
                    break;
            }

            MessageBox.Show($"Die Liste muss im Format\n{formatText}\nimportiert werden.", "Fehler beim Importieren der Klassenliste",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    public enum ClassListFormat
    {
        NameOnly, WithCompany
    }

}
