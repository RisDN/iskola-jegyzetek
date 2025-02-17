-- Adatbázis schema
-- fenykep (id, evszam, szines, meret_x, meret_y)
--     id          A digitális kép azonosítója (szám), ez a kulcs
--     evszam      A fotó készítési éve (szám)
--     szines      A kép színes-e (logikai). Fekete-fehér képnél hamis és színesnél igaz.
--     meret_x     A kép szélessége képpontban (szám)
--     meret_y     A kép magassága képpontban (szám)

-- kapcsolo (fenyid, szemid)
--     fenyid      A fotó azonosítója (szám), az összetett kulcs része
--     szemid      A képen felismert személy azonosítója (szám), az összetett kulcs része

-- szemely (id, nev, szulev)
--     id          A személy azonosítója (szám), ez a kulcs
--     nev         A személy neve (szöveg), családtag esetén egyedi keresztnév, 
--                 különben nem kitöltött
--     szulev      A személy születési éve (szám), családtagon kívüli személy esetén nem kitöltött


-- 2. feladat: A színes képek a legelterjedtebbek a fotózásban, de művészi képeket ma is fekete-fehérben 
-- készítenek sokszor. Készítsen lekérdezést, amely évszám szerinti csökkenő sorrendben megjeleníti a fekete-fehér
-- képek évszámát, szélességét és magasságát!
SELECT evszam, meret_x, meret_y FROM fenykep WHERE szines = false ORDER BY evszam DESC;

-- 3. feladat: Készítsen lekérdezést, amely a „Vince” nevű családtag fotóit sorolja fel! 
-- A listában a fénykép azonosítója, Vince életkora a fotón, és a kép mérete, azaz a kép 
-- szélességének és magasságának szorzata jelenjen meg!
SELECT fenykep.meret_y * fenykep.meret_x AS Méret, fenykep.id FROM fenykep, kapcsolo, szemely
WHERE fenykep.id = kapcsolo.fenyid AND kapcsolo.szemid = szemely.id AND
szemely.nev LIKE '%Vince%'


-- 4. feladat: Lekérdezés segítségével sorolja fel azoknak a fényképeknek az azonosítóját és készítés évét, 
-- amelyen szerepel olyan csA jelentés létrehozását lekérdezéssel készítse elő! aládtag, 
-- aki a fénykép készítésének évében született! 
-- A listában többször szerepelhet az a kép, amelyen több ilyen családtag van!
SELECT fenykep.id, fenykep.evszam
FROM fenykep
JOIN kapcsolo ON fenykep.id = kapcsolo.fenyid
JOIN szemely ON kapcsolo.szemid = szemely.id
WHERE szemely.szulev = fenykep.evszam
GROUP BY fenykep.id, fenykep.evszam
HAVING COUNT(szemely.id) > 1;

-- 5. feladat: Határozza meg lekérdezés segítségével annak a fotónak az azonosítóját és készítési évét, amelyen a
-- legtöbb ember látható! Ha több ugyanannyit tartalmazó van, akkor mindet megjelenítheti.
SELECT fenykep.id, fenykep.evszam
FROM fenykep
JOIN kapcsolo ON fenykep.id = kapcsolo.fenyid
GROUP BY fenykep.id, fenykep.evszam
HAVING COUNT(kapcsolo.szemid) = (SELECT MAX(szam) FROM (SELECT COUNT(kapcsolo.szemid) AS szam FROM kapcsolo GROUP BY fenyid) AS szamol);

-- 6. feladat:  A családtagok egyéni fotói mindig érdekesek. Szeretnénk listázni azokat a képeket,
-- amelyeken valamelyik családtag egyedül szerepel. Az ilyen képek azonosítója és a képen szereplő
-- családtag neve jelenjen meg!
SELECT fenykep.id, szemely.nev
FROM fenykep
JOIN kapcsolo ON fenykep.id = kapcsolo.fenyid
JOIN szemely ON kapcsolo.szemid = szemely.id
WHERE kapcsolo.fenyid NOT IN (SELECT fenyid FROM kapcsolo WHERE fenyid = kapcsolo.fenyid AND szemid != kapcsolo.szemid)
AND nev IS NOT NULL;


-- 7. feladat: Matyi Anna unokája. Készítsen lekérdezést, amely felsorolja azokat a fotókat, amelyen mind a ketten
-- szerepelnek! A listában a fénykép azonosítója, és a kép készítési ideje jelenjen meg!
SELECT fenykep.id, fenykep.evszam
FROM fenykep
JOIN kapcsolo AS kapcsolo1 ON fenykep.id = kapcsolo1.fenyid
JOIN kapcsolo AS kapcsolo2 ON fenykep.id = kapcsolo2.fenyid
JOIN szemely AS szemely1 ON kapcsolo1.szemid = szemely1.id
JOIN szemely AS szemely2 ON kapcsolo2.szemid = szemely2.id
WHERE szemely1.nev = 'Matyi' AND szemely2.nev = 'Anna';

-- 8. feladat: Készítsen jelentést, amely évente kilistázza, hogy melyik családtag hány fotón szerepel!
-- A jelentés legyen év szerint csoportosítva és jelenítse meg az évet a családtag nevét és a
-- daraszámot.

SELECT fenykep.evszam, szemely.nev, COUNT(kapcsolo.szemid) AS darab
FROM fenykep
JOIN kapcsolo ON fenykep.id = kapcsolo.fenyid
JOIN szemely ON kapcsolo.szemid = szemely.id
GROUP BY fenykep.evszam, szemely.nev
ORDER BY fenykep.evszam, szemely.nev;


