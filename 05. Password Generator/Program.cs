using System;

namespace _05._Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            for (int simbol1 = 1; simbol1 <= n; simbol1++)
            {
                for (int simbol2 = 1; simbol2 <= n; simbol2++)
                {
                    for (int simbol3 = 97; simbol3 < 97 + l; simbol3++)
                    {
                        for (int simbol4 = 97; simbol4 < 97 + l; simbol4++)
                        {
                            for (int simbol5 = 1; simbol5 <= n; simbol5++)
                            {
                                if (simbol5 > simbol1 && simbol5 > simbol2)
                                {
                                    Console.Write("{0}{1}{2}{3}{4} ", simbol1, simbol2, Convert.ToChar(simbol3), Convert.ToChar(simbol4), simbol5);
                                }
                            }
                        }

                    }
                }

            }
        }
    }
}
