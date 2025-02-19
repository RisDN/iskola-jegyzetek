Világ országai - Laravel feladat

Források:
 - Sablon mappa, benne a felhasználandó sablon.html-el, képekkel, assets-el
 - Mintak mappa, benne a segítségként kiadott minta pdf-ek.
 - orszagok.sql fájl az adatbázis kialakításához

1. Adatbázis létrehozása
Hozza létre a "orszagok" adatbázist és importálja be a mellékelt sql fájlt!

2. A projekt létrehozása
Hozzon létre egy új Laravel projektet a témához releváns néven!

3. Weboldal létrehozása
Alakítsa ki a mellékelt sablon segítségével a weboldal kinézetét, oldalszerkezetét!
A böngésző címsorában megjelenő cím --> "Világ országai" legyen!
A menü:
 - Főoldal --> indexre mutasson
 - Kontinensek --> ~/kontinensek/5 útvonalra mutasson
 - Országok --> ~/orszagok/5 útvonalra mutasson
A footer szöveges tartalma: Vizsgázó neve - osztálya 

4. Adatbázis elérése
Alakítsa ki az adatbázis kapcsolatot a létrehozott adatbázissal!
Hozza létre a szükséges modelleket és controllereket!
Alakítsa ki ezek kapcsolódását egymáshoz és az útvonalakhoz!

5. Útvonalak kialakítása
Alakítsa ki az alábbi útvonalakat és hozzon hozzá létre egy-egy nézetet!
 ~/   			Főoldal
 ~/kontinensek/{id}   	egy kontinens adatlapja, paraméterben a kontinens ID-val
 ~/orszagok/{id}  	egy ország adatlapja, paraméterben a kontinens ID-val

6. Egyes nézetek részletes kialakítása, adatbázis lekérdezések

Főoldal és a layout:
 - A böngésző címsorában megjelenő cím és a header, main címsora „Világ országai” legyen.
 - A header magassága 200 px legyen, háttérképe a header.jpg, amely reszponzívan és ismétlődésmentesen jelenjen meg.
 - A header-ben a címsor vízszintesen és függőlegesen középre van igazítva.
 - A főoldalon kialakítandó szöveges és a képi tartalom a szoveg.txt és a word-map.jpg felhasználásával:
	 - A képet a második bekezdésben helyezd el.
	 - A kép 50%-os szélességben jelenik meg XS (576px) méret felett, a képet jobbról folyja körbe a szöveg.
	 - A kép 100%-os szélességben jelenik meg XS (576px) méret alatt, a szöveg alatta és fölötte helyezkedik el ebben az esetben.
 - A főoldal bekezdései sorkizártak.
 - A kontinensek grid-je 50%-50%-os arányban jelenik meg, MD méret (768px) alatt egymás alatt jelenik meg a két hasáb, a kontinens térképe a hasábon belül középre van igazítva.
 - A kontinensek és az országok táblázata keretezett és csíkozott, a keretezés fekete; az országok táblázatának a címsora fekete lásd a mintákat.
 - A táblázatok mobilnézetben reszponzívak, az adattartalmuk sortörés nélkül jelenjen meg!
Amilyen beállításra nincs utalás, ott a minták a mérvadóak!

Kontinensek view – ~/kontinensek/{id}

 - A lap belső menüjéhez használja fel a kontinensek tábla tartalmát! A kontinenseket ABC sorrendbe rendezve jelenítse meg!
 - Az egyes menüpontokra kattintva az adott kontinensre vonatkozó adatok megjelenítését tegye lehetővé a ~/kontinensek/{id} útvonallal! 
 - Az alapértelmezetten kiválasztott kontinens Európa legyen!
 - A menüpontok alatti címsor az aktuális kontinens nevét tartalmazza!
 - A címsor alatt alakítson ki kéthasábos elrendezést 50%:50% arányban, a hasábok MD méret (768 px) alatt egymás alatt helyezkedjenek el!
 - A baloldali hasábban jelenítse meg az aktuális kontinens térképét, 100% szélességgel! A térképek fájlnevei megegyeznek a kontinensek tábla ID-ival!
 - A jobboldali hasábban jelenítse meg a kontinens adatait táblázatosan! A táblázat csíkozott és keretezett legyen! 
 - A táblázat numerikus adatait formázza ezres tagolással, ezresenként szóközzel elválasztva! Ügyeljen az adatok helyes mértékegységeire is! 
 - A legmagasabb, legmélyebb pont és leghosszabb folyó adatait egymás mellett jelenítse meg, kötőjellel elválasztva! Pl.: „-12 m - Eyre-tó”. 
 - A kontinenshez tartozó országok számát adatbázis lekérdezéssel határozza meg, melyhez használja fel az országok táblát!
 - Ha nincs ország az adott kontinensen, akkor jelenítse meg a "Nincs ország a területén" szöveget.

Országok view - ~/orszagok/{id}

 - A lap belső menüjéhez használja fel a kontinensek tábla tartalmát! 
 - Csak azokat a kontinenseket jelenítse meg, melyen van ország!
 - Az egyes menüpontokra kattintva az adott kontinens országaira vonatkozó adatok megjelenítését tegye lehetővé az ~/orszagok/{id} útvonallal! 
 - Az alapértelmezetten kiválasztott kontinens Európa legyen!
 - A menüpontok alatti címsor az aktuális kontinens nevét tartalmazza! A kontinens neve mellett szóközzel elválasztva szerepeljen az „országai” szó!
 - A címsor alatt táblázatos formában jelenítse meg az aktuális kontinens országainak az adatait az orszagok tábla felhasználásával! 
 - A táblázat csíkozott és keretezett, a címsora fekte legyen!
 - A táblázatban az adatokat az országok neve szerint rendezze, növekvő sorrendbe! 
 - Az első oszlopban alkalmazzon sorszámozást 1-től növekvően!
 - A táblázat numerikus adatait formázza ezres tagolással, ezresenként szóközzel elválasztva! Ügyeljen az adatok helyes mértékegységeire is!
 - Abban az esetben, ha egy ország területe nulla, akkor jelenítse meg a következő szöveget: „kisebb mint 1” a megfelelő mértékegységgel!




