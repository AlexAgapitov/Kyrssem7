namespace Kyrssem7
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.buttonDisciplines = new System.Windows.Forms.Button();
            this.buttonFaculties = new System.Windows.Forms.Button();
            this.buttonRating = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGroups
            // 
            this.buttonGroups.Location = new System.Drawing.Point(52, 43);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(97, 23);
            this.buttonGroups.TabIndex = 0;
            this.buttonGroups.Text = "Группы";
            this.buttonGroups.UseVisualStyleBackColor = true;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // buttonStudent
            // 
            this.buttonStudent.Location = new System.Drawing.Point(52, 72);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(97, 23);
            this.buttonStudent.TabIndex = 1;
            this.buttonStudent.Text = "Студенты";
            this.buttonStudent.UseVisualStyleBackColor = true;
            this.buttonStudent.Click += new System.EventHandler(this.buttonStudent_Click);
            // 
            // buttonDisciplines
            // 
            this.buttonDisciplines.Location = new System.Drawing.Point(52, 101);
            this.buttonDisciplines.Name = "buttonDisciplines";
            this.buttonDisciplines.Size = new System.Drawing.Size(97, 23);
            this.buttonDisciplines.TabIndex = 2;
            this.buttonDisciplines.Text = "Дисциплины";
            this.buttonDisciplines.UseVisualStyleBackColor = true;
            this.buttonDisciplines.Click += new System.EventHandler(this.buttonDisciplines_Click);
            // 
            // buttonFaculties
            // 
            this.buttonFaculties.Location = new System.Drawing.Point(52, 130);
            this.buttonFaculties.Name = "buttonFaculties";
            this.buttonFaculties.Size = new System.Drawing.Size(97, 23);
            this.buttonFaculties.TabIndex = 3;
            this.buttonFaculties.Text = "Факультеты";
            this.buttonFaculties.UseVisualStyleBackColor = true;
            this.buttonFaculties.Click += new System.EventHandler(this.buttonFaculties_Click);
            // 
            // buttonRating
            // 
            this.buttonRating.Location = new System.Drawing.Point(52, 159);
            this.buttonRating.Name = "buttonRating";
            this.buttonRating.Size = new System.Drawing.Size(97, 23);
            this.buttonRating.TabIndex = 4;
            this.buttonRating.Text = "Оценки";
            this.buttonRating.UseVisualStyleBackColor = true;
            this.buttonRating.Click += new System.EventHandler(this.buttonRating_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(52, 188);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(97, 23);
            this.buttonSelect.TabIndex = 5;
            this.buttonSelect.Text = "Запрос";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(203, 237);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonRating);
            this.Controls.Add(this.buttonFaculties);
            this.Controls.Add(this.buttonDisciplines);
            this.Controls.Add(this.buttonStudent);
            this.Controls.Add(this.buttonGroups);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonStudent;
        private System.Windows.Forms.Button buttonDisciplines;
        private System.Windows.Forms.Button buttonFaculties;
        private System.Windows.Forms.Button buttonRating;
        private System.Windows.Forms.Button buttonSelect;
    }
}

