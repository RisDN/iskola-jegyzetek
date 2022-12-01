namespace Cica
{
    class Program
    {
        static void Main(string[] args) {
            
            Console.Write("Add meg a számot: ");
            int szam = int.Parse(Console.ReadLine());
            Console.Write($"Add meg a {szam} számrendszerét: ");
            int szamrendszer = int.Parse(Console.ReadLine());

            List<char> chars = new List<char>();
            chars.AddRange(szam.ToString());;

            foreach (var num in chars) {
                if(Char.GetNumericValue(num) >= szamrendszer) {
                    Console.WriteLine($"A(z) {szamrendszer}-es számrendszerben nem lehet {Char.GetNumericValue(num)} szám.!");
                    return;
                }
            }

            int db = szam.ToString().Length;
            double ertek = 0;
            for(int i = 0; i < szam.ToString().Length; i++) {

                db--;
                int szamkent = (int) Char.GetNumericValue(chars[i]);
                Console.WriteLine($"{szamkent}*{szamrendszer}^{db}");

                ertek += szamkent * Math.Pow(szamrendszer, db);
                

            }
            Console.WriteLine("\nVégérték: " + ertek);

        }
    }
}
