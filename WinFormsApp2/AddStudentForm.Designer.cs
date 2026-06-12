namespace DrivingCoursesClasses
{
    partial class AddStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxFathername = new TextBox();
            comboBoxCourses = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(150, 128);
            textBoxName.Margin = new Padding(4, 5, 4, 5);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(141, 31);
            textBoxName.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(150, 45);
            textBoxSurname.Margin = new Padding(4, 5, 4, 5);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(141, 31);
            textBoxSurname.TabIndex = 1;
            // 
            // textBoxFathername
            // 
            textBoxFathername.Location = new Point(150, 228);
            textBoxFathername.Margin = new Padding(4, 5, 4, 5);
            textBoxFathername.Name = "textBoxFathername";
            textBoxFathername.Size = new Size(141, 31);
            textBoxFathername.TabIndex = 2;
            // 
            // comboBoxCourses
            // 
            comboBoxCourses.FormattingEnabled = true;
            comboBoxCourses.Location = new Point(150, 323);
            comboBoxCourses.Margin = new Padding(4, 5, 4, 5);
            comboBoxCourses.Name = "comboBoxCourses";
            comboBoxCourses.Size = new Size(141, 33);
            comboBoxCourses.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 4;
            label1.Text = "Прізвище";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 98);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 25);
            label2.TabIndex = 5;
            label2.Text = "Ім'я";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 198);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 6;
            label3.Text = "По батькові";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 293);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 7;
            label4.Text = "Курс";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(150, 385);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(141, 34);
            btnSave.TabIndex = 8;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 447);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxCourses);
            Controls.Add(textBoxFathername);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddStudentForm";
            Text = "Додати студента";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxFathername;
        private ComboBox comboBoxCourses;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSave;
    }
}