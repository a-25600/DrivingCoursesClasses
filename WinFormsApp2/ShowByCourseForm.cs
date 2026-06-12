using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DrivingCoursesClasses
{
    public partial class ShowByCourseForm : Form
    {
        private OleDbConnection _connection;

        public string SelectedCourse { get; private set; }

        public ShowByCourseForm(OleDbConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            LoadCoursesIntoComboBox();
        }

        private void LoadCoursesIntoComboBox()
        {
            try
            {
                comboBoxFilterCourse.Items.Clear();

                string query = "SELECT [Курс] FROM Курси";

                using (OleDbCommand cmd = new OleDbCommand(query, _connection))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxFilterCourse.Items.Add(reader["Курс"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося завантажити список курсів: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowByCourse_Click(object sender, EventArgs e)
        {
            if (comboBoxFilterCourse.SelectedItem == null)
            {
                MessageBox.Show("Оберіть курс!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SelectedCourse = comboBoxFilterCourse.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}