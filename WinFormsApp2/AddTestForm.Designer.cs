namespace DrivingCoursesClasses
{
    partial class AddTestForm
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
            btnSave = new Button();
            textBoxTestScore = new TextBox();
            label1 = new Label();
            textBoxExamScore = new TextBox();
            label2 = new Label();
            comboBoxStudents = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(95, 311);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 38);
            btnSave.TabIndex = 0;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // textBoxTestScore
            // 
            textBoxTestScore.Location = new Point(78, 131);
            textBoxTestScore.Margin = new Padding(4, 5, 4, 5);
            textBoxTestScore.Name = "textBoxTestScore";
            textBoxTestScore.Size = new Size(141, 31);
            textBoxTestScore.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 101);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 2;
            label1.Text = "Результати тестувань";
            // 
            // textBoxExamScore
            // 
            textBoxExamScore.Location = new Point(78, 227);
            textBoxExamScore.Margin = new Padding(4, 5, 4, 5);
            textBoxExamScore.Name = "textBoxExamScore";
            textBoxExamScore.Size = new Size(141, 31);
            textBoxExamScore.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 197);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 25);
            label2.TabIndex = 4;
            label2.Text = "Результати екзамену";
            // 
            // comboBoxStudents
            // 
            comboBoxStudents.FormattingEnabled = true;
            comboBoxStudents.Location = new Point(60, 54);
            comboBoxStudents.Name = "comboBoxStudents";
            comboBoxStudents.Size = new Size(182, 33);
            comboBoxStudents.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 26);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 6;
            label3.Text = "Студент";
            // 
            // AddTestForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 372);
            Controls.Add(label3);
            Controls.Add(comboBoxStudents);
            Controls.Add(label2);
            Controls.Add(textBoxExamScore);
            Controls.Add(label1);
            Controls.Add(textBoxTestScore);
            Controls.Add(btnSave);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddTestForm";
            Text = "Додати тест";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox textBoxTestScore;
        private Label label1;
        private TextBox textBoxExamScore;
        private Label label2;
        private ComboBox comboBoxStudents;
        private Label label3;
    }
}