using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_3
{
    internal class Question
    {

        public Question(string question, string[] choises, string answer)
        {
            this.Qs = question;
            this.Choises = choises;
            this.Answer = answer;
        }
        public string Qs { get; set; }
        public string[] Choises { get; set; }
        public string Answer { get; set; }

        private void showDetails()
        {
            Console.WriteLine(this.Qs);
            foreach (string i in this.Choises)
            {
                Console.WriteLine(i);
            };
        }
        public bool checkAnswer(string answer)
        {
            return (answer.Trim().ToLower() == this.Answer.ToLower()) ? true : false;
        }   
    }
    
   
}
