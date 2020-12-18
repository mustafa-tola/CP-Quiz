using System;
using static Quiz_App.QuizDB;

namespace Quiz_App
{
    class Program
    {
        static void Main(string[] args)
        {
            QuizDB quizDB = new QuizDB();
            string permissionToStartQuiz = " ";
            int scoreOfQuiz = 0;
            float percentageOfQuiz = 0;
            string answerFromUser = "";
            Console.WriteLine("{0,60}", "Quiz App");
            Console.WriteLine("{0,25} {1}"," ","__________________________________________________________");
            Console.WriteLine("{0,25} | {1,34} {2,19} |", " ","Instructions"," ");
            Console.WriteLine("{0,25} |{1}", " ", "1.This quiz will be of the category: The History Of Pak |");
            Console.WriteLine("{0,25} |{1} {2,13} |", " ", "2.There will be 10 questions in this quiz"," ");
            Console.WriteLine("{0,25} |{1} |", " ", "3.You will have to answer the best option in the blank ");
            Console.WriteLine("{0,25} |{1} {2,15} |", " ", "  under the questions in this format:- "," ");
            Console.WriteLine("{0,25} |{1} {2,33}|", " ", "    i.a for 1st option"," ");
            Console.WriteLine("{0,25} |{1} {2,32}|", " ", "    ii.b for 2nd option", " ");
            Console.WriteLine("{0,25} |{1} {2,31}|", " ", "    iii.c for 3rd option", " ");
            Console.WriteLine("{0,25} |{1} {2,32}|", " ", "    iv.d for 4th option", " ");
            Console.WriteLine("{0,25} |{1} {2,12}|", " ", "4.There is no negative marking in this quiz", " ");
            Console.WriteLine("{0,25} {1}", " ", "----------------------------------------------------------");
            Console.WriteLine("{0,27} Please Enter s to start the quiz or q to quit the quiz", " ");
            do
            {
                Console.CursorLeft = (Console.WindowWidth - 12) / 2;
                permissionToStartQuiz = Console.ReadLine();
                if(permissionToStartQuiz == "q")
                {
                    break;
                }
            } while (permissionToStartQuiz != "s");
            if (permissionToStartQuiz== "s")
            {
                for (int i = 0; i < quizDB.questions.Length; i++)
                {
                    Console.Clear();
                    Console.WriteLine("{0,60}", "Quiz App");
                    Console.Write("{0,40}", " ");
                    for (int index = 0; index < (quizDB.questions[i].Length + 2); index++)
                    {

                        Console.Write("{0}","_");
                    };
                    Console.WriteLine("\n{0,40}|{1,-35}|\n", " ", quizDB.questions[i]);
                    Console.Write("", " ");
                    for (int j = 0; j < 4; j++)
                    {
                        Console.WriteLine("{0,40}|{1}.{2,-33}|"," ", (j + 1), quizDB.answers[i, j]);
                    }
                    do
                    {
                        Console.WriteLine("\n {0,45}Please enter the answer"," ");
                        Console.WriteLine("{0,43} {1} {2,33}", " ", "    i.a for 1st option", " ");
                        Console.WriteLine("{0,43} {1} {2,32}", " ", "    ii.b for 2nd option", " ");
                        Console.WriteLine("{0,43} {1} {2,31}", " ", "    iii.c for 3rd option", " ");
                        Console.WriteLine("{0,43} {1} {2,32}", " ", "    iv.d for 4th option", " ");
                        Console.CursorLeft = (Console.WindowWidth - 5) / 2;
                        answerFromUser = Console.ReadLine();
                    } while ((answerFromUser != "a" && answerFromUser != "b") && ((answerFromUser != "c" && answerFromUser != "d")));
                    if(answerFromUser == quizDB.correctAnswersOptions[i])
                    {
                        scoreOfQuiz += 1;
                    }
                }
                percentageOfQuiz = scoreOfQuiz * 100 / quizDB.questions.Length;
                Console.Clear();
                Console.WriteLine("{0,60}", "Quiz App");
                Console.WriteLine("{0,25} {1}", " ", "__________________________________________________________");
                Console.WriteLine("{0,25} | {1,34} {2,19} |", " ", "Report Card", " ");
                Console.WriteLine("{0,26}|{1,-55} |"," ", "Your Score is " + scoreOfQuiz);
                Console.WriteLine("{0,26}|{1,-55} |", " ", "Your Percentage is " + percentageOfQuiz);
                if (percentageOfQuiz > 50)
                {
                    Console.WriteLine("{0,26}|{1,-55} |", " ", "Congratulations! You Have Passed");
                }
                else
                {
                    Console.WriteLine("{0,26}|{1,-55} |", " ", "Better Luck Next Time");
                }
                Console.WriteLine("{0,25} {1}", " ", "----------------------------------------------------------");

            }
            else
            {
                Console.WriteLine("Hope You Play It Next Time");
            }
        }
    }

}
