-- A szárazföldi közlekedés a vasút megjelenésével indult ugrásszerű fejlődésnek. A magyar gőzvontatású vasút története 1844-ben kezdődött. A vasúti hálózat egy évszázadig folyamatosan terebélyesedett, azóta több hullámban zártak be vasútvonalakat részben vagy egészben. Ritkábban az is előfordult, hogy újranyitottak vonalakat. Az adatbázis a személyforgalmú vasútvonalak adatait tartalmazza. Az állomások a különböző vonalakon más-más helyet foglalhatnak el a kiindulási állomástól való távolságuk alapján.
-- allomas (id, nev, tipus, orszag, mukodo)
--     id          Az állomás azonosítója (szám), ez a kulcs
--     nev         Az állomás neve (szöveg); a nevek egyediek
--     tipus       Az állomás típusa (szöveg); megmutatja, hogy a vasúti forgalomban milyen szerepe 
--                 töltött be
--     orszag      Az állomás országa (szöveg), megmutatja, hogy az állomás melyik országb     
--                 található jelenleg, értéke az ország nemzetközi gépkocsijele (pl. Ausztria – A, Szlovénia – SLO), Magyarország esetén üres
--     mukodo      Az állomás működési állapota (logikai), ha működik, akkor értéke igaz


-- vonal (id, kisvasut, mukodo)
--     id          A vasútvonal azonosítója (szöveg), ez a kulcs
--     kisvasut    A vasútvonal típusát mutatja (logikai), értéke igaz, ha kisvasúti
--     mukodo      A vasútvonal állapotát mutatja (logikai), értéke hamis, ha felszámolták

-- hely (id, vonalid, allomasid, tav)
--     id              A vonal egy helyének azonosítója (szám), ez a kulcs
--     vonalid         Annak a vasútvonalnak az azonosítója, ahol a hely található (szöveg)
--     allomasid       Annak az állomásnak az azonosítója, amelyik az adott helyen van (szám)
--     tav             A hely kilométerben mért távolsága a vonal indulási állomásától (szám); 
--                     az indulási állomáshoz tartozó távolság 0 km. Értéke a hely km-re
--                     kerekített távolsága.

-- Ügyeljen arra, hogy a lekérdezésben pontosan a kívánt mezők szerepeljenek, felesleges mezőt ne
-- jelenítsen meg!




-- 1. feladat:
-- Importálja be a mellékelt szöveges állományt az adatbázisába! vasutvonalak.sql

-- 2. feladat:
-- A feladat elkészítéséhez használt egyik forrás azt írja, hogy „Szeged-Feketehalom” megállóhely
-- sosem létezett. Törölje az allomas és a hely táblákból a rá vonatkozó adatokat!
DELETE FROM hely WHERE allomasid = (SELECT id FROM allomas WHERE nev = 'Szeged-Feketehalom');
DELETE FROM allomas WHERE nev = 'Szeged-Feketehalom';

-- 3. feladat:
-- Készítsen lekérdezést, amely az adatbázisban tárolt adatok alapján megjeleníti a jelenleg
-- Magyarországon kívül található állomások nevét és ország jelét, az állomásnév szerint
-- ábécérendben!
SELECT nev, orszag
FROM allomas
WHERE orszag IS NOT NULL
ORDER BY nev;

-- 4. feladat:
-- A 80-as vonal az egyik leghosszabb hazánkban. Készítsen lekérdezést, amely a kiinduló állomástól
-- mért távolság sorrendjében megjeleníti a működő állomások nevét, típusát és a indulási állomástól
-- mért távolságát!
SELECT a.nev, a.tipus, h.tav
FROM allomas a
JOIN hely h ON a.id = h.allomasid
WHERE h.vonalid = '80' AND a.mukodo
ORDER BY h.tav;


-- 5. feladat:
-- Készítsen lekérdezést, amely megadja az egyes vonalak hosszát, azaz az első és az utolsó hely
-- távolságát! Jelenítse meg a vonal azonosítóját és a hossz értékét!
SELECT vonalid, MAX(tav) - MIN(tav) AS hossz
FROM hely
GROUP BY vonalid;


-- 6. feladat:
-- Egészítse ki az alábbi lekérdezést a kérdőjelekkel jelzett 5 helyen, hogy megadja az egyes vonalak azonosítóját, 
-- valamint az első és az utolsó állomását! Van, ahová egyetlen szót, más helyre egy kifejezést kell írnia.
SELECT indulasi.vonalid, indulasi.nev, veg.nev
FROM
(
SELECT nev, vonalid
FROM allomas, hely
WHERE allomas.id=allomasid
AND tav = 0
) AS indulasi,
(
SELECT nev, vonalid, tav
FROM allomas, hely
WHERE allomas.id=allomasid
) AS veg,
(
SELECT vonalid, MAX(tav) AS maxtav
FROM hely
GROUP BY vonalid
) AS tulso
WHERE indulasi.vonalid=veg.vonalid
AND veg.vonalid=tulso.vonalid
AND veg.tav =tulso.maxtav;

-- 7. feladat:
-- Készítsen lekérdezést, amely megadja, hogy Hatvan mely állomásokról érhető el jelenleg vagy a
-- múltban valamikor közvetlenül, azaz átszállás nélkül! Az állomás nevét és a vonalazonosítóját jelenítse meg!
-- Hatvan neve ne szerepeljen a listában!
SELECT a.nev, h.vonalid
FROM allomas a
JOIN hely h ON a.id = h.allomasid
WHERE h.vonalid IN (SELECT vonalid FROM hely WHERE allomasid = (SELECT id FROM allomas WHERE nev = 'Hatvan'))
AND a.nev != 'Hatvan'
GROUP BY a.nev, h.vonalid
HAVING COUNT(DISTINCT h.vonalid) = 1;

-- 8. feladat:
-- Készítsen lekérdezést, amely megadja, hogy melyik állomás része legalább 5 vasútvonalnak! Az állomás
-- nevét és a vonalak számát jelenítse meg darabszám szerint csökkenő sorrendben!
SELECT a.nev, COUNT(DISTINCT h.vonalid) AS vonalak_szama
FROM allomas a
JOIN hely h ON a.id = h.allomasid
GROUP BY a.nev
HAVING COUNT(DISTINCT h.vonalid) >= 5
ORDER BY COUNT(DISTINCT h.vonalid) DESC, a.nev;

-- 9. feladat:
-- Napjainkban két állomás közötti jegyet kell váltani, de régebben a jegy egy adott távolságintervallumon
-- volt érvényes: 5, 10, 20, ..., 90, 100, ... km-es jegyeket lehetett venni. Ha valaki 100 km távolságra szóló
-- jegyet vett, akkor bizonyára távolabb utazott, mint 90 km (mert az volt az azt közvetlenül megelőző, 100
-- km-nél rövidebb távra szóló jegy),de a 100 km-t nem léphette túl. Készítsen lekérdezést, amelyik megadja,
-- hogy a 140-es vonal indulási állomásától hova utazhatott az, aki 100 km-es jegyet vett! Adja meg az
-- állomások nevét és a távolságát!
SELECT a.nev, h.tav
FROM allomas a
JOIN hely h ON a.id = h.allomasid
WHERE h.vonalid = '140' AND h.tav <= 100
ORDER BY h.tav DESC;


