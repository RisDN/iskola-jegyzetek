-- másodlagos név: 1) felhasználónak
-- 2) saját magunknak új névnek
-- <kifejezés> as <uj nev>
-- kérdezd le a cikkek nevét és nettó egységárát
-- úgy, hogy az oszlopneve legyen:"Termék neve", "Nettó egységár"
select
	nev as "Termék neve",
    near as "Nettó egységár"
from cikkek;

-- konstans műveletek
-- c <művelet> <oszlopnév>
-- műveletek: + - / * 
-- oszlop: numerikus adattal 
-- kérdezd le, hogy mennyi lenne a netto egységár,
-- ha 10%-kal megemelnénk azt
select
	nev,
    near,
    near*1.1 as ujar
from cikkek;
-- oszlopokon is lehet műveleteket végezni
-- kérdezd le a termék nevét, nettó egységárát,
-- áfa kulcsát, és bruttó egységárat
select
	nev,
    near,
    afa,
    near*(100+afa)/100 as brutto
from cikkek;

-- függvények
-- aggregáló: sorhalmazfüggvény
-- több értékből képez egyet
-- min(), max(), sum(), count(), avg() - numerikus
-- min(), max() - dátum
-- count() - bármilyen
-- nem aggregáló: sorfüggvények
-- month(), left()
-- kérdezd le,hogy mennyi a termékek átlagára
select avg(near)
from cikkek;
-- kérdezd le a legolcsóbb termék árát
select min(near)
from cikkek;

-- kérdezd le  a legolcsóbb termék árát és a termékek átlagárát
select min(near), avg(near), count(cid)
from cikkek;


-- kérdezd le a termékek nevét és a nevük első három karakterét
select nev, left(nev,3)
from cikkek;