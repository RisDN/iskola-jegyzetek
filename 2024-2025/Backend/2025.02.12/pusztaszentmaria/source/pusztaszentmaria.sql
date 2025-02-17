-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2025. Jan 28. 11:26
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `pusztaszentmaria`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `hirek`
--

CREATE TABLE `hirek` (
  `hirek_id` int(11) NOT NULL,
  `date` date NOT NULL,
  `title` text NOT NULL,
  `text` text NOT NULL,
  `img` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `hirek`
--

INSERT INTO `hirek` (`hirek_id`, `date`, `title`, `text`, `img`) VALUES
(1, '2023-02-15', 'MEGHÍVÓ képviselő testületi ülésre', 'MEGHÍVÓ Pusztaszentmária Község Önkormányzat nyílt és zárt képviselő testületi ülésére. Időpont: 2023. február 15. 17.30 óra Helyszín: Polgármesteri Hivatal, díszterem.', 'ules.jpg'),
(2, '2023-03-13', 'Március 15.-i ünnepség', 'Tisztelettel meghívunk minden lakost az 1848-1849-es forradalom és szabadságharc 175. évfordulója alkalmából rendezett Március 15.-i ünnepségre. Helyszín: Petőfi út 1., a Tanácsháza előtti park. Beszédet mond: Kiss Béla Lajos polgármester úr.', 'kokarda.jpg'),
(3, '2023-04-03', 'Italbolt nyitvatartása megváltozott', 'Felhívjuk minden kedves pusztaszentmáriai lakos figyelmét, hogy jövő héttől az Italbolt nyitvatartása megváltozik. Nyitás 13:00 óra helyett 15:00 órától, HÉTFŐN és SZERDÁN zárva!', 'italbolt.jpg'),
(4, '2023-04-15', 'Káros-e az 5G? - ELŐADÁS', 'Szeretettel meghívjuk Oláh Mária Ibolya \"Káros-e az 5G?\" című előadására, ahol mindent megtudhat az 5G-ről!<br> Helyszín: Polgármesteri Hivatal, Díszterem, Petőfi út 1.<br> Időpont: 2023. április 29., 17 óra.<br> A helyszínen 5G elleni védőfelszerelés is kapható!', '5g.jpg');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `user`
--

CREATE TABLE `user` (
  `user_id` int(11) NOT NULL,
  `nev` text NOT NULL,
  `email` text NOT NULL,
  `password` text NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `vendegkonyv`
--

CREATE TABLE `vendegkonyv` (
  `vendegkonyv_id` int(11) NOT NULL,
  `nev` text NOT NULL,
  `email` text NOT NULL,
  `message` text NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `vendegkonyv`
--

INSERT INTO `vendegkonyv` (`vendegkonyv_id`, `nev`, `email`, `message`, `date`) VALUES
(1, 'Istvánka', 'csgofan2011@gmail.com', 'Első!', '2022-09-05'),
(2, 'Molnár Géza', 'mgeza@citromail.hu', 'Gratulálok a honlaphoz! Jó látni mi történik a faluban. Olvasni róla. Köszönöm! \r\n\r\nÁldott Ünnepeket mindenkinek!', '2022-12-20'),
(3, 'Józsi bácsi', 'kjozsef@freemail.hu', 'Nem igaz, hogy szerdán nincs nyitva az italbolt!! Bezzeg a mi időnkben minden nap nyitva volt!! Reggel hattól!! Hogy lehet így rendesen élni kérdem én kedves Polgár Mester Úr??', '2023-04-06');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `hirek`
--
ALTER TABLE `hirek`
  ADD PRIMARY KEY (`hirek_id`);

--
-- A tábla indexei `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`);

--
-- A tábla indexei `vendegkonyv`
--
ALTER TABLE `vendegkonyv`
  ADD PRIMARY KEY (`vendegkonyv_id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `hirek`
--
ALTER TABLE `hirek`
  MODIFY `hirek_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT a táblához `user`
--
ALTER TABLE `user`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `vendegkonyv`
--
ALTER TABLE `vendegkonyv`
  MODIFY `vendegkonyv_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
