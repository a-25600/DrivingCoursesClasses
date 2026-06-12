namespace DrivingCoursesClasses
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            додатиToolStripMenuItem = new ToolStripMenuItem();
            btnAddStudent = new ToolStripMenuItem();
            btnAddCourse = new ToolStripMenuItem();
            btnAddTask = new ToolStripMenuItem();
            btnAddTest = new ToolStripMenuItem();
            вИвестиToolStripMenuItem = new ToolStripMenuItem();
            студентівToolStripMenuItem = new ToolStripMenuItem();
            курсиToolStripMenuItem = new ToolStripMenuItem();
            тестиToolStripMenuItem = new ToolStripMenuItem();
            btnDelete = new ToolStripMenuItem();
            btnPublish = new ToolStripMenuItem();
            btnExit = new ToolStripMenuItem();
            dataGridViewStudents = new DataGridView();
            btnShowStudentInfo = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { додатиToolStripMenuItem, вИвестиToolStripMenuItem, btnDelete, btnPublish, btnExit });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1143, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // додатиToolStripMenuItem
            // 
            додатиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnAddStudent, btnAddCourse, btnAddTask, btnAddTest });
            додатиToolStripMenuItem.Name = "додатиToolStripMenuItem";
            додатиToolStripMenuItem.Size = new Size(87, 29);
            додатиToolStripMenuItem.Text = "Додати";
            // 
            // btnAddStudent
            // 
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(186, 34);
            btnAddStudent.Text = "Студента";
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnAddCourse
            // 
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(186, 34);
            btnAddCourse.Text = "Курс";
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // btnAddTask
            // 
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(186, 34);
            btnAddTask.Text = "Заняття";
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnAddTest
            // 
            btnAddTest.Name = "btnAddTest";
            btnAddTest.Size = new Size(186, 34);
            btnAddTest.Text = "Тест";
            btnAddTest.Click += btnAddTest_Click;
            // 
            // вИвестиToolStripMenuItem
            // 
            вИвестиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { студентівToolStripMenuItem, курсиToolStripMenuItem, btnShowStudentInfo, тестиToolStripMenuItem });
            вИвестиToolStripMenuItem.Name = "вИвестиToolStripMenuItem";
            вИвестиToolStripMenuItem.Size = new Size(92, 29);
            вИвестиToolStripMenuItem.Text = "Вивести";
            // 
            // студентівToolStripMenuItem
            // 
            студентівToolStripMenuItem.Name = "студентівToolStripMenuItem";
            студентівToolStripMenuItem.Size = new Size(396, 34);
            студентівToolStripMenuItem.Text = "Загальний список студентів";
            студентівToolStripMenuItem.Click += btnShowAll_Click;
            // 
            // курсиToolStripMenuItem
            // 
            курсиToolStripMenuItem.Name = "курсиToolStripMenuItem";
            курсиToolStripMenuItem.Size = new Size(396, 34);
            курсиToolStripMenuItem.Text = "Список студентів на курсі";
            курсиToolStripMenuItem.Click += btnShowByCourse_Click;
            // 
            // тестиToolStripMenuItem
            // 
            тестиToolStripMenuItem.Name = "тестиToolStripMenuItem";
            тестиToolStripMenuItem.Size = new Size(396, 34);
            тестиToolStripMenuItem.Text = "Статус складання іспитів і тестів";
            тестиToolStripMenuItem.Click += btnShowExamStatus_Click;
            // 
            // btnDelete
            // 
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 29);
            btnDelete.Text = "Видалити";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnPublish
            // 
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(59, 29);
            btnPublish.Text = "Звіт";
            btnPublish.Click += btnPublish_Click;
            // 
            // btnExit
            // 
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(70, 29);
            btnExit.Text = "Вихід";
            btnExit.Click += btnExit_Click;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(17, 45);
            dataGridViewStudents.Margin = new Padding(4, 5, 4, 5);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowHeadersWidth = 62;
            dataGridViewStudents.Size = new Size(1109, 685);
            dataGridViewStudents.TabIndex = 1;
            // 
            // btnShowStudentInfo
            // 
            btnShowStudentInfo.Name = "btnShowStudentInfo";
            btnShowStudentInfo.Size = new Size(396, 34);
            btnShowStudentInfo.Text = "Загальна інформація про студента";
            btnShowStudentInfo.Click += btnShowStudentInfo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(dataGridViewStudents);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Водійські курси";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem додатиToolStripMenuItem;
        private ToolStripMenuItem btnAddStudent;
        private ToolStripMenuItem btnAddTask;
        private ToolStripMenuItem btnAddCourse;
        private ToolStripMenuItem btnAddTest;
        private ToolStripMenuItem btnDelete;
        private DataGridView dataGridViewStudents;
        private ToolStripMenuItem вИвестиToolStripMenuItem;
        private ToolStripMenuItem студентівToolStripMenuItem;
        private ToolStripMenuItem курсиToolStripMenuItem;
        private ToolStripMenuItem тестиToolStripMenuItem;
        private ToolStripMenuItem btnPublish;
        private ToolStripMenuItem btnExit;
        private ToolStripMenuItem btnShowStudentInfo;
    }
}
