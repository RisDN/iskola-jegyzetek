Nagykátai járás - Laravel dolgozat

Források:
 - Sablon mappa, benne a felhasználandó sablon.html-el, képekkel, css és js fájlokkal
 - Mintak mappa, benne a segítségként kiadott minta pdf-ek.
 - jaras-nagykata.sql fájl az adatbázis kialakításához
 - szoveg.txt

1. Adatbázis létrehozása
Hozza létre a "jaras-nagykata" adatbázist és importálja be a mellékelt sql fájlt!

2. A projekt létrehozása
Hozzon létre egy új Laravel projektet a témához releváns néven!
Munkája végén az egész projektet adja be a kijelölt meghajtón lévő mappába!

3. Weboldal létrehozása
Alakítsa ki a mellékelt sablon segítségével a weboldal kinézetét, oldalszerkezetét!
A böngésző címsorában megjelenő cím, a navbar-brand és a mainpage H1 --> "Nagykátai járás" legyen!
A menü:
 - Navbar-brand --> indexre mutasson
 - Települések --> ~/telepulesek útvonalra mutasson
 - Wikipedia --> külső hivatkozás, új ablakban nyíljon meg; linket lásd a szoveg.txt-ben
 - Önkormányzati címerek --> külső hivatkozás, új ablakban nyíljon meg; linket lásd a szoveg.txt-ben
A főoldal szöveges tartalmát a szoveg.txt segítségével alakítsa ki!
A footer szöveges tartalma a vizsgázó neve és osztálya legyen!

4. Adatbázis elérése
Alakítsa ki az adatbázis kapcsolatot a létrehozott adatbázissal!
Hozzon létre egy modelt "telepulesek" néven!
Hozzon létre egy controllert "JarasController" néven!
Alakítsa ki ezek kapcsolódását egymáshoz és az útvonalakhoz!

5. Útvonalak kialakítása
Alakítsa ki az alábbi útvonalakat és hozzon hozzá létre egy-egy nézetet!
 ~/   			Főoldal
 ~/telepulesek  	települések oldal
 ~/adatlap/{id}  	egy település adatlapja

6. Egyes nézetek részletes kialakítása, adatbázis lekérdezések
- A Főoldalon alakítsa ki a szöveges tartalmat, ügyeljen a helyes mértékegységekre és a szövegigazításra!

- A települések oldalon alkalmazzon táblázatos megjelenítést. A táblázat keretezett és csíkozott legyen. A település nevére kattintva tovább lehessen jutni a ~/adatlap/{id} nézetre

- Az adatlap oldalon alkalmazz bootstrap gridet, a gidben jelenjen meg baloldalt az adott település címere és képaláírása egy kártyában, jobb oldalon az adott település adatai egy csíkozott, keretezett táblázatban!
	- A grid 4:8 arányú legyen, töréspontja MD méretnél legyen!
	- A táblázatban lévő linkek külső linkek, új ablakban nyíljanak meg!




