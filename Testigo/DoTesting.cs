using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Testigo
{
    public partial class DoTesting : Form
    {
        StartForm startForm;
        private int questionNumber;  //номер вопроса
        private int testdone = 0;
        public DoTesting(StartForm startForm)
        {
            InitializeComponent();
            questionNumber = 0;
            this.startForm = startForm;
            Text = startForm.Test.TestName;
            QuestionNumber.Text = "Вопрос " + Convert.ToString(questionNumber + 1) + " из " + Convert.ToString(startForm.Test.GetNumOfQuestions());
            string str = "";
            for (int i = 0; i < startForm.Test.GetQuestion(questionNumber).GetQuestionText().Length; i++)
            {
                str += startForm.Test.GetQuestion(questionNumber).GetQuestionText()[i];
            }
            QuestionText.Text = str;
            SetQuestionWiev(startForm.Test.GetQuestion(questionNumber));
        }

        private void DoTestingFormClosing(object sender, FormClosingEventArgs e)  //закрытие формы
        {
            if (testdone == 0)
            {
                DialogResult result = MessageBox.Show("Текущий прогресс будет потерян.", "Хотите прервать тестирование?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    startForm.Show();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            
        }

        private void PreviousButton_Click(object sender, EventArgs e)  //предыдущий вопрос
        {
            switch (startForm.Test.GetQuestion(questionNumber).Type)  //запись выбранного ответа
            {
                case 1:
                    if (VariantType1Radio1.Checked == true) startForm.Test.GetQuestion(questionNumber).SetSelectedVariant(1);
                    if (VariantType1Radio2.Checked == true) startForm.Test.GetQuestion(questionNumber).SetSelectedVariant(2);
                    if (VariantType1Radio3.Checked == true) startForm.Test.GetQuestion(questionNumber).SetSelectedVariant(3);
                    if (VariantType1Radio4.Checked == true) startForm.Test.GetQuestion(questionNumber).SetSelectedVariant(4);
                    if (VariantType1Radio5.Checked == true) startForm.Test.GetQuestion(questionNumber).SetSelectedVariant(5);
                    if (VariantType1Radio6.Checked == true) startForm.Test.GetQuestion(questionNumber).SetSelectedVariant(6);
                    break;
                case 2:
                    startForm.Test.GetQuestion(questionNumber).SetSelectedVariantStr(VariantType2TB.Text.Split(' ')[0] + Convert.ToChar(13));
                    break;
                case 3:
                    int ans = 1000000;
                    if (VariantType3Check1.Checked == true) ans += 100000;
                    if (VariantType3Check2.Checked == true) ans += 20000;
                    if (VariantType3Check3.Checked == true) ans += 3000;
                    if (VariantType3Check4.Checked == true) ans += 400;
                    if (VariantType3Check5.Checked == true) ans += 50;
                    if (VariantType3Check6.Checked == true) ans += 6;
                    startForm.Test.GetQuestion(questionNumber).SetSelectedVariant(ans);                    
                    break;
                default:
                    break;
            }
            if (NextButton.Visible == false) NextButton.Visible = true;
            questionNumber--;
            if (questionNumber == 0)
            {
                PreviousButton.Visible = false;
            }
            QuestionNumber.Text = "Вопрос " + Convert.ToString(questionNumber + 1) + " из " + Convert.ToString(startForm.Test.GetNumOfQuestions());
            string str = "";
            for (int i = 0; i < startForm.Test.GetQuestion(questionNumber).GetQuestionText().Length; i++)
            {
                str += startForm.Test.GetQuestion(questionNumber).GetQuestionText()[i];
            }
            QuestionText.Text = str;
            SetQuestionWiev(startForm.Test.GetQuestion(questionNumber));
        }

        private void StopTestButton_Click(object sender, EventArgs e)  //завершить тест
        {
            switch (startForm.Test.GetQuestion(questionNumber).Type)  //запись выбранного ответа
            {
                case 1:
                    if (VariantType1Radio1.Checked == true) startForm.Test.GetQuestion(questionNumber).SetSelectedVariant(1);
                    if (VariantType1Radio2.Checked == true) startForm.Test.GetQuestion(questionNumber).SetSelectedVariant(2);
                    if (VariantType1Radio3.Checked == true) startForm.Test.GetQuestion(questionNumber).SetSelectedVariant(3);
                    if (VariantType1Radio4.Checked == true) startForm.Test.GetQuestion(questionNumber).SetSelectedVariant(4);
                    if (VariantType1Radio5.Checked == true) startForm.Test.GetQuestion(questionNumber).SetSelectedVariant(5);
                    if (VariantType1Radio6.Checked == true) startForm.Test.GetQuestion(questionNumber).SetSelectedVariant(6);
                    break;
                case 2:
                    startForm.Test.GetQuestion(questionNumber).SetSelectedVariantStr(VariantType2TB.Text.Split(' ')[0] + Convert.ToChar(13));
                    break;
                case 3:
                    int ans = 1000000;
                    if (VariantType3Check1.Checked == true) ans += 100000;
                    if (VariantType3Check2.Checked == true) ans += 20000;
                    if (VariantType3Check3.Checked == true) ans += 3000;
                    if (VariantType3Check4.Checked == true) ans += 400;
                    if (VariantType3Check5.Checked == true) ans += 50;
                    if (VariantType3Check6.Checked == true) ans += 6;
                    startForm.Test.GetQuestion(questionNumber).SetSelectedVariant(ans);
                    break;
                default:
                    break;
            }
            DialogResult result = MessageBox.Show("Вы действительно хотите завершить тестирование?", "Завершить тестирование?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                testdone = 1;
                //MessageBox.Show(Convert.ToString(string.Compare(startForm.Test.GetQuestion(1).GetSelectedVariantStr(), startForm.Test.GetQuestion(1).GetCorrectAnswerStr())));
                //MessageBox.Show(Convert.ToString(Convert.ToInt32(startForm.Test.GetQuestion(1).GetSelectedVariantStr()[4])) + Convert.ToString(Convert.ToInt32(startForm.Test.GetQuestion(1).GetCorrectAnswerStr()[4])));
                MessageBox.Show("Вы ответили правильно на " + Convert.ToString(startForm.Test.Count()) + " вопроса(ов) из " + Convert.ToString(startForm.Test.GetNumOfQuestions()), "Тест завершен");
                Close();
                startForm.Show();        ////////////////////////////////////
            }
        }

        private void NextButton_Click(object sender, EventArgs e)  //следующий вопрос
        {
            switch (startForm.Test.GetQuestion(questionNumber).Type)  //запись выбранного ответа
            {
                case 1:
                    if (VariantType1Radio1.Checked == true) startForm.Test.GetQuestion(questionNumber).SetSelectedVariant(1);
                    if (VariantType1Radio2.Checked == true) startForm.Test.GetQuestion(questionNumber).SetSelectedVariant(2);
                    if (VariantType1Radio3.Checked == true) startForm.Test.GetQuestion(questionNumber).SetSelectedVariant(3);
                    if (VariantType1Radio4.Checked == true) startForm.Test.GetQuestion(questionNumber).SetSelectedVariant(4);
                    if (VariantType1Radio5.Checked == true) startForm.Test.GetQuestion(questionNumber).SetSelectedVariant(5);
                    if (VariantType1Radio6.Checked == true) startForm.Test.GetQuestion(questionNumber).SetSelectedVariant(6);
                    break;
                case 2:
                    startForm.Test.GetQuestion(questionNumber).SetSelectedVariantStr(VariantType2TB.Text.Split(' ')[0] + Convert.ToChar(13));
                    break;
                case 3:
                    int ans = 1000000;
                    if (VariantType3Check1.Checked == true) ans += 100000;
                    if (VariantType3Check2.Checked == true) ans += 20000;
                    if (VariantType3Check3.Checked == true) ans += 3000;
                    if (VariantType3Check4.Checked == true) ans += 400;
                    if (VariantType3Check5.Checked == true) ans += 50;
                    if (VariantType3Check6.Checked == true) ans += 6;
                    startForm.Test.GetQuestion(questionNumber).SetSelectedVariantStr(Convert.ToString(ans));                    
                    break;
                default:
                    break;
            }
            if (PreviousButton.Visible == false) PreviousButton.Visible = true;
            questionNumber++;
            if (questionNumber == startForm.Test.GetNumOfQuestions() - 1)
            {
                NextButton.Visible = false;
            }
            QuestionNumber.Text = "Вопрос " + Convert.ToString(questionNumber + 1) + " из " + Convert.ToString(startForm.Test.GetNumOfQuestions());
            string str = "";
            for (int i = 0; i < startForm.Test.GetQuestion(questionNumber).GetQuestionText().Length; i++)
            {
                str += startForm.Test.GetQuestion(questionNumber).GetQuestionText()[i];
            }
            QuestionText.Text = str;
            SetQuestionWiev(startForm.Test.GetQuestion(questionNumber));
        }
        private void SetQuestionWiev(Question question)  //показать варианты ответов
        {
            switch (question.Type)
            {
                case 1:  //1 вариант из нескольки
                    VariantType1.Visible = true;
                    VariantType2.Visible = false;
                    VariantType3.Visible = false;
                    VariantType1Radio1.Visible = false;
                    VariantType1Radio2.Visible = false;
                    VariantType1Radio3.Visible = false;
                    VariantType1Radio4.Visible = false;
                    VariantType1Radio5.Visible = false;
                    VariantType1Radio6.Visible = false;
                    VariantType1Radio1.Checked = false;
                    VariantType1Radio2.Checked = false;
                    VariantType1Radio3.Checked = false;
                    VariantType1Radio4.Checked = false;
                    VariantType1Radio5.Checked = false;
                    VariantType1Radio6.Checked = false;
                    string[] variants = question.GetVariants();
                    for (int i = 1; i <= variants.Length; i++)
                    {
                        switch (i)
                        {
                            case 1:
                                VariantType1Radio1.Text = variants[i - 1];
                                VariantType1Radio1.Visible = true;
                                if (question.GetSelectedVariant() == i) VariantType1Radio1.Checked = true;
                                break;
                            case 2:
                                VariantType1Radio2.Text = variants[i - 1];
                                VariantType1Radio2.Visible = true;
                                if (question.GetSelectedVariant() == i) VariantType1Radio2.Checked = true;
                                break;
                            case 3:
                                VariantType1Radio3.Text = variants[i - 1];
                                VariantType1Radio3.Visible = true;
                                if (question.GetSelectedVariant() == i) VariantType1Radio3.Checked = true;
                                break;
                            case 4:
                                VariantType1Radio4.Text = variants[i - 1];
                                VariantType1Radio4.Visible = true;
                                if (question.GetSelectedVariant() == i) VariantType1Radio4.Checked = true;
                                break;
                            case 5:
                                VariantType1Radio5.Text = variants[i - 1];
                                VariantType1Radio5.Visible = true;
                                if (question.GetSelectedVariant() == i) VariantType1Radio5.Checked = true;
                                break;
                            case 6:
                                VariantType1Radio6.Text = variants[i - 1];
                                VariantType1Radio6.Visible = true;
                                if (question.GetSelectedVariant() == i) VariantType1Radio6.Checked = true;
                                break;
                        }
                    }
                    break;
                case 2:  //слово/число
                    VariantType1.Visible = false;
                    VariantType2.Visible = true;
                    VariantType3.Visible = false;
                    VariantType2TB.Text = question.GetSelectedVariantStr();

                    break;
                case 3:  //несколько вариантов
                    VariantType1.Visible = false;
                    VariantType2.Visible = false;
                    VariantType3.Visible = true;
                    VariantType3Check1.Visible = false;
                    VariantType3Check2.Visible = false;
                    VariantType3Check3.Visible = false;
                    VariantType3Check4.Visible = false;
                    VariantType3Check5.Visible = false;
                    VariantType3Check6.Visible = false;
                    VariantType3Check1.Checked = false;
                    VariantType3Check2.Checked = false;
                    VariantType3Check3.Checked = false;
                    VariantType3Check4.Checked = false;
                    VariantType3Check5.Checked = false;
                    VariantType3Check6.Checked = false;
                    variants = question.GetVariants();
                    string ans = Convert.ToString(question.GetSelectedVariant());                    
                    for (int i = 1; i <= variants.Length; i++)
                    {
                        switch (i)
                        {
                            case 1:
                                VariantType3Check1.Text = variants[i - 1];
                                VariantType3Check1.Visible = true;
                                if (ans[1] == '1') VariantType3Check1.Checked = true;
                                break;
                            case 2:
                                VariantType3Check2.Text = variants[i - 1];
                                VariantType3Check2.Visible = true;
                                if (ans[2] == '2') VariantType3Check2.Checked = true;
                                break;
                            case 3:
                                VariantType3Check3.Text = variants[i - 1];
                                VariantType3Check3.Visible = true;
                                if (ans[3] == '3') VariantType3Check3.Checked = true;
                                break;
                            case 4:
                                VariantType3Check4.Text = variants[i - 1];
                                VariantType3Check4.Visible = true;
                                if (ans[4] == '4') VariantType3Check4.Checked = true;
                                break;
                            case 5:
                                VariantType3Check5.Text = variants[i - 1];
                                VariantType3Check5.Visible = true;
                                if (ans[5] == '5') VariantType3Check5.Checked = true;
                                break;
                            case 6:
                                VariantType3Check6.Text = variants[i - 1];
                                VariantType3Check6.Visible = true;
                                if (ans[6] == '6') VariantType3Check6.Checked = true;
                                break;
                        }
                    }
                    break;
                default:
                    VariantType1.Visible = false;
                    VariantType2.Visible = false;
                    VariantType3.Visible = false;
                    break;
            }
        }
    }
}
