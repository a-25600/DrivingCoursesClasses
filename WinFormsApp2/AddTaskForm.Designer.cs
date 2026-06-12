namespace DrivingCoursesClasses
{
    partial class AddTaskForm
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
            checkedListBoxMistakes = new CheckedListBox();
            checkBoxIsPresent = new CheckBox();
            dateTimePickerDate = new DateTimePicker();
            btnSave = new Button();
            Зауваження = new Label();
            label1 = new Label();
            label2 = new Label();
            comboBoxStudent = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // checkedListBoxMistakes
            // 
            checkedListBoxMistakes.FormattingEnabled = true;
            checkedListBoxMistakes.Location = new Point(44, 148);
            checkedListBoxMistakes.Margin = new Padding(4, 5, 4, 5);
            checkedListBoxMistakes.Name = "checkedListBoxMistakes";
            checkedListBoxMistakes.Size = new Size(284, 144);
            checkedListBoxMistakes.TabIndex = 0;
            // 
            // checkBoxIsPresent
            // 
            checkBoxIsPresent.AutoSize = true;
            checkBoxIsPresent.Location = new Point(125, 424);
            checkBoxIsPresent.Margin = new Padding(4, 5, 4, 5);
            checkBoxIsPresent.Name = "checkBoxIsPresent";
            checkBoxIsPresent.Size = new Size(120, 29);
            checkBoxIsPresent.TabIndex = 1;
            checkBoxIsPresent.Text = "Присутній";
            checkBoxIsPresent.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new Point(44, 340);
            dateTimePickerDate.Margin = new Padding(4, 5, 4, 5);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(284, 31);
            dateTimePickerDate.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(44, 463);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(286, 38);
            btnSave.TabIndex = 3;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Зауваження
            // 
            Зауваження.AutoSize = true;
            Зауваження.Location = new Point(138, 118);
            Зауваження.Margin = new Padding(4, 0, 4, 0);
            Зауваження.Name = "Зауваження";
            Зауваження.Size = new Size(110, 25);
            Зауваження.TabIndex = 4;
            Зауваження.Text = "Зауваження";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 310);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 5;
            label1.Text = "Дата";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 391);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 6;
            label2.Text = "Присутність";
            // 
            // comboBoxStudent
            // 
            comboBoxStudent.FormattingEnabled = true;
            comboBoxStudent.Location = new Point(91, 68);
            comboBoxStudent.Name = "comboBoxStudent";
            comboBoxStudent.Size = new Size(182, 33);
            comboBoxStudent.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 40);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 8;
            label3.Text = "Студент";
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 539);
            Controls.Add(label3);
            Controls.Add(comboBoxStudent);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Зауваження);
            Controls.Add(btnSave);
            Controls.Add(dateTimePickerDate);
            Controls.Add(checkBoxIsPresent);
            Controls.Add(checkedListBoxMistakes);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddTaskForm";
            Text = "Додати заняття";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBoxMistakes;
        private CheckBox checkBoxIsPresent;
        private DateTimePicker dateTimePickerDate;
        private Button btnSave;
        private Label Зауваження;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxStudent;
        private Label label3;
    }
}