using DrivingCoursesClasses.Classes;
using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace DrivingCoursesClasses
{
    public partial class DeleteStudentForm : Form
    {
        private OleDbConnection _connection;

        public DeleteStudentForm(OleDbConnection connection, BindingList<Student> students)
        {
            InitializeComponent();
            _connection = connection;

            var comboSource = students.Select(s => new { Id = s.Id, FullName = $"{s.Surname} {s.Name} {s.FatherName}" }).ToList();
            comboBoxStudents.DataSource = comboSource;
            comboBoxStudents.DisplayMember = "FullName";
            comboBoxStudents.ValueMember = "Id";
            comboBoxStudents.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxStudents.SelectedItem == null)
            {
                MessageBox.Show("Оберіть студента для видалення!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int studentId = (int)comboBoxStudents.SelectedValue;
            string studentName = comboBoxStudents.Text;

            var confirmResult = MessageBox.Show($"Ви дійсно хочете видалити студента {studentName}?",
                                     "Підтвердження видалення",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Студенти WHERE ID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, _connection))
                    {
                        cmd.Parameters.AddWithValue("?", studentId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Студента успішно видалено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка видалення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}