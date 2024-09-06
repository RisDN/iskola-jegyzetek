CREATE TABLE fizetesek (
  dkod VARCHAR(4) NOT NULL,
  datum DATE NULL,
  kifizetes INT NULL,
  adoeloleg INT NULL);

CREATE TABLE szemely_th (
  dkod VARCHAR(4) NOT NULL,
  thkod VARCHAR(4) NOT NULL);

CREATE TABLE telephely_torzs (
  thkod VARCHAR(4) NOT NULL,
  thnev VARCHAR(45) NOT NULL,
  PRIMARY KEY (thkod));

CREATE TABLE szemely_torzs (
  dkod VARCHAR(4) NOT NULL,
  dnev VARCHAR(45) NOT NULL,
  szulhely VARCHAR(20) NOT NULL,
  szulido DATE NOT NULL,
  fizetes INT NOT NULL,
  belepdatum DATE NOT NULL,
  kilepdatum DATE NULL,
  beosztas VARCHAR(8) NOT NULL,
  PRIMARY KEY (dkod));

INSERT INTO telephely_torzs (thkod, thnev) VALUES ('1000', 'Budapest'),
('3200', 'Eger'),
('5000', 'Debrecen');

INSERT INTO szemely_torzs (dkod, dnev, szulhely, szulido, fizetes, belepdatum,kilepdatum, beosztas) 
VALUES 
('1234', 'Gipsz Jakab', 'Budapest', '1962-08-13', '220000', '2017-08-11',NULL, 'fizikai'),
('1235', 'Mező Mária', 'Debrecen', '1976-12-12', '450000', '2018-08-21',NULL, 'vezető'),
('2345', 'Cserép Virág', 'Szeged', '1988-10-12', '320000', '2019-01-06',NULL, 'szellemi'),
('4687', 'Kis Géza', 'Debrecen', '1959-02-09', '188000', '2017-10-18', '2018-12-20', 'fizikai'),
('4785', 'Kiss Miklós', 'Budapest', '1987-04-07', '510000', '2019-10-11',NULL, 'vezető'),
('7845', 'Magyar István', 'Eger', '1960-06-01', '380000', '2018-11-14',NULL, 'szellemi'),
('8541', 'Vezér Tas', 'Szeged', '1959-04-06', '250000', '2017-08-12',NULL, 'fizikai'),
('7462', 'Nagy Emőd', 'Eger', '1990-06-12', '270000', '2019-12-01',NULL, 'fizikai'),
('9682', 'Pintér Eszter', 'Budapest', '1982-02-17', '360000', '2018-08-14', '2019-01-19', 'szellemi'),
('9681', 'Nagy Máté', 'Szeged', '1971-10-06', '325000', '2018-12-03',NULL, 'szellemi'),
('4581', 'Bezzeg Jakab', 'Debrecen', '1970-06-08', '421000', '2019-10-12', '2019-12-03', 'vezető'),
('3581', 'Nagy Béla', 'Szeged', '1980-02-15', '210000', '2017-12-01',NULL, 'fizikai'),
('4216', 'Kis Tünde', 'Eger', '1960-10-08', '220000', '2017-12-03', '2020-02-06', 'fizikai');

INSERT INTO fizetesek (dkod,datum,kifizetes,adoeloleg) VALUES
('1234','2020-02-05','321200','60000'),
('7845','2020-02-05','342112','62000'),
('9681','2020-02-05','214000','37100'),
('7462','2020-02-10','222222','40000'),
('3581','2020-02-10','184500','42100');

INSERT  INTO szemely_th (dkod,thkod) VALUES 
('1234','1000'),
('1235','5000'),
('2345','1000'),
('4687','5000'),
('3581','3200'),
('4785','1000'),
('7845','3200'),
('8541','5000'),
('7462','3200'),
('9682','1000'),
('4216','3200'),
('9681','5000'),
('4581','5000');