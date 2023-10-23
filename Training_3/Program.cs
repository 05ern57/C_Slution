

using System.Threading.Channels;
using Training_3;

Question q1 = new Question("What is the language that you are trying to learn?", new string[] { "c#", "javascript", "java", "python" }, "c#");
Question q2 = new Question("What is the language that you have been learned?", new string[] { "c#", "javascript", "java", "python" }, "javascript");
Question q3= new Question("What is the language that you have seen in university?", new string[] { "c#", "javascript", "java", "python" }, "java");
Question q4 = new Question("Only language you completely don't know out of the sections?", new string[] { "c#", "javascript", "java", "python" }, "python");


Question[] qstns = new Question[] { q1, q2, q3, q4 };

Quiz quiz = new Quiz(qstns);

//Console.WriteLine(quiz.QuestionList[quiz.QuestionIndex].Qs);
//quiz.QuestionIndex++;
//Console.WriteLine(quiz.QuestionList[quiz.QuestionIndex].Qs);
//quiz.QuestionIndex++;
//Console.WriteLine(quiz.QuestionList[quiz.QuestionIndex].Qs);
//quiz.QuestionIndex++;
//Console.WriteLine(quiz.QuestionList[quiz.QuestionIndex].Qs);

quiz.DisplayQuestion();


//foreach (Question quest in qstns)
//{
//    Console.WriteLine(quest.chechAnswer() + "\n");
//}

// instead of using a method for that we can do it here simply
//foreach (Question quest in qstns)
//{
//    Console.WriteLine(quest.Qs);
//    foreach (string chs in quest.Choises)
//    {
//        Console.WriteLine("(-) " + chs);
//    }

//    Console.Write("\nWhat is your answer: ");
//    string answer = Console.ReadLine();
//    Console.WriteLine(answer.ToLower() == quest.Answer.ToLower() ? "True" : "False");
//    Console.WriteLine("################");

//}







// You will going to implement the methods of the class that you have written 