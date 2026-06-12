namespace DrivingCoursesClasses
{
    partial class SelectStudentForm
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
            comboBoxStudents = new ComboBox();
            label1 = new Label();
            btnShow = new Button();
            SuspendLayout();
            // 
            // comboBoxStudents
            // 
            comboBoxStudents.FormattingEnabled = true;
            comboBoxStudents.Location = new Point(130, 99);
            comboBoxStudents.Name = "comboBoxStudents";
            comboBoxStudents.Size = new Size(182, 33);
            comboBoxStudents.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 71);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 1;
            label1.Text = "Студент";
            // 
            // btnShow
            // 
            btnShow.Location = new Point(169, 152);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(112, 34);
            btnShow.TabIndex = 2;
            btnShow.Text = "Обрати";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // SelectStudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 268);
            Controls.Add(btnShow);
            Controls.Add(label1);
            Controls.Add(comboBoxStudents);
            Name = "SelectStudentForm";
            Text = "Обрати студента";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxStudents;
        private Label label1;
        private Button btnShow;
    }
}