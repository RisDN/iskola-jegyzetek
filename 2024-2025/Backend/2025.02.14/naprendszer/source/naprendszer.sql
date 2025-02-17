-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2025. Feb 13. 21:09
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
-- Adatbázis: `naprendszer`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `bolygok`
--

CREATE TABLE `bolygok` (
  `bolygok_id` int(11) NOT NULL,
  `nev` text NOT NULL,
  `tavolsag` bigint(20) NOT NULL,
  `sebesseg` int(11) NOT NULL,
  `egyenlito` int(11) NOT NULL,
  `keringes` int(11) NOT NULL,
  `atmoszfera` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `bolygok`
--

INSERT INTO `bolygok` (`bolygok_id`, `nev`, `tavolsag`, `sebesseg`, `egyenlito`, `keringes`, `atmoszfera`) VALUES
(1, 'Merkúr', 57909227, 170503, 2440, 88, '-'),
(2, 'Vénusz', 108209475, 126074, 6052, 225, 'Szén-dioxid, nitrogén'),
(3, 'Föld', 149589262, 107218, 6371, 365, 'Nitrogén, oxigén'),
(4, 'Mars', 227943824, 86667, 3390, 687, 'Szén-dioxid, Nitrogén, Argon'),
(5, 'Jupiter', 778340821, 47002, 69911, 4333, 'Hidrogén, hélium'),
(6, 'Szaturnusz', 1426666422, 34701, 58232, 10759, 'Hidrogén, hélium'),
(7, 'Uránusz', 2870658186, 76968, 25362, 30687, 'Hidrogén, hélium, metán'),
(8, 'Neptunusz', 4498396441, 84816, 24662, 60190, 'Hidrogén, hélium, metán');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `holdak`
--

CREATE TABLE `holdak` (
  `holdak_id` int(11) NOT NULL,
  `nev` text NOT NULL,
  `bolygok_id` int(11) NOT NULL,
  `felfedezes` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `holdak`
--

INSERT INTO `holdak` (`holdak_id`, `nev`, `bolygok_id`, `felfedezes`) VALUES
(1, 'Eukelade', 5, '2003. február 6.'),
(2, 'Eupheme', 5, '2003. március 4.'),
(3, 'Euporie', 5, '2001. december 11.'),
(4, 'Chaldene', 5, '2000. november 23.'),
(5, 'S/2003 J19', 5, '2003. február'),
(6, 'Dia', 5, '2000. december 5.'),
(7, 'S/2021 J2', 5, '2021.'),
(8, 'S/2021 J3', 5, '2021.'),
(9, 'Bergelmir', 6, '2004. december 12.'),
(10, 'Sponde', 5, '2001. december 9.'),
(11, 'Taygete', 5, '2000. november 25.'),
(12, 'S/2017 J5', 5, '2017.'),
(13, 'S/2017 J6', 5, '2017.'),
(14, 'S/2017 J7', 5, '2017.'),
(15, 'S/2017 J8', 5, '2017.'),
(16, 'Adrastea', 5, '1979. július'),
(17, 'Aitne', 5, '2001. december 9.'),
(18, 'Amalthea', 5, '1892. szeptember 9.'),
(19, 'S/2004 S34', 6, '2004.'),
(20, 'S/2004 S36', 6, '2004.'),
(21, 'S/2004 S37', 6, '2004.'),
(22, 'S/2004 S12', 6, '2004. december 12.'),
(23, 'S/2004 S13', 6, '2004. december 12.'),
(24, 'Despina', 8, '1989. július'),
(25, 'Galatea', 8, '1989. július'),
(26, 'Margaret', 7, '2003. augusztus 29.'),
(27, 'Miranda', 7, '1948. február 16.'),
(28, 'Sao', 8, '2002. augusztus 14.'),
(29, 'Thalassa', 8, '1989. augusztus'),
(30, 'Triton', 8, '1846. október 10.'),
(31, 'Hold', 3, 'Ismeretlen'),
(32, 'Deimos', 4, '1877. augusztus 11.'),
(33, 'Ganymede', 5, '1610. január 7.'),
(34, 'Harpalyke', 5, '2000. november 23.'),
(35, 'Phobos', 4, '1877. augusztus 17.'),
(36, 'Ananke', 5, '1951. szeptember 28.'),
(37, 'S/2016 J4', 5, '2016.'),
(38, 'S/2017 J1', 5, '2017.'),
(39, 'S/2017 J2', 5, '2017.'),
(40, 'S/2017 J3', 5, '2017.'),
(41, 'S/2003 J16', 5, '2003. április'),
(42, 'S/2003 J18', 5, '2003. április'),
(43, 'S/2003 J19', 5, '2003. február'),
(44, 'Pasithee', 5, '2001. december 11.'),
(45, 'Enceladus', 6, '1789. augusztus 28.'),
(46, 'Epimetheus', 6, '1966. december 15.'),
(47, 'Angrboda', 6, '2004. december 12.'),
(48, 'Anthe', 6, '2007. május 30.'),
(49, 'Thyone', 5, '2001. december 11.'),
(50, 'Valetudo', 5, '2017.'),
(51, 'Aegaeon', 6, '2008. augusztus 15.'),
(52, 'S/2021 J4', 5, '2021.'),
(53, 'S/2021 J5', 5, '2021.'),
(54, 'S/2021 J6', 5, '2021.'),
(55, 'S/2022 J1', 5, '2022.'),
(56, 'Kale', 5, '2001. december 9.'),
(57, 'Kallichore', 5, '2003. február 6.'),
(58, 'Kalyke', 5, '2000. november 23.'),
(59, 'Kore', 5, '2003. február 8.'),
(60, 'Leda', 5, '1974. szeptember 14.'),
(61, 'S/2004 S21', 6, '2004.'),
(62, 'S/2004 S24', 6, '2004.'),
(63, 'S/2004 S26', 6, '2004.'),
(64, 'S/2006 S3', 6, '2006. március 6.'),
(65, 'S/2007 S2', 6, '2007.'),
(66, 'S/2007 S3', 6, '2007.'),
(67, 'S/2009 S1', 6, '2009.'),
(68, 'S/2019 S1', 6, '2019.'),
(69, 'Siarnaq', 6, '2000. szeptember 23.'),
(70, 'Skathi', 6, '2000. szeptember 23.'),
(71, 'Skoll', 6, '2006. március 6.'),
(72, 'Skrymir', 6, '2004. december 12.'),
(73, 'Surtur', 6, '2006. március 6.'),
(74, 'Suttungr', 6, '2000.'),
(75, 'Tarqeq', 6, '2007. január 16.'),
(76, 'Tarvos', 6, '2000. szeptember 23.'),
(77, 'Iapetus', 6, '1671. október 25.'),
(78, 'Ijiraq', 6, '2000. szeptember 23.'),
(79, 'Janus', 6, '1966. december 15.'),
(80, 'Jarnsaxa', 6, '2006. március 6.'),
(81, 'Kari', 6, '2006. március 6.'),
(82, 'Kiviuq', 6, '2000. augusztus 7.'),
(83, 'Loge', 6, '2006. március 6.'),
(84, 'Umbriel', 7, '1851. október 24.'),
(85, 'Halimede', 8, '2002. augusztus 14.'),
(86, 'Hippocamp', 8, '2013. július 1.'),
(87, 'Laomedeia', 8, '2002. augusztus 13.'),
(88, 'Juliet', 7, '1986. január 3.'),
(89, 'Mab', 7, '2003. augusztus 23.'),
(90, 'Oberon', 7, '1787. január 11.'),
(91, 'Ophelia', 7, '1986. január'),
(92, 'Bianca', 7, '1986. január 13.'),
(93, 'Caliban', 7, '1997. szeptember 6.'),
(94, 'Himalia', 5, '1904. december 3.'),
(95, 'Io', 5, '1610. január 8.'),
(96, 'Isonoe', 5, '2000. november 23.'),
(97, 'S/2018 J2', 5, '2018.'),
(98, 'S/2018 J3', 5, '2018.'),
(99, 'S/2018 J4', 5, '2018.'),
(100, 'S/2003 J9', 5, '2003. február'),
(101, 'S/2011 J1', 5, '2011. szeptember 27.'),
(102, 'S/2011 J2', 5, '2011. szeptember 27.'),
(103, 'Gerd', 6, '2004. december 12.'),
(104, 'Greip', 6, '2006. március 6.'),
(105, 'Gridr', 6, '2004. december 12.'),
(106, 'Gunnlod', 6, '2004. december 12.'),
(107, 'Hati', 6, '2004. december 12.'),
(108, 'Calypso', 6, '1980.'),
(109, 'Daphnis', 6, '2005. május 1.'),
(110, 'Dione', 6, '1684. március 21.'),
(111, 'Eggther', 6, '2004. december 12.'),
(112, 'Erriapus', 6, '2000. szeptember 23.'),
(113, 'Cupid', 7, '2003. augusztus 25.'),
(114, 'Desdemona', 7, '1986. január 13.'),
(115, 'Ferdinand', 7, '2001. augusztus 13.'),
(116, 'Nereid', 8, '1949. május 1.'),
(117, 'Neso', 8, '2002.'),
(118, 'Proteus', 8, '1989.'),
(119, 'Titania', 7, '1787. január 11.'),
(120, 'Trinculo', 7, '2001. augusztus 13.'),
(121, 'Larissa', 8, '1981.'),
(122, 'Naiad', 8, '1989. szeptember'),
(123, 'Psamathe', 8, '2003. augusztus 29.'),
(124, 'Rhea', 6, '1672. december 23.'),
(125, 'S/2004 S17', 6, '2004. december 12.'),
(126, 'S/2004 S28', 6, '2004.'),
(127, 'S/2004 S29', 6, '2004.'),
(128, 'S/2004 S31', 6, '2004.'),
(129, 'Hyperion', 6, '1848.'),
(130, 'Hyrrokkin', 6, '2004. december 12.'),
(131, 'Methone', 6, '2004. június 1.'),
(132, 'Mimas', 6, '1789. szeptember 17.'),
(133, 'Mundilfari', 6, '2000.'),
(134, 'S/2022 J2', 5, '2022.'),
(135, 'S/2022 J3', 5, '2022.'),
(136, 'Sinope', 5, '1914. július 21.'),
(137, 'Taygete', 5, '1980.'),
(138, 'Thelxinoe', 5, '2003. február 9.'),
(139, 'Themisto', 5, '1975. szeptember 30.'),
(140, 'Pandora', 6, '1980.'),
(141, 'Phoebe', 6, '1898. augusztus'),
(142, 'Polydeuces', 6, '2004. október 21.'),
(143, 'Prometheus', 6, '1980. október'),
(144, 'S/2004 S39', 6, '2004.'),
(145, 'S/2004 S7', 6, '2004. december 12.'),
(146, 'Belinda', 7, '1986. január 13.'),
(147, 'Cordelia', 7, '1986. január 20.'),
(148, 'Cressida', 7, '1986. január 9.'),
(149, 'Rosalind', 7, '1986. január 13.'),
(150, 'Setebos', 7, '1999. július 18.'),
(151, 'Stephano', 7, '1999. július 18.'),
(152, 'Hermippe', 5, '2001. december 9.'),
(153, 'Herse', 5, '2003. február 27.'),
(154, 'S2010 J2', 5, '2010. szeptember 8.'),
(155, 'S2010 J1', 5, '2010. szeptember 7.'),
(156, 'S/2003 J4', 5, '2003.'),
(157, 'S/2011 J3', 5, '2011.'),
(158, 'S/2016 J1', 5, '2016.'),
(159, 'S/2016 J3', 5, '2016.'),
(160, 'Orthosie', 5, '2001.'),
(161, 'Pandia', 5, '2017.'),
(162, 'Pasiphae', 5, '1908. január 27.'),
(163, 'Philophrosyne', 5, '2003. április'),
(164, 'Praxidike', 5, '2000. november 23.'),
(165, 'Cyllene', 5, '2003. február 9.'),
(166, 'Eirene', 5, '2003. február 6.'),
(167, 'Elara', 5, '1905. január 5.'),
(168, 'Erinome', 5, '2000. november 23.'),
(169, 'S/2021 J1', 5, '2021.'),
(170, 'Aegir', 6, '2004. december 12.'),
(171, 'Albiorix', 6, '2000. november 9.'),
(172, 'Alvaldi', 6, '2004. december 12.'),
(173, 'Atlas', 6, '1980'),
(174, 'Telesto', 6, '1980.'),
(175, 'Tethys', 6, '1684. március 21.'),
(176, 'Thiazzi', 6, '2004. december 12.'),
(177, 'Titan', 6, '1655. március 25.'),
(178, 'Ymir', 6, '2000.'),
(179, 'Perdita', 7, '1986.'),
(180, 'Portia', 7, '1986. január'),
(181, 'Prospero', 7, '1999. július 18.'),
(182, 'Puck', 7, '1985. december'),
(183, 'Sycorax', 7, '1997. szeptember 6.'),
(184, 'Bestla', 6, '2004. december 12.'),
(185, 'Farbauti', 6, '2004. december 12.'),
(186, 'Fenrir', 6, '2004. december 12.'),
(187, 'Fornjot', 6, '2004. december 12.'),
(188, 'Geirrod', 6, '2004. december 12.'),
(189, 'Helene', 6, '1980. március 1.'),
(190, 'Euanthe', 5, '2001. december 11.'),
(191, 'Europa', 5, '1610. január 8.'),
(192, 'Eurydome', 5, '2001. december 9.'),
(193, 'Hegemone', 5, '2003. február 8.'),
(194, 'Helike', 5, '2003. február 6.'),
(195, 'Lysithea', 5, '1938. július 6.'),
(196, 'Megaclite', 5, '2000. november 25.'),
(197, 'Mneme', 5, '2003. február 9.'),
(198, 'S/2003 J10', 5, '2003. február'),
(199, 'S/2003 J12', 5, '2003. február 6.-március 7.'),
(200, 'S/2003 J2', 5, '2003. február-március'),
(201, 'S/2003 J23', 5, '2003.'),
(202, 'S/2003 J24', 5, '2003.'),
(203, 'S/2017 J9', 5, '2017.'),
(204, 'Bebhionn', 6, '2004. december 12.'),
(205, 'Beli', 6, '2004. december 12.'),
(206, 'Narvi', 6, '2003. április 8.'),
(207, 'Paaliaq', 6, '2000. augusztus 7.'),
(208, 'Aoede', 5, '2003. február 8.'),
(209, 'Arche', 5, '2002. október 31.'),
(210, 'Autonoe', 5, '2001. december 10.'),
(211, 'Callirrhoe', 5, '1999. október 19.'),
(212, 'Callisto', 5, '1610. január 7.'),
(213, 'Carme', 5, '1938. július 30.'),
(214, 'Carpo', 5, '2003. február 26.'),
(215, 'Ersa', 5, '2017.'),
(216, 'Metis', 5, '1979. március'),
(217, 'Pallene', 6, '2004. június 1.'),
(218, 'Pan', 6, '1990.'),
(219, 'S/2006 S1', 6, '2006. március 6.'),
(220, 'Thrymr', 6, '2000.'),
(221, 'Ariel', 7, '1851. október 24.'),
(222, 'Francisco', 7, '2001. augusztus 13.');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `bolygok`
--
ALTER TABLE `bolygok`
  ADD PRIMARY KEY (`bolygok_id`);

--
-- A tábla indexei `holdak`
--
ALTER TABLE `holdak`
  ADD PRIMARY KEY (`holdak_id`),
  ADD KEY `bolygo` (`bolygok_id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `bolygok`
--
ALTER TABLE `bolygok`
  MODIFY `bolygok_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT a táblához `holdak`
--
ALTER TABLE `holdak`
  MODIFY `holdak_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=224;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `holdak`
--
ALTER TABLE `holdak`
  ADD CONSTRAINT `holdak_ibfk_1` FOREIGN KEY (`bolygok_id`) REFERENCES `bolygok` (`bolygok_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
