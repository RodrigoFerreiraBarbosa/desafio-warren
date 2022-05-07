using System;
using System.Collections.Generic;
namespace DesafioWarrenTech_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();
            int minAluno = 3;
            List<int> alunos = new List<int>();

            for(int i = 0; i < 5; i++)
            {
                int adAluno = random.Next(-2, 2);
                alunos.Add(adAluno);
            }
            foreach(int x in alunos)
            {
                Console.Write(x +",");
            }
            Console.WriteLine();
            alunos = alunos.FindAll(x => x < 1);
            foreach(int x in alunos)
            {
                Console.Write(x +",");
            }
            if(alunos.Count >= 3)
            {
                Console.WriteLine("\ntem aula ");
            }
            else
            {
                Console.WriteLine("\nNão tem aula");
            }
        }
    }
}
