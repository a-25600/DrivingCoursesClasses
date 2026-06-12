using DrivingCoursesClasses.Classes;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DrivingCoursesClasses
{
    public partial class SelectStudentForm : Form
    {
        public SelectStudentForm(BindingList<Student> students)
        {
            InitializeComponent();

            var comboSource = students.Select(s => new
            {
                Id = s.Id,
                FullName = $"{s.Surname} {s.Name} {s.FatherName}"
            }).ToList();

            comboBoxStudents.DataSource = comboSource;
            comboBoxStudents.DisplayMember = "FullName";
            comboBoxStudents.ValueMember = "Id";
            comboBoxStudents.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (comboBoxStudents.SelectedItem == null)
            {
                MessageBox.Show("Оберіть студента!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public int GetSelectedStudentId()
        {
            return (int)comboBoxStudents.SelectedValue;
        }
    }
}