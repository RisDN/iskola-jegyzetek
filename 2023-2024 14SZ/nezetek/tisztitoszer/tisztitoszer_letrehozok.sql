create table vevo
(vkod varchar(4) not null primary key,
vnev varchar(200) not null,
telepules varchar(45) not null);

create table cikkek
(cikkszam varchar(4) not null primary key,
cikknev varchar(45) not null, 
bruttoar integer not null);

create table rendeles_torzs
(rszam varchar(4) not null primary key,
vkod varchar(4) not null,
datum date not null,
szallitva varchar(1), 
szalldatum date);

create table rendeles_tetel
(rszam varchar(4) not null,
cikkszam varchar(4) not null,
menny int not null);

insert into cikkek(cikkszam,cikknev,bruttoar)
values
("T001","fertőtlenítőszer",439),
("T002","súrolószer",598),
("T003","víkőoldó",485),
("T004","ablaktisztító",697),
("T005","törlőkendő",324),
("T006","mosogatószer",298),
("T007","fehérítő",555),
("T008","mosószer",1236);

insert into vevo(vkod,vnev,telepules)
values
("V001","Nagy Jolán","Fót"),
("V002","Kis Béla","Budapest"),
("V003","Kovács István","Veresegyház"),
("V004","Takács Ernő","Budapest"),
("V011","Húz Ella","Kistarcsa"),
("V018","Tök Ödön","Fót");

insert into rendeles_torzs(rszam,vkod,datum,szallitva,szalldatum)
values
("R001","V001","2015-10-04","Y","2015-10-15"),
("R002","V003","2015-10-28","Y","2015-11-05"),
("R003","V007","2015-10-30","Y","2015-11-05"),
("R004","V002","2015-11-16","Y","2015-12-20"),
("R005","V004","2015-12-03","Y","2015-12-20"),
("R006","V004","2015-12-17","Y","2015-12-20"),
("R007","V003","2015-12-19","N",null),
("R008","V001","2016-01-06","Y","2016-01-10"),
("R009","V004","2016-01-13","N",null),
("R010","V001","2016-10-04","N",NULL),
("R011","V006","2016-10-08","N",null);

insert into rendeles_tetel(rszam,cikkszam,menny)
values
("R001","T004",15),
("R001","T005",21),
("R002","T001",18),
("R003","T001",10),
("R004","T002",8),
("R005","T005",10),
("R005","T002",2),
("R006","T003",22),
("R006","T004",15),
("R007","T002",11),
("R008","T002",24),
("R009","T003",10),
("R009","T005",16),
("R009","T004",12);