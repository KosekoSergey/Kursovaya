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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void StartTestingButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();  //открытие файла
            openFileDialog1.Title = "Выберите тест";
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
    }
}
