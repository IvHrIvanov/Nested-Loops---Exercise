using System;
using System.Runtime.InteropServices;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int row = 1;
            int currNum = 1;
            bool isEqua = false;
            while (isEqua == false)
            {
                for (int i = 1; i <= row; i++)
                {
                    Console.Write(currNum + " ");
                    currNum++;
                    if (currNum > n)
                    {
                        isEqua = true;
                        break;
                    }
                }
                Console.WriteLine();
                row++;
            }

        }
    }
}
