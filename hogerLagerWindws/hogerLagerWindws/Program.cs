using System;

namespace hogerLagerWindws
{
    class Program
    {
        static void Main(string[] args)
        {
            int programStop = 1;
            Console.WriteLine("SPEL: HOGER/LAGER");
            while (programStop != 0)
            {
                int getalOnder = 0;
                int getalBoven = 0;
                Console.WriteLine();
                while (getalOnder >= getalBoven)
                {
                    Console.Write("Geef een positief (int) getal voor de ondergrens: ");
                    getalOnder = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Geef een positief (int) getal voor de bovengrens: ");
                    getalBoven = Convert.ToInt32(Console.ReadLine());
                    if (getalBoven <= getalOnder)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Vul een getal in dat hoger ligt dan de ondergrens.");
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }

                Console.WriteLine();
                //willekeurig getal genereren van getalOnder t.e.m. getal+1
                Random rnd = new Random();
                int getal = rnd.Next(getalOnder, getalBoven + 1);
                //invoer getal
                Console.WriteLine("Raad een getal tussen {0} en {1}. (inclusief deze getallen)", getalOnder, getalBoven);
                int raadGetal = Convert.ToInt16(Console.ReadLine());
                int raadTeller = 1;
                //controleren met behulp van de selectie
                while (getal != raadGetal)
                {
                    if (getalOnder <= raadGetal && raadGetal <= getalBoven)
                    {

                        if (raadGetal < getal)
                        {
                            Console.WriteLine("Hoger!");

                        }
                        else
                        {
                            Console.WriteLine("Lager!");
                        }
                        raadTeller++;
                    }
                    else
                    {
                        Console.WriteLine("Vul een getal in dat zich tussen deze waardes bevind.");
                    }
                    Console.Write("Raad opnieuw: ");
                    raadGetal = Convert.ToInt16(Console.ReadLine());
                }
                Console.WriteLine();
                Console.WriteLine("Juist geraden!");
                Console.WriteLine();
                Console.WriteLine("U heeft hiervoor " + raadTeller + " keer moeten raden.");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("VUL 0 IN OM HET PROGRAMMA TE STOPPEN, VUL 1 IN OM OPNIEUW TE SPELEN: ");
                programStop = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
