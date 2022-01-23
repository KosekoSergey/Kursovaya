
namespace Testigo
{
    partial class StartForm
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
            this.StartTestingButton = new System.Windows.Forms.Button();
            this.ResultLookButton = new System.Windows.Forms.Button();
            this.CreateTestButton = new System.Windows.Forms.Button();
            this.RedactTestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartTestingButton
            // 
            this.StartTestingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartTestingButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartTestingButton.Location = new System.Drawing.Point(100, 69);
            this.StartTestingButton.Name = "StartTestingButton";
            this.StartTestingButton.Size = new System.Drawing.Size(235, 41);
            this.StartTestingButton.TabIndex = 0;
            this.StartTestingButton.Text = "Начать тестирование";
            this.StartTestingButton.UseVisualStyleBackColor = true;
            this.StartTestingButton.Click += new System.EventHandler(this.StartTestingButton_Click);
            // 
            // ResultLookButton
            // 
            this.ResultLookButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResultLookButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultLookButton.Location = new System.Drawing.Point(121, 116);
            this.ResultLookButton.Name = "ResultLookButton";
            this.ResultLookButton.Size = new System.Drawing.Size(193, 33);
            this.ResultLookButton.TabIndex = 1;
            this.ResultLookButton.Text = "Посмотреть результаты";
            this.ResultLookButton.UseVisualStyleBackColor = true;
            this.ResultLookButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateTestButton
            // 
            this.CreateTestButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreateTestButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateTestButton.Location = new System.Drawing.Point(121, 194);
            this.CreateTestButton.Name = "CreateTestButton";
            this.CreateTestButton.Size = new System.Drawing.Size(193, 33);
            this.CreateTestButton.TabIndex = 2;
            this.CreateTestButton.Text = "Создать тест";
            this.CreateTestButton.UseVisualStyleBackColor = true;
            // 
            // RedactTestButton
            // 
            this.RedactTestButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RedactTestButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RedactTestButton.Location = new System.Drawing.Point(121, 155);
            this.RedactTestButton.Name = "RedactTestButton";
            this.RedactTestButton.Size = new System.Drawing.Size(193, 33);
            this.RedactTestButton.TabIndex = 3;
            this.RedactTestButton.Text = "Редактировать тест";
            this.RedactTestButton.UseVisualStyleBackColor = true;
            this.RedactTestButton.Click += new System.EventHandler(this.RedactTestButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 292);
            this.Controls.Add(this.RedactTestButton);
            this.Controls.Add(this.CreateTestButton);
            this.Controls.Add(this.ResultLookButton);
            this.Controls.Add(this.StartTestingButton);
            this.MaximumSize = new System.Drawing.Size(460, 330);
            this.MinimumSize = new System.Drawing.Size(460, 330);
            this.Name = "StartForm";
            this.Text = "Testigo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartTestingButton;
        private System.Windows.Forms.Button ResultLookButton;
        private System.Windows.Forms.Button CreateTestButton;
        private System.Windows.Forms.Button RedactTestButton;
    }
}

