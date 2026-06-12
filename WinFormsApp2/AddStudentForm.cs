using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DrivingCoursesClasses
{
    public partial class AddStudentForm : Form
    {
        private OleDbConnection _connection;

        public AddStudentForm(OleDbConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            LoadCoursesIntoComboBox();
        }

        private void LoadCoursesIntoComboBox()
        {
            try
            {
                comboBoxCourses.Items.Clear();

                string query = "SELECT [Курс] FROM Курси";

                using (OleDbCommand cmd = new OleDbCommand(query, _connection))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxCourses.Items.Add(reader["Курс"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося завантажити список курсів: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxSurname.Text) ||
                comboBoxCourses.SelectedItem == null)
            {
                MessageBox.Show("Заповніть ПІБ та обов'язково оберіть курс!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;

            string surname = textBoxSurname.Text.Trim();
            string name = textBoxName.Text.Trim();
            string fathername = textBoxFathername.Text.Trim();
            string selectedCourse = comboBoxCourses.SelectedItem.ToString();

            string insertQuery = "INSERT INTO Студенти ([Прізвище], [Ім'я], [По батькові], [Курс]) VALUES (?, ?, ?, ?)";

            try
            {
                using (OleDbCommand cmd = new OleDbCommand(insertQuery, _connection))
                {
                    cmd.Parameters.AddWithValue("?", surname);
                    cmd.Parameters.AddWithValue("?", name);
                    cmd.Parameters.AddWithValue("?", fathername);
                    cmd.Parameters.AddWithValue("?", selectedCourse);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Студента успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка збереження: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}