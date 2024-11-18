namespace berek2020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader(@"berek2020.txt");

            if(streamReader == null)
            {
                Console.WriteLine("File not found!");
                return;
            }

            bool isFirstline = true;
            while (!streamReader.EndOfStream)
            {
                string[] line = streamReader.ReadLine().Split(';');
                if(isFirstline)
                {
                   isFirstline = false;
                    continue;
                }
                new Employee(line[0], line[1] == "férfi", line[2], line[3], int.Parse(line[4]));
            }


            Console.WriteLine($"3. feladat: Dolgozók száma: {Employee.employees.Count} fő.");

            double avarageSalary = (Employee.employees.Sum(e => e.Salary) / Employee.employees.Count) / 1000;

            Console.WriteLine($"4. feladat: Bérek átlaga: {avarageSalary:0.0} eFt");

            Console.Write("5. feladat: Kérem a részleg nevét: ");

            string positionInput = Console.ReadLine();
            List<Employee> positions = Employee.employees.FindAll(e => e.Position.Equals(positionInput));

            while (positions.Count <= 0)
            {

                Console.WriteLine("A megadott részleg nem létezik a cégnél!");
                Console.Write("5. feladat: Kérem a részleg nevét: ");
                positionInput = Console.ReadLine();
                positions = Employee.employees.FindAll(e => e.Position.Equals(positionInput));
            }

            Employee withHighestSalary = positions.MaxBy(e => e.Salary);

            if(withHighestSalary == null)
            {
                return;
            }

            Console.WriteLine("6. feladat: ");
            Console.WriteLine("A legtöbbet kereső dolgozó a megadott részlegen:");
            Console.WriteLine($"\tNév: {withHighestSalary.Name}");
            Console.WriteLine($"\tNem: {withHighestSalary.SexToString()}");
            Console.WriteLine($"\tBelépés: {withHighestSalary.SinceYear}");
            Console.WriteLine($"\tBér {withHighestSalary.Salary} Forint");

            Console.WriteLine("7. Feladat: Statisztika");
            var positionPopularity = Employee.employees.Select(e => e.Position);
            foreach(var position in positionPopularity.Distinct())
            {
                Console.WriteLine($"\t{position} - {Employee.employees.Count(e => e.Position.Equals(position))} fő");
            }
        }
    }
}
