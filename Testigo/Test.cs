using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Testigo
{

    class Test
    {
        private Question[] task;  //массив вопросов
        private int[] characteristics;  //характеристики теста: 0-кол-во вопросов
        private int score;  //кол-во правильных ответов
        public Test() { }
        public Test(string path)
        {
            characteristics = new int[1];
            string[] test;
            using (StreamReader stream = File.OpenText(path))
                test = stream.ReadToEnd().Split("\n");
            int i = 0;
            foreach (string num in test[0].Split(" "))  //считывание строки характериситик
            {
                characteristics[i] = Convert.ToInt32(num);
                i++;
            }
            task = new Question[characteristics[0]];  //создание вопросов

            int curqest = 0;
            for (i = 1; i < test.Length; i++)  //цикл поочередного инициализирования вопроса
            {
                string[] tempstr;
                tempstr = test[i].Split(" ");
                int size_of_quest = Convert.ToInt32(tempstr[0]);  //получение размера вопроса
                int type_of_quest = Convert.ToInt32(tempstr[1]);  //получение типа вопроса                
                switch (type_of_quest)  //инициализация вопроса
                {
                    case 1:
                        int correct_var = Convert.ToInt32(tempstr[2]);  //получение правильного варианта
                        int num_of_var = Convert.ToInt32(tempstr[3]);  //получение кол-ва вариантов
                        task[curqest] = new QuestionType1(size_of_quest, num_of_var, correct_var, i + 1, test);
                        break;
                    case 2:
                        correct_var = Convert.ToInt32(tempstr[2]);  //получение правильного варианта
                        task[curqest] = new QuestionType2(size_of_quest, correct_var, i + 1, test);
                        break;
                    case 3:
                        string correct_var_str = tempstr[2];  //получение правильного варианта
                        task[curqest] = new QuestionType3(size_of_quest, correct_var_str, i + 1, test);
                        break;
                }
                curqest++;
                if (curqest >= characteristics[0]) break;
                i += size_of_quest;
            }
        }
        public void AddQuestion(Question question)  //добавление вопроса
        {
            characteristics[0]++;
            Array.Resize(ref task, characteristics[0]);
            task[characteristics[0] - 1] = question;
        }
        public int GetNumOfQuestions()
        {
            return characteristics[0];
        }
        public bool CheckAnswer(int num)  //проверка ответа вопроса теста
        {
            return task[num].Check();
        }
        public Question GetQuestion(int num)  //получение доступа к вопросу
        {
            return task[num];
        }
    }
}
