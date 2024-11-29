# 2. feladat
INSERT INTO dolgozok (DKOD, DNEV, SZULHELY, SZULIDO, FIZETES)
VALUES 
('D2345', 'Kiss János', 'Budapest', '1968-12-11', 240000),
('D3456', 'Kis Béla', 'Budapest', '1970-02-28', 210000),
('D4567', 'Nagy Lajos', 'Eger', '1972-01-30', 300000),
('D5678', 'Veres Péter', 'Eger', '1958-07-12', 420000),
('D6789', 'Kovács Eszter', 'Szeged', '1967-05-12', 240000);

# 3. feladat
SELECT * FROM dolgozok;

# 4. feladat
SELECT DNEV AS "Dolgozó neve", FIZETES AS "Fizetés" FROM dolgozok;

# 5. feladat
SELECT DNEV AS "Dolgozó neve", FIZETES * 1.10 AS "Emelt fizetés" FROM dolgozok;

# 6. feladat
SELECT DISTINCT SZULHELY FROM dolgozok;

# 7. feladat
SELECT COUNT(DKOD) AS "A dolgozók száma", SUM(FIZETES) AS "A dolgozók összes fizetése", AVG(FIZETES) AS "A dolgozók átlagos fizetése" FROM dolgozok;

# 8. feladat
SELECT DNEV AS "Név", LEFT(SZULHELY, 3) AS "Rövid születési hely", YEAR(SZULIDO) AS "Születési évszám" FROM dolgozok;

# 9. feladat
SELECT DNEV, FIZETES FROM dolgozok WHERE FIZETES < 300000;

# 10. feladat
SELECT DNEV, FIZETES FROM dolgozok WHERE FIZETES > 210000 AND SZULIDO > "1968-01-01";

# 11. feladat
SELECT DNEV, SZULHELY, FIZETES FROM dolgozok WHERE FIZETES > 210000 AND FIZETES < 240000;

# 12. feladat
SELECT DNEV, FIZETES FROM dolgozok WHERE FIZETES = 200000 OR FIZETES = 300000;

# 13. feladat
SELECT DKOD AS "Dolgozói azonosító", DNEV AS "Név", SZULHELY AS "Születési hely", SZULIDO AS "Születési idő", FIZETES AS "Fizetés"
FROM dolgozok WHERE (SZULHELY LIKE "Eger" AND FIZETES = 300000) OR (SZULHELY LIKE "Budapest" AND SZULIDO > "1970-01-01");

# 14. feladat
SELECT DNEV, SZULHELY FROM dolgozok WHERE DNEV LIKE '%Kis %';