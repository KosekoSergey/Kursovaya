using System;
using System.Collections.Generic;
using System.Text;

namespace Testigo
{
    public abstract class Question  //базовый класс вопроса
    {
        protected int type;  //тип вопроса
        public int Type
        {
            get
            {
                return type;
            }
        }
        protected string[] question;  //текст вопроса
        public string[] GetQuestionText()
        {
            return question;
        }
        public void SetQuestion(string[] question)
        {
            this.question = question;
        }
        virtual public string[] GetVariants()
        {
            return null;
        }
        virtual public int GetCorrectAnswer()
        {
            return 0;
        }
        virtual public int GetSelectedVariant()
        {
            return 0;
        }
        virtual public string GetSelectedVariantStr()
        {
            return null;
        }
        virtual public string GetCorrectAnswerStr()
        {
            return null;
        }
        virtual public void SetVariants(string[] variants) { }
        virtual public void SetCorrectAnswer(int answer) { }
        virtual public void SetSelectedVariant(int answer) { }
        virtual public void SetCorrectAnswerStr(string answer) { }
        virtual public void SetSelectedVariantStr(string answer) { }
        abstract public bool Check();  //проверка ответа
    }

    public class QuestionType1 : Question
    {
        private string[] variants;  //варианты
        private int correct_answer;  //правильный ответ
        private int selected_variant = 0;  //выбранный вариант ответа
        public QuestionType1(int size_of_quest, int num_of_var, int correct_var, int baseline, string[] test)
        {
            type = 1;
            question = new string[size_of_quest - num_of_var];
            for (int i = 0; i < size_of_quest - num_of_var; i++) question[i] = test[baseline + i];  //текст вопроса
            variants = new string[num_of_var];
            for (int i = 0; i < num_of_var; i++) variants[i] = test[baseline + size_of_quest - num_of_var + i];  //варианты
            correct_answer = correct_var;  //правильный ответ
        }
        public override string[] GetVariants()
        {
            return variants;
        }
        public override void SetVariants(string[] variants)
        {
            this.variants = variants;
        }
        public override int GetCorrectAnswer()
        {
            return correct_answer;
        }
        public override int GetSelectedVariant()
        {
            return selected_variant;
        }
        public override void SetCorrectAnswer(int answer)
        {
            correct_answer = answer;
        }
        public override void SetSelectedVariant(int answer)
        {
            selected_variant = answer;
        }
        public override bool Check()  //проверка ответа
        {
            if (correct_answer == selected_variant) return true;
            else return false;
        }
    }
    /*public class QuestionType2 : Question
    {
        private int correct_answer;  //правильный ответ
        private int selected_variant;  //выбранный вариант ответа
        public QuestionType2(int size_of_quest, int correct_var, int baseline, string[] test)
        {
            type = 2;
            question = new string[size_of_quest];
            for (int i = 0; i < size_of_quest; i++) question[i] = test[baseline + i];  //текст вопроса
            correct_answer = correct_var;  //правильный ответ
        }
        public override int GetCorrectAnswer()
        {
            return correct_answer;
        }
        public override int GetSelectedVariant()
        {
            return selected_variant;
        }
        public override void SetCorrectAnswer(int answer)
        {
            correct_answer = answer;
        }
        public override void SetSelectedVariant(int answer)
        {
            selected_variant = answer;
        }
        public override bool Check()  //проверка ответа
        {
            if (correct_answer == selected_variant) return true;
            else return false;
        }
    }*/
    public class QuestionType2 : Question  //3
    {
        private string correct_answer;  //правильный ответ
        private string selected_variant = "";  //выбранный вариант ответа
        public QuestionType2(int size_of_quest, string correct_var, int baseline, string[] test)
        {
            type = 2;
            question = new string[size_of_quest];
            for (int i = 0; i < size_of_quest; i++) question[i] = test[baseline + i];  //текст вопроса
            correct_answer = correct_var;  //правильный ответ
        }
        public override string GetCorrectAnswerStr()
        {
            return correct_answer;
        }
        public override string GetSelectedVariantStr()
        {
            return selected_variant;
        }
        public override void SetCorrectAnswerStr(string answer)
        {
            correct_answer = answer;
        }
        public override void SetSelectedVariantStr(string answer)
        {
            selected_variant = answer;
        }
        public override bool Check()  //проверка ответа
        {
            return string.Compare(correct_answer,selected_variant) == 0;
        }
    }
    public class QuestionType3 : Question    //4
    {
        private string[] variants;  //варианты
        private int correct_answer;  //правильный ответ
        private int selected_variant = 1000000;  //выбранный вариант ответа
        public QuestionType3(int size_of_quest, int num_of_var, int correct_var, int baseline, string[] test)
        {
            type = 3;
            question = new string[size_of_quest - num_of_var];
            for (int i = 0; i < size_of_quest - num_of_var; i++) question[i] = test[baseline + i];  //текст вопроса
            variants = new string[num_of_var];
            for (int i = 0; i < num_of_var; i++) variants[i] = test[baseline + size_of_quest - num_of_var + i];  //варианты
            correct_answer = correct_var;  //правильный ответ
        }
        public override string[] GetVariants()
        {
            return variants;
        }
        public override void SetVariants(string[] variants)
        {
            this.variants = variants;
        }
        public override int GetCorrectAnswer()
        {
            return correct_answer;
        }
        public override int GetSelectedVariant()
        {
            return selected_variant;
        }
        public override void SetCorrectAnswer(int answer)
        {
            correct_answer = answer;
        }
        public override void SetSelectedVariant(int answer)
        {
            selected_variant = answer;
        }
        public override bool Check()  //проверка ответа
        {
            if (correct_answer == selected_variant) return true;
            else return false;
        }
    }
}
