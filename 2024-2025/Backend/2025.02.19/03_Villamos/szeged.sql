-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Már 22. 00:27
-- Kiszolgáló verziója: 10.4.28-MariaDB
-- PHP verzió: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `szeged`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `jaratok`
--

CREATE TABLE `jaratok` (
  `jaratok_id` int(11) NOT NULL,
  `jaratszam` text NOT NULL,
  `jarat_leiras` text NOT NULL,
  `jarat_tipus` char(1) NOT NULL,
  `hatterszin` text NOT NULL,
  `betuszin` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `jaratok`
--

INSERT INTO `jaratok` (`jaratok_id`, `jaratszam`, `jarat_leiras`, `jarat_tipus`, `hatterszin`, `betuszin`) VALUES
(1, '1', 'Szeged vasútállomás - Hódmezővásárhely vasútállomás', '1', '#003b73', '#fac65c'),
(2, '2', 'Szeged vasútállomás - Európa liget', '2', '#fed265', '#000000'),
(3, '3', 'Tarján - Vadaspark', '2', '#fed265', '#000000'),
(4, '3F', 'Tarján - Fonógyári út', '2', '#fed265', '#000000'),
(5, '4', 'Tarján - Kecskés', '2', '#fed265', '#000000'),
(6, '5', 'Körtöltés utca - Gyermekkórház', '3', '#2ba22c', '#ffffff'),
(7, '6', 'Vértói út - Gyermekkórház', '3', '#2ba22c', '#ffffff'),
(8, '8', 'Makkosház - Klinikák', '3', '#2ba22c', '#ffffff'),
(9, '9', 'Bakay Nándor utca - Lugas utca', '3', '#2ba22c', '#ffffff'),
(10, '10', 'Víztorony tér - Klinikák', '3', '#2ba22c', '#ffffff'),
(11, '19', 'Makkosház - Víztorony tér', '3', '#2ba22c', '#ffffff');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `megallo`
--

CREATE TABLE `megallo` (
  `megallo_id` int(11) NOT NULL,
  `nev` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `megallo`
--

INSERT INTO `megallo` (`megallo_id`, `nev`) VALUES
(1, 'Szeged vasútállomás'),
(2, 'Galamb utca'),
(3, 'Bécsi körút'),
(4, 'Aradi vértanúk tere'),
(5, 'Somogyi utca'),
(6, 'Anna-kút'),
(7, 'Rókusi templom'),
(8, 'Tavasz utca'),
(9, 'Damjanich utca'),
(10, 'Vásárhelyi Pál utca'),
(11, 'Pulz utca'),
(12, 'Rókus vasútállomás'),
(13, 'Algyő'),
(14, 'Hódmezővásárhelyi Népkert vasútállomás'),
(15, 'Strandfürdő'),
(16, 'Hősök tere'),
(17, 'Kossuth tér'),
(18, 'Kálvin János tér'),
(19, 'Hódmezővásárhely vasútállomás'),
(20, 'Széchenyi tér'),
(21, 'Bem utca'),
(22, 'Szatymazi utca'),
(23, 'Rókusi víztorony'),
(24, 'Bálint Sándor utca'),
(25, 'Vértó'),
(26, 'Európa liget'),
(27, 'Tarján'),
(28, 'Budapesti körút'),
(29, 'Deák Ferenc Gimnázium'),
(30, 'Rózsa utca'),
(31, 'Kecskeméti utca'),
(32, 'Brüsszeli körút'),
(33, 'Szent György tér'),
(34, 'Glattfelder Gyula tér'),
(35, 'Károlyi utca'),
(36, 'Dugonics tér'),
(37, 'Londoni körút'),
(38, 'Veresács utca'),
(39, 'Kálvária tér'),
(40, 'II. Kórház'),
(41, 'Vadaspark'),
(42, 'Belvárosi temető'),
(43, 'Belvárosi temető II. kapu'),
(44, 'Kereskedő köz'),
(45, 'Fonógyári út'),
(46, 'Vitéz utca'),
(47, 'Szivárvány kitérő'),
(48, 'Vám tér'),
(49, 'Szabadkai út'),
(50, 'Szalámigyár'),
(51, 'Kecskés'),
(52, 'Körtöltés utca'),
(53, 'Makkosházi körút'),
(54, 'Sárosi utca'),
(55, 'Rózsa utca'),
(56, 'Tündér utca'),
(57, 'Berlini körút'),
(58, 'Hétvezér utca'),
(59, 'Mars tér (autóbusz-állomás)'),
(60, 'Bartók tér'),
(61, 'Torontál tér (P+R)'),
(62, 'Csanádi utca'),
(63, 'Gyermekkórház'),
(64, 'Mikszáth Kálmán utca'),
(65, 'Gém utca'),
(66, 'Vértói út'),
(67, 'Makkosház'),
(68, 'Gát utca'),
(69, 'Ortutay utca'),
(70, 'Szent István tér'),
(71, 'Honvéd tér'),
(72, 'Klinikák'),
(73, 'Ságvári Gimnázium - SZTK'),
(74, 'Dugonics tér (Petőfi Sándor sugárút)'),
(75, 'Bakay Nándor utca'),
(76, 'Vásárhelyi Pál utca (Bakay Nándor utca)'),
(77, 'Mura utca'),
(78, 'Huszár utca'),
(79, 'Londoni körút (Bakay Nándor utca)'),
(80, 'Attila utca (Mars tér)'),
(81, 'Múzeum'),
(82, 'Dózsa utca'),
(83, 'Háló utca'),
(84, 'Tabán utca (Felső Tisza-part)'),
(85, 'Etelka sor'),
(86, 'Erdő utca'),
(87, 'Csaba utca'),
(88, 'Csillag tér'),
(89, 'Lugas utca'),
(90, 'Mars tér (Attila utca)'),
(91, 'Víztorony tér'),
(92, 'Fecske utca'),
(93, 'Római körút'),
(94, 'Sándor utca'),
(95, 'Bercsényi utca'),
(96, 'Gál utca');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `utvonal`
--

CREATE TABLE `utvonal` (
  `utvonal_id` int(11) NOT NULL,
  `jarat_id` int(11) NOT NULL,
  `megallo_id` int(11) NOT NULL,
  `utirany` char(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `utvonal`
--

INSERT INTO `utvonal` (`utvonal_id`, `jarat_id`, `megallo_id`, `utirany`) VALUES
(1, 1, 1, 'o'),
(2, 1, 2, 'o'),
(3, 1, 3, 'o'),
(4, 1, 4, 'o'),
(5, 1, 5, 'o'),
(6, 1, 20, 'o'),
(7, 1, 6, 'o'),
(8, 1, 7, 'o'),
(9, 1, 8, 'o'),
(10, 1, 9, 'o'),
(11, 1, 10, 'o'),
(12, 1, 11, 'o'),
(13, 1, 12, 'o'),
(14, 1, 13, 'o'),
(15, 1, 14, 'o'),
(16, 1, 15, 'o'),
(17, 1, 16, 'o'),
(18, 1, 17, 'o'),
(19, 1, 18, 'o'),
(20, 1, 19, 'o'),
(21, 1, 19, 'v'),
(22, 1, 18, 'v'),
(23, 1, 17, 'v'),
(24, 1, 15, 'v'),
(25, 1, 14, 'v'),
(26, 1, 13, 'v'),
(27, 1, 12, 'v'),
(28, 1, 11, 'v'),
(29, 1, 10, 'v'),
(30, 1, 9, 'v'),
(31, 1, 8, 'v'),
(32, 1, 7, 'v'),
(33, 1, 6, 'v'),
(34, 1, 20, 'v'),
(35, 1, 5, 'v'),
(36, 1, 4, 'v'),
(37, 1, 3, 'v'),
(38, 1, 21, 'v'),
(39, 1, 1, 'v'),
(40, 2, 1, 'o'),
(41, 2, 2, 'o'),
(42, 2, 3, 'o'),
(43, 2, 4, 'o'),
(44, 2, 5, 'o'),
(45, 2, 20, 'o'),
(46, 2, 6, 'o'),
(47, 2, 7, 'o'),
(48, 2, 8, 'o'),
(49, 2, 9, 'o'),
(50, 2, 10, 'o'),
(51, 2, 22, 'o'),
(52, 2, 23, 'o'),
(53, 2, 24, 'o'),
(54, 2, 25, 'o'),
(55, 2, 26, 'o'),
(56, 2, 26, 'v'),
(57, 2, 25, 'v'),
(58, 2, 24, 'v'),
(59, 2, 23, 'v'),
(60, 2, 22, 'v'),
(61, 2, 10, 'v'),
(62, 2, 9, 'v'),
(63, 2, 8, 'v'),
(64, 2, 7, 'v'),
(65, 2, 6, 'v'),
(66, 2, 20, 'v'),
(67, 2, 5, 'v'),
(68, 2, 4, 'v'),
(69, 2, 3, 'v'),
(70, 2, 21, 'v'),
(71, 2, 1, 'v'),
(72, 3, 27, 'o'),
(73, 3, 28, 'o'),
(74, 3, 29, 'o'),
(75, 3, 30, 'o'),
(76, 3, 31, 'o'),
(77, 3, 32, 'o'),
(78, 3, 33, 'o'),
(79, 3, 34, 'o'),
(80, 3, 6, 'o'),
(81, 3, 35, 'o'),
(82, 3, 36, 'o'),
(83, 3, 37, 'o'),
(84, 3, 38, 'o'),
(85, 3, 39, 'o'),
(86, 3, 40, 'o'),
(87, 3, 41, 'o'),
(88, 3, 41, 'v'),
(89, 3, 40, 'v'),
(90, 3, 39, 'v'),
(91, 3, 38, 'v'),
(92, 3, 37, 'v'),
(94, 3, 36, 'v'),
(95, 3, 35, 'v'),
(96, 3, 6, 'v'),
(97, 3, 34, 'v'),
(98, 3, 33, 'v'),
(99, 3, 32, 'v'),
(100, 3, 31, 'v'),
(101, 3, 30, 'v'),
(102, 3, 29, 'v'),
(103, 3, 28, 'v'),
(104, 3, 27, 'v'),
(105, 4, 27, 'o'),
(106, 4, 28, 'o'),
(107, 4, 29, 'o'),
(108, 4, 30, 'o'),
(109, 4, 31, 'o'),
(110, 4, 32, 'o'),
(111, 4, 33, 'o'),
(112, 4, 34, 'o'),
(113, 4, 6, 'o'),
(114, 4, 35, 'o'),
(115, 4, 36, 'o'),
(116, 4, 37, 'o'),
(117, 4, 38, 'o'),
(118, 4, 39, 'o'),
(119, 4, 40, 'o'),
(120, 4, 41, 'o'),
(121, 4, 42, 'o'),
(122, 4, 43, 'o'),
(123, 4, 44, 'o'),
(124, 4, 45, 'o'),
(125, 4, 45, 'v'),
(126, 4, 44, 'v'),
(127, 4, 43, 'v'),
(128, 4, 42, 'v'),
(129, 4, 41, 'v'),
(130, 4, 40, 'v'),
(131, 4, 39, 'v'),
(132, 4, 38, 'v'),
(133, 4, 37, 'v'),
(134, 4, 36, 'v'),
(135, 4, 35, 'v'),
(136, 4, 6, 'v'),
(137, 4, 34, 'v'),
(138, 4, 33, 'v'),
(139, 4, 32, 'v'),
(140, 4, 31, 'v'),
(141, 4, 30, 'v'),
(142, 4, 29, 'v'),
(143, 4, 28, 'v'),
(144, 4, 27, 'v'),
(145, 5, 27, 'o'),
(146, 5, 28, 'o'),
(147, 5, 29, 'o'),
(148, 5, 30, 'o'),
(149, 5, 31, 'o'),
(150, 5, 32, 'o'),
(151, 5, 33, 'o'),
(152, 5, 34, 'o'),
(153, 5, 6, 'o'),
(154, 5, 35, 'o'),
(155, 5, 36, 'o'),
(156, 5, 46, 'o'),
(157, 5, 47, 'o'),
(158, 5, 48, 'o'),
(159, 5, 49, 'o'),
(160, 5, 50, 'o'),
(161, 5, 51, 'o'),
(162, 5, 51, 'v'),
(163, 5, 50, 'v'),
(164, 5, 49, 'v'),
(165, 5, 48, 'v'),
(166, 5, 47, 'v'),
(167, 5, 46, 'v'),
(168, 5, 36, 'v'),
(169, 5, 35, 'v'),
(170, 5, 6, 'v'),
(171, 5, 34, 'v'),
(172, 5, 33, 'v'),
(173, 5, 32, 'v'),
(174, 5, 31, 'v'),
(175, 5, 30, 'v'),
(176, 5, 29, 'v'),
(177, 5, 28, 'v'),
(178, 5, 27, 'v'),
(179, 6, 52, 'o'),
(180, 6, 23, 'o'),
(181, 6, 24, 'o'),
(182, 6, 25, 'o'),
(184, 6, 53, 'o'),
(185, 6, 54, 'o'),
(186, 6, 55, 'o'),
(187, 6, 56, 'o'),
(188, 6, 57, 'o'),
(189, 6, 58, 'o'),
(190, 6, 59, 'o'),
(191, 6, 60, 'o'),
(192, 6, 20, 'o'),
(193, 6, 61, 'o'),
(194, 6, 62, 'o'),
(195, 6, 63, 'o'),
(196, 6, 63, 'v'),
(197, 6, 62, 'v'),
(198, 6, 61, 'v'),
(199, 6, 20, 'v'),
(200, 6, 64, 'v'),
(201, 6, 59, 'v'),
(202, 6, 58, 'v'),
(203, 6, 65, 'v'),
(204, 6, 55, 'v'),
(205, 6, 54, 'v'),
(206, 6, 53, 'v'),
(207, 6, 25, 'v'),
(208, 6, 24, 'v'),
(209, 6, 52, 'v'),
(210, 7, 66, 'o'),
(211, 7, 25, 'o'),
(212, 7, 53, 'o'),
(213, 7, 54, 'o'),
(214, 7, 55, 'o'),
(215, 7, 56, 'o'),
(216, 7, 57, 'o'),
(217, 7, 58, 'o'),
(218, 7, 59, 'o'),
(219, 7, 60, 'o'),
(220, 7, 20, 'o'),
(221, 7, 61, 'o'),
(222, 7, 62, 'o'),
(223, 7, 63, 'o'),
(224, 7, 63, 'v'),
(225, 7, 62, 'v'),
(226, 7, 61, 'v'),
(227, 7, 20, 'v'),
(228, 7, 64, 'v'),
(229, 7, 59, 'v'),
(230, 7, 58, 'v'),
(231, 7, 65, 'v'),
(232, 7, 55, 'v'),
(233, 7, 54, 'v'),
(234, 7, 53, 'v'),
(235, 7, 66, 'v'),
(236, 8, 67, 'o'),
(237, 8, 68, 'o'),
(238, 8, 69, 'o'),
(239, 8, 53, 'o'),
(240, 8, 54, 'o'),
(241, 8, 55, 'o'),
(242, 8, 56, 'o'),
(243, 8, 70, 'o'),
(244, 8, 6, 'o'),
(245, 8, 35, 'o'),
(246, 8, 36, 'o'),
(247, 8, 71, 'o'),
(248, 8, 4, 'o'),
(249, 8, 72, 'o'),
(250, 8, 72, 'v'),
(251, 8, 73, 'v'),
(252, 8, 74, 'v'),
(253, 8, 36, 'v'),
(254, 8, 35, 'v'),
(255, 8, 6, 'v'),
(256, 8, 70, 'v'),
(257, 8, 65, 'v'),
(258, 8, 55, 'v'),
(259, 8, 54, 'v'),
(260, 8, 53, 'v'),
(261, 8, 69, 'v'),
(262, 8, 68, 'v'),
(263, 8, 67, 'v'),
(264, 9, 75, 'o'),
(265, 9, 76, 'o'),
(266, 9, 77, 'o'),
(267, 9, 78, 'o'),
(268, 9, 79, 'o'),
(269, 9, 80, 'o'),
(270, 9, 60, 'o'),
(271, 9, 20, 'o'),
(272, 9, 81, 'o'),
(273, 9, 82, 'o'),
(274, 9, 34, 'o'),
(275, 9, 83, 'o'),
(276, 9, 84, 'o'),
(277, 9, 85, 'o'),
(278, 9, 86, 'o'),
(279, 9, 87, 'o'),
(280, 9, 88, 'o'),
(281, 9, 89, 'o'),
(282, 9, 89, 'v'),
(283, 9, 88, 'v'),
(284, 9, 87, 'v'),
(285, 9, 86, 'v'),
(286, 9, 86, 'v'),
(287, 9, 84, 'v'),
(288, 9, 83, 'v'),
(289, 9, 34, 'v'),
(290, 9, 82, 'v'),
(291, 9, 81, 'v'),
(292, 9, 20, 'v'),
(293, 9, 64, 'v'),
(294, 9, 90, 'v'),
(295, 9, 79, 'v'),
(296, 9, 78, 'v'),
(297, 9, 77, 'v'),
(298, 9, 76, 'v'),
(299, 9, 75, 'v'),
(300, 10, 91, 'o'),
(301, 10, 88, 'o'),
(302, 10, 92, 'o'),
(303, 10, 93, 'o'),
(304, 10, 94, 'o'),
(305, 10, 95, 'o'),
(306, 10, 70, 'o'),
(307, 10, 6, 'o'),
(308, 10, 35, 'o'),
(309, 10, 36, 'o'),
(310, 10, 71, 'o'),
(311, 10, 4, 'o'),
(312, 10, 72, 'o'),
(313, 10, 72, 'v'),
(314, 10, 73, 'v'),
(315, 10, 74, 'v'),
(316, 10, 36, 'v'),
(317, 10, 35, 'v'),
(318, 10, 6, 'v'),
(319, 10, 70, 'v'),
(320, 10, 57, 'v'),
(321, 10, 96, 'v'),
(322, 10, 93, 'v'),
(323, 10, 92, 'v'),
(324, 10, 88, 'v'),
(325, 10, 91, 'v'),
(326, 11, 67, 'o'),
(327, 11, 68, 'o'),
(328, 11, 69, 'o'),
(329, 11, 53, 'o'),
(330, 11, 54, 'o'),
(331, 11, 55, 'o'),
(332, 11, 56, 'o'),
(333, 11, 57, 'o'),
(334, 11, 58, 'o'),
(335, 11, 59, 'o'),
(336, 11, 80, 'o'),
(337, 11, 60, 'o'),
(338, 11, 20, 'o'),
(339, 11, 81, 'o'),
(340, 11, 82, 'o'),
(341, 11, 34, 'o'),
(342, 11, 83, 'o'),
(343, 11, 84, 'o'),
(344, 11, 85, 'o'),
(345, 11, 86, 'o'),
(346, 11, 87, 'o'),
(347, 11, 88, 'o'),
(348, 11, 91, 'o'),
(349, 11, 91, 'v'),
(350, 11, 88, 'v'),
(351, 11, 87, 'v'),
(352, 11, 86, 'v'),
(353, 11, 85, 'v'),
(354, 11, 84, 'v'),
(355, 11, 83, 'v'),
(356, 11, 34, 'v'),
(357, 11, 82, 'v'),
(358, 11, 81, 'v'),
(359, 11, 20, 'v'),
(360, 11, 64, 'v'),
(361, 11, 59, 'v'),
(362, 11, 58, 'v'),
(363, 11, 65, 'v'),
(364, 11, 55, 'v'),
(365, 11, 54, 'v'),
(366, 11, 53, 'v'),
(367, 11, 69, 'v'),
(368, 11, 68, 'v'),
(369, 11, 67, 'v');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `jaratok`
--
ALTER TABLE `jaratok`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `megallo`
--
ALTER TABLE `megallo`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `utvonal`
--
ALTER TABLE `utvonal`
  ADD PRIMARY KEY (`id`),
  ADD KEY `jarat_id` (`jarat_id`),
  ADD KEY `megallo_id` (`megallo_id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `jaratok`
--
ALTER TABLE `jaratok`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT a táblához `megallo`
--
ALTER TABLE `megallo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=97;

--
-- AUTO_INCREMENT a táblához `utvonal`
--
ALTER TABLE `utvonal`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=370;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `utvonal`
--
ALTER TABLE `utvonal`
  ADD CONSTRAINT `utvonal_ibfk_1` FOREIGN KEY (`jarat_id`) REFERENCES `jaratok` (`id`),
  ADD CONSTRAINT `utvonal_ibfk_2` FOREIGN KEY (`megallo_id`) REFERENCES `megallo` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
