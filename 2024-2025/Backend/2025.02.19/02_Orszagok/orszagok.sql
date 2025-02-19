-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2025. Feb 14. 00:21
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
-- Adatbázis: `orszagok`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kontinens`
--

CREATE TABLE `kontinens` (
  `kontinens_id` int(11) NOT NULL,
  `nev` text NOT NULL,
  `terulet` int(11) NOT NULL,
  `max` int(11) NOT NULL,
  `max_nev` text NOT NULL,
  `min` int(11) NOT NULL,
  `min_nev` text NOT NULL,
  `folyo` int(11) NOT NULL,
  `folyo_nev` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `kontinens`
--

INSERT INTO `kontinens` (`kontinens_id`, `nev`, `terulet`, `max`, `max_nev`, `min`, `min_nev`, `folyo`, `folyo_nev`) VALUES
(1, 'Afrika', 30319, 5895, 'Kibo (Kilimandzsáró)', -155, 'Assal-tó', 6650, 'Nílus'),
(2, 'Amerika', 42549, 6959, 'Aconcagua (Andok)', -86, 'Death Valley', 6400, 'Amazonas'),
(3, 'Ausztrália és Óceánia', 8510, 5030, 'Puncak Jaya (Maoke-hg.)', -12, 'Eyre-tó', 2508, 'Murray'),
(4, 'Ázsia', 44411, 8848, 'Csomolungma (Himalája)', -397, 'Holt-tenger', 6300, 'Jangce'),
(5, 'Európa', 10508, 5642, 'Elburz (Kaukázus)', -28, 'Kapszi-mélyföld', 3645, 'Volga'),
(6, 'Antarktisz', 14200, 4892, 'Mount Vinson (Vinson Massif)', -3500, 'Denman-gleccser', 32, 'Onyx');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `orszag`
--

CREATE TABLE `orszag` (
  `orszag_id` int(11) NOT NULL,
  `nev` text NOT NULL,
  `kontinens_id` int(11) NOT NULL,
  `fovaros` text NOT NULL,
  `nepesseg` int(11) NOT NULL,
  `terulet` int(11) NOT NULL,
  `nepsuruseg` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `orszag`
--

INSERT INTO `orszag` (`orszag_id`, `nev`, `kontinens_id`, `fovaros`, `nepesseg`, `terulet`, `nepsuruseg`) VALUES
(1, 'Afganisztán', 4, 'Kabul', 38928346, 65286, 60),
(2, 'Albánia', 5, 'Tirana', 2877797, 274, 105),
(3, 'Algéria', 1, 'Algír', 43851044, 2381740, 18),
(4, 'Andorra', 5, 'Andorra la Vella', 77265, 470, 164),
(5, 'Angola', 1, 'Luanda', 32866272, 1246700, 26),
(6, 'Antigua és Barbuda', 2, 'St. John\'s', 97929, 440, 223),
(7, 'Argentina', 2, 'Buenos Aires', 45195774, 2736690, 17),
(8, 'Örményország', 4, 'Jereván', 2963243, 2847, 104),
(9, 'Ausztrália', 3, 'Canberra', 25499884, 7682300, 3),
(10, 'Ausztria', 5, 'Bécs', 9006398, 82409, 109),
(11, 'Azerbajdzsán', 4, 'Baku', 10139177, 82658, 123),
(12, 'Bahama-szigetek', 2, 'Nassau', 393244, 1001, 39),
(13, 'Bahrein', 4, 'Manáma', 1701575, 760, 2239),
(14, 'Banglades', 4, 'Dakka', 164689383, 13017, 1265),
(15, 'Barbados', 2, 'Bridgetown', 287375, 430, 668),
(16, 'Fehéroroszország', 5, 'Minszk', 9449323, 20291, 47),
(17, 'Belgium', 5, 'Brüsszel', 11589623, 3028, 383),
(18, 'Belize', 2, 'Belmopan', 397628, 2281, 17),
(19, 'Benin', 1, 'Porto Novo', 12123200, 11276, 108),
(20, 'Bhután', 4, 'Timpu', 771608, 38117, 20),
(21, 'Bolívia', 2, 'La Paz', 11673021, 1083300, 11),
(22, 'Bosznia-Hercegovina', 5, 'Szarajevó', 3280819, 51, 64),
(23, 'Botswana', 1, 'Gaborone', 2351627, 56673, 4),
(24, 'Brazília', 2, 'Brasília', 212559417, 8358140, 25),
(25, 'Brunei', 4, 'Bandar Seri Begawan', 437479, 527, 83),
(26, 'Bulgária', 5, 'Szófia', 6948445, 10856, 64),
(27, 'Burkina Faso', 1, 'Ouagadougou', 20903273, 2736, 76),
(28, 'Burundi', 1, 'Gitega', 11890784, 2568, 463),
(29, 'Elefántcsontpart', 1, 'Yamoussoukro', 26378274, 318, 83),
(30, 'Zöld-foki Köztársaság', 1, 'Praia', 555987, 403, 138),
(31, 'Kambodzsa', 4, 'Phnom Penh', 16718965, 17652, 95),
(32, 'Kamerun', 1, 'Yaoundé', 26545863, 47271, 56),
(33, 'Kanada', 2, 'Ottawa', 37742154, 9093510, 4),
(34, 'Közép-afrikai Köztársaság', 1, 'Bangui', 4829767, 62298, 8),
(35, 'Csád', 1, 'N\'Djamena', 16425864, 1259200, 13),
(36, 'Chile', 2, 'Santiago', 19116201, 743532, 26),
(37, 'Kína', 4, 'Peking', 1439323776, 9388211, 153),
(38, 'Kolumbia', 2, 'Bogotá', 50882891, 1109500, 46),
(39, 'Comore-szigetek', 1, 'Moroni', 869601, 1861, 467),
(40, 'Kongó', 1, 'Brazzaville', 5518087, 3415, 16),
(41, 'Costa Rica', 2, 'San José', 5094118, 5106, 100),
(42, 'Horvátország', 5, 'Zágráb', 4105267, 5596, 73),
(43, 'Kuba', 2, 'Havanna', 11326616, 10644, 106),
(44, 'Ciprus', 5, 'Nicosia', 1207359, 924, 131),
(45, 'Csehország', 5, 'Prága', 10708981, 7724, 139),
(46, 'Kongói Demokratikus Köztársaság', 1, 'Kinshasa', 89561403, 2267050, 40),
(47, 'Dánia', 5, 'Koppenhága', 5792202, 4243, 137),
(48, 'Dzsibuti', 1, 'Dzsibuti', 988, 2318, 43),
(49, 'Dominikai Közösség', 2, 'Roseau', 71986, 750, 96),
(50, 'Dominikai Köztársaság', 2, 'Santo Domingo', 10847910, 4832, 225),
(51, 'Ecuador', 2, 'Quito', 17643054, 24836, 71),
(52, 'Egyiptom', 1, 'Kairó', 102334404, 99545, 103),
(53, 'El Salvador', 2, 'San Salvador', 6486205, 2072, 313),
(54, 'Egyenlítői-Guinea', 1, 'Malabo', 1402985, 2805, 50),
(55, 'Eritrea', 1, 'Aszmara', 3546421, 101, 35),
(56, 'Észtország', 5, 'Tallin', 1326535, 4239, 31),
(57, 'Szváziföld', 1, 'Mbabane', 1160164, 172, 67),
(58, 'Etiópia', 1, 'Addis Ababa', 114963588, 1000000, 115),
(59, 'Fidzsi-szigetek', 3, 'Suva', 896445, 1827, 49),
(60, 'Finnország', 5, 'Helsinki', 5540720, 30389, 18),
(61, 'Franciaország', 5, 'Párizs', 65273511, 547557, 119),
(62, 'Gabon', 1, 'Libreville', 2225734, 25767, 9),
(63, 'Gambia', 1, 'Banjul', 2416668, 1012, 239),
(64, 'Grúzia', 4, 'Tbiliszi', 3989167, 6949, 57),
(65, 'Németország', 5, 'Berlin', 83783942, 34856, 240),
(66, 'Ghána', 1, 'Accra', 31072940, 22754, 137),
(67, 'Görögország', 5, 'Athén', 10423054, 1289, 81),
(68, 'Grenada', 2, 'St. George\'s', 112523, 340, 331),
(69, 'Guatemala', 2, 'Guatemalaváros', 17915568, 10716, 167),
(70, 'Guinea', 1, 'Conakry', 13132795, 24572, 53),
(71, 'Bissau-Guinea', 1, 'Bissau', 1968001, 2812, 70),
(72, 'Guyana', 2, 'Georgetown', 786552, 19685, 4),
(73, 'Haiti', 2, 'Port-au-Prince', 11402528, 2756, 414),
(74, 'Vatikán', 5, 'Vatikán', 801, 0, 2003),
(75, 'Honduras', 2, 'Tegucigalpa', 9904607, 11189, 89),
(76, 'Magyarország', 5, 'Budapest', 9660351, 9053, 107),
(77, 'Izland', 5, 'Reykjavík', 341243, 10025, 3),
(78, 'India', 4, 'Új-Delhi', 1380004385, 2973190, 464),
(79, 'Indonézia', 4, 'Jakarta', 273523615, 1811570, 151),
(80, 'Irán', 4, 'Teherán', 83992949, 1628550, 52),
(81, 'Irak', 4, 'Bagdad', 40222493, 43432, 93),
(82, 'Írország', 5, 'Dublin', 4937786, 6889, 72),
(83, 'Izrael', 4, 'Jeruzsálem', 8655535, 2164, 400),
(84, 'Olaszország', 5, 'Róma', 60461826, 29414, 206),
(85, 'Jamaica', 2, 'Kingston', 2961167, 1083, 273),
(86, 'Japán', 4, 'Tokió', 126476461, 364555, 347),
(87, 'Jordánia', 4, 'Ammán', 10203134, 8878, 115),
(88, 'Kazahsztán', 4, 'Asztana', 18776707, 2699700, 7),
(89, 'Kenya', 1, 'Nairobi', 53771296, 56914, 94),
(90, 'Kiribati', 3, 'Tarawa', 119449, 810, 147),
(91, 'Kuvait', 4, 'Kuvait', 4270571, 1782, 240),
(92, 'Kirgizisztán', 4, 'Biskek', 6524195, 1918, 34),
(93, 'Laosz', 4, 'Vientián', 7275560, 2308, 32),
(94, 'Lettország', 5, 'Riga', 1886198, 622, 30),
(95, 'Libanon', 4, 'Bejrút', 6825445, 1023, 667),
(96, 'Lesotho', 1, 'Maseru', 2142249, 3036, 71),
(97, 'Libéria', 1, 'Monrovia', 5057681, 9632, 53),
(98, 'Líbia', 1, 'Tripoli', 6871292, 1759540, 4),
(99, 'Liechtenstein', 5, 'Vaduz', 38128, 160, 238),
(100, 'Litvánia', 5, 'Vilnius', 2722289, 62674, 43),
(101, 'Luxemburg', 5, 'Luxembourg', 625978, 259, 242),
(102, 'Madagaszkár', 1, 'Antananarivo', 27691018, 581795, 48),
(103, 'Malawi', 1, 'Lilongwe', 19129952, 9428, 203),
(104, 'Malajzia', 4, 'Kuala Lumpur', 32365999, 32855, 99),
(105, 'Maldív-szigetek', 4, 'Malé', 540544, 300, 1802),
(106, 'Mali', 1, 'Bamako', 20250833, 1220190, 17),
(107, 'Málta', 5, 'Valletta', 441543, 320, 138),
(108, 'Marshall-szigetek', 3, 'Majuro', 5919, 180, 329),
(109, 'Mauritánia', 1, 'Nouakchott', 4649658, 1030700, 5),
(110, 'Mauritius', 1, 'Port Louis', 1271768, 203, 626),
(111, 'Mexikó', 2, 'Mexikóváros', 128932753, 1943950, 66),
(112, 'Mikronéziai Szövetségi Államok', 3, 'Palikir', 548914, 700, 784),
(113, 'Moldova', 5, 'Kisinyov', 4033963, 3285, 123),
(114, 'Monaco', 5, 'Monaco', 39242, 1, 26337),
(115, 'Mongólia', 4, 'Ulánbátor', 3278290, 1553560, 2),
(116, 'Montenegró', 5, 'Podgorica', 628066, 1345, 47),
(117, 'Marokkó', 1, 'Rabat', 36910560, 4463, 83),
(118, 'Mozambik', 1, 'Maputo', 31255435, 78638, 40),
(119, 'Mianmar', 4, 'Nepjida', 54409800, 65329, 83),
(120, 'Namíbia', 1, 'Windhoek', 2540905, 82329, 3),
(121, 'Nauru', 3, 'Yaren', 10824, 20, 541),
(122, 'Nepál', 4, 'Katmandu', 29136808, 14335, 203),
(123, 'Hollandia', 5, 'Amszterdam', 17134872, 3372, 508),
(124, 'Új-Zéland', 3, 'Wellington', 4822233, 26331, 18),
(125, 'Nicaragua', 2, 'Managua', 6624554, 12034, 55),
(126, 'Niger', 1, 'Niamey', 24206644, 1266700, 19),
(127, 'Nigéria', 1, 'Abuja', 206139589, 91077, 226),
(128, 'Észak-Korea', 4, 'Phenjan', 25778816, 12041, 214),
(129, 'Észak-Macedónia', 5, 'Szkopje', 2083374, 2522, 83),
(130, 'Norvégia', 5, 'Oslo', 5421241, 365268, 15),
(131, 'Omán', 4, 'Maszkat', 5106626, 3095, 16),
(132, 'Pakisztán', 4, 'Iszlámábád', 220892340, 77088, 287),
(133, 'Palau', 3, 'Ngerulmud', 18094, 460, 39),
(134, 'Palesztina', 4, 'Kelet-Jeruzsálem', 5101414, 602, 847),
(135, 'Panama', 2, 'Panamaváros', 4314767, 7434, 58),
(136, 'Pápua Új-Guinea', 3, 'Port Moresby', 8947024, 45286, 20),
(137, 'Paraguay', 2, 'Asunción', 7132538, 3973, 18),
(138, 'Peru', 2, 'Lima', 32971854, 1280000, 26),
(139, 'Fülöp-szigetek', 4, 'Manila', 109581078, 29817, 368),
(140, 'Lengyelország', 5, 'Varsó', 37846611, 30623, 124),
(141, 'Portugália', 5, 'Lisszabon', 10196709, 9159, 111),
(142, 'Katar', 4, 'Doha', 2881053, 1161, 248),
(143, 'Románia', 5, 'Bukarest', 19237691, 23017, 84),
(144, 'Oroszország', 5, 'Moszkva', 145934462, 16376870, 9),
(145, 'Ruanda', 1, 'Kigali', 12952218, 2467, 525),
(146, 'Saint Kitts és Nevis', 2, 'Basseterre', 53199, 260, 205),
(147, 'Saint Lucia', 2, 'Castries', 183627, 610, 301),
(148, 'Saint Vincent és a Grenadine-szigetek', 2, 'Kingstown', 11094, 390, 284),
(149, 'Szamoa', 3, 'Apia', 198414, 283, 70),
(150, 'San Marino', 5, 'San Marino', 33931, 60, 566),
(151, 'São Tomé és Príncipe', 1, 'São Tomé', 219159, 960, 228),
(152, 'Szaúd-Arábia', 4, 'Rijád', 34813871, 2149690, 16),
(153, 'Szenegál', 1, 'Dakar', 16743927, 19253, 87),
(154, 'Szerbia', 5, 'Belgrád', 8737371, 8746, 100),
(155, 'Seychelle-szigetek', 1, 'Victoria', 98347, 460, 214),
(156, 'Sierra Leone', 1, 'Freetown', 7976983, 7218, 111),
(157, 'Szingapúr', 4, 'Szingapúr', 5850342, 700, 8358),
(158, 'Szlovákia', 5, 'Pozsony', 5459642, 48088, 114),
(159, 'Szlovénia', 5, 'Ljubljana', 2078938, 2014, 103),
(160, 'Salamon-szigetek', 3, 'Honiara', 686884, 2799, 25),
(161, 'Szomália', 1, 'Mogadishu', 15893222, 62734, 25),
(162, 'Dél-afrikai Köztársaság', 1, 'Pretoria', 59308690, 1213090, 49),
(163, 'Dél-Korea', 4, 'Seoul', 51269185, 9723, 527),
(164, 'Dél-Szudán', 1, 'Juba', 11193725, 610952, 18),
(165, 'Spanyolország', 5, 'Madrid', 46754778, 4988, 94),
(166, 'Srí Lanka', 4, 'Colombo', 21413249, 6271, 341),
(167, 'Szudán', 1, 'Khartoum', 43849260, 1765048, 25),
(168, 'Suriname', 2, 'Paramaribo', 586632, 156, 4),
(169, 'Svédország', 5, 'Stockholm', 10099265, 41034, 25),
(170, 'Svájc', 5, 'Bern', 8654622, 39516, 219),
(171, 'Szíria', 4, 'Damaszkusz', 17500658, 18363, 95),
(172, 'Tádzsikisztán', 4, 'Dusanbe', 9537645, 13996, 68),
(173, 'Tanzánia', 1, 'Dodoma', 59734218, 8858, 67),
(174, 'Thaiföld', 4, 'Bangkok', 69799978, 51089, 137),
(175, 'Kelet-Timor', 4, 'Dili', 1318445, 1487, 89),
(176, 'Togo', 1, 'Lomé', 8278724, 5439, 152),
(177, 'Tonga', 3, 'Nuku\'alofa', 105695, 720, 147),
(178, 'Trinidad és Tobago', 2, 'Port of Spain', 1399488, 513, 273),
(179, 'Tunézia', 1, 'Tunisz', 11818619, 15536, 76),
(180, 'Törökország', 4, 'Ankara', 84339067, 76963, 110),
(181, 'Türkmenisztán', 4, 'Asgabat', 6031200, 46993, 13),
(182, 'Tuvalu', 4, 'Funafuti', 11792, 30, 393),
(183, 'Uganda', 1, 'Kampala', 45741007, 19981, 229),
(184, 'Ukrajna', 5, 'Kijev', 43733762, 57932, 75),
(185, 'Egyesült Arab Emírségek', 4, 'Abu-Dzabi', 9890402, 836, 118),
(186, 'Egyesült Királyság', 5, 'London', 67886011, 24193, 281),
(187, 'Amerikai Egyesült Államok', 2, 'Washington', 331002651, 9147420, 36),
(188, 'Uruguay', 2, 'Montevideo', 3473730, 17502, 20),
(189, 'Üzbegisztán', 4, 'Taskent', 33469203, 4254, 79),
(190, 'Vanuatu', 3, 'Port Vila', 307145, 1219, 25),
(191, 'Venezuela', 2, 'Caracas', 28435940, 88205, 32),
(192, 'Vietnam', 4, 'Hanoi', 97338579, 31007, 314),
(193, 'Jemen', 4, 'Szanaa', 29825964, 52797, 56),
(194, 'Zambia', 1, 'Lusaka', 18383955, 74339, 25),
(195, 'Zimbabwe', 1, 'Harare', 14862924, 38685, 38);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `kontinens`
--
ALTER TABLE `kontinens`
  ADD PRIMARY KEY (`kontinens_id`);

--
-- A tábla indexei `orszag`
--
ALTER TABLE `orszag`
  ADD PRIMARY KEY (`orszag_id`),
  ADD KEY `kontinens` (`kontinens_id`),
  ADD KEY `kontinens_id` (`kontinens_id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `kontinens`
--
ALTER TABLE `kontinens`
  MODIFY `kontinens_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT a táblához `orszag`
--
ALTER TABLE `orszag`
  MODIFY `orszag_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=197;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `orszag`
--
ALTER TABLE `orszag`
  ADD CONSTRAINT `orszag_ibfk_1` FOREIGN KEY (`kontinens_id`) REFERENCES `kontinens` (`kontinens_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
