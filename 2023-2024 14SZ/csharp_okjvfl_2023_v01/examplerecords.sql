-- CREATE DATABASE koboldbikersdb;
-- USE koboldbikersdb;

-- CREATE TABLES missing here --

INSERT INTO kobolds (name, size) VALUES
('Zam', 0),
('Tox', 0),
('Sug', 0),
('Hott', 1);

INSERT INTO types (name, price, size) VALUES
('Desire', 40, 0),
('Patriot', 65, 0),
('Hammer', 110, 1),
('Satisfaction', 300, 1);

INSERT INTO bikes (color, typeID) VALUES
('black', 1),
('blue', 2),
('red', 2),
('black', 2),
('yellow', 3),
('red', 4),
('brown', 4);

INSERT INTO rentals (start, days, koboldID, bikeID) VALUES
('2023-04-20', 7, 1, 3),
('2023-04-21', 2, 3, 2),
('2023-04-21', 1, 2, 1),
('2023-04-25', 1, 4, 5),
('2023-05-02', 3, 1, 4),
('2023-04-23', 4, 2, 1),
('2023-05-10', 4, 4, 6),
('2023-04-28', 2, 3, 1),
('2023-05-08', 1, 2, 4),
('2023-04-24', 6, 1, 2),
('2023-05-20', 3, 4, 7),
('2023-05-05', 1, 1, 1),
('2023-05-09', 6, 2, 3);