using System;

namespace Quiz_App
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = " ";
            string[] questions = new string [3] { "Pakistan came into being in the year", "Liaquat Ali Khan was assasinated in", "Allama Iqbal was born in which city" };
            string[] correctAnswersOptions = new string [3] { "c", "d", "b" };
            string[,] answers = new string[3, 4]
            {
                {"1950","1945","1947","1943"},
                {"1931","1930","1948","1951"},
                {"Karachi","Sialkot","Lahore","Rawalpindi"}
            };
            int scoreOfQuiz = 0;
            float percentageOfQuiz = 0;
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
            Console.CursorLeft = (Console.WindowWidth - 12) / 2;
            input = Console.ReadLine();
            while (input != "s")
            {
                if(input == "q")
                {
                    break;
                }
                Console.WriteLine("{0,27} Please Enter s to start the quiz or q to quit the quiz", " ");
                Console.CursorLeft = (Console.WindowWidth - 12) / 2;
                input = Console.ReadLine();
            }
            if(input== "s")
            {
                for (int i = 0; i < questions.Length; i++)
                {
                    Console.Clear();
                    Console.WriteLine("{0,60}", "Quiz App");
                    Console.Write("{0,40}", " ");
                    for (int index = 0; index < (questions[i].Length + 2); index++)
                    {

                        Console.Write("{0}","_");
                    }
                    Console.WriteLine("\n{0,40}|{1,-35}|\n", " ", questions[i]);
                    Console.Write("", " ");
                    for (int j = 0; j < 4; j++)
                    {
                        Console.WriteLine("{0,40}|{1}.{2,-33}|"," ", (j + 1), answers[i, j]);
                    }
                    Console.CursorLeft = (Console.WindowWidth - 27) / 2;
                    Console.WriteLine("Please enter the answer");
                    Console.CursorLeft = (Console.WindowWidth - 5) / 2;
                    string answerFromUser = Console.ReadLine();
                    while((answerFromUser != "a" && answerFromUser != "b") && ((answerFromUser != "c" && answerFromUser != "d")))
                    {
                        Console.CursorLeft = (Console.WindowWidth - 27) / 2;
                        Console.WriteLine("Please enter the answer");
                        Console.CursorLeft = (Console.WindowWidth - 5) / 2;
                        answerFromUser = Console.ReadLine();
                    }
                    if(answerFromUser == correctAnswersOptions[i])
                    {
                        scoreOfQuiz += 1;
                    }
                }
                percentageOfQuiz = scoreOfQuiz * 100 / questions.Length;
                Console.Clear();
                Console.WriteLine("Your Score is {0}", scoreOfQuiz);
                Console.WriteLine("Your Percentage is {0}%",(float) percentageOfQuiz);
            }
            else
            {
                Console.WriteLine("Hope You Play It Next Time");
            }
        }
    }

}
