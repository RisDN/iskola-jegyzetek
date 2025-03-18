-- 2. feladat: Kisfaludi Strobl Zsigmond alkotta a Budapesten, 1963-ban avatott egyetlen Csajkovszkijt ábrázoló mellszobrot. Jegyezze be ezt a tényt a kapcsolat táblába!
insert into kapcsolat (szoborid, alkotoid)
select s.id, a.id
from szobor s, alkoto a
where s.szemely = 'Csajkovszkij' and s.hely = 'Budapest' and s.avatas = 1963 and a.nev = 'Kisfaludi Strobl Zsigmond';

-- 3. feladat: Készítsen lekérdezést, amely megadja azt az 5 személyt, akiket a legtöbb szobor ábrázol! Jelenítse meg a megformált személy nevét és a darabszámot, a darabszám szerint csökkenő sorrendben!
select s.szemely, count(*) as darab
from szobor s
group by s.szemely
order by darab desc
limit 5;

-- 4. feladat: Medgyessy Ferenc kétszeres Kossuth-díjas szobrász. Készítsen lekérdezést, amely megadja, hogy mellszobrai hol állnak, kit ábrázolnak és az alkotó hány éves korában avatták fel azokat!
select s.hely, s.szemely, s.avatas - a.szulev as kor
from szobor s, alkoto a, kapcsolat k
where a.nev = 'Medgyessy Ferenc' and a.id = k.alkotoid and k.szoborid = s.id;

-- 5. feladat: Készítsen lekérdezést, amely megadja azon adatbázisban szereplő alkotók nevét, akiknek a születési évük és születési helyük közül csak az egyik ismert!
select nev
from alkoto
where szulev is null or szulhely is null;

-- 6. feladat: Készítsen lekérdezést, amely megadja, hogy mely budapesti szobrok adatai kerültek az adatbázisba az avatás évében! Az ábrázolt személy nevét és az avatás évét adja meg!
select szemely, avatas
from szobor
where hely = 'Budapest' and avatas is not null and year(rogzites) = avatas;

-- 7. feladat: Készítsen lekérdezést, amely megadja, hogy kik azok a múlt század első felében (1901 és 1950 között, a határokat is beleértve) született alkotók, akiknek születési helyén van általuk készített szobor! Az alkotó neve és születési helye jelenjen meg, de mindenki csak egyszer! A budapesti alkotásokat ne vegye figyelembe!
select distinct a.nev, a.szulhely
from alkoto a, szobor s, kapcsolat k
where a.szulev between 1901 and 1950 and a.szulhely = s.hely and a.id = k.alkotoid and k.szoborid = s.id and s.hely != 'Budapest';

-- 8. feladat: Mely településeken kapott mellszobrot „Erkel Ferenc” és „Liszt Ferenc” is? Egészítse ki az alábbi lekérdezést, úgy, hogy az válaszoljon az előbbi kérdésre!
-- SELECT DISTINCT hely
-- FROM szobor
-- WHERE hely IN (...)
-- AND szemely=’Liszt Ferenc’;
select distinct hely
from szobor where hely
in (select hely from szobor where szemely = 'Erkel Ferenc')
and szemely = 'Liszt Ferenc';

-- 9. feladat: Készítsen lekérdezést a debreceni mellszobrokról! A szobrokat alkotó és avatás éve szerint növekvően rendezve jelenítse meg! A lekérdezés elkészítésekor a mezők sorrendjét, a címet és a címkék megjelenítését vegye figyelembe!
select a.nev as 'Alkotó', s.szemely as 'Ábrázolt személy', s.avatas as 'Avatás éve'
from szobor s, alkoto a, kapcsolat k
where s.hely = 'Debrecen' and s.id = k.szoborid and a.id = k.alkotoid
order by a.nev, s.avatas;