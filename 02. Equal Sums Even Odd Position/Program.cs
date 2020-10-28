using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            for (int i = numOne; i <= numTwo; i++)
            {
                int currentNum = i;
                int evenSum = 0;
                int oddSum = 0;
                int counter = 0;
                while (currentNum != 0)
                {
                    int digit = currentNum % 10;
                    if (counter % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }
                    currentNum = currentNum / 10;
                    counter++;
                }
                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
