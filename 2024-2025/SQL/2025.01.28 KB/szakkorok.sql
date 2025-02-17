-- Adatbázis schema
-- diak (azon, nev, evfolyam, betujel)
--     azon        A diák azonosítója (szám), ez a kulcs
--     nev         A diák neve (szöveg)
--     evfolyam    A diák évfolyama (szám)
--     betujel     A diák osztályának betűjele (szöveg)

-- szakkor (azon, mk, nev, tanar)
--     azon        A szakkör azonosítója (szám), ez a kulcs
--     mk          A szakkört meghirdető tanári munkaközösség neve (szöveg)
--     nev         A szakkör neve (szöveg); a szakkörök neve egyedi
--     tanar       A szakkört tartó tanár neve (szöveg)

-- jelentkezes (azon, diakazon, szakazon)
--     azon        A jelentkezés azonosítója (szám), ez a kulcs
--     diakazon    A jelentkező diák azonosítója (szám)
--     szakazon    A szakkör azonosítója, amelyre a diák jelentkezik (szám)


-- 2. feladat: Készítsen lekérdezést, amely megadja a 10. évfolyam C osztályának szakkörre jelentkező tanulóinak a
-- nevét ábécérendben! A listában minden név csak egyszer jelenjen meg!
SELECT DISTINCT nev FROM diak WHERE betujel LIKE 'C' AND evfolyam = 10 ORDER BY nev;

-- 3. feladat: Készítsen lekérdezést, amely megadja azokat a szakköröket és az ezeket meghirdető tanárokat,
-- amely szakkörök nevében szerepel a „programoz” vagy a „robotika” szórészlet!
SELECT nev, tanar FROM szakkor WHERE nev LIKE '%programoz%' OR nev LIKE '%robotika%'

-- 4. feladat: Készítsen lekérdezést, amely megadja azokat a szakköröket, amelyekre legalább 10-en jelentkeztek! 
-- A lekérdezés a szakkörök számát jelenítse meg! (Azt, hogy hány ilyen van amire legalább 10-en jelentkeztek)
SELECT COUNT(*) AS szakkorok_szama FROM (SELECT szakazon FROM jelentkezes GROUP BY szakazon HAVING COUNT(*) >= 10) AS jelentkezok_szama;

-- 5. feladat: Készítsen lekérdezést, amely megadja azokat az osztályokat, amelyekből jelentkeztek a
-- „Matematika” munkaközösséghez tartozó egyik szakkörre! A lista legyen az osztályok évfolyama,
-- azon belül betűjel szerint rendezve, és a listában minden osztály csak egyszer jelenjen meg!
SELECT DISTINCT evfolyam, betujel, FROM diak JOIN jelentkezes ON diak.azon = jelentkezes.diakazon JOIN szakkor ON jelentkezes.szakazon = szakkor.azon WHERE szakkor.mk = 'Matematika' ORDER BY evfolyam, betujel; 

-- 6. feladat: Készítsen lekérdezést, amely megadja azon szakkörök nevét, amelyekre csak a 10. vagy a 11.
-- évfolyamról jelentkeztek, és más évfolyamról nem!
SELECT DISTINCT szakkor.nev FROM szakkor, jelentkezes, diak WHERE 
szakkor.azon = jelentkezes.szakazon AND jelentkezes.diakazon = diak.azon AND diak.evfolyam = 10 OR diak.evfolyam = 11;

-- 7. feladat: Készítsen lekérdezést, amely megadja „Beke Fanni” évfolyamtársai közül azokat, akikkel közös
-- szakkörre jár! A lekérdezés jelenítse meg a szakkörök és a diákok nevét! A névsorban „Beke Fanni”
-- neve ne jelenjen meg!
SELECT diak.nev, szakkor.nev
FROM diak, szakkor, jelentkezes
WHERE szakkor.azon = jelentkezes.szakazon AND diak.azon = jelentkezes.diakazon
AND diak.evfolyam = (SELECT diak.evfolyam FROM diak WHERE diak.nev LIKE "Beke Fanni");

-- 8. feladat: Készítsen jelentést a „2. idegen nyelv” munkaközösség szakköreiről! A jelentést lekérdezéssel
-- készítse elő! A jelentés legyen szakkörök szerint csoportosítva, és egy-egy szakkörnél a tanulók
-- ábécérendben kövessék egymást! A lekérdezés jelenítse meg a szakkörök és a diákok nevét valamint
-- a diák osztályát!
SELECT szakkor.nev AS szakkor_neve, diak.nev AS diak_neve, diak.betujel AS diak_osztalya
FROM diak
JOIN jelentkezes ON diak.azon = jelentkezes.diakazon
JOIN szakkor ON jelentkezes.szakazon = szakkor.azon
WHERE szakkor.mk = '2. idegen nyelv'
ORDER BY szakkor.nev, diak.nev;

-- 9. feladat: Készítsen lekérdezést, amely megadja azt az osztályt, ahonnan a legtöbbféle szakkörre jelentkeztek
-- a tanulók! A lekérdezés az osztály évfolyamát, betűjelét és a különböző szakkörök számát jelenítse
-- meg! A megoldás során feltételezheti, hogy csak egy ilyen osztály van.
SELECT diak.evfolyam, diak.betujel, 
COUNT(DISTINCT jelentkezes.szakazon) AS szakkorok_szama 
FROM diak JOIN jelentkezes ON diak.azon = jelentkezes.diakazon 
GROUP BY diak.evfolyam, diak.betujel 
ORDER BY szakkorok_szama DESC LIMIT 1;
