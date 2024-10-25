-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Okt 07. 08:53
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
-- Adatbázis: `travel`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `destination`
--

CREATE TABLE `destination` (
  `id` int(11) NOT NULL,
  `uticel` text NOT NULL,
  `megnevezes` text NOT NULL,
  `ellatas` text NOT NULL,
  `utazas` text NOT NULL,
  `szallas` text NOT NULL,
  `szoba` text NOT NULL,
  `idotartam` text NOT NULL,
  `ar` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `destination`
--

INSERT INTO `destination` (`id`, `uticel`, `megnevezes`, `ellatas`, `utazas`, `szallas`, `szoba`, `idotartam`, `ar`) VALUES
(1, 'Nürnberg', 'Advent Nürnbergben', 'Reggeli', 'Busz', 'Hotel***', '2 ágyas', '3 éjszaka', 89990),
(2, 'Nürnberg', 'Nürnbergi városlátogatás', 'Reggeli + vacsora', 'Busz', 'Hotel****', '2 ágyas', '2 éjszaka', 94000),
(3, 'Drezda', 'Advent Drezdában', 'Reggeli', 'Busz', 'Hotel***', '2 ágyas', '3 éjszaka', 77400),
(4, 'Salzkammergut', 'Salzkammergut hegyek gyöngyszemei', 'Reggeli', 'Busz', 'Panzió', '2 ágyas', '3 éjszaka', 99000),
(5, 'Prága', 'Advent Prágában', 'Reggeli', 'Busz', 'Hotel**', 'Szoba, 2 felnőtnek', '2 éjszaka', 62000),
(6, 'Prága', 'Prágai sörtúra', 'Voucher pubba', 'Vonat', 'Diákszállás', '12 ágyas', '2 éjszaka', 59900),
(7, 'Prága', 'Száztornyú Prága - buszos kirándulás', 'Reggeli', 'Busz', 'Hotel***', 'Standard 2 ágyas', '3 éjszaka', 82490),
(8, 'Prága', 'Hétvége Prágában', 'Reggeli', 'Busz', 'Hotel***', '2 ágyas', '2 éjszaka', 60375),
(9, 'Tátra', 'Hétvége a Magas Tátrában', 'Reggeli', 'Busz', 'Panzió', '2 ágyas', '1 éjszaka', 39990),
(10, 'Erdély', 'Erdély téli arca', 'Reggeli + pálinka', 'Busz', 'Családoknál', '2-3 ágyas', '2 éjszaka', 108006),
(11, 'Dubai', 'Szilveszter Dubaiban', 'Reggeli + vacsora', 'Repülő', 'Hotel****', '2 ágyas', '7 éjszaka', 690000),
(12, 'Dubai', 'Dubai körutazás', 'Reggeli', 'Repülő', 'Hotel****', 'Standard 2 ágyas', '7 éjszaka', 449990);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `destination`
--
ALTER TABLE `destination`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `destination`
--
ALTER TABLE `destination`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
