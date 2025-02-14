Naprendszer - Laravel feladat

Források:
 - Sablon mappa, benne a felhasználandó sablon.html-el, képekkel, assets-el
 - Mintak mappa, benne a segítségként kiadott minta pdf-ek.
 - naprendszer.sql fájl az adatbázis kialakításához

1. Adatbázis létrehozása
Hozza létre a "naprendszer" adatbázist és importálja be a mellékelt sql fájlt!

2. A projekt létrehozása
Hozzon létre egy új Laravel projektet a témához releváns néven!

3. Weboldal létrehozása
Alakítsa ki a mellékelt sablon segítségével a weboldal kinézetét, oldalszerkezetét!
A böngésző címsorában megjelenő cím --> "Naprendszer" legyen!
A menü:
 - Főoldal --> indexre mutasson
 - Bolygók --> ~/bolygok/3 útvonalra mutasson
 - Holdak --> ~/holdak/3 útvonalra mutasson
A footer szöveges tartalma: Vizsgázó neve - osztálya 

4. Adatbázis elérése
Alakítsa ki az adatbázis kapcsolatot a létrehozott adatbázissal!
Hozza létre a szükséges modelleket és controllereket!
Alakítsa ki ezek kapcsolódását egymáshoz és az útvonalakhoz!

5. Útvonalak kialakítása
Alakítsa ki az alábbi útvonalakat és hozzon hozzá létre egy-egy nézetet!
 ~/   			Főoldal
 ~/bolygok/{id}   	egy bolygó adatlapja, paraméterben a bolygo ID-val
 ~/holdak/{id}  	egy hold adatlapja, paraméterben a bolygo ID-val
 ~/edit/{id}		egy hold módosításának a form-ja

6. Egyes nézetek részletes kialakítása, adatbázis lekérdezések

Főoldal és a layout:
 - A böngésző címsorában megjelenő cím és a header címsora „Naprendszer” legyen.
 - A header magassága 300 px legyen, háttérképe a header.jpg, amely reszponzívan és ismétlődésmentesen jelenjen meg.
 - A header-ben a címsor vízszintesen és függőlegesen középre van igazítva.
 - A főoldalon kialakítandó szöveges és a képi tartalom a szoveg.txt és a solar-system.jpg felhasználásával:
 - A kép 50%-os szélességben jelenik meg XS (576px) méret felett, a képet jobbról folyja körbe a szöveg.
 - A kép 100%-os szélességben jelenik meg XS (576px) méret alatt, a szöveg alatta helyezkedik el ebben az esetben.
 - A főoldal bekezdései sorkizártak.
 - A bolygók grid-je 50%-50%-os arányban jelenik meg, MD méret (768px) alatt egymás alatt jelenik meg a két hasáb, a bolygók képe a hasábon belül középre van igazítva.
 - A bolygók és a holdak táblázata keretezett és csíkozott, lásd a mintákat.
Amilyen beállításra nincs utalás, ott a minták a mérvadóak!

Bolygók view – ~/bolygok/{id}

 - Az oldal belső menüjében a címsor fölött középre igazítva, az adatbázis adatainak felhasználásával jelenítse meg a bolygók nevét. 
 - A bolygók neve link, formázása fekete gomb és a bolygók ID-ját felhasználva (~/bolygok/{id}) egy-egy bolygó adatainak megjelenítésére szolgáljon. 
 - Az oldal view-nak az alapértelmezése a Föld, azaz az ehhez tartozó ID legyen, mind más esetben a linkek ID-ját használja a view.
 - Az oldal belső menüje alatt a címsorban jelenítse meg az aktuális bolygó nevét.
 - A címsor alatt kéthasábos grid-ben jelenítse meg a bolygó képét és az adatait egy táblázatban. 
 - A táblázatban a számadatok ezresenként szóközzel vannak tagolva. A szükséges mértékegységeket lásd a mintán!
 - A holdak számát darabban jelenítse meg! Amennyiben nincs holdja a bolygónak, akkor jelenjen meg a "Nincs holdja" szöveg.

Holdak view – ~/holdak/{id}

 - Az oldal belső menüjében a címsor fölött középre igazítva, az adatbázis adatainak felhasználásával jelenítse meg csak azon bolygók nevét, amelyeknek van holdja. 
 - A bolygok neve link, formázása fekete gomb és a bolygók ID-ját felhasználva (~/holdak/{id}) egy-egy bolygóhoz tartozó holdak listájának a megjelenítésére szolgáljon. 
 - Az oldal view-nak az alapértelmezése a Föld, azaz az ehhez tartozó ID legyen, mind más esetben a linkek ID-ját használja a view.
 - Az oldal belső menüje alatt a címsorban jelenítse meg az aktuális bolygó nevét.
 - A címsor alatt táblázatosan jelenítse meg az adott bolygóhoz tartozó holdak adatait, illetve egy „Módosítás” gombot (formázása a belső menü linkjeivel azonos), mely a Hold módosítása (~/edit/{id}) view-ra mutat. 
 - A táblázat a holdak neve szerint abc sorrendbe legyen rendezve, sorszámozva legyen megjelenítve. 
 
Hold módosítása view – ~/edit/{id}

 - A még el nem nevezett holdak módosításához (pl.: Jupiter egyes holdjai – S/2017 J1, S/2017 J2, stb.) vagy a felfedezés időpontjának pontosításához hozzon létre egy űrlapot. 
 - Az űrlap középre rendezett, további formázását lásd a mintán.
 - Az űrlappal módosítani lehessen a hold nevét és felfedezésének időpontját. 
 - Az űrlap beküldése előtt végezz üresség ellenőrzést, az ehhez kapcsolódó validálási üzenetek az input mező alatt jelenjenek meg, magyarítva. 
 - Sikeres validálás után az űrlap segítségével módosítsd a holdak tábla aktuális rekodját és jelenítsd meg a Success view-t (~/success).

Success view

 - A view-on a címsorban jelenítsd meg a „Sikeresen módosítottad a(z) <hold neve> holdat!” üzenetet.




