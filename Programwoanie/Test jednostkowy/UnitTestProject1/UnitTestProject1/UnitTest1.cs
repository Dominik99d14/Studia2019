using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /*
         * 
         * Te testy sprawdzają czy Class1 wyrzuca prawidłowo wyjątek w momencie podania złych danych do programu.
         * Aby uruchomić test nalezy wyszukać w programie "eksplorator testów"/"test explorer" i w nim nacisnać "uruchom wszystkie"/"run all"
         */

        /*
        Testowanie Funkcji Wyplata()
            TESTY - Zadaniem testów jest sprawdzenie czy program wyrzuca wyjątki.

            TestWplata1 - On wyrzuca błąd ponieważ podaliśmy dobre dane i nie wykryto żadnego wyjątku 

            TestWplata2 - On działa ponieważ wprowadziliśmy złe dane test wykrył argument i test się udał

            TestWplata3 - On działa ponieważ wprowadziliśmy złe dane test wykrył argument i test się udał
        */

        [TestMethod]
        public void TestWplata1()
        {
            Class1 konto = new Class1();
            try
            {
                konto.Wplata(1000);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException a)
            {
                Console.WriteLine(a);
            }
        }

        [TestMethod]
        public void TestWplata2()
        {
            Class1 konto = new Class1();
            try
            {
                konto.Wplata(-1000);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException a)
            {
                Console.WriteLine(a);
            }
        }

        [TestMethod]
        public void TestWplata3()
        {
            Class1 konto = new Class1();
            try
            {
                konto.Wplata(0);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException a)
            {
                Console.WriteLine(a);
            }
        }


        /*
        Testowanie Funkcji Wyplata()
            TESTY - Zadaniem testów jest sprawdzenie czy program wyrzuca wyjątki.

            TestWyplata1 - On wyrzuca błąd ponieważ podaliśmy dobre dane i nie wykryto żadnego wyjątku 

            TestWyplata2 - On działa ponieważ wprowadziliśmy złe dane test wykrył argument i test się udał

            TestWyplata3 - On działa ponieważ wprowadziliśmy złe dane test wykrył argument i test się udał
        */

        [TestMethod]
        public void TestWyplata1()
        {
            Class1 konto = new Class1();
            try
            {
                konto.Wyplata(1000);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException a)
            {
                Console.WriteLine(a);
            }
        }

        [TestMethod]
        public void TestWyplata2()
        {
            Class1 konto = new Class1();
            try
            {
                konto.Wyplata(-1000);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException a)
            {
                Console.WriteLine(a);
            }
        }

        [TestMethod]
        public void TestWyplata3()
        {
            Class1 konto = new Class1();
            try
            {
                konto.Wyplata(0);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException a)
            {
                Console.WriteLine(a);
            }
        }

    }
}
