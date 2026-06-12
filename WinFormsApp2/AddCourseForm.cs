using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DrivingCoursesClasses
{
    public partial class AddCourseForm : Form
    {
        private OleDbConnection _connection;

        public AddCourseForm(OleDbConnection connection)
        {
            InitializeComponent();
            _connection = connection;
        }

        public bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(textBoxCourseName.Text))
            {
                MessageBox.Show("Введіть назву курсу!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;

            string courseName = textBoxCourseName.Text.Trim();

            string insertQuery = "INSERT INTO Курси ([Курс]) VALUES (?)";

            try
            {
                using (OleDbCommand cmd = new OleDbCommand(insertQuery, _connection))
                {
                    cmd.Parameters.AddWithValue("?", courseName);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show($"Курс '{courseName}' успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка додавання курсу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}