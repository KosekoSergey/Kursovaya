using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Testigo
{
    public partial class DeleteQuestionButton : Form
    {
        StartForm startForm;
        private int questionNumber;  //номер вопроса
        private int testsaved = 0;
        private bool fqtype = false;  //так надо
        private bool fqsq = false;
        private bool fqsq2 = false;
        public DeleteQuestionButton(StartForm startForm)
        {
            InitializeComponent();
            questionNumber = 0;
            this.startForm = startForm;
            Text = "Редактирование теста";
            TestNameTB.Text = startForm.Test.TestName;
            for (int i = 0; i < startForm.Test.GetNumOfQuestions(); i++)
            {
                QuestionNumberComboBox.Items.Add(i + 1);
            }
            questionNumber = 0;
            QuestionNumberComboBox.SelectedIndex = questionNumber;
            LoadQuestion(questionNumber);
        }

        private void RedactingClosed(object sender, FormClosingEventArgs e)
        {
            if (testsaved == 0)
            {
                DialogResult result = MessageBox.Show("Несохраненные изменения будут потеряны.", "Хотите завершить редактирование?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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
        
        private void LoadQuestion(int num)  //загрузка вопроса
        {
            Question question = startForm.Test.GetQuestion(num);
            QuestionTypeCB.SelectedItem = question.GetType();
            string str = "";
            for (int i = 0; i < question.GetQuestionText().Length; i++)
            {
                str += question.GetQuestionText()[i];
            }
            QTextTB.Text = str;
            //QTextTB.Lines = startForm.Test.GetQuestion(questionNumber).GetQuestionText();
            QuestionTypeCB.SelectedIndex = question.Type - 1;

            NumOfVarCombo.Visible = false;
            NumOfVarLabel.Visible = false;
            AnswerLabel.Visible = false;
            Type13.Visible = false;
            Type2TB.Visible = false;

            Type13C1.Enabled = false;
            Type13C2.Enabled = false;
            Type13C3.Enabled = false;
            Type13C4.Enabled = false;
            Type13C5.Enabled = false;
            Type13C6.Enabled = false;
            Type13C1.Checked = false;
            Type13C2.Checked = false;
            Type13C3.Checked = false;
            Type13C4.Checked = false;
            Type13C5.Checked = false;
            Type13C6.Checked = false;

            Type13R1.Enabled = false;
            Type13R2.Enabled = false;
            Type13R3.Enabled = false;
            Type13R4.Enabled = false;
            Type13R5.Enabled = false;
            Type13R6.Enabled = false;
            Type13R1.Checked = false;
            Type13R2.Checked = false;
            Type13R3.Checked = false;
            Type13R4.Checked = false;
            Type13R5.Checked = false;
            Type13R6.Checked = false;

            Type13TB1.Enabled = false;
            Type13TB2.Enabled = false;
            Type13TB3.Enabled = false;
            Type13TB4.Enabled = false;
            Type13TB5.Enabled = false;
            Type13TB6.Enabled = false;
            Type13TB1.Text = "";
            Type13TB2.Text = "";
            Type13TB3.Text = "";
            Type13TB4.Text = "";
            Type13TB5.Text = "";
            Type13TB6.Text = "";


            switch (question.Type)
            {
                case 1:
                    NumOfVarCombo.Visible = true;
                    NumOfVarCombo.SelectedIndex = question.GetVariants().Length - 2;
                    NumOfVarLabel.Visible = true;
                    Type13.Visible = true;
                    AnswerLabel.Visible = true;
                    Type13R1.Enabled = true;
                    Type13R2.Enabled = true;
                    if (NumOfVarCombo.SelectedIndex > 0) Type13R3.Enabled = true;
                    if (NumOfVarCombo.SelectedIndex > 1) Type13R4.Enabled = true;
                    if (NumOfVarCombo.SelectedIndex > 2) Type13R5.Enabled = true;
                    if (NumOfVarCombo.SelectedIndex > 3) Type13R6.Enabled = true;

                    Type13TB1.Enabled = true;
                    Type13TB2.Enabled = true;
                    if (NumOfVarCombo.SelectedIndex > 0) Type13TB3.Enabled = true;
                    if (NumOfVarCombo.SelectedIndex > 1) Type13TB4.Enabled = true;
                    if (NumOfVarCombo.SelectedIndex > 2) Type13TB5.Enabled = true;
                    if (NumOfVarCombo.SelectedIndex > 3) Type13TB6.Enabled = true;

                    Type13TB1.Text = question.GetVariants()[0];
                    Type13TB2.Text = question.GetVariants()[1];
                    if (question.GetVariants().Length > 2) Type13TB3.Text = question.GetVariants()[2];
                    else Type13TB3.Text = "";
                    if (question.GetVariants().Length > 3) Type13TB4.Text = question.GetVariants()[3];
                    else Type13TB4.Text = "";
                    if (question.GetVariants().Length > 4) Type13TB5.Text = question.GetVariants()[4];
                    else Type13TB5.Text = "";
                    if (question.GetVariants().Length > 5) Type13TB6.Text = question.GetVariants()[5];
                    else Type13TB6.Text = "";
                    switch (question.GetCorrectAnswer())
                    {
                        case 1:
                            Type13R1.Checked = true;
                            break;
                        case 2:
                            Type13R2.Checked = true;
                            break;
                        case 3:
                            Type13R3.Checked = true;
                            break;
                        case 4:
                            Type13R4.Checked = true;
                            break;
                        case 5:
                            Type13R5.Checked = true;
                            break;
                        case 6:
                            Type13R6.Checked = true;
                            break;
                    }
                    break;
                case 2:
                    Type2TB.Visible = true;
                    Type2TB.Text = question.GetCorrectAnswerStr();
                    break;
                case 3:
                    NumOfVarCombo.Visible = true;
                    NumOfVarCombo.SelectedIndex = question.GetVariants().Length - 2;
                    NumOfVarLabel.Visible = true;
                    Type13.Visible = true;
                    AnswerLabel.Visible = true;
                    Type13C1.Enabled = true;
                    Type13C2.Enabled = true;
                    if (NumOfVarCombo.SelectedIndex > 0) Type13C3.Enabled = true;
                    if (NumOfVarCombo.SelectedIndex > 1) Type13C4.Enabled = true;
                    if (NumOfVarCombo.SelectedIndex > 2) Type13C5.Enabled = true;
                    if (NumOfVarCombo.SelectedIndex > 3) Type13C6.Enabled = true;

                    Type13TB1.Enabled = true;
                    Type13TB2.Enabled = true;
                    if (NumOfVarCombo.SelectedIndex > 0) Type13TB3.Enabled = true;
                    if (NumOfVarCombo.SelectedIndex > 1) Type13TB4.Enabled = true;
                    if (NumOfVarCombo.SelectedIndex > 2) Type13TB5.Enabled = true;
                    if (NumOfVarCombo.SelectedIndex > 3) Type13TB6.Enabled = true;

                    Type13TB1.Text = question.GetVariants()[0];
                    Type13TB2.Text = question.GetVariants()[1];
                    if (question.GetVariants().Length > 2) Type13TB3.Text = question.GetVariants()[2];
                    if (question.GetVariants().Length > 3) Type13TB4.Text = question.GetVariants()[3];
                    if (question.GetVariants().Length > 4) Type13TB5.Text = question.GetVariants()[4];
                    if (question.GetVariants().Length > 5) Type13TB6.Text = question.GetVariants()[5];
                    string ans = Convert.ToString(question.GetCorrectAnswer());
                    if (ans[1] == '1') Type13C1.Checked = true;
                    if (ans[2] == '2') Type13C2.Checked = true;
                    if (ans[3] == '3') Type13C3.Checked = true;
                    if (ans[4] == '4') Type13C4.Checked = true;
                    if (ans[5] == '5') Type13C5.Checked = true;
                    if (ans[6] == '6') Type13C6.Checked = true;
                    break;
            }
        }
        private void SaveQ()  //сохранить вопрос в программе
        {
            //Convert.Tostring(Convert.ToChar(13))
            Question temp = startForm.Test.GetQuestion(questionNumber);
            string[] str1 = new string[QTextTB.Lines.Length];
            for (int i = 0; i < QTextTB.Lines.Length; i++)
            {
                str1[i] = QTextTB.Lines[i];
            }
            temp.SetQuestion(str1);
            switch (QuestionTypeCB.SelectedIndex)
            {
                case 0:
                    string[] str = new string[NumOfVarCombo.SelectedIndex + 2];
                    str[0] = Type13TB1.Text;
                    str[1] = Type13TB2.Text;
                    if (str.Length > 2) str[2] = Type13TB3.Text;
                    if (str.Length > 3) str[3] = Type13TB4.Text;
                    if (str.Length > 4) str[4] = Type13TB5.Text;
                    if (str.Length > 5) str[5] = Type13TB6.Text;
                    if (Type13R1.Checked) temp.SetCorrectAnswer(1);
                    if (Type13R2.Checked) temp.SetCorrectAnswer(2);
                    if (Type13R3.Checked) temp.SetCorrectAnswer(3);
                    if (Type13R4.Checked) temp.SetCorrectAnswer(4);
                    if (Type13R5.Checked) temp.SetCorrectAnswer(5);
                    if (Type13R6.Checked) temp.SetCorrectAnswer(6);
                    temp.SetVariants(str);
                    break;
                case 1:
                    temp.SetCorrectAnswerStr(Type2TB.Text + Convert.ToChar(13));
                    break;
                case 2:
                    str = new string[NumOfVarCombo.SelectedIndex + 2];
                    str[0] = Type13TB1.Text;
                    str[1] = Type13TB2.Text;
                    if (str.Length > 2) str[2] = Type13TB3.Text;
                    if (str.Length > 3) str[3] = Type13TB4.Text;
                    if (str.Length > 4) str[4] = Type13TB5.Text;
                    if (str.Length > 5) str[5] = Type13TB6.Text;
                    int ans = 1000000;
                    if (Type13C1.Checked) ans += 100000;
                    if (Type13C2.Checked) ans += 20000;
                    if (Type13C3.Checked) ans += 3000;
                    if (Type13C4.Checked) ans += 400;
                    if (Type13C5.Checked) ans += 50;
                    if (Type13C6.Checked) ans += 6;
                    temp.SetCorrectAnswer(ans);
                    temp.SetVariants(str);
                    break;
            }

        }
        private void QuestionNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)  //изменение номера вопроса
        {
            if (fqsq2)
                SaveQ();
            else fqsq2 = true;
            questionNumber = QuestionNumberComboBox.SelectedIndex;
            fqtype = false;
            fqsq = false;
            LoadQuestion(questionNumber);
        }

        private void QuestionTypeCB_SelectedIndexChanged(object sender, EventArgs e)  //изменение типа вопроса
        {
            if (fqtype)
            {
                switch (QuestionTypeCB.SelectedIndex)
                {
                    case 0:
                        startForm.Test.ReplaceQuestion(questionNumber, new QuestionType1(3, 2, 1, 0, new string[] { "", "", "" }));
                        break;
                    case 1:
                        startForm.Test.ReplaceQuestion(questionNumber, new QuestionType2(3, "", 0, new string[] { "", "", "" }));
                        break;
                    case 2:
                        startForm.Test.ReplaceQuestion(questionNumber, new QuestionType3(3, 2, 1000000, 0, new string[] { "", "", "" }));
                        break;
                }
            }
            else fqtype = true;
            LoadQuestion(questionNumber);
        }

        private void NumOfVarCombo_SelectedIndexChanged(object sender, EventArgs e)  //изменение кол-ва вариантов
        {
            if (fqsq)
                SaveQ();
            else fqsq = true;
            string[] temp = startForm.Test.GetQuestion(questionNumber).GetVariants();
            Array.Resize(ref temp, NumOfVarCombo.SelectedIndex + 2);
            startForm.Test.GetQuestion(questionNumber).SetVariants(temp);
            LoadQuestion(questionNumber);
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)  //добавить вопрос
        {
            SaveQ();
            questionNumber = startForm.Test.GetNumOfQuestions();
            startForm.Test.AddQuestion(new QuestionType2(1,"",0,new string[] { "","" }));
            QuestionNumberComboBox.Items.Add(questionNumber + 1);
            QuestionNumberComboBox.SelectedIndex = questionNumber;
        }

        private void button1_Click(object sender, EventArgs e)  //удалить вопрос
        {
            if (startForm.Test.GetNumOfQuestions() - 1 != questionNumber && startForm.Test.GetNumOfQuestions() != 1)
            {
                startForm.Test.DeleteQ(questionNumber);
                fqsq2 = false;
                fqsq = false;
                fqtype = false;
                LoadQuestion(questionNumber);
                QuestionNumberComboBox.Items.RemoveAt(startForm.Test.GetNumOfQuestions());
            }
            if(startForm.Test.GetNumOfQuestions() - 1 == questionNumber && startForm.Test.GetNumOfQuestions() != 1)
            {
                fqsq2 = false;
                fqsq = false;
                fqtype = false;
                QuestionNumberComboBox.SelectedIndex = --questionNumber;
                startForm.Test.DeleteQ(questionNumber + 1);
                QuestionNumberComboBox.Items.RemoveAt(startForm.Test.GetNumOfQuestions());
            }
        }

        private void SaveAllButton_Click(object sender, EventArgs e)  //сохранить все изменения в файл
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();  //открытие файла
            saveFileDialog1.Title = "Сохранить тест";
            saveFileDialog1.Filter = "Text files(*.test)|*.test";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream myStream;
                if ((myStream = (saveFileDialog1.OpenFile())) != null)
                {
                    StreamWriter streamWriter = new StreamWriter(myStream);
                    string[] str = new string[2];
                    str[0] = TestNameTB.Text.Replace(Convert.ToString(Convert.ToChar(13)), "");
                    str[1] = Convert.ToString(startForm.Test.GetNumOfQuestions());
                    //Array.Resize(ref str, str.Length + 1);
                    int qstr = 1;
                    for (int i = 0; i < startForm.Test.GetNumOfQuestions(); i++)
                    {
                        switch (startForm.Test.GetQuestion(i).Type)
                        {
                            case 1:
                                Array.Resize(ref str, str.Length + 1);
                                qstr++;
                                str[qstr] = Convert.ToString(startForm.Test.GetQuestion(i).GetQuestionText().Length + startForm.Test.GetQuestion(i).GetVariants().Length) + " ";
                                str[qstr] += Convert.ToString(startForm.Test.GetQuestion(i).Type) + " ";
                                str[qstr] += Convert.ToString(startForm.Test.GetQuestion(i).GetCorrectAnswer()) + " ";
                                str[qstr] += Convert.ToString(startForm.Test.GetQuestion(i).GetVariants().Length);
                                for (int j = 0; j < startForm.Test.GetQuestion(i).GetQuestionText().Length; j++)  //текст вопроса
                                {
                                    Array.Resize(ref str, str.Length + 1);
                                    str[++qstr] = startForm.Test.GetQuestion(i).GetQuestionText()[j].Replace(Convert.ToString(Convert.ToChar(13)), "");
                                }
                                for (int j = 0; j < startForm.Test.GetQuestion(i).GetVariants().Length; j++)  //варианты ответов
                                {
                                    Array.Resize(ref str, str.Length + 1);
                                    str[++qstr] = startForm.Test.GetQuestion(i).GetVariants()[j].Replace(Convert.ToString(Convert.ToChar(13)), "");
                                }
                                break;
                            case 2:
                                Array.Resize(ref str, str.Length + 1);
                                qstr++;
                                str[qstr] = Convert.ToString(startForm.Test.GetQuestion(i).GetQuestionText().Length) + " ";
                                str[qstr] += Convert.ToString(startForm.Test.GetQuestion(i).Type) + " ";
                                str[qstr] += startForm.Test.GetQuestion(i).GetCorrectAnswerStr().Replace(Convert.ToString(Convert.ToChar(13)), "");
                                for (int j = 0; j < startForm.Test.GetQuestion(i).GetQuestionText().Length; j++)  //текст вопроса
                                {
                                    Array.Resize(ref str, str.Length + 1);
                                    str[++qstr] = startForm.Test.GetQuestion(i).GetQuestionText()[j].Replace(Convert.ToString(Convert.ToChar(13)), "");
                                }
                                break;
                            case 3:
                                Array.Resize(ref str, str.Length + 1);
                                qstr++;
                                str[qstr] = Convert.ToString(startForm.Test.GetQuestion(i).GetQuestionText().Length + startForm.Test.GetQuestion(i).GetVariants().Length) + " ";
                                str[qstr] += Convert.ToString(startForm.Test.GetQuestion(i).Type) + " ";
                                str[qstr] += Convert.ToString(startForm.Test.GetQuestion(i).GetCorrectAnswer()) + " ";
                                str[qstr] += Convert.ToString(startForm.Test.GetQuestion(i).GetVariants().Length);
                                for (int j = 0; j < startForm.Test.GetQuestion(i).GetQuestionText().Length; j++)  //текст вопроса
                                {
                                    Array.Resize(ref str, str.Length + 1);
                                    str[++qstr] = startForm.Test.GetQuestion(i).GetQuestionText()[j].Replace(Convert.ToString(Convert.ToChar(13)), "");
                                }
                                for (int j = 0; j < startForm.Test.GetQuestion(i).GetVariants().Length; j++)  //варианты ответов
                                {
                                    Array.Resize(ref str, str.Length + 1);
                                    str[++qstr] = startForm.Test.GetQuestion(i).GetVariants()[j].Replace(Convert.ToString(Convert.ToChar(13)), "");
                                }                                
                                break;
                        }
                    }
                    for (int i = 0; i < str.Length; i++)
                        streamWriter.WriteLine(str[i]);
                    streamWriter.Close();
                    myStream.Close();
                }
            }
            else return;
        }
    }
}
