using System;
using System.Collections.Generic;


namespace DesafioWarrenTech_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int quant = 1; quant < 1000; quant++)
            {
                int num1 = quant;
                int num2 = 0;
                int auxi = 0;
                while (num1 != 0)
                {
                    auxi = num1 % 10;
                    num2 = num2 * 10 + auxi;
                    num1 /= 10;
                }
                num1 = quant;
                int result = num1 + num2;
                string comp = Convert.ToString(num2);
                if (!(comp[0] == '0'))
                {
                    if (result % 2 != 0)
                    {
                        Console.WriteLine("\nNumero reversivel : " + num1);
                    }
                }
            }
        }
    }
}
