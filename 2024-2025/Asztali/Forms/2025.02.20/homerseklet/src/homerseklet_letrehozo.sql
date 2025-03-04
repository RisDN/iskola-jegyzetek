
CREATE TABLE homerseklet(
azon INT PRIMARY KEY NOT NULL,
varos VARCHAR(40) NOT NULL,
napszak VARCHAR(10) NOT NULL,
datum DATE NOT NULL,
ertek FLOAT NOT NULL,
csapadek INT DEFAULT 0
)


INSERT INTO homerseklet (azon, varos, napszak, datum, ertek, csapadek) VALUES
(31, "Budapest", "este", '2008-01-12', "1.8", 12),
(32, "Ózd", "reggel", '2009-12-28', "5.5", 5),
(38, "Vác", "reggel", '2012-06-28', "32.8", 0),
(39, "Vác", "délután", '2014-10-18', "16.5", 4),
(40, "Ózd", "este", '2018-03-28', "21.7", 0);
