using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Diagnostics;
using System.IO;

namespace Projekt
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Kalkulator
        private void Wynik(object sender, RoutedEventArgs e)
        {
            string tablica = Table.Text;
            string TablicaDlaProgramu = Table.Text;
            int LengthTablica = tablica.Length;
            StringBuilder Zadanie = new StringBuilder(tablica);
            try
            {
                ErrorWiadomosc.Visibility = Visibility.Hidden;
                for (int i = 0; i < Zadanie.Length; i++)
                {
                    if (Zadanie[i] == ',')
                    {
                        Zadanie[i] = '.';
                    }
                }

                for (int SpradzanieFunkcji = 0; SpradzanieFunkcji < tablica.Length; SpradzanieFunkcji++)
                {
                    //Funkcje Dodatkowe
                    if (TablicaDlaProgramu.Contains("Delta("))
                    {
                        int Start = TablicaDlaProgramu.IndexOf("Delta(");
                        int StartNawiasu = TablicaDlaProgramu.IndexOf("Delta(") + "Delta(".Length;
                        int Koniec = TablicaDlaProgramu.IndexOf(")");
                        int length = Koniec - StartNawiasu;
                        string zmienne = "";
                        StringBuilder zmienneX = new StringBuilder(TablicaDlaProgramu);

                        for (int x = 0; x < length; x++)
                        {
                            zmienne = zmienne + TablicaDlaProgramu[x + StartNawiasu];
                        }

                        string ZmiennaA = "";
                        string ZmiennaB = "";
                        string ZmiennaC = "";
                        int NumerZmiennej = 1;
                        for (int z = 0; z < zmienne.Length; z++)
                        {
                            if (zmienne[z] == '.' || zmienne[z] == ',')
                            {
                                NumerZmiennej++;

                            }
                            else
                            {
                                if (NumerZmiennej == 1)
                                {
                                    ZmiennaA = ZmiennaA + zmienne[z];
                                }
                                if (NumerZmiennej == 2)
                                {
                                    ZmiennaB = ZmiennaB + zmienne[z];
                                }
                                if (NumerZmiennej == 3)
                                {
                                    ZmiennaC = ZmiennaC + zmienne[z];
                                }
                            }

                        }



                        string wynik = "(" + ZmiennaB + "*" + ZmiennaB + ")-4*" + ZmiennaA + "*" + ZmiennaC;
                        string WynikDelta = new DataTable().Compute(wynik, null).ToString();



                        string reszta = TablicaDlaProgramu.Substring(Koniec + 1, TablicaDlaProgramu.Length - Koniec - 1);
                        TablicaDlaProgramu = TablicaDlaProgramu.Substring(0, Start) + WynikDelta + TablicaDlaProgramu.Substring(Koniec + 1, TablicaDlaProgramu.Length - Koniec - 1);


                    }

                    if (TablicaDlaProgramu.Contains("Potegowanie("))
                    {
                        int Start = TablicaDlaProgramu.IndexOf("Potegowanie(");

                        int StartNawiasu = TablicaDlaProgramu.IndexOf("Potegowanie(") + "Potegowanie(".Length;
                        int Koniec = TablicaDlaProgramu.IndexOf(")");
                        int length = Koniec - StartNawiasu;
                        int KolejnoscPobieraniaDanych = 1;
                        string LiczbaPotengowana = " ";
                        string StopienPotegi = " ";
                        string zmienne = "";

                        for (int x = 0; x < length; x++)
                        {
                            zmienne = zmienne + TablicaDlaProgramu[x + StartNawiasu];
                        }

                        for (int z = 0; z < zmienne.Length; z++)
                        {
                            if (zmienne[z] == '.' || zmienne[z] == ',')
                            {
                                KolejnoscPobieraniaDanych++;

                            }
                            else
                            {
                                if (KolejnoscPobieraniaDanych == 1)
                                {
                                    LiczbaPotengowana = LiczbaPotengowana + zmienne[z];
                                }
                                if (KolejnoscPobieraniaDanych == 2)
                                {
                                    StopienPotegi = StopienPotegi + zmienne[z];
                                }

                            }
                        }
                        float Liczba = float.Parse(LiczbaPotengowana);
                        float potega = float.Parse(StopienPotegi);
                        float Wynik = 1;
                        for (int potegowanie = 0; potegowanie < potega; potegowanie++)
                        {
                            Wynik = Wynik * Liczba;
                        }

                        string reszta = TablicaDlaProgramu.Substring(Koniec + 1, TablicaDlaProgramu.Length - Koniec - 1);
                        TablicaDlaProgramu = TablicaDlaProgramu.Substring(0, Start) + Wynik.ToString() + TablicaDlaProgramu.Substring(Koniec + 1, TablicaDlaProgramu.Length - Koniec - 1);
                    }

                    if (TablicaDlaProgramu.Contains("PoleProstokąta("))
                    {
                        int Start = TablicaDlaProgramu.IndexOf("PoleProstokąta(");

                        int StartNawiasu = TablicaDlaProgramu.IndexOf("PoleProstokąta(") + "PoleProstokąta(".Length;
                        int Koniec = TablicaDlaProgramu.IndexOf(")");
                        int length = Koniec - StartNawiasu;
                        int KolejnoscPobieraniaDanych = 1;
                        string A = " ";
                        string B = " ";
                        string zmienne = "";

                        for (int x = 0; x < length; x++)
                        {
                            zmienne = zmienne + TablicaDlaProgramu[x + StartNawiasu];
                        }

                        for (int z = 0; z < zmienne.Length; z++)
                        {
                            if (zmienne[z] == '.' || zmienne[z] == ',')
                            {
                                KolejnoscPobieraniaDanych++;

                            }
                            else
                            {
                                if (KolejnoscPobieraniaDanych == 1)
                                {
                                    A = A + zmienne[z];
                                }
                                if (KolejnoscPobieraniaDanych == 2)
                                {
                                    B = B + zmienne[z];
                                }

                            }
                        }
                        float LiczbaA = float.Parse(A);
                        float LiczbaB = float.Parse(B);
                        float Wynik;

                        Wynik = LiczbaA * LiczbaB;

                        string reszta = TablicaDlaProgramu.Substring(Koniec + 1, TablicaDlaProgramu.Length - Koniec - 1);
                        TablicaDlaProgramu = TablicaDlaProgramu.Substring(0, Start) + Wynik.ToString() + TablicaDlaProgramu.Substring(Koniec + 1, TablicaDlaProgramu.Length - Koniec - 1);
                    }

                    if (TablicaDlaProgramu.Contains("PoleTrojkonta("))
                    {
                        int Start = TablicaDlaProgramu.IndexOf("PoleTrojkonta(");

                        int StartNawiasu = TablicaDlaProgramu.IndexOf("PoleTrojkonta(") + "PoleTrojkonta(".Length;
                        int Koniec = TablicaDlaProgramu.IndexOf(")");
                        int length = Koniec - StartNawiasu;
                        int KolejnoscPobieraniaDanych = 1;
                        string A = " ";
                        string h = " ";
                        string zmienne = "";

                        for (int x = 0; x < length; x++)
                        {
                            zmienne = zmienne + TablicaDlaProgramu[x + StartNawiasu];
                        }

                        for (int z = 0; z < zmienne.Length; z++)
                        {
                            if (zmienne[z] == '.' || zmienne[z] == ',')
                            {
                                KolejnoscPobieraniaDanych++;

                            }
                            else
                            {
                                if (KolejnoscPobieraniaDanych == 1)
                                {
                                    A = A + zmienne[z];
                                }
                                if (KolejnoscPobieraniaDanych == 2)
                                {
                                    h = h + zmienne[z];
                                }

                            }
                        }
                        float LiczbaA = float.Parse(A);
                        float LiczbaB = float.Parse(h);
                        float Wynik;

                        Wynik = (LiczbaA * LiczbaB)/2;

                        string reszta = TablicaDlaProgramu.Substring(Koniec + 1, TablicaDlaProgramu.Length - Koniec - 1);
                        TablicaDlaProgramu = TablicaDlaProgramu.Substring(0, Start) + Wynik.ToString() + TablicaDlaProgramu.Substring(Koniec + 1, TablicaDlaProgramu.Length - Koniec - 1);
                    }
                }


                string WynikX = new DataTable().Compute(TablicaDlaProgramu, null).ToString();

                WynikText.Content = WynikX;
            }
            catch
            {
                ErrorWiadomosc.Visibility = Visibility.Visible;
                ErrorWiadomosc.Content = "UWAGA: Coś poszło nie tak. Prawdopodobnie podałeś złe dane";
            }
        }
        //Wklejanie opcji
        private void DeltaWklej(object sender, RoutedEventArgs e)
        {
            Table.Text = Table.Text + "Delta(a,b,c)";
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            Table.Text = Table.Text + "+";
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            Table.Text = Table.Text + "-";
        }

        private void MnozenieButton_Click(object sender, RoutedEventArgs e)
        {
            Table.Text = Table.Text + "*";
        }

        private void DzielenieButton_Click(object sender, RoutedEventArgs e)
        {
            Table.Text = Table.Text + "/";
        }
        private void PierwiastekWklej(object sender, RoutedEventArgs e)
        {
            Table.Text = Table.Text + "Potegowanie(liczba,stopień)";
        }

        private void PoleProstokonta_Click(object sender, RoutedEventArgs e)
        {
            Table.Text = Table.Text + "PoleProstokąta(A,B)";
        }

        private void PoleTrojkonta_Click(object sender, RoutedEventArgs e)
        {
            Table.Text = Table.Text + "PoleTrojkonta(a,h)";
        }
        //MENU OPCJE
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Kalulator.Visibility = Visibility.Visible;
            Kalkulator_Informatyczny.Visibility = Visibility.Hidden;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Kalulator.Visibility = Visibility.Hidden;
            Kalkulator_Informatyczny.Visibility = Visibility.Visible;

        }


        //Kalkulator Informatyczny
        
        private void LiczSystemy(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("sda");
            string liczba = Systemy_Tablica.Text;
            try
            {
                BledyProgramisty.Visibility = Visibility.Hidden;
                if (SystemDziesietny.IsChecked == true)
                {
                    int liczba2 = int.Parse(liczba);
                    Dziesietne.Text = liczba2.ToString();
                    Binarny(liczba2);
                    Osemkowy(liczba2);
                    Szesnastkowy(liczba2);
                }
                if (SystemDwojkowy.IsChecked == true)
                {
                    int liczba2 = int.Parse(liczba);
                    Dziesietny(liczba2, 2);
                    Binarne.Text = liczba2.ToString();
                    liczba2 = Convert.ToInt32(Dziesietne.Text);
                    Osemkowy(liczba2);
                    Szesnastkowy(liczba2);
                }
                if (SystemOsemkowy.IsChecked == true)
                {
                    int liczba2 = int.Parse(liczba);
                    Dziesietny(liczba2, 8);
                    Osemkowe.Text = liczba2.ToString();
                    liczba2 = Convert.ToInt32(Dziesietne.Text);
                    Binarny(liczba2);
                    Szesnastkowy(liczba2);
                }
                if (SystemSzesnastkowa.IsChecked == true)
                {
                    Dziesietne.Text = Convert.ToInt32(liczba, 16).ToString();
                    Szesnastkowe.Text = liczba.ToString();
                    int liczba2 = int.Parse(Dziesietne.Text);
                    Osemkowy(liczba2);
                    Binarny(liczba2);
                }
            }
            catch
            {
                BledyProgramisty.Visibility = Visibility.Visible;
                BledyProgramisty.Content = "UWAGA: Coś poszło nie tak. Prawdopodobnie podałeś złe dane";
            }
        }

        private void Binarny(int liczba)
        {
            Binarne.Text = Convert.ToString(liczba, 2);
        }

        private void Osemkowy(int liczba)
        {
            Osemkowe.Text = Convert.ToString(liczba, 8);
        }

        private void Szesnastkowy(int liczba)
        {
            Szesnastkowe.Text = Convert.ToString(liczba, 16);           
        }

        private void Dziesietny(int liczba, int stpien)
        {

            string liczba2 = liczba.ToString();
            Dziesietne.Text = Convert.ToInt32(liczba2,2).ToString();
        }

        //Wczytywanie z pliku
        private void WczytanieZPliku_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ErrorWiadomosc.Visibility = Visibility.Hidden;
                using (StreamReader sr = new StreamReader(NazwaPliku.Text+".txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    Table.Text = line;
                }
            }
            catch
            {
                ErrorWiadomosc.Visibility = Visibility.Visible;
                ErrorWiadomosc.Content = "UWAGA: Coś poszło nie tak. Prawdopodobnie podałeś złe dane";
            }

        }
        //Zapis do pliku
        private void ZapisDoPliku_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ErrorWiadomosc.Visibility = Visibility.Hidden;
                if (!File.Exists(NazwaPliku.Text))
                {
                    using (FileStream fs = File.Create(NazwaPliku.Text))
                    {

                        using (StreamWriter sw = new StreamWriter(NazwaPliku.Text + ".txt"))
                        {
                            sw.WriteLine(Table.Text);
                        }

                    }
                }
            }
            catch
            {
                ErrorWiadomosc.Visibility = Visibility.Visible;
                ErrorWiadomosc.Content = "UWAGA: Coś poszło nie tak. Prawdopodobnie podałeś złe dane";
            }
        }

       
    }
}
