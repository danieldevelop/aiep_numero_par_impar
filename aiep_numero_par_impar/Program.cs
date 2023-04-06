using System;

namespace aiep_numero_par_impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número por favor");
            int numeroUsuario = int.Parse(Console.ReadLine());

            if (comprobadorDePares(numeroUsuario))
            {
                Console.WriteLine("Es Par");
            } 
            else
            {
                Console.WriteLine("No es Impar");
            }

            Console.WriteLine("\nPres and key continue...");
            Console.ReadKey();
        }


        static bool comprobadorDePares(int numero)
        {
            bool esPar;

            if ((numero % 2) == 0)
            {
                esPar = true;
            }
            else
            {
                esPar = false;
            }

            return esPar;
        }
    }
}
