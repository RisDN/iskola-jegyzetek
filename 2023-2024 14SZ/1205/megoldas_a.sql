-- 1) Lakástípusonként írasd ki az összeladási árat! (2p)
select tipus, sum(ar)
from ingatlan
group by tipus;
--  Készíts egy nézet táblát, mely az eladott
-- ingatlanok adatait tartalmazza ár szerint növekvő 
-- sorrendben! A nézet tábla neve: 
-- eladott_ingatlanok(azonosito, kerulet, eladasi_ar, meret, 
-- tipus, eladas_datuma). 
create view eladott_ingatlanok(azonosito,kerulet,eladasi_ar,meret,tipus,eladas_datuma)
as
select iazon,kerulet,ar,meret,tipus,eladdatum
from ingatlan
where eladdatum is not null
order by ar asc;
-- Készíts egy nézet táblát mely az eladásra váró
-- ingatlanok adatait tartalmazza, úgy, hogy 
-- megjelenik az ingatlanügynök neve és az eladó neve
-- is! A nézet tábla neve: eladasravaro_ingatlanok(
-- azonosito, ugynok, elado, kerulet, eladasi_ar,
-- meret, tipus). (6p)
create view eladasravaro_ingatlanok(azonosito,ugynok,elado,kerulet,eladasi_ar,meret,tipus)
as
select ingatlan.iazon, ugynok.unev,partner.pnev,ingatlan.kerulet,ingatlan.ar,ingatlan.meret,ingatlan.tipus
from ingatlan natural join ugynok natural join partner
where ingatlan.eladdatum is null;
-- Készíts egy nézet táblát, mely megadja a
-- legdrágább, eladásra váró ingatlan tulajdonosának 
-- nevét és telefonszámát! A nézet tábla neve:
-- legdragabb_ingatlan(elado, telefonszam). (6p)
create view legdragabb_ingatlan(elado,telefonszam)
as
select partner.pnev,partner.telszam
from ingatlan natural join partner
where  ingatlan.ar=(select max(ingatlan.ar) from ingatlan where eladdatum is null)
and eladdatum is null;
-- Listázd ki az eladott ingatlanok közül azokat,
-- melyek az az eladott ingatlanok átlag eladási ára 
-- átlag alattiak! (5p)
select ingatlan.*
from ingatlan
where ar<(select avg(ar) from ingatlan where eladdatum is not null)
and eladdatum is not null;
-- Vegyél fel egy új ingatlan ügynököt, akinek a 
-- kódja „U05” neve pedig a saját keresztneved legyen!
-- (1p)
insert into ugynok(uazon,unev)
values ("U05","Erika");
-- 7) Add meg a panel lakások közül a legkisebb
-- méretű lakás ingatlanügynökének nevét! (7p)
select ugynok.unev
from ugynok natural join ingatlan
where 
	ar=(select min(ar) from ingatlan where tipus="panel lakás")
    and tipus="panel lakás";
-- 8) Listázd ki az összes ingatlant és a
-- hozzájuk tartozó jutalékok összegét! (3p)
select ingatlan.*,jutalek.osszeg
from ingatlan natural left join jutalek;
-- 9) Listázd ki ingatlan típusonként az átlag
-- eladási árakat, úgy, hogy az árak szerint
-- csökkenő sorrendben jelenjenek meg! (3p)
select tipus,avg(ar)
from ingatlan
group by tipus
order by avg(ar) desc;
-- 10) Az eladott_ingatlanok nézet tábla
-- felhasználásával listázd ki azok adatait, az
-- értékesítő ügynök nevét és a jutalék összegét! (3p)
select eladott_ingatlanok.*,ugynok.unev, jutalek.osszeg
from ingatlan,eladott_ingatlanok,ugynok
where ingatlan.iazon=eladott_ingatlanok.azonosito
	and ingatlan.uazon=ugynok.uazon;
-- 11) Mely ingatlanok vannak az átlag méret felett
-- (ingatlan minden adatát írasd ki! (3p)
select *
from ingatlan
where meret>(select avg(mere) from ingatlan);
-- 12) Listázd ki az összes partnert a hozzá tartozó
-- ingatlan(ok) adataival. (3p)
select partner.pnev, ingatlan.*
from partner natural left join ingatlan;
-- 13) Listázd ki az összes ügynököt és a hozzájuk
-- tartozó összjutalékot! (5p)
select ugynok.unev,sum(jutalek.osszeg)
from ugynok natural left join ingatlan natural left join jutalek
group by ugynok.unev;
-- 14) Add meg, hogy Hókuszpók ingatlanügynök mely
-- eladóval (név, telefonszám) van jelenleg is 
-- kapcsolatban (azaz nem zárult le az ingatlan eladás)!
--  (6p)
select partner.pnev,partner.telszam
from ingatlan natural join partner natural join ugynok
where ugynok.unev="Hókuszpók"
	and eladdatum is null;
-- 15) Listázd ki az összes ingatlanügynököt (neve)
-- és a hozzájuk tartozó ingatlanokat (minden adatát)!
-- (3p)
select ugynok.unev, ingatlan.*
from ugynok natural left join ingatlan;





