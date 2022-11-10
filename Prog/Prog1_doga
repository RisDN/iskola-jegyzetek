namespace Prog1
    // Saját_név_11B_Prog1
{
    class Program
    {



        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Console.ReadKey();

        }


        private static void Feladat1()
        {

            Console.WriteLine("Kérem adja meg a kezdőösszeget: ");
            int kezdoosszeg = int.Parse(Console.ReadLine());
            Console.WriteLine("Kérem adja meg a kamatlábat: ");
            int kamatlab = int.Parse(Console.ReadLine());
            Console.WriteLine("Kérem adja meg az évek (tőkésítések) számát: ");
            int evek = int.Parse(Console.ReadLine());
            double szorzo = (double) (100 + kamatlab) / 100;
            for (int i = 0; i < evek; i++) {
                Console.WriteLine($"{i+1}. év: {Math.Round(kezdoosszeg * Math.Pow(szorzo, i), 2)}");
            }
            Console.WriteLine($"Végösszeg: {Math.Round(kezdoosszeg * Math.Pow(szorzo, evek), 2)}");
  
        }
    

        private static void Feladat2()
        {
            int db = 0;
            for (int i = 10; i < 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    if (i % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.WriteLine(i);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void Feladat3()
        {
            Random rnd = new Random();
            Console.WriteLine("Adjon meg egy nevet: ");
            string nev = Console.ReadLine();
            Console.WriteLine("Adjon meg egy számot 1-10 között: ");
            int szam = int.Parse(Console.ReadLine());
            int randSzam = rnd.Next(1, 10);
            if(szam == randSzam)
            {
                Console.WriteLine("Döntetlen!");
                return;
            }
            Console.WriteLine(szam > randSzam ? $"Nyertél {nev}!" : "A gép nyert!");
        }

        private static void Feladat4()
        {
            Console.WriteLine("Adja meg a sugarat: ");
            double sugar = double.Parse(Console.ReadLine());
            double a = 4 * Math.PI * Math.Pow(sugar, 2);
            Console.WriteLine($"A gömb sugara: {Math.Round(a, 2)}");
            double v = (4*Math.Pow(sugar, 3)*Math.PI) / 3;
            Console.WriteLine($"A gömb felszíne: {Math.Round(v, 2)}");
        }

        private static void Feladat5()
        {
            Random rnd = new Random();
            List<int> csapadek = new List<int>();
            int db = 0;
            int osszeg = 0;
            for(int i = 0; i < 21; i++)
            {
                int randszm = rnd.Next(35, 75);
                osszeg += randszm;
                csapadek.Add(randszm);
                Console.WriteLine($"{i+1}. nap: {randszm}mm");
                if(randszm > 55)
                {
                    db++;
                }
            }
            Console.WriteLine($"A csapadák {db}db alkalommal volt nagyobb mint 55mm.");
        }

        private static void Feladat6()
        {
            Console.WriteLine("Adjon meg egy nevet: ");
            string nev = Console.ReadLine();
            Console.WriteLine("Adja meg pontszámát: ");
            int szam = int.Parse(Console.ReadLine());
            string eredmeny = "";

            if(szam < 0 || szam > 100) { Console.WriteLine("1-100 közötti pontszámot adjon meg!"); Feladat6(); }

            if(szam < 29) {
                eredmeny = "elégtelen";
            }
            if(szam > 30 && szam < 49) {
                eredmeny = "elégséges";
            }
            if (szam > 50 && szam < 69) {
                eredmeny = "közepes";
            }
            if (szam > 70 && szam < 84) {
                eredmeny = "jó";
            }
            if (szam > 85) {
                eredmeny = "jeles";
            }
            
            Console.WriteLine($"{nev}, Önnek a(z) {szam} pontja, {eredmeny} osztályzatot ér el.");
        }

    }
}
