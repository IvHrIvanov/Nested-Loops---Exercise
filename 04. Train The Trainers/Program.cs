using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();


            
            double totalSum = 0;
            double scoreLoops = 0;
            while (input != "Finish")
            {
                double sumScore = 0;
                for (int i = 0; i < persons; i++)
                {
                    double addScore = double.Parse(Console.ReadLine());
                    sumScore += addScore;
                    scoreLoops++;
                }
                totalSum += sumScore;
                double middleScore = sumScore / persons * 1.0;
                Console.WriteLine($"{input} - {middleScore:f2}.");
                input = Console.ReadLine();
            }
            double studentFinalScore =totalSum/scoreLoops;
            Console.WriteLine($"Student's final assessment is {studentFinalScore:f2}.");
            
        }
    }
}
