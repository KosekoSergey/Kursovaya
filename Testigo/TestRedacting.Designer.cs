
namespace Testigo
{
    partial class DeleteQuestionButton
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
            this.TestNameLabel = new System.Windows.Forms.Label();
            this.TestNameTB = new System.Windows.Forms.TextBox();
            this.QuestionNumberComboBox = new System.Windows.Forms.ComboBox();
            this.SelectQuestionLabel = new System.Windows.Forms.Label();
            this.QuestionTypeCB = new System.Windows.Forms.ComboBox();
            this.AnswerTypeLabel = new System.Windows.Forms.Label();
            this.AddQuestionButton = new System.Windows.Forms.Button();
            this.QTextTB = new System.Windows.Forms.RichTextBox();
            this.QTextLabel = new System.Windows.Forms.Label();
            this.CorrectAnswerLabel = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.Type13 = new System.Windows.Forms.GroupBox();
            this.Type13TB6 = new System.Windows.Forms.TextBox();
            this.Type13TB5 = new System.Windows.Forms.TextBox();
            this.Type13TB4 = new System.Windows.Forms.TextBox();
            this.Type13TB3 = new System.Windows.Forms.TextBox();
            this.Type13TB2 = new System.Windows.Forms.TextBox();
            this.Type13TB1 = new System.Windows.Forms.TextBox();
            this.Type13C6 = new System.Windows.Forms.CheckBox();
            this.Type13C5 = new System.Windows.Forms.CheckBox();
            this.Type13C4 = new System.Windows.Forms.CheckBox();
            this.Type13C3 = new System.Windows.Forms.CheckBox();
            this.Type13C2 = new System.Windows.Forms.CheckBox();
            this.Type13C1 = new System.Windows.Forms.CheckBox();
            this.Type13R6 = new System.Windows.Forms.RadioButton();
            this.Type13R5 = new System.Windows.Forms.RadioButton();
            this.Type13R4 = new System.Windows.Forms.RadioButton();
            this.Type13R3 = new System.Windows.Forms.RadioButton();
            this.Type13R2 = new System.Windows.Forms.RadioButton();
            this.Type13R1 = new System.Windows.Forms.RadioButton();
            this.Type2TB = new System.Windows.Forms.TextBox();
            this.NumOfVarLabel = new System.Windows.Forms.Label();
            this.NumOfVarCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SaveAllButton = new System.Windows.Forms.Button();
            this.Type13.SuspendLayout();
            this.SuspendLayout();
            // 
            // TestNameLabel
            // 
            this.TestNameLabel.AutoSize = true;
            this.TestNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TestNameLabel.Location = new System.Drawing.Point(52, 13);
            this.TestNameLabel.Name = "TestNameLabel";
            this.TestNameLabel.Size = new System.Drawing.Size(122, 21);
            this.TestNameLabel.TabIndex = 0;
            this.TestNameLabel.Text = "Название теста:";
            // 
            // TestNameTB
            // 
            this.TestNameTB.Location = new System.Drawing.Point(185, 15);
            this.TestNameTB.Name = "TestNameTB";
            this.TestNameTB.Size = new System.Drawing.Size(240, 23);
            this.TestNameTB.TabIndex = 1;
            // 
            // QuestionNumberComboBox
            // 
            this.QuestionNumberComboBox.FormattingEnabled = true;
            this.QuestionNumberComboBox.Location = new System.Drawing.Point(185, 71);
            this.QuestionNumberComboBox.Name = "QuestionNumberComboBox";
            this.QuestionNumberComboBox.Size = new System.Drawing.Size(35, 23);
            this.QuestionNumberComboBox.TabIndex = 2;
            this.QuestionNumberComboBox.SelectedIndexChanged += new System.EventHandler(this.QuestionNumberComboBox_SelectedIndexChanged);
            // 
            // SelectQuestionLabel
            // 
            this.SelectQuestionLabel.AutoSize = true;
            this.SelectQuestionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectQuestionLabel.Location = new System.Drawing.Point(52, 69);
            this.SelectQuestionLabel.Name = "SelectQuestionLabel";
            this.SelectQuestionLabel.Size = new System.Drawing.Size(124, 21);
            this.SelectQuestionLabel.TabIndex = 3;
            this.SelectQuestionLabel.Text = "Номер вопроса:";
            // 
            // QuestionTypeCB
            // 
            this.QuestionTypeCB.AutoCompleteCustomSource.AddRange(new string[] {
            "Один вариант",
            "Ввод слова или числа",
            "Несколько вариантов"});
            this.QuestionTypeCB.FormattingEnabled = true;
            this.QuestionTypeCB.Items.AddRange(new object[] {
            "Один вариант",
            "Ввод слова или числа",
            "Несколько вариантов"});
            this.QuestionTypeCB.Location = new System.Drawing.Point(185, 109);
            this.QuestionTypeCB.Name = "QuestionTypeCB";
            this.QuestionTypeCB.Size = new System.Drawing.Size(257, 23);
            this.QuestionTypeCB.TabIndex = 4;
            this.QuestionTypeCB.SelectedIndexChanged += new System.EventHandler(this.QuestionTypeCB_SelectedIndexChanged);
            // 
            // AnswerTypeLabel
            // 
            this.AnswerTypeLabel.AutoSize = true;
            this.AnswerTypeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnswerTypeLabel.Location = new System.Drawing.Point(52, 111);
            this.AnswerTypeLabel.Name = "AnswerTypeLabel";
            this.AnswerTypeLabel.Size = new System.Drawing.Size(90, 21);
            this.AnswerTypeLabel.TabIndex = 5;
            this.AnswerTypeLabel.Text = "Тип ответа:";
            // 
            // AddQuestionButton
            // 
            this.AddQuestionButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddQuestionButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddQuestionButton.Location = new System.Drawing.Point(430, 68);
            this.AddQuestionButton.Name = "AddQuestionButton";
            this.AddQuestionButton.Size = new System.Drawing.Size(125, 25);
            this.AddQuestionButton.TabIndex = 6;
            this.AddQuestionButton.Text = "Добавить вопрос";
            this.AddQuestionButton.UseVisualStyleBackColor = false;
            this.AddQuestionButton.Click += new System.EventHandler(this.AddQuestionButton_Click);
            // 
            // QTextTB
            // 
            this.QTextTB.Location = new System.Drawing.Point(52, 176);
            this.QTextTB.Name = "QTextTB";
            this.QTextTB.Size = new System.Drawing.Size(634, 105);
            this.QTextTB.TabIndex = 7;
            this.QTextTB.Text = "";
            // 
            // QTextLabel
            // 
            this.QTextLabel.AutoSize = true;
            this.QTextLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QTextLabel.Location = new System.Drawing.Point(52, 152);
            this.QTextLabel.Name = "QTextLabel";
            this.QTextLabel.Size = new System.Drawing.Size(114, 21);
            this.QTextLabel.TabIndex = 8;
            this.QTextLabel.Text = "Текст вопроса:";
            // 
            // CorrectAnswerLabel
            // 
            this.CorrectAnswerLabel.AutoSize = true;
            this.CorrectAnswerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CorrectAnswerLabel.Location = new System.Drawing.Point(52, 284);
            this.CorrectAnswerLabel.Name = "CorrectAnswerLabel";
            this.CorrectAnswerLabel.Size = new System.Drawing.Size(146, 21);
            this.CorrectAnswerLabel.TabIndex = 9;
            this.CorrectAnswerLabel.Text = "Правильный ответ:";
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnswerLabel.Location = new System.Drawing.Point(251, 284);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(143, 21);
            this.AnswerLabel.TabIndex = 10;
            this.AnswerLabel.Text = "Варианты ответов:";
            // 
            // Type13
            // 
            this.Type13.Controls.Add(this.Type13TB6);
            this.Type13.Controls.Add(this.Type13TB5);
            this.Type13.Controls.Add(this.Type13TB4);
            this.Type13.Controls.Add(this.Type13TB3);
            this.Type13.Controls.Add(this.Type13TB2);
            this.Type13.Controls.Add(this.Type13TB1);
            this.Type13.Controls.Add(this.Type13C6);
            this.Type13.Controls.Add(this.Type13C5);
            this.Type13.Controls.Add(this.Type13C4);
            this.Type13.Controls.Add(this.Type13C3);
            this.Type13.Controls.Add(this.Type13C2);
            this.Type13.Controls.Add(this.Type13C1);
            this.Type13.Controls.Add(this.Type13R6);
            this.Type13.Controls.Add(this.Type13R5);
            this.Type13.Controls.Add(this.Type13R4);
            this.Type13.Controls.Add(this.Type13R3);
            this.Type13.Controls.Add(this.Type13R2);
            this.Type13.Controls.Add(this.Type13R1);
            this.Type13.Location = new System.Drawing.Point(146, 308);
            this.Type13.Name = "Type13";
            this.Type13.Size = new System.Drawing.Size(540, 197);
            this.Type13.TabIndex = 11;
            this.Type13.TabStop = false;
            // 
            // Type13TB6
            // 
            this.Type13TB6.Location = new System.Drawing.Point(47, 163);
            this.Type13TB6.Name = "Type13TB6";
            this.Type13TB6.Size = new System.Drawing.Size(487, 23);
            this.Type13TB6.TabIndex = 17;
            // 
            // Type13TB5
            // 
            this.Type13TB5.Location = new System.Drawing.Point(47, 134);
            this.Type13TB5.Name = "Type13TB5";
            this.Type13TB5.Size = new System.Drawing.Size(487, 23);
            this.Type13TB5.TabIndex = 16;
            // 
            // Type13TB4
            // 
            this.Type13TB4.Location = new System.Drawing.Point(47, 105);
            this.Type13TB4.Name = "Type13TB4";
            this.Type13TB4.Size = new System.Drawing.Size(487, 23);
            this.Type13TB4.TabIndex = 15;
            // 
            // Type13TB3
            // 
            this.Type13TB3.Location = new System.Drawing.Point(47, 76);
            this.Type13TB3.Name = "Type13TB3";
            this.Type13TB3.Size = new System.Drawing.Size(487, 23);
            this.Type13TB3.TabIndex = 14;
            // 
            // Type13TB2
            // 
            this.Type13TB2.Location = new System.Drawing.Point(47, 47);
            this.Type13TB2.Name = "Type13TB2";
            this.Type13TB2.Size = new System.Drawing.Size(487, 23);
            this.Type13TB2.TabIndex = 13;
            // 
            // Type13TB1
            // 
            this.Type13TB1.Location = new System.Drawing.Point(47, 18);
            this.Type13TB1.Name = "Type13TB1";
            this.Type13TB1.Size = new System.Drawing.Size(487, 23);
            this.Type13TB1.TabIndex = 12;
            // 
            // Type13C6
            // 
            this.Type13C6.AutoSize = true;
            this.Type13C6.Location = new System.Drawing.Point(26, 167);
            this.Type13C6.Name = "Type13C6";
            this.Type13C6.Size = new System.Drawing.Size(15, 14);
            this.Type13C6.TabIndex = 11;
            this.Type13C6.UseVisualStyleBackColor = true;
            // 
            // Type13C5
            // 
            this.Type13C5.AutoSize = true;
            this.Type13C5.Location = new System.Drawing.Point(26, 138);
            this.Type13C5.Name = "Type13C5";
            this.Type13C5.Size = new System.Drawing.Size(15, 14);
            this.Type13C5.TabIndex = 10;
            this.Type13C5.UseVisualStyleBackColor = true;
            // 
            // Type13C4
            // 
            this.Type13C4.AutoSize = true;
            this.Type13C4.Location = new System.Drawing.Point(26, 109);
            this.Type13C4.Name = "Type13C4";
            this.Type13C4.Size = new System.Drawing.Size(15, 14);
            this.Type13C4.TabIndex = 9;
            this.Type13C4.UseVisualStyleBackColor = true;
            // 
            // Type13C3
            // 
            this.Type13C3.AutoSize = true;
            this.Type13C3.Location = new System.Drawing.Point(26, 80);
            this.Type13C3.Name = "Type13C3";
            this.Type13C3.Size = new System.Drawing.Size(15, 14);
            this.Type13C3.TabIndex = 8;
            this.Type13C3.UseVisualStyleBackColor = true;
            // 
            // Type13C2
            // 
            this.Type13C2.AutoSize = true;
            this.Type13C2.Location = new System.Drawing.Point(26, 51);
            this.Type13C2.Name = "Type13C2";
            this.Type13C2.Size = new System.Drawing.Size(15, 14);
            this.Type13C2.TabIndex = 7;
            this.Type13C2.UseVisualStyleBackColor = true;
            // 
            // Type13C1
            // 
            this.Type13C1.AutoSize = true;
            this.Type13C1.Location = new System.Drawing.Point(26, 22);
            this.Type13C1.Name = "Type13C1";
            this.Type13C1.Size = new System.Drawing.Size(15, 14);
            this.Type13C1.TabIndex = 6;
            this.Type13C1.UseVisualStyleBackColor = true;
            // 
            // Type13R6
            // 
            this.Type13R6.AutoSize = true;
            this.Type13R6.Location = new System.Drawing.Point(6, 167);
            this.Type13R6.Name = "Type13R6";
            this.Type13R6.Size = new System.Drawing.Size(14, 13);
            this.Type13R6.TabIndex = 5;
            this.Type13R6.TabStop = true;
            this.Type13R6.UseVisualStyleBackColor = true;
            // 
            // Type13R5
            // 
            this.Type13R5.AutoSize = true;
            this.Type13R5.Location = new System.Drawing.Point(6, 138);
            this.Type13R5.Name = "Type13R5";
            this.Type13R5.Size = new System.Drawing.Size(14, 13);
            this.Type13R5.TabIndex = 4;
            this.Type13R5.TabStop = true;
            this.Type13R5.UseVisualStyleBackColor = true;
            // 
            // Type13R4
            // 
            this.Type13R4.AutoSize = true;
            this.Type13R4.Location = new System.Drawing.Point(6, 109);
            this.Type13R4.Name = "Type13R4";
            this.Type13R4.Size = new System.Drawing.Size(14, 13);
            this.Type13R4.TabIndex = 3;
            this.Type13R4.TabStop = true;
            this.Type13R4.UseVisualStyleBackColor = true;
            // 
            // Type13R3
            // 
            this.Type13R3.AutoSize = true;
            this.Type13R3.Location = new System.Drawing.Point(6, 80);
            this.Type13R3.Name = "Type13R3";
            this.Type13R3.Size = new System.Drawing.Size(14, 13);
            this.Type13R3.TabIndex = 2;
            this.Type13R3.TabStop = true;
            this.Type13R3.UseVisualStyleBackColor = true;
            // 
            // Type13R2
            // 
            this.Type13R2.AutoSize = true;
            this.Type13R2.Location = new System.Drawing.Point(6, 51);
            this.Type13R2.Name = "Type13R2";
            this.Type13R2.Size = new System.Drawing.Size(14, 13);
            this.Type13R2.TabIndex = 1;
            this.Type13R2.TabStop = true;
            this.Type13R2.UseVisualStyleBackColor = true;
            // 
            // Type13R1
            // 
            this.Type13R1.AutoSize = true;
            this.Type13R1.Location = new System.Drawing.Point(6, 22);
            this.Type13R1.Name = "Type13R1";
            this.Type13R1.Size = new System.Drawing.Size(14, 13);
            this.Type13R1.TabIndex = 0;
            this.Type13R1.TabStop = true;
            this.Type13R1.UseVisualStyleBackColor = true;
            // 
            // Type2TB
            // 
            this.Type2TB.Location = new System.Drawing.Point(52, 330);
            this.Type2TB.Name = "Type2TB";
            this.Type2TB.Size = new System.Drawing.Size(487, 23);
            this.Type2TB.TabIndex = 18;
            // 
            // NumOfVarLabel
            // 
            this.NumOfVarLabel.AutoSize = true;
            this.NumOfVarLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumOfVarLabel.Location = new System.Drawing.Point(451, 284);
            this.NumOfVarLabel.Name = "NumOfVarLabel";
            this.NumOfVarLabel.Size = new System.Drawing.Size(175, 21);
            this.NumOfVarLabel.TabIndex = 19;
            this.NumOfVarLabel.Text = "Количество вариантов:";
            // 
            // NumOfVarCombo
            // 
            this.NumOfVarCombo.AutoCompleteCustomSource.AddRange(new string[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.NumOfVarCombo.FormattingEnabled = true;
            this.NumOfVarCombo.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.NumOfVarCombo.Location = new System.Drawing.Point(632, 286);
            this.NumOfVarCombo.Name = "NumOfVarCombo";
            this.NumOfVarCombo.Size = new System.Drawing.Size(35, 23);
            this.NumOfVarCombo.TabIndex = 20;
            this.NumOfVarCombo.SelectedIndexChanged += new System.EventHandler(this.NumOfVarCombo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(561, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 25);
            this.button1.TabIndex = 21;
            this.button1.Text = "Удалить вопрос";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveAllButton
            // 
            this.SaveAllButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SaveAllButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveAllButton.Location = new System.Drawing.Point(483, 12);
            this.SaveAllButton.Name = "SaveAllButton";
            this.SaveAllButton.Size = new System.Drawing.Size(157, 25);
            this.SaveAllButton.TabIndex = 22;
            this.SaveAllButton.Text = "Сохранить изменения";
            this.SaveAllButton.UseVisualStyleBackColor = false;
            this.SaveAllButton.Click += new System.EventHandler(this.SaveAllButton_Click);
            // 
            // DeleteQuestionButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 522);
            this.Controls.Add(this.SaveAllButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumOfVarCombo);
            this.Controls.Add(this.NumOfVarLabel);
            this.Controls.Add(this.Type2TB);
            this.Controls.Add(this.Type13);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.CorrectAnswerLabel);
            this.Controls.Add(this.QTextLabel);
            this.Controls.Add(this.QTextTB);
            this.Controls.Add(this.AddQuestionButton);
            this.Controls.Add(this.AnswerTypeLabel);
            this.Controls.Add(this.QuestionTypeCB);
            this.Controls.Add(this.SelectQuestionLabel);
            this.Controls.Add(this.QuestionNumberComboBox);
            this.Controls.Add(this.TestNameTB);
            this.Controls.Add(this.TestNameLabel);
            this.MaximumSize = new System.Drawing.Size(750, 560);
            this.MinimumSize = new System.Drawing.Size(750, 560);
            this.Name = "DeleteQuestionButton";
            this.Text = "TestRedacting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RedactingClosed);
            this.Type13.ResumeLayout(false);
            this.Type13.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TestNameLabel;
        private System.Windows.Forms.TextBox TestNameTB;
        private System.Windows.Forms.ComboBox QuestionNumberComboBox;
        private System.Windows.Forms.Label SelectQuestionLabel;
        private System.Windows.Forms.ComboBox QuestionTypeCB;
        private System.Windows.Forms.Label AnswerTypeLabel;
        private System.Windows.Forms.Button AddQuestionButton;
        private System.Windows.Forms.RichTextBox QTextTB;
        private System.Windows.Forms.Label QTextLabel;
        private System.Windows.Forms.Label CorrectAnswerLabel;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.GroupBox Type13;
        private System.Windows.Forms.CheckBox Type13C1;
        private System.Windows.Forms.RadioButton Type13R6;
        private System.Windows.Forms.RadioButton Type13R5;
        private System.Windows.Forms.RadioButton Type13R4;
        private System.Windows.Forms.RadioButton Type13R3;
        private System.Windows.Forms.RadioButton Type13R2;
        private System.Windows.Forms.RadioButton Type13R1;
        private System.Windows.Forms.TextBox Type13TB6;
        private System.Windows.Forms.TextBox Type13TB5;
        private System.Windows.Forms.TextBox Type13TB4;
        private System.Windows.Forms.TextBox Type13TB3;
        private System.Windows.Forms.TextBox Type13TB2;
        private System.Windows.Forms.TextBox Type13TB1;
        private System.Windows.Forms.CheckBox Type13C6;
        private System.Windows.Forms.CheckBox Type13C5;
        private System.Windows.Forms.CheckBox Type13C4;
        private System.Windows.Forms.CheckBox Type13C3;
        private System.Windows.Forms.CheckBox Type13C2;
        private System.Windows.Forms.TextBox Type2TB;
        private System.Windows.Forms.Label NumOfVarLabel;
        private System.Windows.Forms.ComboBox NumOfVarCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SaveAllButton;
    }
}