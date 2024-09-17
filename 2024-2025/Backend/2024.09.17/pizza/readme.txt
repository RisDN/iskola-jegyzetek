Menu paraméteres legyen!

Létrehozandó oldalak:
 - akcios.php  -- ez töltődjön be default a főoldalon
 - adatlap.php -- egy pizza adatlapja
 - pizzak.php  -- összes pizzát tartalmazó táblázat
 - rnd.php     -- pizzafutár ajánlata

Árak: 
 - Az adatbázis a 24 cm-es pizza árát tartalmazza
 - 32 cm-es pizza a 24-es 125%-a
 - 45 cm-es pizza a 24-es 150%-a
 - az akciós pizza minden méretben 10% kedvezményű

Linkek
 - Az akciós pizzák lapon a <h2> és a "további méretek" link az adatlap.php-re mutat
 - A táblázatnál a pizza neve az adatlap.php-re mutat
 - A táblázat felett a rendezés linjei rendezik a táblázatot

Grid
 - Az akciós pizzák felsorolásánál gridhez segítség:
   row --> "row row-cols-1 row-cols-sm-2 row-cols-md-3"
           // XS méret 1 oszlom SM méret 2 oszlop MD mérettől 3 oszlop
   col --> "col"
   title -->  <h2>