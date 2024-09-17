using haziallatok;

namespace Program
{
    class Program
    {
       public static void Main(string[] args) {
            
            List<Pet> pets = new List<Pet>();
            #region
            pets.Add(new Pet()
            {
                Name = "Mr. Wick",
                Species = "Hamster",
                BirthDate = new(2022, 05, 05),
                Sex = true
            });
            pets.Add(new Pet()
            {
                Name = "Ferenc",
                Species = "Cat",
                BirthDate = new(2018, 01, 02),
                Sex = false,
            });

            pets.Add(new Pet()
            {
                Name = "Maci",
                Species = "Dog",
                BirthDate = new(2019, 11, 10),
                Sex = true,
            });

            pets.Add(new Pet()
            {
                Name = "Macska",
                Species = "Cat",
                BirthDate = new(2024, 02, 10),
                Sex = false,
            });

            pets.Add(new Pet()
            {
                Name = "Hal",
                Species = "Fish",
                BirthDate = new(2005, 04, 15),
                Sex = true,
            });

            pets.Add(new Pet()
            {
                Name = "Sziszi",
                Species = "Dog",
                BirthDate = new(2022, 09, 20),
                Sex = false,
            });

            pets.Add(new Pet()
            {
                Name = "Csirke",
                Species = "Chicken",
                BirthDate = new(2020, 08, 05),
                Sex = false,
            });
            #endregion

            List<Pet> dogsOnly = pets.Where(p => p.Species == "Dog").ToList(); // kivalogatas
            int dogCount = pets.Count(p => p.Species == "Dog"); // megszamlalas
            Console.WriteLine($"Kutyák száma: {dogCount} vagy másképp: {dogsOnly.Count}");

            Pet firstCat = pets.Where(p => p.Species == "Cat").FirstOrDefault();
            Console.WriteLine("Első cica: " + firstCat.Name);

            double sum = pets.Sum(p => p.Age); // osszegzes
            double avarage = pets.Average(p => p.Age); // atlag
            Console.WriteLine($"Átlag korosztály: {sum / pets.Count:0.00} vagy másképp: {avarage:0.00}");

            int femaleCats = pets.Count(p => p.Species == "Cat" && p.Sex); // szures
            Console.WriteLine($"Nőstény cicák: {femaleCats}");

            Pet nevsorbanAzElso = pets.MinBy(p => p.Name);
            Console.WriteLine(nevsorbanAzElso.Name);
        }

    }

}