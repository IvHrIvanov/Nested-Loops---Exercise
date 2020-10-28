using System;
using System.Threading;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int prime = 0;
            int notPrime = 0;
            string command = Console.ReadLine();
            while (command != "stop")
            {
                int num = int.Parse(command);
                               
                int count = 0;
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    command = Console.ReadLine();
                    continue;
                }
                for (int i = 2; i < num; i++)
                {

                    if (num % i == 0)
                    {
                        count++;
                        break;
                    }
                }
                     if (num != 1 && count == 0)
                    {
                        prime += num;
                    }
                    else
                    {
                        notPrime += num;
                    }

                    command = Console.ReadLine();                             
            }
            Console.WriteLine($"Sum of all prime numbers is: {prime}");
            Console.WriteLine($"Sum of all non prime numbers is: {notPrime}");


        }

    }
}
