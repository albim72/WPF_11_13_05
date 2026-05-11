using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Platforma .NET");
            Console.Write("Podaj czas zawodnika w minutach: ");

            if(int.TryParse(Console.ReadLine(), out int czas))
            {
                if (czas < 30)
                {
                    Console.WriteLine("Zawodnik jest szybki.");
                }
                else if (czas < 60)
                {
                    Console.WriteLine("Zawodnik jest średni.");
                }
                else
                {
                    Console.WriteLine("Zawodnik jest wolny.");
                }
            }
            else
            {
                Console.WriteLine("Nieprawidłowa wartość. Proszę podać liczbę całkowitą.");
            }
        }
    }
}
