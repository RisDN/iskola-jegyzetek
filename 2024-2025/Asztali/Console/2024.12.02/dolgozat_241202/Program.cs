using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat_241202
{
    internal class Program
    {

        private static readonly Random random = new Random();

        static void Main(string[] args)
        {

            List<Book> books = new List<Book>();
            for (int i = 0; i < 15; i++)
            {
                string language;
                if (random.Next(0, 100) < 80)
                {
                    language = "magyar";
                }
                else
                {
                    language = "angol";
                }

                string title = FakeNames.GetRandom(language);

                string ISBN = "";
                do
                {
        
                    ISBN = random.Next(999999999, int.MaxValue).ToString();
                } while (books.Any(x => x.ISBN.ToString() == ISBN));
                int releaseDate = random.Next(2007, DateTime.Now.Year);

                int amount;
                if (random.Next(0, 100) < 30)
                {
                    amount = 0;
                }
                else
                {
                    amount = random.Next(5, 10);
                }

                string[] authors = FakeNames.GetRandomAuthor(random.Next(1, 4));
                int price = 0;

                do
                {
                    price = random.Next(1000, 5000);
                } while (price % 100 != 0);

                Book book = new Book(long.Parse(ISBN),
                    title,
                    releaseDate,
                    language,
                    amount,
                    price,
                    authors
                );
   

                books.Add(book);

            }

            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }


            Console.WriteLine("\nEmuláció eredményei:");
            int income = 0;
            int soldBooks = 0;
            int totalBooks = books.Sum(x => x.Amount);
            for (int i = 0; i < 100; i++)
            {
                Book book = books[random.Next(0, books.Count)];
                if (book.Amount > 0)
                {
                    book.Amount--; 
                    income += book.Price;
                    soldBooks++;
                }
                else
                {
                    if (random.Next(0, 100) < 50)
                    {
                        book.Amount += random.Next(1, 10);
                    }
                    else
                    {
                        books.Remove(book);
                    }
                }
            }
            
            Console.WriteLine("Bevétel: " + income + " Ft");
            Console.WriteLine("Eladott könyvek: " + soldBooks);
            Console.WriteLine("Kezdeti készlet: " + totalBooks);
            Console.WriteLine("Végleges készlet: " + books.Sum(x => x.Amount));
            Console.WriteLine("Különbség: " + (totalBooks - books.Sum(x => x.Amount)));
            


            Console.ReadKey();
        }
    }
}
