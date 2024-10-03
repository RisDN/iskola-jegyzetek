
using System.Collections.Generic;
using System.IO;

namespace sportolok
{
    internal class Player
    {
        public static List<Player> players = new List<Player>();

        public string Name { get; set; }
        public int Age { get; set; }

        public Player(string name, int age)
        {
            Name = name;
            Age = age;

            players.Add(this);
        }

        public override string ToString()
        {
            return $"{Name}: {Age} éves";
        }

        public static void savePlayers()
        {
            StreamWriter sw = new StreamWriter("players.txt");

            foreach (Player player in players)
            {
                sw.WriteLine($"{player.Name};{player.Age}");
            }

            sw.Close();
        }

        public static void loadPlayers()
        {

            if(!File.Exists("players.txt"))
            {
                return;
            }

            StreamReader sr = new StreamReader("players.txt");

            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(';');
                string name = line[0];
                int age = int.Parse(line[1]);

                new Player(name, age);
            }

            sr.Close();
        }
    }
}
