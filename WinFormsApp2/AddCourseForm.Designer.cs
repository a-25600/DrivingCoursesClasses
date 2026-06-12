namespace DrivingCoursesClasses
{
    partial class AddCourseForm
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
            label1 = new Label();
            textBoxCourseName = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 5;
            label1.Text = "Назва курсу";
            // 
            // textBoxCourseName
            // 
            textBoxCourseName.Location = new Point(115, 99);
            textBoxCourseName.Margin = new Padding(4, 5, 4, 5);
            textBoxCourseName.Name = "textBoxCourseName";
            textBoxCourseName.Size = new Size(141, 31);
            textBoxCourseName.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(115, 166);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(141, 34);
            btnSave.TabIndex = 7;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddCourseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 267);
            Controls.Add(btnSave);
            Controls.Add(textBoxCourseName);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddCourseForm";
            Text = "Додати курс";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxCourseName;
        private Button btnSave;
    }
}