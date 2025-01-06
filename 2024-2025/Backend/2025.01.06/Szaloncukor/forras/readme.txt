Szaloncukor - Laravel $_POST dolgozat

Források:
 - Sablon mappa, benne a felhasználandó sablon.html-el, képekkel, css és js fájlokkal
 - Mintak mappa, benne a segítségként kiadott minta pdf-ek.
 - szaloncukor.sql fájl az adatbázis kialakításához

1. Adatbázis létrehozása
Hozza létre a "szaloncukor" adatbázist és importálja be a mellékelt sql fájlt!

2. A projekt létrehozása
Hozzon létre egy új Laravel projektet a témához releváns néven!
Munkája végén az egész projektet adja be a kijelölt meghajtón lévő mappába!

3. Weboldal létrehozása
Alakítsa ki a mellékelt sablon segítségével a weboldal kinézetét, oldalszerkezetét!
A böngésző címsorában megjelenő cím --> "Szaloncukor" legyen!
A menü:
 - Szaloncukor hozzáadása --> Indexre mutasson
 - Szaloncukor Wikipedia --> külső hivatkozás, új ablakban nyíljon meg; Link: https://hu.wikipedia.org/wiki/Szaloncukor
A footer szöveges tartalma a vizsgázó neve és osztálya legyen!

4. Adatbázis elérése
Alakítsa ki az adatbázis kapcsolatot a létrehozott adatbázissal!
Hozzon létre egy modelt és egy controllert a témához releváns néven! 
Alakítsa ki ezek kapcsolódását egymáshoz és az útvonalakhoz!

5. Útvonalak kialakítása
Alakítsa ki az alábbi útvonalakat és hozzon hozzá létre egy-egy nézetet!
 ~/   			Főoldal

6. Egyes nézetek részletes kialakítása, adatbázis lekérdezések
- A Főoldalon alakítsa ki az űrlap és a táblázat grid-es elrendezését. A grid  Lg méret alatt (992px) 1 hasábos legyen, ezen felül két hasábos legyen.
- A bal oldalon az űrlapot egy keretezett fehér blokkban jelenítse meg, pl.: Bootstrap Card
- A jobb oldalon a táblázat keretezett és csíkozott legyen.
- A táblázatban jelenítse meg az összes adatot, a megfelelő mértékegységekkel: g, Ft
- A 18+ oszlopban képpel plusz18.png-t jelenítse meg, ha 18 éven felülieknek való a szaloncukor, mérete: 30x30px legyen.
- Az oldalon belül alkalmazott címsorok 5-ös szintű címsorok.

7. Űrlap elemei: 
- Szaloncukor márkája:     -- szöveg típusú mező
- Szaloncukor íze:         -- szöveg típusú mező
- Csomag súlya:            -- szám típusú mező
- Csomag ára:              -- szám típusú mező
- 18+ - csak felnőtteknek: -- jelölőnégyzet
- Szaloncukor hozzáadása:  -- gomb

Egyes mezőknél alkalmazz súgó szövegeket, lásd a mintát.
Minden mező és a jelölőnégyzet is a validálás során tartsa meg az értékét.

8. Űrlap validálása:
- Minden validálási üzenet az aktuális űrlapelem alatt jelenjen meg, lásd a mintát.
- Minden mező esetében (kivéve jelölőnégyzet) legyen üresség ellenörzés. A hibaüzenet szövege az adott mező ürességére utal: 
   - "A márka megadása kötelező!" 
   - "Az íz megadása kötelező!" 
   - "A súly megadása kötelező!" 
   - "Az ár megadása kötelező!" 
- A súly mezőben a minimum súly 100 g legyen, hiba esetén az üzenet: 
   - "Minimum ár 100 g!"  
   Pont csak akkár jár, ha PhP-s üzenettel oldod meg a mező alatt
- Az ár mezőben a minimum ár 100 Ft legyen, hiba esetén az üzenet: 
   - "Minimum ár 100 Ft!" 
   Pont csak akkár jár, ha PhP-s üzenettel oldod meg a mező alatt

9. Űrlap beküldése:
- Sikeres validálás után a "Szaloncukor hozzáadása" gomb segítségével az adatok legyenek beleírva az adatbázisba.
- A gomb lenyomása után az index töltődjön be. 
- Az index betöltődésével az űrlapban eltárolt értékeket nullázd ki. 
- Az index betöltődésével egyidőben a táblázat is frissüljön, ne kelljen külön újratölteni az oldalt.

OPCIONÁLIS FELADATOK - plusz pontért unatkozóknak:
- NINCS ==> Szép csoport :)

!!BEADÁS!!
- Az egyész weboldalt tartalmazó mappádat CTRL+X-el !!helyezd át!! a kijelölt meghajtón lévő Saját neves mappádba.
- A létrehozott adatbázis eldobható.
