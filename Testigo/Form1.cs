using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testigo
{
    public partial class StartForm : Form
    {
        private Test test;
        public Test Test
        {
            get
            {
                return test;
            }
        }
        public StartForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)  //Посмор=треть результаты
        {
            if (test != null)
            {
                MessageBox.Show("Результат вашей прошлой попытки - " + Convert.ToString(test.Count()) + " из " + Convert.ToString(test.GetNumOfQuestions()), "Результаты предыдущего теста");
            }
        }

        private void StartTestingButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();  //открытие файла
            openFileDialog1.Title = "Выберите тест";
            openFileDialog1.Filter = "Text files(*.test)|*.test";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            if (openFileDialog1.CheckFileExists)
            {
                test = new Test(/*@"C:\Users\zalman\source\repos\Kursovaya\Testigo\test.txt"*/openFileDialog1.FileName);  //копирование теста в память
                DoTesting doTesting = new DoTesting(this);
                doTesting.Show();

                Hide();
                
            } 
            

        }

        private void RedactTestButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();  //открытие файла
            openFileDialog1.Title = "Выберите тест";
            openFileDialog1.Filter = "Text files(*.test)|*.test";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            if (openFileDialog1.CheckFileExists)
            {
                test = new Test(openFileDialog1.FileName);  //копирование теста в память
                DeleteQuestionButton doTesting = new DeleteQuestionButton(this);
                doTesting.Show();
                Hide();

            }
        }

        private void CreateTestButton_Click(object sender, EventArgs e) //создание теста
        {
            test = new Test();  //копирование теста в память
            DeleteQuestionButton doTesting = new DeleteQuestionButton(this);
            doTesting.Show();
            Hide();
        }
    }
}
