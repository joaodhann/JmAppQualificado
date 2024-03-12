using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JmAppQualificado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual sua data de nascimento?");
            int nascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Em qual ano você entrou na empresa?");
            int anoemp = int.Parse(Console.ReadLine());

            int idade = 2024 - nascimento;
            int anosnaep = 2024 - anoemp;

            Console.WriteLine("Você tem " + idade, "anos");
            Console.WriteLine("Você trabalha à " + anosnaep, "anos na empresa");

            if (idade >= 65 || anosnaep >= 30 || idade >= 60 && anosnaep >= 25)
            {
                Console.WriteLine("Já pode se aposentar");
            }

            else
            {
                Console.WriteLine("Ainda não pode se aposentar");
            }
        
            Console.ReadKey();
        }
    }
}
