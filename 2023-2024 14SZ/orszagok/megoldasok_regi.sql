-- 1)	Mi MADAGASZKÁR fővárosa?
select fovaros
from orszagok
where orszag="MADAGASZKAR";
-- 2)	Melyik ország fővárosa OUAGADOUGOU?
select orszag
from orszagok
where fovaros="OUAGADOUGOU";
-- 3)	Melyik ország autójele a TT?
select orszag
from orszagok
where autojel="TT";
-- 4)	Melyik ország pénzének jele az SGD?
select orszag
from orszagok
where penzjel="SGD";
-- 5)	Melyik ország nemzetközi telefon-hívószáma a 61?
select orszag
from orszagok
where telefon=61;
-- 6)	Mekkora területű Monaco?
select terulet
from orszagok
where orszag="MONACO";
-- 7)	Hányan laknak Máltán?
select nepesseg
from orszagok
where orszag="MALTA";
-- 8)	Mennyi Japán népsűrűsége?
select nepesseg*1000/terulet as nepsuruseg
from orszagok
where orszag="Japan";
-- 9)	Mely országok népsűrűsége nagyobb 500 fő/km2-nél?
select orszag
from orszagok
where nepesseg*1000/terulet>500;
-- 10)	Melyek a szigetországok?
select orszag
from orszagok
where foldr_hely like "%szigetorszag%";
-- 11)	Melyik a első hat legnagyobb területű ország?
select orszag
from orszagok
order by terulet desc
limit 6;
-- 12)	Melyik három ország területe a legkisebb?
select orszag
from orszagok
order by terulet
limit 3;

-- 13)	Melyik a 40. legkisebb területű ország?
select orszag
from orszagok
order by terulet
-- limit 1 offset 39;
limit 39,1;
-- 14)	Melyik a 15. legkisebb népességű ország?
select orszag
from orszagok
order by nepesseg asc
limit 14,1;
-- 15)	Melyik a 61. legnagyobb népsűrűségű ország?
select orszag
from orszagok
order by nepesseg*1000/terulet desc
limit 60,1;
-- 16)	Hány lakosa van a Földnek?
select sum(nepesseg*1000) as "A Föld lakosai"
from orszagok;
-- 17)	Mennyi a Föld népsűrűsége?
select sum(nepesseg*1000)/sum(terulet)
from orszagok;
-- 18)	Hány 1.000.000 km2-nél nagyobb területű ország van?
select count(orszag)
from orszagok
where terulet>1000000;
-- 19)	Hány ország területe esik 50.000 és 150.000 km2 közé?
select count(orszag)
from orszagok
where terulet between 50000 and 150000;
-- 20)	Hány 1.000.000-nál kevesebb lakosú ország van?
select count(orszag)
from orszagok
where nepesseg<1000000;
-- 21)	Hány olyan ország van, aminek a területe
-- kisebb, mint 10.000 km2, vagy a lakossága
-- kevesebb 1.000.000-nál?
select count(orszag)
from orszagok
where terulet<10000
	or nepesseg<1000000;
-- 22)	Hány ország pénzneme a kelet-karib
-- dollár?
select count(orszag)
from orszagok
where penznem="kelet-karib dollár";
-- 23)	Hány ország nevében van benne, hogy
-- "ORSZÁG"?
select count(orszag)
from orszagok
where orszag like "%ORSZÁG%";
-- 24)	Hány ország van Afrikában?
select count(orszag)
from orszagok
where foldr_hely like "%Afrika%";
-- 25)	Mennyi Afrika lakossága?
select sum(nepesseg*1000)
from orszagok
where foldr_hely like "%Afrika%";
-- 26)	Mennyi Európa területe?
select sum(terulet)
from orszagok
where foldr_hely like "%Európa%";
-- 27)	Mennyi Európa népsűrűsége?
select sum(nepesseg*1000)/sum(terulet)
from orszagok
where foldr_hely like "%Európa%";
-- 28)	Hány országnak nincs autójelzése?
select count(orszag)
from orszagok
where autojel="";
-- 29)	Hány országban nem 100 a váltószáma az aprópénznek?
select count(orszag)
from orszagok
where valtopenz not like("100 %");