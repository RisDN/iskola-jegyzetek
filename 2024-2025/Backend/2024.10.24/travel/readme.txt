Happy Travel - Laravel feladat

Források:
 - Sablon mappa, benne a felhasználandó sablon.html-el, képekkel, assets-el
 - Mintak mappa, benne a segítségként kiadott minta pdf-ek.
 - travel.sql fájl az adatbázis kialakításához

1. Adatbázis létrehozása
Hozza létre a "travel" adatbázist és importálja be a mellékelt sql fájlt!

2. A projekt létrehozása
Hozzon létre egy új Laravel projektet a témához releváns néven!

3. Weboldal létrehozása
Alakítsa ki a mellékelt sablon segítségével a weboldal kinézetét, oldalszerkezetét!
A böngésző címsorában megjelenő cím és a navbar-brand --> "Happy Travel" legyen!
A menü:
 - Navbar-brand --> indexre mutasson
 - Drezda --> ~/uticel/Drezda útvonalra mutasson
 - Dubai --> ~/uticel/Dubai útvonalra mutasson
 - Erdély --> ~/uticel/Erdély útvonalra mutasson
 - Nürnberg --> ~/uticel/Nürnberg útvonalra mutasson
 - Prága --> ~/uticel/Prága útvonalra mutasson
 - Salzkammergut --> ~/uticel/Salzkammergut útvonalra mutasson
 - Tátra --> ~/uticel/Tátra útvonalra mutasson
 !!Opcionális lehetőség!! -> A menüben az uticélok ABC sorrendben s hozzá az ~/uticel/<uticel> útvonal hivatkozások adatbázis lekérdezéssel is elkészíthetők.
A footer szöveges tartalma:
	- Happy Travel - E-mail: hello@happytravel.hu - Tel: 06 1 123-4567 -
Az e-mail cím és a telefonszám kattintható legyen, mobiltelefonon nyissák meg az levelező applikációt illetve a telefonhívás applikációt

4. Adatbázis elérése
Alakítsa ki az adatbázis kapcsolatot a létrehozott adatbázissal!
Hozza létre a szükséges modelleket és controllereket!
Alakítsa ki ezek kapcsolódását egymáshoz és az útvonalakhoz!

5. Útvonalak kialakítása
Alakítsa ki az alábbi útvonalakat és hozzon hozzá létre egy-egy nézetet!
 ~/   			Főoldal
 ~/uticel/{p}   	uticélok oldala, paraméterben az uticél nevével
 ~/adatlap/{id}  	egy utazás adatlapja, paraméterben az utazást azonosító ID-val.

6. Egyes nézetek részletes kialakítása, adatbázis lekérdezések
 - A Főoldalon készítsen egy táblázatot, amelyben: 
	- Megjeleníti az összes utazást, "Uticél", "Utazás megnevezése", "Időtartam" és "Ár" oszlopokban. 
	- Az adatokat uticél szerint ABC sorrendbe rendezze. 
	- A táblázat legyen keretezett és csíkozott.
	- Az utazás neve mutasson az ~/adatlap/{id} útvonalra!
	- Az árat Ft/fő-ben és ezres tagolással jelenítse meg!

 - Az ~/uticél/{p} útvonalhoz tartozó nézeten:
	- H1-es címsorban jelenítse meg az adott desztináció nevét.
	- A címsor alatt alkalmazzon 4:8 arányú grideket, töréspontjuk MD méret legyen.
	- Egy-egy gridben a bal oldalon az utazáshoz tartozó kép legyen, melyet az ID azonosít, alt="" a fájlnév legyen!
	- Egy-egy gridben a jobb oldalon a program megnevezése, időtartam és ár adatok legyenek!
	- Az utazás neve mutasson az ~/adatlap/{id} útvonalra!
	- Az árat Ft/fő-ben és ezres tagolással jelenítse meg!
	- A gridek közt alkalmazzon elválasztó vonalat, lásd a mintán!

 - Az ~/adatlap/{id} útvonalhoz tartozó nézeten:
	- H1-es címsorban jelenítse meg az adott utazás nevét.
	- A címsor alatt alkalmazzon 50%:50% arányú grideet, töréspontja MD méret legyen.
	- A gridben a bal oldalon az utazáshoz tartozó kép legyen, melyet az ID azonosít, alt="" a fájlnév legyen!
	- Egy-egy gridben a jobb oldalon az utazáshoz tartozó összes adat legyen kiírva, lásd a mintát!
	- Az utazáshoz tartozó uticél az ~/uticel/{p} útvonalra mutasson!
	- Az árat Ft/fő-ben és ezres tagolással jelenítse meg!

	



