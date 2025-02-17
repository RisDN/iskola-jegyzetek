using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat_241202
{
    internal class FakeNames
    {
        //      https://www.theguardian.com/books/2015/aug/17/the-100-best-novels-written-in-english-the-full-list
        //      let asd = []
        //      document.querySelectorAll("strong a").forEach((elem => {
        //        asd.push(elem.innerText)
        //      }))

        //      https://mek.oszk.hu/html/303.html
        //      let asd = [];
        //      document.querySelectorAll(".cim_nk").forEach((elem) => {
        //        asd.push(elem.innerText.split("/")[0].split(".")[1])
        //      })

        private static readonly Random random = new Random();

        private static string[] authors = new string[]
        {
           "Jókai Mór",
           "Móricz Zsigmond",
           "Karinthy Frigyes",
           "Kosztolányi Dezső",
           "Mikszáth Kálmán",
           "Szabó Magda",
           "Kertész Imre",
           "Krasznahorkai László",
           "Nádas Péter",
           "Kodolányi János",
           "Karinthy Frigyes",
           "James Joyce",
           "Sinclair Lewis",
           "Aldous Huxley",
           "Evelyn Waugh",
           "Graham Greene",
           "Anthony Powell",
           "Vladimir Nabokov",
           "William Golding",
           "Iris Murdoch",
           "Muriel Spark",
           "Anthony Burgess",
           "Salman Rushdie",
           "Ian McEwan",
           "Kazuo Ishiguro",
           "Martin Amis",
           "Julian Barnes",
           "Asylk Byatt",
           "Salman Rushdie",
           "Ian McEwan",
           "Kazuo Ishiguro",
        };

        private static string[] english = new string[]
        {
           "The Pilgrim’s Progress",
           "Robinson Crusoe",
           "Gulliver’s Travels",
           "Clarissa",
           "Tom Jones",
           "The Life and Opinions",
           "Emma",
           "Frankenstein",
           "Nightmare Abbey",
           "The Narrative of Arthur",
           "Sybil",
           "Jane Eyre",
           "Wuthering Heights",
           "Vanity Fair",
           "David Copperfield",
           "The Scarlet Letter",
           "Moby-Dick",
           "Alice’s Adventures",
           "The Moonstone",
           "Little Women",
           "Middlemarch",
           "The Way We Live Now",
           "The Adventures",
           "Kidnapped",
           "Three Men in a Boat",
           "The Sign of Four",
           "The Picture of Dorian Gray",
           "New Grub Street",
           "Jude the Obscure",
           "The Red Badge",
           "Dracula",
           "Heart of Darkness",
           "Sister Carrie",
           "Kim",
           "The Call of the Wild",
           "The Golden Bowl",
           "Hadrian the Seventh",
           "The Wind in the Willows",
           "The History of Mr Polly",
           "Zuleika Dobson",
           "The Good Soldier",
           "The Thirty-Nine Steps",
           "The Rainbow",
           "Of Human Bondage",
           "The Age of Innocence",
           "Ulysses",
           "Babbitt",
           "A Passage to India",
           "Gentlemen Prefer Blondes",
           "Mrs Dalloway",
           "The Great Gatsby",
           "Lolly Willowes",
           "The Sun Also Rises",
           "The Maltese Falcon",
           "As I Lay Dying",
           "Brave New World",
           "Cold Comfort Farm",
           "Nineteen Nineteen",
           "Tropic of Cancer",
           "Scoop",
           "Murphy",
           "The Big Sleep",
           "Party Going",
           "At Swim-Two-Birds",
           "The Grapes of Wrath",
           "Joy in the Morning",
           "All the King’s Men",
           "Under the Volcano",
           "The Heat of the Day",
           "Nineteen Eighty-Four",
           "The End of the Affair",
           "The Catcher in the Rye",
           "The Adventures",
           "Lord of the Flies",
           "Lolita",
           "On the Road",
           "Voss",
           "To Kill a Mockingbird",
           "The Prime",
           "Catch-22",
           "The Golden Notebook",
           "A Clockwork Orange",
           "A Single Man",
           "In Cold Blood",
           "The Bell Jar",
           "Portnoy’s Complaint",
           "Mrs Palfrey",
           "Rabbit Redux",
           "Song of Solomon",
           "A Bend in the River",
           "Midnight’s Children",
           "Housekeeping",
           "Money: A Suicide Note",
           "An Artist",
           "The Beginning",
           "Breathing Lessons",
           "Amongst Women",
           "Underworld",
           "Disgrace",
           "True History"
        };

        private static string[] hungarian = new string[]
        {
           "Etelka",
           "Törökországi levelek",
           "Tariménes utazása",
           "A Bélteky-ház",
           "Abafi",
           "A csehek Magyarországon",
           "A karthausi",
           "Fanni hagyományai",
           "Magyar titkok",
           "A falu jegyzője",
           "A hóhér kötele",
           "Hazai rejtelmek",
           "Magyarország 1514-ben",
           "Egy magyar nábob",
           "Özvegy és leánya",
           "Egy régi udvarház utolsó gazdája",
           "A nemzet napszámosai",
           "Bethlen Miklós önéletírása",
           "A rajongók",
           "Zord idő",
           "Az új földesúr",
           "A kőszívű ember fiai",
           "Jelky András kalandjai",
           "Az arany ember",
           "Anatole",
           "Az urak",
           "A jövő század regénye",
           "Álmok álmodója",
           "Pályám emlékezete",
           "Déryné naplója",
           "Köd",
           "Apai örökség",
           "A püspök atyafisága",
           "Fuimus",
           "Beszterce ostroma",
           "Új Zrinyiász",
           "Különös házasság",
           "Egri csillagok",
           "Budapest",
           "A nap lovagja",
           "A láthatatlan ember",
           "Elnémult harangok",
           "Midás király",
           "A kertelő agár",
           "A Noszty fiú esete",
           "Az Isten háta mögött",
           "A fekete város",
           "Színek és évek",
           "A vörös postakocsi",
           "A kristálynézők",
           "A gólyakalifa",
           "Tanár úr kérem",
           "Hangyaboly",
           "A zöldköves gyűrű",
           "Asszonyságok díja",
           "Az elsodort falu",
           "Piroska",
           "Légy jó mindhalálig",
           "Hét bagoly",
           "Neró, a véres költő",
           "Pacsirta",
           "Orbán lelke",
           "Pillangó",
           "Segítség!",
           "Édes Anna",
           "Halálfiai",
           "Jászai Mari emlékiratai",
           "Ének a búzamezőkről",
           "Fekete vőlegények",
           "A párizsi regény",
           "Boldogult úrfikoromban",
           "A nagymosoda",
           "Fekete kolostor",
           "Mint oldott kéve",
           "Aranykoporsó",
           "Rokonok",
           "Esti Kornél",
           "Napos oldal",
           "Családi album",
           "Erdély",
           "Párizsi eső",
           "Utazás a koponyám körül",
           "Utas és holdvilág",
           "Azarel",
           "Csontbrigád"
        };

        public static string GetRandomHungarian()
        {
            return hungarian[random.Next(0, hungarian.Length)];
        }

        public static string GetRandomEnglish()
        {
            return english[random.Next(0, english.Length)];
        }

        public static string GetRandomAuthor() {
            return authors[random.Next(0, authors.Length)];
        }

        public static string[] GetRandomAuthor(int count)
        {
            string[] strings = new string[count];
            for (int i = 0; i < count; i++)
            {
                strings[i] = GetRandomAuthor();
            }
            return strings;
        }

        public static string GetRandom(string language)
        {
            switch(language)
            {
                case"magyar":
                    return GetRandomHungarian();
                case"angol":
                    return GetRandomEnglish();
                default:
                    throw new Exception("Nem támogatott nyelv:"+ language);
            }
        }

    };
}
