class Program {


    public static void Main(string[] args) {

        StreamReader rd = new StreamReader(@"chi.txt");
        while (!rd.EndOfStream) {
            new Chi(rd.ReadLine());
        }
        rd.Close();

        List<Chi> list = Chi.getChis();

		Console.WriteLine("2. feladat: ");
        Console.WriteLine($"Összesen {Chi.getChisCount()} db csincsilla van.");


        Console.WriteLine("\n3. feladat");
        int count = 0;
        foreach (Chi chi in list) {
            if(!chi.getLikesPet().Equals(Pet.Y)) {
                continue;
			}
            count++;
        }
        double likes = (double) count / Chi.getChisCount() * 100;
		Console.WriteLine($"{count} A csincsillák {likes:0.00}%-a szereti, ha simogatják.");

        Console.WriteLine("\n4. feladat");

        Chi searched = null;
        foreach (Chi chi in list) {
            if (chi.getYearsOld() >= 8 && chi.getWeight() < 360) {
                searched = chi;
			}
        }

        if (searched != null) {
            Console.WriteLine($"{searched.getName()} {searched.getYearsOld()} éves és {searched.getWeight()} gramm.");
        }
        else {
            Console.WriteLine("Nincs ilyen csincsilla.");
        }

		Console.WriteLine("5. feladat");

        List<Chi> sorted = list.OrderBy(o => o.getWeight()).ToList();
        sorted.Reverse();
        for (int i = 0; i < 5; i++) {
            Console.WriteLine($"{i+1}. {sorted[i].getName()}\t  {sorted[i].getWeight()} g");
        }

        Dictionary<string, int> borns = new Dictionary<string, int>();
        foreach(Chi chi in list) {
            string year = Convert.ToString(chi.getBorn().Year);
            if (borns.ContainsKey(year)) {
                borns[year]++;
                continue;
            }
            borns[year] = 1;
		}

        StreamWriter writer = new StreamWriter(@"evek.txt");
        foreach(var born in borns) {
            writer.WriteLine($"{born.Key}: {born.Value}");
        }
        writer.Close();


    }


}

class Chi {

    private static List<Chi> list = new List<Chi>(); 

    private string name;
    private DateTime born;
    private int weight;
    private Pet likesPet;

    public Chi(string line) {

        string[] splitted = line.Split(";");
        name = splitted[0];
        born = DateTime.Parse(splitted[1]);
        weight = int.Parse(splitted[2]);
        likesPet = getPetState(splitted[3]);

        list.Add(this);
    }

    public string getName() {
        return this.name;
    }

    public DateTime getBorn() {
        return this.born;
    }

    public int getWeight() {
        return this.weight;
    }

    public Pet getLikesPet() {
        return this.likesPet;
    }

    public int getYearsOld() {
        return DateTime.Now.Year - getBorn().Year;
    }


    public static Pet getPetState(String type) {
        return type.Equals("I") ? Pet.Y : Pet.N;
    }

    public static List<Chi> getChis() {
        return list;
    }

    public static int getChisCount() {
        return getChis().Count;
	}

}

public enum Pet {
    Y,
    N
}