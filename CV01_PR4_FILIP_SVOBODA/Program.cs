using System;

namespace CV01_PR4_FILIP_SVOBODA
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
                Random random = new Random();
                int Náhodné_číslo = random.Next(0, 100);
                int i = 0;
                Console.WriteLine("Hádej číslo 1-100");
                while (i != 10) 
                {
                    string HC = Console.ReadLine();
                    int Hádané_číslo = Int32.Parse(HC);
                    i++;
                    if (Náhodné_číslo > Hádané_číslo) 
                    {
                        Console.WriteLine("Číslo je větší hadej znovu");
                    }
                    if (Náhodné_číslo < Hádané_číslo) 
                    {
                        Console.WriteLine("Číslo je menší hadej znovu");
                    }
                    if (Náhodné_číslo == Hádané_číslo)
                    {
                        Console.WriteLine("Uhodl a Vyhrál jsi");
                        break;
                    }
                }
                if (i == 10) 
                {
                Console.WriteLine("Bohužel jsi překročil 10 pokusů prohrál jsi");
                }
                /*Console.WriteLine("Chceš hrát znovu? 0-NO 1-YES");
                int a = Console.Read();
                if (a == 0) 
                {
                    break;
                }
                if (a == 1) 
                {
                    continue;
                }
                */
            }
        }
    }
}
