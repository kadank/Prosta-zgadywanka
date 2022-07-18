using System;

namespace zgadula
{
    class Program
    {
        class zgadula
        {
            private int szukana, odp, licznik;
            public void gra()
            {
                Random rnd = new Random();
                szukana = rnd.Next(1, 20);
                licznik = 0;
                do
                {
                    Console.WriteLine("zgadnij liczbę z zakresu 1-20");
                    odp = int.Parse(Console.ReadLine()) ;
                    licznik++;
                        if(odp > szukana)
                    {
                        Console.WriteLine("Za duża");
                    }
                        else if(odp < szukana)
                    {
                        Console.WriteLine("Za mała");
                    }
                    else
                    {
                        Console.WriteLine("oł je zgadłeś");
                        Console.WriteLine("Liczba prob:");
                        Console.WriteLine(licznik);
                    }

                }
                while (odp != szukana);
            }
            
        }
       
        


        static void Main(string[] args)
        {
            zgadula z = new zgadula();
            z.gra();
        }
    }

}
