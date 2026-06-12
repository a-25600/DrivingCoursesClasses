using DrivingCoursesClasses.Classes;
using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DrivingCoursesClasses
{
    public partial class AddTaskForm : Form
    {
        private OleDbConnection _connection;

        private class StudentItem
        {
            public int Id { get; set; }
            public string FullName { get; set; }
        }

        public AddTaskForm(OleDbConnection connection, BindingList<Student> students)
        {
            InitializeComponent();
            _connection = connection;

            PopulateStudentList(students);
            PopulateMistakesList();
        }

        private void PopulateStudentList(BindingList<Student> students)
        {
            var comboSource = students.Select(s => new StudentItem
            {
                Id = s.Id,
                FullName = $"{s.Surname} {s.Name} {s.FatherName}"
            }).ToList();

            comboBoxStudent.DataSource = comboSource;
            comboBoxStudent.DisplayMember = "FullName";
            comboBoxStudent.ValueMember = "Id";
            comboBoxStudent.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void PopulateMistakesList()
        {
            checkedListBoxMistakes.Items.Add("Пошкодження транспортного засобу");
            checkedListBoxMistakes.Items.Add("Перевищення швидкості");
            checkedListBoxMistakes.Items.Add("Неправомірний перетин");
            checkedListBoxMistakes.Items.Add("Проїзд на червоний сигнал");
            checkedListBoxMistakes.Items.Add("Ненадання пріоритету");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isPresent = checkBoxIsPresent.Checked;
            if (comboBoxStudent.SelectedItem == null)
            {
                MessageBox.Show("Оберіть студента!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int studentId = (int)comboBoxStudent.SelectedValue;
            DateTime lessonDate = dateTimePickerDate.Value.Date;

            List<string> selectedMistakes = new List<string>();
            foreach (var item in checkedListBoxMistakes.CheckedItems)
            {
                selectedMistakes.Add(item.ToString());
            }

            try
            {
                string queryLesson = "INSERT INTO Заняття ([ID студента], [Дата], [Присутній]) VALUES (?, ?, ?)";
                using (OleDbCommand cmdLesson = new OleDbCommand(queryLesson, _connection))
                {
                    cmdLesson.Parameters.AddWithValue("?", studentId);
                    cmdLesson.Parameters.AddWithValue("?", lessonDate);
                    cmdLesson.Parameters.AddWithValue("?", isPresent);
                    cmdLesson.ExecuteNonQuery();
                }

                if (selectedMistakes.Count > 0)
                {
                    string mistakesText = string.Join(", ", selectedMistakes);
                    string queryMistakes = "INSERT INTO Зауваження ([ID студента], [Зауваження]) VALUES (?, ?)";

                    using (OleDbCommand cmdMistakes = new OleDbCommand(queryMistakes, _connection))
                    {
                        cmdMistakes.Parameters.AddWithValue("?", studentId);
                        cmdMistakes.Parameters.AddWithValue("?", mistakesText);
                        cmdMistakes.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Дані про індивідуальне заняття успішно збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка збереження даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}