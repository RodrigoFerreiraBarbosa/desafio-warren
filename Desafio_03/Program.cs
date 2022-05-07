using System;
using System.Linq;

namespace DesafioWarrenTech_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[3] {2,3,4};
            int n = 10;
            int[] result = new int[3];
            int[] result1 =new int[3];
            int soma;

            result[0] = v[0];
            result[1] = v[2];
            result[2] = v[2];

            soma = result.Sum();
            if(soma == n)
            {
                Console.WriteLine(soma);
                foreach(int i in result)
                {
                    Console.Write(i +" ");
                }
            }
            Console.WriteLine();

            result1[0] = v[1];
            result1[1] = v[1];
            result1[2] = v[2];

            soma = result1.Sum();
            if (soma == n)
            {
                Console.WriteLine(soma);
                foreach (int i in result1)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
