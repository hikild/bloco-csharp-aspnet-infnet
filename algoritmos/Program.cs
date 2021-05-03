using System;

namespace algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            verificaNumero(2);
            verificaNumero(-2);
            Console.WriteLine("__________________");
            verificaIdade("hithalo", 26);
            verificaIdade("hithalo", 15);
            Console.WriteLine("__________________");
            estrelas(4);
            Console.WriteLine("__________________");
            calcularFatorial(4);
        }
        public static void verificaNumero(int num)
        {
            if (num <= 0)
            {
                Console.WriteLine("Este número é negativo");
            }
            else
            {
                Console.WriteLine("Número positivo.");
            }
        }

        public static void verificaIdade(string nome, int idade)
        {
            if (idade < 18)
            {
                Console.WriteLine($"{nome} é menor de idade.");
            }
            else
            {
                Console.WriteLine($"{nome} é maior de idade.");
            }
        }

        public static void estrelas(int numero)
        {
            for (int i = 1; i <= numero; i++)
            {
                string estrela = new string('*', i);
                Console.WriteLine(estrela);
            }
        }

        public static void calcularFatorial(int numero)
        {
            int fatorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                fatorial *= i;
                Console.WriteLine($"{i}! = {fatorial}");
            }
        }
    }

}
