-- 1. feladat:
-- Importálja be a mellékelt szöveges állományt az adatbázisába! oscardijasfilmek.sql


-- 2. feladat: 
-- Készítsen lekérdezést, amely az elismerés évének sorrendjében jeleníti meg az Oscar-díjas
-- filmeket! Az elnyerés éve és a film eredeti címe jelenjen meg!
SELECT ev, cim FROM oscar_film WHERE nyert = 1 ORDER BY ev;


-- 3. feladat:
-- Készítsen lekérdezést, amely megadja, hogy mely években jelöltek legalább 10 filmet a díjra!
-- Csak a jelölés évét jelenítse meg!
SELECT ev FROM oscar_film GROUP BY ev HAVING COUNT(*) >= 10;

-- 4. feladat:
-- Készítsen lekérdezést, amely megadja azon filmek eredeti címét, amelyeket a második világháború
-- éveiben (1939 és 1945 között, a határokat is beleértve) jelöltek és ebben az időszakban be is
-- mutattak hazánkban!
SELECT cim FROM oscar_film WHERE ev >= 1939 AND ev <= 1945 AND bemutato IS NOT NULL;

-- 5. feladat:
-- Készítsen lekérdezést, amely megadja, hogy mely nyertes filmek esetén volt a magyarországi
-- bemutató legalább 10 évvel később, mint a díjazás! Csak a film eredeti címét jelenítse meg!
SELECT cim FROM oscar_film WHERE (bemutato - ev) >= 10 AND nyert = 1;

-- 6. feladat:
-- Vannak olyan producerek, akiknek több filmjét is jelölték díjra, e feladatban őket keressük. Készítsen
-- lekérdezést, amely megadja, hogy hány év telt el a legelső és a legutolsó jelölés között! 
SELECT MAX(ev) - MIN(ev) AS Eltelt, keszito.nev
FROM oscar_film
JOIN kapcsolat ON oscar_film.id = kapcsolat.filmid
JOIN keszito ON kapcsolat.keszitoid = keszito.id
WHERE keszito.producer = true
GROUP BY keszito.id
HAVING COUNT(*) > 1;

-- 7. feladat:
-- Nem ritka, hogy egy-egy filmnek több, akár három-négy producere is van. Készítsen lekérdezést,
-- amely megadja, hogy a jelölést kapott, azaz az adatbázisban tárolt filmekben kik voltak „Clint
-- Eastwood” producertársai! Az érintett személyek nevét jelenítse meg, és biztosítsa, hogy mindenki
-- csak egyszer szerepeljen!
SELECT DISTINCT keszito.nev
FROM oscar_film
JOIN kapcsolat ON oscar_film.id = kapcsolat.filmid
JOIN keszito ON kapcsolat.keszitoid = keszito.id
WHERE oscar_film.id IN (SELECT filmid FROM kapcsolat WHERE keszitoid IN 
(SELECT id FROM keszito WHERE nev = 'Clint Eastwood')) AND keszito.nev != 'Clint Eastwood';

-- 8. feladat:
-- Készítsen lekérdezést, amely megadja, hogy kik azok a producerek, akiknek egyetlen Oscar-díjra
-- jelölt filmje esetén sem ismert a magyarországi bemutató dátuma!
SELECT DISTINCT keszito.nev FROM oscar_film, keszito, kapcsolat 
WHERE kapcsolat.filmid = oscar_film.id 
AND keszito.id = kapcsolat.keszitoid
AND oscar_film.bemutato IS NULL
AND keszito.producer = 1;
