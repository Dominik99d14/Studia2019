using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZadaniaWprowadzenie
{
    class Program
    {
        private char A1 = '1';
        private char A2 = '2';
        private char A3 = '3';
        private char B1 = '4';
        private char B2 = '5';
        private char B3 = '6';
        private char C1 = '7';
        private char C2 = '8';
        private char C3 = '9';
        private bool koniec = false;
        private char[,] pola = new char[3,3]; 
        static void Main(string[] args)
        {
            Program program = new Program();

            program.Menu();
            
        }

        public void Menu()
        {
            Program program = new Program();
            Console.Clear();
            Console.WriteLine("Witaj w grze kółko i krzyżyk");
            Console.WriteLine("1. Nowa gra");
            Console.WriteLine("2. Informacje o autorze");
            Console.WriteLine("3. Wyjscie");
            int menu = 0;
            bool sprawdzam = int.TryParse(Console.ReadLine(),out menu);
            if(!sprawdzam)
            {
                Console.WriteLine("Zle Dane");
            }
            else
            {
                if(menu==1)
                {
                    program.Gra();
                }
                if(menu==2)
                {
                    this.Info();
                }
                if(menu==3)
                {
                    System.Environment.Exit(1);
                }
                else
                {
                    this.Menu();
                }
            }


        }

        public void Info()
        {
            Console.Clear();
            Console.WriteLine("Autor gry: Dominik Kowalczyk");
            if(Console.ReadKey().Key==ConsoleKey.Enter)
            {
                this.Menu();
            }

        }

        public void Gra()
        {
            Program program = new Program();

            Console.WriteLine();
            //Tura1
            program.Plansza();
            program.RuchX();
            Console.Clear();
            program.CzyWygrana();
            program.Plansza();
            program.RuchY();
            Console.Clear();
            program.CzyWygrana();
            //Tura2
            program.Plansza();
            program.RuchX();
            Console.Clear();
            program.CzyWygrana();
            program.Plansza();
            program.RuchY();
            Console.Clear();
            program.CzyWygrana();
            //Tura3
            program.Plansza();
            program.RuchX();
            Console.Clear();
            program.CzyWygrana();
            program.Plansza();
            program.RuchY();
            Console.Clear();
            program.CzyWygrana();
            //Tura4
            program.Plansza();
            program.RuchX();
            Console.Clear();
            program.CzyWygrana();
            program.Plansza();
            program.RuchY();
            Console.Clear();
            program.CzyWygrana();
            //Tura5
            program.Plansza();
            program.RuchX();
            Console.Clear();
            program.CzyWygrana();
        }


        public void Plansza()
        {
            if (koniec == false)
            {
                Console.WriteLine();
                Console.WriteLine(" " + pola[0,0] + " | " + pola[0,1] + " | " + pola[0,2]);
                Console.WriteLine("---+---+---");
                Console.WriteLine(" " + pola[1, 0] + " | " + pola[1, 1] + " | " + pola[1, 2]);
                Console.WriteLine("---+---+---");
                Console.WriteLine(" " + pola[2, 0] + " | " + pola[2, 1] + " | " + pola[2, 2]);
                Console.WriteLine();
            }
        }

        public void CzyWygrana()
        {
            
                if (pola[0,0] == pola[0, 1] && pola[0, 0] == pola[0, 2] && pola[0, 2] == pola[0, 1])
                {
                    if (pola[0, 0] == 'X')
                    {
                        Console.WriteLine();
                        Console.WriteLine("WYGRYWA X");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        koniec = true;
                    Console.ReadKey();
                    this.Menu();

                }
                    if (pola[0, 0] == 'O')
                    {
                        Console.WriteLine();
                        Console.WriteLine("WYGRYWA O");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        koniec = true;
                    Console.ReadKey();
                    this.Menu();
                }
                }
                if (pola[1, 0] == pola[1, 1] && pola[1, 0] == pola[1, 2] && pola[1, 2] == pola[1, 1])
                {
                    if (pola[1, 0] == 'X')
                    {
                        Console.WriteLine();
                        Console.WriteLine("WYGRYWA X");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        koniec = true;
                    Console.ReadKey();
                    this.Menu();
                }
                    if (pola[1, 0] == 'O')
                    {
                        Console.WriteLine();
                        Console.WriteLine("WYGRYWA O");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        koniec = true;
                    Console.ReadKey();
                    this.Menu();
                }
                }
                if (pola[2, 0] == pola[2, 1] && pola[2, 0] == pola[2, 2] && pola[2, 2] == pola[2, 1])
                {
                    if (pola[2, 0] == 'X')
                    {
                        Console.WriteLine();
                        Console.WriteLine("WYGRYWA X");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        koniec = true;
                    Console.ReadKey();
                    this.Menu();
                }
                    if (pola[2, 0] == 'O')
                    {
                        Console.WriteLine();
                        Console.WriteLine("WYGRYWA O");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        koniec = true;
                    Console.ReadKey();
                    this.Menu();
                }
                }

                if (pola[0, 0] == pola[1, 0] && pola[0, 0] == pola[2, 0] && pola[2, 0] == pola[1, 0])
                {
                    if (pola[0, 0] == 'X')
                    {
                        Console.WriteLine();
                        Console.WriteLine("WYGRYWA X");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        koniec = true;
                    Console.ReadKey();
                    this.Menu();
                }
                    if (pola[0, 0] == 'O')
                    {
                        Console.WriteLine();
                        Console.WriteLine("WYGRYWA O");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        koniec = true;
                    Console.ReadKey();
                    this.Menu();
                }
                }
                if (pola[0, 1] == pola[1, 1] && pola[0, 1] == pola[2, 1] && pola[2, 1] == pola[1, 1])
                {
                    if (pola[0, 1] == 'X')
                    {
                        Console.WriteLine();
                        Console.WriteLine("WYGRYWA X");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        koniec = true;
                    Console.ReadKey();
                    this.Menu();
                }
                    if (pola[0, 1] == 'O')
                    {
                        Console.WriteLine();
                        Console.WriteLine("WYGRYWA O");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        koniec = true;
                    Console.ReadKey();
                    this.Menu();
                }
                }
                if (pola[0, 2] == pola[1, 2] && pola[0, 2] == pola[2, 2] && pola[2, 2] == pola[1, 2])
            {
                    if (pola[0, 2] == 'X')
                    {
                        Console.WriteLine();
                        Console.WriteLine("WYGRYWA X");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        koniec = true;
                    Console.ReadKey();
                    this.Menu();
                }
                    if (pola[0, 2] == 'O')
                    {
                        Console.WriteLine();
                        Console.WriteLine("WYGRYWA O");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        koniec = true;
                    Console.ReadKey();
                    this.Menu();
                }
                }

                if (pola[0, 0] == pola[1, 1] && pola[0, 0] == pola[2, 2] && pola[2, 2] == pola[1, 1])
                {
                    if (pola[0, 0] == 'X')
                    {
                        Console.WriteLine();
                        Console.WriteLine("WYGRYWA X");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        koniec = true;
                    Console.ReadKey();
                    this.Menu();
                }
                    if (pola[0, 0] == 'O')
                    {
                        Console.WriteLine();
                        Console.WriteLine("WYGRYWA O");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        koniec = true;
                    Console.ReadKey();
                    this.Menu();
                }
                }

                if (pola[0, 2] == pola[1, 1] && pola[0, 2] == pola[2, 0] && pola[2, 0] == pola[1, 1])
                {
                    if (pola[0, 2] == 'X')
                    {
                        Console.WriteLine();
                        Console.WriteLine("WYGRYWA X");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        koniec = true;
                    Console.ReadKey();
                    this.Menu();
                }
                    if (pola[0, 2] == 'O')
                    {
                        Console.WriteLine();
                        Console.WriteLine("WYGRYWA O");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        
                        koniec = true;
                    Console.ReadKey();
                    this.Menu();
                }
                
            }
            
        }

        public void RuchX()
        {
            if (koniec == false)
            {
                Console.Write("Wprowadz X: ");
                int ruch1;
                bool a1 = int.TryParse(Console.ReadLine(), out ruch1);
                if (!a1)
                {
                    Console.WriteLine("Zle dane");
                }

                switch (ruch1)
                {
                    case 1:
                        if (pola[0, 0] != 'X' && pola[0, 0] != 'O')
                        {
                            pola[0, 0] = 'X';
                        }
                        else
                        {
                            RuchX();
                        }
                        return;
                    case 2:
                        if (pola[0, 1] != 'X' && pola[0, 1] != 'O')
                        {
                            pola[0, 1] = 'X';
                        }
                        
                        else
                        {
                            RuchX();
                        }
                        return;
                    case 3:
                        if (pola[0, 2] != 'X' && pola[0, 2] != 'O')
                        {
                            pola[0, 2] = 'X';
                        }
                        else
                        {
                            RuchX();
                        }
                        return;
                    case 4:
                        if (pola[1, 0] != 'X' && pola[1, 0] != 'O')
                        {
                            pola[1, 0] = 'X';
                        }
                        else
                        {
                            RuchX();
                        }
                        return;
                    case 5:
                        if (pola[1, 1] != 'X' && pola[1, 1] != 'O')
                        {
                            pola[1, 1] = 'X';
                        }
                        else
                        {
                            RuchX();
                        }
                        return;
                    case 6:
                        if (pola[1, 2] != 'X' && pola[1, 2] != 'O')
                        {
                            pola[1, 2] = 'X';
                        }
                        else
                        {
                            RuchX();
                        }
                        return;
                    case 7:
                        if (pola[2, 0] != 'X' && pola[2, 0] != 'O')
                        {
                            pola[2, 0] = 'X';
                        }
                        else
                        {
                            RuchX();
                        }
                        return;
                    case 8:
                        if (pola[2, 1] != 'X' && pola[2, 1] != 'O')
                        {
                            pola[2, 1] = 'X';
                        }
                        else
                        {
                            RuchX();
                        }
                        return;
                    case 9:
                        if (pola[2, 2] != 'X' && pola[2, 2] != 'O')
                        {
                            pola[2, 2] = 'X';
                        }
                        else
                        {
                            RuchX();
                        }
                        return;
                }
            }
        }

        public void RuchY()
        {
            if (koniec == false)
            {
                Console.Write("Wprowadz O: ");
                int ruch2;
                bool a1 = int.TryParse(Console.ReadLine(), out ruch2);
                if (!a1)
                {
                    Console.WriteLine("Zle dane");
                }

                switch (ruch2)
                {
                    case 1:

                        if (pola[0, 0] != 'X' && pola[0, 0] != 'O')
                        {
                            pola[0, 0] = 'O';
                        }
                        else
                        {
                            RuchY();
                        }
                        return;
                    case 2:
                        if (pola[0, 1] != 'X' && pola[0, 1] != 'O')
                        {
                            pola[0, 1] = 'O';
                        }
                        else
                        {
                            RuchY();
                        }
                        return;
                    case 3:
                        if (pola[0, 2] != 'X' && pola[0, 2] != 'O')
                        {
                            pola[0, 2] = 'O';
                        }
                        else
                        {
                            RuchY();
                        }
                        return;
                    case 4:
                        if (pola[1, 0] != 'X' && pola[1, 0] != 'O')
                        {
                            pola[1, 0] = 'O';
                        }
                        else
                        {
                            RuchY();
                        }
                        return;
                    case 5:
                        if (pola[1, 1] != 'X' && pola[1, 1] != 'O')
                        {
                            pola[1, 1] = 'O';
                        }
                        else
                        {
                            RuchY();
                        }
                        return;
                    case 6:
                        if (pola[1, 2] != 'X' && pola[1, 2] != 'O')
                        {
                            pola[1, 2] = 'O';
                        }
                        else
                        {
                            RuchY();
                        }
                        return;
                    case 7:
                        if (pola[2, 0] != 'X' && pola[2, 0] != 'O')
                        {
                            pola[2, 0] = 'O';
                        }
                        else
                        {
                            RuchY();
                        }
                        return;
                    case 8:
                        if (pola[2, 2] != 'X' && pola[2, 2] != 'O')
                        {
                            pola[2, 2] = 'O';
                        }
                        else
                        {
                            RuchY();
                        }
                        return;
                    case 9:
                        if (pola[2, 2] != 'X' && pola[2, 2] != 'O')
                        {
                            pola[2, 2] = 'O';
                        }
                        else
                        {
                            RuchY();
                        }
                        return;
                }
            }
        }
    }
}
