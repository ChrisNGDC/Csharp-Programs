using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Programs
{
    class Program
    {
        static void NumberGuesser()
        {
            Random r = new Random();
            int winNum = r.Next(0, 100);
            bool acerto = false;
            Console.WriteLine("Adivine el numero natural que pienso:");
            do
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (winNum > num)
                    Console.WriteLine("El numero a adivinar es mayor");
                if (winNum < num)
                    Console.WriteLine("El numero a adivinar es menor");
                if (winNum == num)
                {
                    acerto = true;
                    Console.WriteLine("Ha acertado!! (Oprima un tecla para continuar)");
                    Console.ReadKey();
                }
            } while (!acerto);
        }
        
        
        static void Main(string[] args)
        {
            int opcion;
            bool exit = false;

            do
            {
                Console.Clear();
                Console.WriteLine("1: Number Guess Game");
                Console.WriteLine("0: Exit");
                Console.WriteLine("Eliga que quiere programa quiere utilizar:");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        NumberGuesser();
                        break;
                    default:
                        break;
                }
            } while (!exit);
        }
    }
}
