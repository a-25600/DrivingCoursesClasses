using DrivingCoursesClasses.Classes;
using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace DrivingCoursesClasses
{
    public partial class AddTestForm : Form
    {
        private OleDbConnection _connection;

        public AddTestForm(OleDbConnection connection, BindingList<Student> students)
        {
            InitializeComponent();
            _connection = connection;

            var comboSource = students.Select(s => new { Id = s.Id, FullName = $"{s.Surname} {s.Name} {s.FatherName}" }).ToList();
            comboBoxStudents.DataSource = comboSource;
            comboBoxStudents.DisplayMember = "FullName";
            comboBoxStudents.ValueMember = "Id";
            comboBoxStudents.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBoxStudents.SelectedItem == null)
            {
                MessageBox.Show("Оберіть студента!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newTestScore = textBoxTestScore.Text.Trim();
            string examScoreText = textBoxExamScore.Text.Trim();

            if (string.IsNullOrEmpty(newTestScore) && string.IsNullOrEmpty(examScoreText))
            {
                MessageBox.Show("Введіть хоча б одну оцінку (за тест або екзамен)!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int studentId = (int)comboBoxStudents.SelectedValue;

            try
            {
                bool recordExists = false;
                string existingTests = "";

                string checkQuery = "SELECT [Результати проміжних тестів] FROM Тести WHERE [ID студента] = ?";
                using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, _connection))
                {
                    checkCmd.Parameters.AddWithValue("?", studentId);
                    using (OleDbDataReader reader = checkCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            recordExists = true;
                            existingTests = reader["Результати проміжних тестів"].ToString();
                        }
                    }
                }

                string updatedTests = existingTests;
                if (!string.IsNullOrEmpty(newTestScore))
                {
                    if (string.IsNullOrEmpty(existingTests))
                        updatedTests = newTestScore;
                    else
                        updatedTests = existingTests + ", " + newTestScore;
                }

                if (recordExists)
                {
                    string updateQuery = "UPDATE Тести SET [Результати проміжних тестів] = ? ";

                    if (!string.IsNullOrEmpty(examScoreText))
                        updateQuery += ", [Екзамен] = ? ";

                    updateQuery += "WHERE [ID студента] = ?";

                    using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, _connection))
                    {
                        updateCmd.Parameters.AddWithValue("?", updatedTests);

                        if (!string.IsNullOrEmpty(examScoreText))
                            updateCmd.Parameters.AddWithValue("?", int.Parse(examScoreText));

                        updateCmd.Parameters.AddWithValue("?", studentId);
                        updateCmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    string insertQuery = "INSERT INTO Тести ([ID студента], [Результати проміжних тестів], [Екзамен]) VALUES (?, ?, ?)";
                    using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, _connection))
                    {
                        insertCmd.Parameters.AddWithValue("?", studentId);
                        insertCmd.Parameters.AddWithValue("?", updatedTests);

                        if (string.IsNullOrEmpty(examScoreText))
                            insertCmd.Parameters.AddWithValue("?", DBNull.Value);
                        else
                            insertCmd.Parameters.AddWithValue("?", int.Parse(examScoreText));

                        insertCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Оцінку успішно збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка збереження результатів: {ex.Message}\nПеревірте правильність введених даних.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}