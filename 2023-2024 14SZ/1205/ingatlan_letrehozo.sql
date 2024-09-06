CREATE TABLE ingatlan(
iazon VARCHAR(4) PRIMARY KEY,
kerulet TINYINT NOT NULL,
pazon VARCHAR(3) NOT NULL,
ar INTEGER NOT NULL,
uazon VARCHAR(3) NOT NULL,
nm INTEGER NOT NULL,
tipus VARCHAR(20) NOT NULL,
eladdatum DATE);

CREATE TABLE partner(
pazon VARCHAR(3) PRIMARY KEY,
pnev VARCHAR(20) NOT NULL,
telszam VARCHAR(20) NOT NULL);

CREATE TABLE ugynok(
uazon VARCHAR(3) PRIMARY KEY,
unev VARCHAR(20) NOT NULL);

CREATE TABLE jutalek(
iazon VARCHAR(3) NOT null,
osszeg INTEGER NOT null);

INSERT INTO ugynok (uazon, unev) VALUES 
("U01", "Törpapa"),
("U02","Hókuszpók"),
("U03","Okoska"),
("U04","Törpilla");

INSERT INTO partner(pazon, pnev,telszam) VALUES 
("P01", "Hófehérke","06201234567"),
("P02","Herceg","06302345678"),
("P03","Gonosz Mostoha","06703456789"),
("P04","Tudor","06205281477"),
("P05","Vidor","06308989899"),
("P06","Szende","06205252522"),
("P07","Szundi","06702323233"),
("P08","Hapci","06201414145"),
("P09","Morgó","06709996664");

INSERT INTO ingatlan(iazon,kerulet,pazon,ar,uazon,nm,tipus,eladdatum) VALUES 
("I01",12,"P01",82000000,"U02",121,"lakás",NULL),
("I02",11,"P09",25000000,"U01",35,"lakás",NULL),
("I03",15,"P02",41000000,"U03",72,"családi ház","2021-01-22"),
("I04",14,"P08",72000000,"U02",67,"családi ház","2021-02-10"),
("I05",13,"P03",15000000,"U04",25,"üzlet helység",null),
("I06",8,"P07",22000000,"U01",67,"panel lakás","2021-02-11"),
("I07",9,"P04",12000000,"U02",20,"üzlet helység",NULL),
("I08",7,"P06",52000000,"U01",114,"lakás","2021-02-14"),
("I09",18,"P05",2500000,"U03",12,"üzlet helység",NULL),
("I10",3,"P01",21000000,"U04",25,"panel lakás","2021-02-18"),
("I11",6,"P02",62000000,"U01",86,"lakás","2021-09-28"),
("I12",13,"P01",32000000,"U03",52,"panel lakás",null);

INSERT INTO jutalek(iazon,osszeg) VALUES
("I03",410000),
("I04",720000),
("I06",220000),
("I08",520000),
("I10",210000);