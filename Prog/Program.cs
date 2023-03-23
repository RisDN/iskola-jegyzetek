class Program {
    

    private static List<Stadium> stadiums = new List<Stadium>();
    public static void Main(string[] args) {
       
       // 2.
        string[] lines = File.ReadAllLines("vb2018.txt");
        foreach (string line in lines) {
            stadiums.Add(new Stadium(line));
        }

        // 3.
        Console.WriteLine("3. feladat: Stadionok száma: " + getAmounts());

        // 4.
        Console.WriteLine("4. feladat: A legkevesebb férőhely: ");
        Stadium smallest = getSmallest();
        Console.WriteLine("     Város: " + smallest.getCity());
        Console.WriteLine("     Stadion neve: " + smallest.getName1());
        Console.WriteLine("     Férőhely: " + smallest.getSize());


        // 5.
        Console.WriteLine("Átlagos férőhelyszám: " + getAvarageSize());

        // 6.
        Console.WriteLine("Két néven is ismert stadionok száma: " + getDobleNameCount());

        // 7.
    
        string city = "";
        Console.Write("\nKérem a város nevét: ");
        goto asd;
        asd:
            city = Console.ReadLine();
            if(city.Length < 3) {
                goto asd;
            }
        
        // 8
        Console.WriteLine(isVbPlace(city) ? "8. feladat: A megadott város VB helyszín" : "8. feladat: A megadott város nem VB helyszín");
        
    }

    public static Boolean isVbPlace(string city) {
        foreach (Stadium item in stadiums) {   
            if(item.getCity().ToLower().Equals(city.ToLower())) {
                return true;
            }
        }
        return false;
    }

    public static Stadium? getStadiumByCity(string city) {

        foreach (Stadium item in stadiums) {   
            if(item.getCity().ToLower().Equals(city.ToLower())) {
                return item;
            }
        }
        return null;

    }

    public static int getDobleNameCount() {
        int count = 0;
        foreach (Stadium item in stadiums) {   
            if(item.getName2().Equals("n.a.")) {
                continue;
            }
            count++;
        }
        return count;
    }

    public static int getAmounts() {
        return stadiums.Count();
    }

    public static double getAvarageSize() {
        int sum = 0;
        foreach (Stadium item in stadiums) {   
            sum += item.getSize();
        }
        return sum / getAmounts();
    }

    public static Stadium getSmallest() {
        int min = int.MaxValue;
        int index = 0;
        for(int i = 0; i < stadiums.Count(); i++) {
            if(min > stadiums[i].getSize()) {
                min = stadiums[i].getSize();
                index = i;
            }
        }

        return stadiums[index];
    }

}