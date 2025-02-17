using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat_241202
{
    internal class Book
    {
        private static readonly Random random = new Random();

        private long iSBN;
        private string title;
        private int releaseDate;
        private string language;
        private int amount;
        private int price;

        public long ISBN
        {
            get => iSBN;

            set
            {
                if (value.ToString().Length != 10)
                {
                    throw new Exception("ISBN azonosítónak 10 számjegyűnek kell lennie! Megadott: " + value);
                }
                iSBN = value;
            }
        }

        public List<Author> Authors { get; set; }
        public string Title { get => title; set {
                if (value.Length < 3 || value.Length > 64)
                {
                    throw new Exception("A title-nek 3 és 64 közötti hosszúságnak kell lennie. Megadott: " + value + " (" + value.Length + ")");
                }
                title = value;
            } }
        public int ReleaseDate { get => releaseDate; set {
                if (value < 2007 || value > DateTime.Now.Year)
                {
                    throw new Exception("A ReleaseDate-nek 2007 és" + DateTime.Now.Year + " között kell lennie. Megadott: " + value);
                }
                releaseDate = value;
            } }
        public string Language { get => language; set {
                if(!value.Equals("angol") && !value.Equals("magyar") && !value.Equals("német"))
                {
                    throw new Exception("A Language-nek csak 'magyar', 'angol', 'német' értéket lehet adni. Megadott: " + value);
                }
                language = value;
            } }
        public int Amount { get => amount; set {
                if(value < 0)
                {
                    throw new Exception("A Amount-nak pozitív számnak kell lennie. Megadott: " + value);
                }
                amount = value;
            } }
        // - ár (1000 és 10000 közötti, kerek 100as szám)
        public int Price { get => price; set {
                if(value < 1000 || value > 10000 || value % 100 != 0)
                {
                throw new Exception("Az árnak 1000 és 10000 közötti, kerek 100as számúnak kell lennie. Megadott: " + value);
                }
                price = value;
            } }


        public Book(long iSBN, string title, int releaseDate, string language, int amount, int price, params string[] authors)
        {
            ISBN = iSBN;
            Title = title;
            ReleaseDate = releaseDate;
            Language = language;
            Amount = amount;
            Price = price;
            Authors = new List<Author>();
            if (authors.Length > 3 || authors.Length < 1)
            {
                throw new Exception("Egy könyvnek min 1, max 3 szerzője lehet! Megadott:" + authors.Length);
            }
            Console.WriteLine(authors[0]);
            foreach(string author in authors)
            {
                Authors.Add(new Author(author));
            }
        }

        public Book(string title, string author)
        {
            ISBN = (long) random.Next(1000000000, 999999999);
            Title = title;
            ReleaseDate = 2024;
            Language = "magyar";
            Amount = 0;
            Price = 4500;
            Authors.Add(new Author(author));
        }
        public override string ToString()
        {
            string authors = "szerzők: ";
            if (Authors.Count == 1)
            {
                authors = "szerző: ";
            }
            string amount = Amount + " db";
            if (Amount == 0)
            {
                amount = "beszerzés alatt";
            }

            string authorNames = "";

            foreach(var author in Authors)
            {
                authorNames += author + ", ";
            }

            authorNames = authorNames.Remove(authorNames.Length - 2);   

            return "\nISBN: " + ISBN + "\n" +
                "Cím: " + Title + "\n" +
                "Megjelenés éve: " + ReleaseDate + "\n" +
                "Nyelv: " + Language + "\n" +
                authors + authorNames + "\n" +
                "Készlet: " + amount + "\n" +
                "Ár: " + Price + " Ft";
        }
    }
}
