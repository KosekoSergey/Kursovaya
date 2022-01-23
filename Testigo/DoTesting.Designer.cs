
namespace Testigo
{
    partial class DoTesting
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
            this.QuestionText = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.QuestionNumber = new System.Windows.Forms.Label();
            this.StopTestButton = new System.Windows.Forms.Button();
            this.VariantType1 = new System.Windows.Forms.GroupBox();
            this.VariantType1Label = new System.Windows.Forms.Label();
            this.VariantType1Radio6 = new System.Windows.Forms.RadioButton();
            this.VariantType1Radio5 = new System.Windows.Forms.RadioButton();
            this.VariantType1Radio4 = new System.Windows.Forms.RadioButton();
            this.VariantType1Radio3 = new System.Windows.Forms.RadioButton();
            this.VariantType1Radio2 = new System.Windows.Forms.RadioButton();
            this.VariantType1Radio1 = new System.Windows.Forms.RadioButton();
            this.VariantType2 = new System.Windows.Forms.GroupBox();
            this.VariantType2TB = new System.Windows.Forms.TextBox();
            this.VariantType2Label = new System.Windows.Forms.Label();
            this.VariantType3 = new System.Windows.Forms.GroupBox();
            this.VariantType3Check6 = new System.Windows.Forms.CheckBox();
            this.VariantType3Check5 = new System.Windows.Forms.CheckBox();
            this.VariantType3Check4 = new System.Windows.Forms.CheckBox();
            this.VariantType3Check3 = new System.Windows.Forms.CheckBox();
            this.VariantType3Check2 = new System.Windows.Forms.CheckBox();
            this.VariantType3Check1 = new System.Windows.Forms.CheckBox();
            this.VariantType3Label = new System.Windows.Forms.Label();
            this.VariantType1.SuspendLayout();
            this.VariantType2.SuspendLayout();
            this.VariantType3.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionText
            // 
            this.QuestionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionText.AutoSize = true;
            this.QuestionText.BackColor = System.Drawing.SystemColors.Control;
            this.QuestionText.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.QuestionText.Location = new System.Drawing.Point(12, 54);
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Size = new System.Drawing.Size(84, 32);
            this.QuestionText.TabIndex = 0;
            this.QuestionText.Text = "label1";
            this.QuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.Location = new System.Drawing.Point(431, 369);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(161, 31);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Следующий вопрос\r\n";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PreviousButton.Location = new System.Drawing.Point(12, 369);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(161, 31);
            this.PreviousButton.TabIndex = 2;
            this.PreviousButton.Text = "Предыдущий вопрос";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Visible = false;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // QuestionNumber
            // 
            this.QuestionNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QuestionNumber.AutoSize = true;
            this.QuestionNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuestionNumber.Location = new System.Drawing.Point(294, 9);
            this.QuestionNumber.Name = "QuestionNumber";
            this.QuestionNumber.Size = new System.Drawing.Size(52, 21);
            this.QuestionNumber.TabIndex = 3;
            this.QuestionNumber.Text = "label1";
            this.QuestionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StopTestButton
            // 
            this.StopTestButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.StopTestButton.Location = new System.Drawing.Point(219, 369);
            this.StopTestButton.Name = "StopTestButton";
            this.StopTestButton.Size = new System.Drawing.Size(184, 31);
            this.StopTestButton.TabIndex = 4;
            this.StopTestButton.Text = "Завершить тестирование";
            this.StopTestButton.UseVisualStyleBackColor = true;
            this.StopTestButton.Click += new System.EventHandler(this.StopTestButton_Click);
            // 
            // VariantType1
            // 
            this.VariantType1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VariantType1.Controls.Add(this.VariantType1Label);
            this.VariantType1.Controls.Add(this.VariantType1Radio6);
            this.VariantType1.Controls.Add(this.VariantType1Radio5);
            this.VariantType1.Controls.Add(this.VariantType1Radio4);
            this.VariantType1.Controls.Add(this.VariantType1Radio3);
            this.VariantType1.Controls.Add(this.VariantType1Radio2);
            this.VariantType1.Controls.Add(this.VariantType1Radio1);
            this.VariantType1.Location = new System.Drawing.Point(12, 157);
            this.VariantType1.Name = "VariantType1";
            this.VariantType1.Size = new System.Drawing.Size(580, 206);
            this.VariantType1.TabIndex = 5;
            this.VariantType1.TabStop = false;
            // 
            // VariantType1Label
            // 
            this.VariantType1Label.AutoSize = true;
            this.VariantType1Label.Location = new System.Drawing.Point(6, 19);
            this.VariantType1Label.Name = "VariantType1Label";
            this.VariantType1Label.Size = new System.Drawing.Size(183, 15);
            this.VariantType1Label.TabIndex = 6;
            this.VariantType1Label.Text = "Выберите правильный вариант:";
            // 
            // VariantType1Radio6
            // 
            this.VariantType1Radio6.AutoSize = true;
            this.VariantType1Radio6.Location = new System.Drawing.Point(6, 166);
            this.VariantType1Radio6.Name = "VariantType1Radio6";
            this.VariantType1Radio6.Size = new System.Drawing.Size(94, 19);
            this.VariantType1Radio6.TabIndex = 5;
            this.VariantType1Radio6.TabStop = true;
            this.VariantType1Radio6.Text = "radioButton6";
            this.VariantType1Radio6.UseVisualStyleBackColor = true;
            // 
            // VariantType1Radio5
            // 
            this.VariantType1Radio5.AutoSize = true;
            this.VariantType1Radio5.Location = new System.Drawing.Point(6, 141);
            this.VariantType1Radio5.Name = "VariantType1Radio5";
            this.VariantType1Radio5.Size = new System.Drawing.Size(94, 19);
            this.VariantType1Radio5.TabIndex = 4;
            this.VariantType1Radio5.TabStop = true;
            this.VariantType1Radio5.Text = "radioButton5";
            this.VariantType1Radio5.UseVisualStyleBackColor = true;
            // 
            // VariantType1Radio4
            // 
            this.VariantType1Radio4.AutoSize = true;
            this.VariantType1Radio4.Location = new System.Drawing.Point(6, 116);
            this.VariantType1Radio4.Name = "VariantType1Radio4";
            this.VariantType1Radio4.Size = new System.Drawing.Size(94, 19);
            this.VariantType1Radio4.TabIndex = 3;
            this.VariantType1Radio4.TabStop = true;
            this.VariantType1Radio4.Text = "radioButton4";
            this.VariantType1Radio4.UseVisualStyleBackColor = true;
            // 
            // VariantType1Radio3
            // 
            this.VariantType1Radio3.AutoSize = true;
            this.VariantType1Radio3.Location = new System.Drawing.Point(6, 91);
            this.VariantType1Radio3.Name = "VariantType1Radio3";
            this.VariantType1Radio3.Size = new System.Drawing.Size(94, 19);
            this.VariantType1Radio3.TabIndex = 2;
            this.VariantType1Radio3.TabStop = true;
            this.VariantType1Radio3.Text = "radioButton3";
            this.VariantType1Radio3.UseVisualStyleBackColor = true;
            // 
            // VariantType1Radio2
            // 
            this.VariantType1Radio2.AutoSize = true;
            this.VariantType1Radio2.Location = new System.Drawing.Point(6, 66);
            this.VariantType1Radio2.Name = "VariantType1Radio2";
            this.VariantType1Radio2.Size = new System.Drawing.Size(94, 19);
            this.VariantType1Radio2.TabIndex = 1;
            this.VariantType1Radio2.TabStop = true;
            this.VariantType1Radio2.Text = "radioButton2";
            this.VariantType1Radio2.UseVisualStyleBackColor = true;
            // 
            // VariantType1Radio1
            // 
            this.VariantType1Radio1.AutoSize = true;
            this.VariantType1Radio1.Location = new System.Drawing.Point(6, 41);
            this.VariantType1Radio1.Name = "VariantType1Radio1";
            this.VariantType1Radio1.Size = new System.Drawing.Size(94, 19);
            this.VariantType1Radio1.TabIndex = 0;
            this.VariantType1Radio1.TabStop = true;
            this.VariantType1Radio1.Text = "radioButton1";
            this.VariantType1Radio1.UseVisualStyleBackColor = true;
            // 
            // VariantType2
            // 
            this.VariantType2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VariantType2.Controls.Add(this.VariantType2TB);
            this.VariantType2.Controls.Add(this.VariantType2Label);
            this.VariantType2.Location = new System.Drawing.Point(12, 157);
            this.VariantType2.Name = "VariantType2";
            this.VariantType2.Size = new System.Drawing.Size(580, 206);
            this.VariantType2.TabIndex = 6;
            this.VariantType2.TabStop = false;
            // 
            // VariantType2TB
            // 
            this.VariantType2TB.Location = new System.Drawing.Point(6, 37);
            this.VariantType2TB.Name = "VariantType2TB";
            this.VariantType2TB.Size = new System.Drawing.Size(166, 23);
            this.VariantType2TB.TabIndex = 2;
            // 
            // VariantType2Label
            // 
            this.VariantType2Label.AutoSize = true;
            this.VariantType2Label.Location = new System.Drawing.Point(6, 19);
            this.VariantType2Label.Name = "VariantType2Label";
            this.VariantType2Label.Size = new System.Drawing.Size(85, 15);
            this.VariantType2Label.TabIndex = 1;
            this.VariantType2Label.Text = "Введите ответ:";
            // 
            // VariantType3
            // 
            this.VariantType3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VariantType3.Controls.Add(this.VariantType3Check6);
            this.VariantType3.Controls.Add(this.VariantType3Check5);
            this.VariantType3.Controls.Add(this.VariantType3Check4);
            this.VariantType3.Controls.Add(this.VariantType3Check3);
            this.VariantType3.Controls.Add(this.VariantType3Check2);
            this.VariantType3.Controls.Add(this.VariantType3Check1);
            this.VariantType3.Controls.Add(this.VariantType3Label);
            this.VariantType3.Location = new System.Drawing.Point(12, 157);
            this.VariantType3.Name = "VariantType3";
            this.VariantType3.Size = new System.Drawing.Size(580, 206);
            this.VariantType3.TabIndex = 8;
            this.VariantType3.TabStop = false;
            // 
            // VariantType3Check6
            // 
            this.VariantType3Check6.AutoSize = true;
            this.VariantType3Check6.Location = new System.Drawing.Point(6, 162);
            this.VariantType3Check6.Name = "VariantType3Check6";
            this.VariantType3Check6.Size = new System.Drawing.Size(82, 19);
            this.VariantType3Check6.TabIndex = 9;
            this.VariantType3Check6.Text = "checkBox6";
            this.VariantType3Check6.UseVisualStyleBackColor = true;
            // 
            // VariantType3Check5
            // 
            this.VariantType3Check5.AutoSize = true;
            this.VariantType3Check5.Location = new System.Drawing.Point(6, 137);
            this.VariantType3Check5.Name = "VariantType3Check5";
            this.VariantType3Check5.Size = new System.Drawing.Size(82, 19);
            this.VariantType3Check5.TabIndex = 8;
            this.VariantType3Check5.Text = "checkBox5";
            this.VariantType3Check5.UseVisualStyleBackColor = true;
            // 
            // VariantType3Check4
            // 
            this.VariantType3Check4.AutoSize = true;
            this.VariantType3Check4.Location = new System.Drawing.Point(6, 112);
            this.VariantType3Check4.Name = "VariantType3Check4";
            this.VariantType3Check4.Size = new System.Drawing.Size(82, 19);
            this.VariantType3Check4.TabIndex = 7;
            this.VariantType3Check4.Text = "checkBox4";
            this.VariantType3Check4.UseVisualStyleBackColor = true;
            // 
            // VariantType3Check3
            // 
            this.VariantType3Check3.AutoSize = true;
            this.VariantType3Check3.Location = new System.Drawing.Point(6, 87);
            this.VariantType3Check3.Name = "VariantType3Check3";
            this.VariantType3Check3.Size = new System.Drawing.Size(82, 19);
            this.VariantType3Check3.TabIndex = 6;
            this.VariantType3Check3.Text = "checkBox3";
            this.VariantType3Check3.UseVisualStyleBackColor = true;
            // 
            // VariantType3Check2
            // 
            this.VariantType3Check2.AutoSize = true;
            this.VariantType3Check2.Location = new System.Drawing.Point(6, 62);
            this.VariantType3Check2.Name = "VariantType3Check2";
            this.VariantType3Check2.Size = new System.Drawing.Size(82, 19);
            this.VariantType3Check2.TabIndex = 5;
            this.VariantType3Check2.Text = "checkBox2";
            this.VariantType3Check2.UseVisualStyleBackColor = true;
            // 
            // VariantType3Check1
            // 
            this.VariantType3Check1.AutoSize = true;
            this.VariantType3Check1.Location = new System.Drawing.Point(6, 37);
            this.VariantType3Check1.Name = "VariantType3Check1";
            this.VariantType3Check1.Size = new System.Drawing.Size(82, 19);
            this.VariantType3Check1.TabIndex = 4;
            this.VariantType3Check1.Text = "checkBox1";
            this.VariantType3Check1.UseVisualStyleBackColor = true;
            // 
            // VariantType3Label
            // 
            this.VariantType3Label.AutoSize = true;
            this.VariantType3Label.Location = new System.Drawing.Point(6, 19);
            this.VariantType3Label.Name = "VariantType3Label";
            this.VariantType3Label.Size = new System.Drawing.Size(191, 15);
            this.VariantType3Label.TabIndex = 3;
            this.VariantType3Label.Text = "Выберите правильные варианты:";
            // 
            // DoTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 412);
            this.Controls.Add(this.VariantType3);
            this.Controls.Add(this.VariantType2);
            this.Controls.Add(this.VariantType1);
            this.Controls.Add(this.StopTestButton);
            this.Controls.Add(this.QuestionNumber);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.QuestionText);
            this.MinimumSize = new System.Drawing.Size(620, 450);
            this.Name = "DoTesting";
            this.Text = "Testigo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoTestingFormClosing);
            this.VariantType1.ResumeLayout(false);
            this.VariantType1.PerformLayout();
            this.VariantType2.ResumeLayout(false);
            this.VariantType2.PerformLayout();
            this.VariantType3.ResumeLayout(false);
            this.VariantType3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionText;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Label QuestionNumber;
        private System.Windows.Forms.Button StopTestButton;
        private System.Windows.Forms.GroupBox VariantType1;
        private System.Windows.Forms.RadioButton VariantType1Radio6;
        private System.Windows.Forms.RadioButton VariantType1Radio5;
        private System.Windows.Forms.RadioButton VariantType1Radio4;
        private System.Windows.Forms.RadioButton VariantType1Radio3;
        private System.Windows.Forms.RadioButton VariantType1Radio2;
        private System.Windows.Forms.RadioButton VariantType1Radio1;
        private System.Windows.Forms.Label VariantType1Label;
        private System.Windows.Forms.GroupBox VariantType2;
        private System.Windows.Forms.Label VariantType2Label;
        private System.Windows.Forms.GroupBox VariantType3;
        private System.Windows.Forms.TextBox VariantType2TB;
        private System.Windows.Forms.Label VariantType3Label;
        private System.Windows.Forms.CheckBox VariantType3Check6;
        private System.Windows.Forms.CheckBox VariantType3Check5;
        private System.Windows.Forms.CheckBox VariantType3Check4;
        private System.Windows.Forms.CheckBox VariantType3Check3;
        private System.Windows.Forms.CheckBox VariantType3Check2;
        private System.Windows.Forms.CheckBox VariantType3Check1;
    }
}