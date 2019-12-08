using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1

{

    public class Class1
    {
        public static float StanKonta;
        /// <summary>
        /// Wypłata sumy z konta podana w pole Wyplacana suma
        /// </summary>
        /// <param name="WyplacanaSuma"></param>
        public void Wyplata(float WyplacanaSuma)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine("Operacja wypłacenie: " + WyplacanaSuma);
            if (WyplacanaSuma > StanKonta || WyplacanaSuma<=0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                StanKonta = StanKonta - WyplacanaSuma;
            }
            
            
        }
        /// <summary>
        /// Wpłata sumy na konto podana w pole Wplacana suma
        /// </summary>
        /// <param name="WplacanaSuma"></param>
        public void Wplata(float WplacanaSuma)
        {
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            
            Console.WriteLine("Operacja wpłacanie: " + WplacanaSuma);
            if (WplacanaSuma <=0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                StanKonta = StanKonta + WplacanaSuma;
            }
            
        }
        /// <summary>
        /// Wyswietla Stan konta
        /// </summary>
        public void StanKontaWyswietl()
        {
            
            Console.Write(StanKonta);
        }
    }
}
