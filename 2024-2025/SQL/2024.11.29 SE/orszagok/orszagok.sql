# 1. Mi MADAGASZKÁR fővárosa?
SELECT fovaros FROM orszagok WHERE orszag LIKE 'madagaszkár';


# 2. Melyik ország fővárosa OUAGADOUGOU?
SELECT orszag FROM orszagok WHERE fovaros LIKE 'OUAGADOUGOU';


# 3. Melyik ország autójele a TT?
SELECT orszag FROM orszagok WHERE autojel LIKE 'TT';


# 4. Melyik ország pénzének jele az SGD?
SELECT orszag FROM orszagok WHERE penzjel LIKE 'SGD';


# 5. Melyik ország nemzetközi telefon-hívószáma a 61?
SELECT orszag FROM orszagok WHERE telefon = 61;


# 6. Mekkora területű Monaco?
SELECT terulet FROM orszagok WHERE orszag LIKE 'MoNaCo';


# 7. Hányan laknak Máltán?
SELECT nepesseg * 1000 FROM orszagok WHERE orszag LIKE 'málta';


# 8. Mennyi Japán népsűrűsége?
SELECT (nepesseg * 1000)/terulet FROM orszagok WHERE orszag LIKE 'japán';


# 9. Mely országok népsűrűsége nagyobb 500 fő/km2-nél?
SELECT orszag FROM orszagok WHERE (nepesseg * 1000)/terulet > 500;


# 10. Melyek a szigetországok?
SELECT orszag FROM orszagok WHERE foldr_hely LIKE '%szigetország%';


# 11. Melyik a első hat legnagyobb területű ország?
SELECT orszag FROM orszagok ORDER BY terulet DESC LIMIT 6;


# 12. Melyik három ország területe a legkisebb?
SELECT orszag FROM orszagok ORDER BY terulet LIMIT 3;


# 13. Melyik a 40. legkisebb területű ország?
SELECT orszag FROM orszagok ORDER BY terulet DESC LIMIT 1 OFFSET 39;


# 14. Melyik a 15. legkisebb népességű ország?
SELECT orszag FROM orszagok ORDER BY terulet LIMIT 1 OFFSET 14;


# 15. Melyik a 61. legnagyobb népsűrűségű ország?
SELECT orszag FROM orszagok ORDER BY (nepesseg * 1000)/terulet DESC LIMIT 1 OFFSET 60;


# 16 Hány lakosa van a Földnek?
SELECT SUM(nepesseg)*1000 FROM orszagok;


# 17. Mennyi a Föld népsűrűsége?
SELECT SUM(nepesseg * 1000)/SUM(terulet) FROM orszagok;


# 18. Hány 1.000.000 km2-nél nagyobb területű ország van?
SELECT COUNT(*) FROM orszagok WHERE terulet > 1000000;


# 19. Hány ország területe esik 50.000 és 150.000 km2 közé?
SELECT COUNT(*) FROM orszagok WHERE terulet BETWEEN 50000 AND 150000;


# 20. Hány 1.000.000-nál kevesebb lakosú ország van?
SELECT COUNT(*) FROM orszagok WHERE nepesseg < 1000000;


# 21. Hány olyan ország van, aminek a területe kisebb, mint 10.000 km2, a. vagy a lakossága kevesebb 1.000.000-nál?
SELECT COUNT(*) FROM orszagok WHERE terulet < 10000 OR nepesseg < 1000000;


# 22. Hány ország pénzneme a kelet-karib dollár?
SELECT COUNT(*) FROM orszagok WHERE penznem LIKE 'kelet-karib dollár';


# 23. Hány ország nevében van benne, hogy "ORSZÁG"?
SELECT COUNT(*) FROM orszagok WHERE orszag LIKE '%ország%'


# 24. Hány ország van Afrikában?
SELECT COUNT(*) FROM orszagok WHERE foldr_hely LIKE '%afrika%'


# 25. Mennyi Afrika lakossága?
SELECT SUM(nepesseg) FROM orszagok WHERE foldr_hely LIKE '%afrika%'


# 26. Mennyi Európa területe?
SELECT SUM(terulet) FROM orszagok WHERE foldr_hely LIKE '%európa%'


# 27. Mennyi Európa népsűrűsége?
SELECT SUM(nepesseg * 1000)/SUM(terulet) FROM orszagok WHERE foldr_hely LIKE '%európa%';


# 28. Hány országnak nincs autójelzése?
SELECT COUNT(*) FROM orszagok WHERE autojel LIKE '';


# 29. Hány országban nem 100 a váltószáma az aprópénznek?
SELECT COUNT(*) FROM orszagok WHERE valtopenz NOT LIKE '%100%';

