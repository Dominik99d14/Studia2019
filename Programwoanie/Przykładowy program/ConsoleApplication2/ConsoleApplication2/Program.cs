using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 konto = new Class1();

            float ile;
            int menu =0 ;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("STAN KONTA: ");
                konto.StanKontaWyswietl();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Menu: ");
                Console.WriteLine("1. Wplata na konto");
                Console.WriteLine("2. Wyplata z konta");
                Console.WriteLine("3. Zamknij");
                Console.Write("Numer opcji: ");

                //Sprawdzanie czy podano liczbę do menu
                bool a = int.TryParse(Console.ReadLine(), out menu);
                if(!a)
                {
                    throw new ArgumentException();
                }


                switch (menu)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Ile wplacasz?");
                        Console.Write("Wartosc: ");
                        bool b = float.TryParse(Console.ReadLine(), out ile);
                        if(!b)
                        {
                            throw new ArgumentException();
                        }
                        konto.Wplata(ile);
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Ile wyplacic?");
                        Console.Write("Wartosc: ");
                        bool c = float.TryParse(Console.ReadLine(), out ile);
                        if (!c)
                        {
                            throw new ArgumentException();
                        }
                        konto.Wyplata(ile);
                        Console.ReadKey();
                        break;

                    case 3:
                        System.Diagnostics.Process.GetCurrentProcess().Kill();
                        break;

                    
                }    

            } while(""=="");

            
        }
    }
}
