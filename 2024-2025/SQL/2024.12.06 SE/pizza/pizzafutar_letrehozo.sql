CREATE TABLE futar (
  fazon int(3) NOT NULL primary key,
  fnev varchar(25) NOT NULL,
  ftel varchar(12) NOT NULL
);

CREATE TABLE pizza (
  pazon int(3) NOT NULL primary key,
  pnev varchar(15) NOT NULL,
  par int(4) NOT NULL default '0'
);

CREATE TABLE rendeles (
  razon int(8) NOT NULL primary key,
  vazon int(6) NOT NULL,
  fazon int(3) NOT NULL,
  idopont datetime NOT NULL
);

CREATE TABLE tetel (
  razon int(8) NOT NULL default '0',
  pazon int(3) NOT NULL default '0',
  db int(3) NOT NULL default '0'
);

CREATE TABLE vevo (
  vazon int(6) NOT NULL primary key,
  vnev varchar(30) NOT NULL,
  vcim varchar(30) NOT NULL
);

INSERT INTO futar(fazon,fnev,ftel) VALUES 
(1, "Hurrikán", "1234567"),
(2, "Gyalogkakukk", "6666666"),
(3, "Gömbvillám", "8888888"),
(4, 'Szélvész', '2583690'),
(5, 'Imperial', '9876544');

INSERT INTO pizza(pazon,pnev,par) VALUES
(1, "Capricciosa", 2050),
(2, "Frutti di Mare", 2350),
(3, "Hawaii", 1850),
(4, "Vesuvio", 1900),
(5, "Sorrento", 2050);

INSERT INTO rendeles(razon,vazon,fazon,idopont) VALUES 
(1, 4, 2, "2019-10-01 12:04:11"),
(2, 7, 2, "2019-10-01 13:18:44"),
(3, 1, 1, "2019-10-02 10:11:41"),
(4, 5, 2, "2019-10-02 10:24:59"),
(5, 2, 3, "2019-10-02 13:19:06"),
(6, 4, 2, "2019-10-03 13:14:38"),
(7, 6, 2, "2019-10-04 11:10:35"),
(8, 7, 4, "2019-10-04 15:34:58"),
(9, 1, 5, "2019-10-04 17:07:59"),
(10, 3, 5, "2019-10-04 20:21:51"),
(11, 2, 1, "2019-10-05 18:52:53"),
(12, 5, 2, "2019-10-05 19:59:02"),
(13, 6, 2, "2019-10-06 14:55:03"),
(14, 4, 3, "2019-10-06 15:01:14"),
(15, 1, 4, "2019-10-06 18:48:46"),
(16, 2, 5, "2019-10-06 19:11:03"),
(17, 7, 2, "2019-10-06 19:56:28"),
(18, 3, 2, "2019-10-07 12:45:30"),
(19, 4, 5, "2019-10-07 13:00:56"),
(20, 1, 1, "2019-10-07 15:42:50"),
(21, 5, 3, "2019-10-08 18:56:00");

INSERT INTO tetel(razon,pazon,db) VALUES 
(1, 1, 2),
(1, 4, 3),
(2, 2, 1),
(3, 1, 2),
(4, 1, 1),
(4, 4, 1),
(5, 2, 4),
(6, 1, 1),
(6, 4, 1),
(6, 5, 1),
(7, 5, 5),
(8, 4, 3),
 (9, 2, 1),
 (10, 1, 1),
 (10, 4, 1),
 (11, 1, 1),
 (12, 2, 2),
 (12, 4, 2),
 (13, 4, 1),
 (13, 5, 1),
 (13, 2, 1),
 (14, 2, 2),
 (15, 1, 1),
 (16, 2, 1),
 (16, 4, 1),
 (16, 5, 1),
 (17, 1, 2),
 (17, 2, 3),
 (18, 1, 4),
 (18, 5, 1),
 (19, 1, 1),
 (19, 2, 1),
 (19, 4, 1),
 (19, 5, 1),
 (20, 5, 3),
 (21, 2, 2),
 (21, 4, 1);
 
INSERT INTO vevo(vazon,vnev,vcim) VALUES 
(1, "Hapci", "Kerekerdő"),
(2, "Vidor", "Gombaház"),
(3, "Tudor", "Sötéterdő"),
(4, "Kuka", "Bánya"),
(5, "Szende", "Tisztás"),
(6, "Szundi", "Szikla"),
(7, "Morgó", "Rét");