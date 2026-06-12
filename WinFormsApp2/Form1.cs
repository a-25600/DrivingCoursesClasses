using DrivingCoursesClasses.Classes;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DrivingCoursesClasses
{
    public partial class Form1 : Form
    {
        internal OleDbConnection connection;
        private BindingList<Student> _studentsList;

        public Form1()
        {
            InitializeComponent();
            InitializeDataBinding();
            try
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Курси.accdb;";
                connection = new OleDbConnection(connectionString);
                connection.Open();
                readStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка підключення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void readStudents()
        {
            if (connection == null || connection.State != ConnectionState.Open) return;

            _studentsList.Clear();
            string query = "SELECT * FROM Студенти";

            try
            {
                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var student = new Student();
                        student.Id = Convert.ToInt32(reader["ID"]);

                        string name = reader["Ім'я"].ToString();
                        string surname = reader["Прізвище"].ToString();
                        string fathername = reader["По батькові"].ToString();
                        string course = reader["Курс"].ToString();

                        student.SetFullName(name, surname, fathername);
                        student.AddCourse(course);

                        _studentsList.Add(student);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка зчитування бази даних: {ex.Message}");
            }
        }

        private void InitializeDataBinding()
        {
            _studentsList = new BindingList<Student>();
            dataGridViewStudents.DataSource = _studentsList;

            if (dataGridViewStudents.Columns["Id"] != null)
                dataGridViewStudents.Columns["Id"].Visible = false;

            if (dataGridViewStudents.Columns["Courses"] != null)
                dataGridViewStudents.Columns["Courses"].Visible = false;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var studentForm = new AddStudentForm(this.connection);
            if (studentForm.ShowDialog() == DialogResult.OK)
            {
                readStudents();
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            var courseForm = new AddCourseForm(this.connection);
            courseForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var deleteForm = new DeleteStudentForm(this.connection, _studentsList);

            if (deleteForm.ShowDialog() == DialogResult.OK)
            {
                readStudents();
            }
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            if (_studentsList == null || _studentsList.Count == 0)
            {
                MessageBox.Show("Немає даних для експорту!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt|CSV Files|*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                        {
                            sw.WriteLine("ID;Прізвище;Ім'я;По батькові;Курс");

                            foreach (var student in _studentsList)
                            {
                                string course = student.Courses.Count > 0 ? student.Courses[0].Category : "Немає";
                                sw.WriteLine($"{student.Id};{student.Surname};{student.Name};{student.FatherName};{course}");
                            }
                        }
                        MessageBox.Show("Дані успішно опубліковано/експортовано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка запису у файл: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {

            var taskForm = new AddTaskForm(this.connection, _studentsList);
            taskForm.ShowDialog();
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            var testForm = new AddTestForm(this.connection, _studentsList);
            testForm.ShowDialog();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            var displayList = _studentsList.Select(s => new
            {
                Прізвище = s.Surname,
                Ім_я = s.Name,
                По_батькові = s.FatherName,
                Курс = s.Courses.Count > 0 ? s.Courses[0].Category : "Не призначено"
            }).ToList();

            dataGridViewStudents.DataSource = displayList;
            dataGridViewStudents.Columns["Ім_я"].HeaderText = "Ім'я";
        }
        private void btnShowByCourse_Click(object sender, EventArgs e)
        {
            var courseForm = new ShowByCourseForm(this.connection);

            if (courseForm.ShowDialog() == DialogResult.OK)
            {
                string targetCourse = courseForm.SelectedCourse;

                var displayList = _studentsList
                    .Where(s => s.Courses.Any(c => c.Category == targetCourse))
                    .Select(s => new
                    {
                        Прізвище = s.Surname,
                        Ім_я = s.Name,
                        По_батькові = s.FatherName
                    }).ToList();

                dataGridViewStudents.DataSource = displayList;

                if (dataGridViewStudents.Columns["Ім_я"] != null)
                {
                    dataGridViewStudents.Columns["Ім_я"].HeaderText = "Ім'я";
                }
            }
        }

        private void btnShowExamStatus_Click(object sender, EventArgs e)
        {
            if (connection == null || connection.State != ConnectionState.Open) return;

            DataTable dt = new DataTable();
            dt.Columns.Add("Прізвище", typeof(string));
            dt.Columns.Add("Ім'я", typeof(string));
            dt.Columns.Add("По батькові", typeof(string));
            dt.Columns.Add("Статус", typeof(string));

            string query = @"
        SELECT С.[Прізвище], С.[Ім'я], С.[По батькові], Т.[Результати проміжних тестів], Т.[Екзамен]
        FROM Студенти AS С
        LEFT JOIN Тести AS Т ON С.ID = Т.[ID студента]";

            try
            {
                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string surname = reader["Прізвище"].ToString();
                        string name = reader["Ім'я"].ToString();
                        string fathername = reader["По батькові"].ToString();

                        string testsStr = reader["Результати проміжних тестів"].ToString();
                        string examStr = reader["Екзамен"].ToString();

                        string status = "Не здав";

                        bool hasExam = int.TryParse(examStr, out int examScore);

                        if (hasExam && examScore >= 4)
                        {
                            status = "Здав";
                        }
                        else if (!string.IsNullOrWhiteSpace(testsStr))
                        {
                            var scores = testsStr.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            int sum = 0;

                            foreach (var s in scores)
                            {
                                if (int.TryParse(s, out int val))
                                    sum += val;
                            }

                            if (scores.Length > 0)
                            {
                                double average = (double)sum / scores.Length;

                                if (average >= 4.0)
                                {
                                    status = "Здав";
                                }
                            }
                        }

                        dt.Rows.Add(surname, name, fathername, status);
                    }
                }

                dataGridViewStudents.DataSource = dt;

                dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка формування звіту: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnShowStudentInfo_Click(object sender, EventArgs e)
        {
            var selectForm = new SelectStudentForm(_studentsList);
            if (selectForm.ShowDialog() == DialogResult.OK)
            {
                int studentId = selectForm.GetSelectedStudentId();
                Student student = _studentsList.FirstOrDefault(s => s.Id == studentId);

                if (student == null) return;

                DataTable dt = new DataTable();
                dt.Columns.Add("Заняття", typeof(int));
                dt.Columns.Add("Дата", typeof(string));
                dt.Columns.Add("Відвідування", typeof(string));
                dt.Columns.Add("Тести", typeof(string));
                dt.Columns.Add("Екзамен", typeof(string));

                string testsStr = "-";
                string examStr = "-";

                string queryTests = "SELECT [Результати проміжних тестів], [Екзамен] FROM Тести WHERE [ID студента] = ?";
                using (OleDbCommand cmd = new OleDbCommand(queryTests, connection))
                {
                    cmd.Parameters.AddWithValue("?", studentId);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            testsStr = reader["Результати проміжних тестів"].ToString();
                            examStr = reader["Екзамен"].ToString();
                        }
                    }
                }

                string queryLessons = "SELECT [Дата], [Присутній] FROM Заняття WHERE [ID студента] = ? ORDER BY [Дата]";
                using (OleDbCommand cmd = new OleDbCommand(queryLessons, connection))
                {
                    cmd.Parameters.AddWithValue("?", studentId);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        int lessonNum = 1;
                        while (reader.Read())
                        {
                            DateTime date = Convert.ToDateTime(reader["Дата"]);
                            string presence = reader["Присутній"].ToString();

                            dt.Rows.Add(lessonNum, date.ToShortDateString(), presence,
                                        lessonNum == 1 ? testsStr : "",
                                        lessonNum == 1 ? examStr : "");
                            lessonNum++;
                        }
                    }
                }

                dataGridViewStudents.DataSource = dt;
            }
        }
    }
}