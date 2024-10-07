Feladatok:

1. Adatbázis létrehozása
   Hozd létre a "cats_a" nevű adatbázist és abban a mellékelt insert.txt fájlban lévő adatok alapján az "image" nevű táblát.
   A táblaszerkezetet a db.png mutatja
   Értékelésnél fontos, hogy az adatbázis neve és a tábla neve egyezzen meg a kiadottal!

2. Fájlok létrehozása
   A feladatban létrehozandó fájlok: **nativ php

3. HTML oldalszerkezet kialakítása
   A mellékelt sablont darabold az oldalszerkezet kialakításához (header - main - footer)
   A szükséges dolgokat írd át a sablonban. 
   A title megegyezik a navbar-brand szövegével.
   A footer text a NEVED és az OSZTÁLYOD legyen. Pl.: "Kiss Béla - 14.SZ"

4. Menü létrehozása.
   Menü elemei: Cute cats   --> indexre mutat
		Cat pics    --> indexre mutat
		Authors     --> author.php-re mutat
		Random cats --> rnd_cats.php-re mutat
  Menüt paraméteres menükezeléssel old meg. 
5. Cat pics oldal
   Az oldalon alkalmazz bootstrap grid-et az adatbázisból lekérdezett képek elrendezéséhez. 
   A grid   Extra small méretben (576px-ig) 1 hasábos legyen
            Small méretben (768px-ig) 2 hasábos legyen
            Medium méretben (992px-ig) 3 hasábos legyen
            e felett 4 hasábos legyen
   A képek fájlnevéhez használd fel az adatbázis ID mezőjét, a képek alt=""-hoz és title=""-hez az adatbázisból nyerj adatokat
   !!A képek fájlnevét ne nevezd át!!
   Egy képre kattintva töltsön be a cat_page.php
6. Cat page oldal
   Az oldalon alkalmazz bootstrap grid-et az adatbázisból lekérdezett adatok elrendezéséhez. 
   A grid   Medium méretig (768px-ig) 1 hasábos legyen
            S e felett 2 hasábos legyen
   A táblázatban lévő "Stock image page", "Direct link to the pic" és "Author's page" linkjei új ablakban nyíljanak meg.
   Az oldal alján lévő "Prev" és "Next" linkek az előző illetve a következő ID-ú cat_page-re mutassanak.
   Az első ID-nál ne jelenjen meg a "Prev"!
   Az utolsó ID-nál ne jelenjen meg a "Next"!
7. Authors oldal
   A táblázatban a minta alapján, sorszámozva kérdezd le a képek készítőinek nevét és az "Author's page" linkjét. A link új ablakban nyíljon meg.
   Figyelj arra, hogy minden Author egyszer szerepeljen a listában!
8. Random cats oldal
   Az oldalon az adatbázis hosszát felhasználva random szám alapján jelenjen meg egy random kép + title-je, ehhez használd fel az adatbázis adatait.




