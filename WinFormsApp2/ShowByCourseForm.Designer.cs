namespace DrivingCoursesClasses
{
    partial class ShowByCourseForm
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
            comboBoxFilterCourse = new ComboBox();
            btnShowByCourse = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBoxFilterCourse
            // 
            comboBoxFilterCourse.FormattingEnabled = true;
            comboBoxFilterCourse.Location = new Point(107, 68);
            comboBoxFilterCourse.Margin = new Padding(4, 5, 4, 5);
            comboBoxFilterCourse.Name = "comboBoxFilterCourse";
            comboBoxFilterCourse.Size = new Size(171, 33);
            comboBoxFilterCourse.TabIndex = 0;
            // 
            // btnShowByCourse
            // 
            btnShowByCourse.Location = new Point(141, 140);
            btnShowByCourse.Margin = new Padding(4, 5, 4, 5);
            btnShowByCourse.Name = "btnShowByCourse";
            btnShowByCourse.Size = new Size(107, 38);
            btnShowByCourse.TabIndex = 1;
            btnShowByCourse.Text = "Показати";
            btnShowByCourse.UseVisualStyleBackColor = true;
            btnShowByCourse.Click += btnShowByCourse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 38);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 2;
            label1.Text = "Курс";
            // 
            // ShowByCourseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 250);
            Controls.Add(label1);
            Controls.Add(btnShowByCourse);
            Controls.Add(comboBoxFilterCourse);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ShowByCourseForm";
            Text = "Обрати курс";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxFilterCourse;
        private Button btnShowByCourse;
        private Label label1;
    }
}