using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Training_3
{
    internal class Quiz
    {
        //public Quiz(params Question[] questionObjList)
        //{
        //    foreach (Question list in questionObjList)
        //    {
        //        this.QuestionObjList.Push
        //    }
        //}

        //public Question[] QuestionObjList { get; private set; }
        // I had something in my mind but I couldn't figured it out what I had then I stopped

        public Quiz(Question[] questionList)
        {
            this.QuestionList = questionList;
            this.QuestionIndex = 0;
            this.Score = 0;
        }

        public Question[] QuestionList { get; private set; }
        public int QuestionIndex { get; set; }

        public int Score {  get; set; } 
        private Question GetQuestion()
        {
            
            return this.QuestionList[this.QuestionIndex];
        }

        private int GetQuestionIndex()
        {
            return this.QuestionIndex;
        }

        public void DisplayQuestion()
        {

            Question question = this.GetQuestion();
            Console.WriteLine($"Soru {this.GetQuestionIndex() + 1}) {question.Qs}");
            foreach (string chs in question.Choises)
            {
                Console.WriteLine("(-) " + chs);
            }

            Console.Write("\nWhat is your answer: ");
            string answer = Console.ReadLine();
            this.Guess(answer);
           

        }
        private void Guess(string answer)
        {
            Question question = this.GetQuestion();
            if (question.checkAnswer(answer)) this.Score++;
            Console.WriteLine($"{this.Score} Correct answer(s) out of {this.QuestionList.Length} " );
            Console.WriteLine("################");
            this.QuestionIndex++;
            if (this.QuestionList.Length != this.QuestionIndex)
            {
                this.DisplayQuestion();
            }
            else
            {
                Console.WriteLine("Quiz Has Finished");
            }
        }

    }
}
