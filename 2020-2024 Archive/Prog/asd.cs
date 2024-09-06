
namespace Program;

class Program {


    public static string[] names = new string[5];
    static void Main(string[] args) {


        string[] nevek = { "Balázs", "Roland", "Gábor", "János" };
        int[] magassag = { 195, 186, 175, 185 };
        Console.WriteLine("\n");
        for (int i = 0; i < magassag.Length; i++) {
            Console.WriteLine($"{nevek[i]} - {magassag[i]}cm");
        }
        Console.WriteLine("-");
        /*
        int temp;
        string tempname;
        for (int i = 0; i < nevek.Length; i++) {
            for (int j = 0; j < nevek.Length-1; j++) {

                if (magassag[j] < magassag[j + 1]) {
                    temp = magassag[j];
                    tempname = nevek[i];

                    nevek[j] = nevek[j + 1];
                    nevek[j + 1] = tempname;
                    magassag[j] = magassag[j + 1];
                    magassag[j + 1] = temp;
                }

            }
        }*/



        /*
        for (int i = magassag.Length - 1; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (magassag[j] > magassag[j + 1])
                {
                    csere = magassag[j];
                    csereNev = nevek[j];

                    nevek[j] = nevek[j + 1];
                    nevek[j + 1] = csereNev;

                    magassag[j] = magassag[j + 1];
                    magassag[j + 1] = csere;
                }
            }
        }*/


        Console.WriteLine("-");
        string csereNev;
        int tmp;
        for (int i = 0; i < magassag.Length - 1; i++)
        {
            for (int j = i + 1; j < magassag.Length; j++)
            {
                if (magassag[i] > magassag[j])
                {
                    csereNev = nevek[j];

                    nevek[j] = nevek[j + 1];
                    nevek[j + 1] = csereNev;

                    tmp = magassag[j];
                    magassag[j] = magassag[i];
                    magassag[i] = tmp;
                }
            }
        }

        for (int i = 0; i < magassag.Length; i++)
        {
            Console.WriteLine($"{nevek[i]} - {magassag[i]}cm");
        }

        Console.ReadKey();

    }
}

