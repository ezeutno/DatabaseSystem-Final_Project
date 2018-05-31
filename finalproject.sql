-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 31, 2018 at 07:14 AM
-- Server version: 10.1.30-MariaDB
-- PHP Version: 7.2.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `finalproject`
--

-- --------------------------------------------------------

--
-- Table structure for table `country`
--

CREATE TABLE `country` (
  `country_id` int(11) NOT NULL,
  `country_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `country`
--

INSERT INTO `country` (`country_id`, `country_name`) VALUES
(1, 'Afghanistan'),
(2, 'Albania'),
(3, 'Algeria'),
(4, 'Andorra'),
(5, 'Angola'),
(6, 'Antigua & Barbuda'),
(7, 'Argentina'),
(8, 'Armenia'),
(9, 'Australia'),
(10, 'Austria'),
(11, 'Azerbaijan'),
(12, 'Bahamas, The'),
(13, 'Bahrain'),
(14, 'Bangladesh'),
(15, 'Barbados'),
(16, 'Belarus'),
(17, 'Belgium'),
(18, 'Belize'),
(19, 'Benin'),
(20, 'Bhutan'),
(21, 'Bolivia'),
(22, 'Bosnia & Herzegovina'),
(23, 'Botzwana'),
(24, 'Brazil'),
(25, 'Brunei'),
(26, 'Bulgaria'),
(27, 'Burkina Faso'),
(28, 'Burundi'),
(29, 'Cabo Verde'),
(30, 'Cambodia'),
(31, 'Cameroon'),
(32, 'Canada'),
(33, 'Central African Republic'),
(34, 'Chad'),
(35, 'Chile'),
(36, 'China'),
(37, 'Colombia'),
(38, 'Congo, Democratic Republic Of'),
(39, 'Costa Rica'),
(40, 'Cote D\'Ivorie'),
(41, 'Croatia'),
(42, 'Cuba'),
(43, 'Cyprus'),
(44, 'Czech Republic'),
(45, 'Denmark'),
(46, 'Djibouti'),
(47, 'DOMINICA'),
(48, 'DOMINICAN REPUBLIC'),
(49, 'ECUADOR'),
(50, 'EGYPT'),
(51, 'EL SALVADOR'),
(52, 'EQUATORIAL GUINEA'),
(53, 'ERITREA'),
(54, 'ESTONIA'),
(55, 'ETHIOPIA'),
(56, 'FEDERATED STATES OF MICRONESIA'),
(57, 'FIJI'),
(58, 'FINLAND'),
(59, 'FRANCE'),
(60, 'GABON'),
(61, 'GAMBIA, THE'),
(62, 'GEORGIA'),
(63, 'GERMANY'),
(64, 'GHANA'),
(65, 'GREECE'),
(66, 'GRENADA'),
(67, 'GUATEMALA'),
(68, 'GUINEA'),
(69, 'GUINEA-BISSAU'),
(70, 'GUYANA'),
(71, 'HAITI'),
(72, 'HONDURAS'),
(73, 'HUNGARY'),
(74, 'ICELAND'),
(75, 'INDIA'),
(76, 'INDONESIA'),
(77, 'IRAN'),
(78, 'IRAQ'),
(79, 'IRELAND'),
(80, 'ISRAEL'),
(81, 'ITALY'),
(82, 'JAMAICA'),
(83, 'JAPAN'),
(84, 'JORDAN'),
(85, 'KAZAKHSTAN'),
(86, 'KENYA'),
(87, 'KIRIBATI'),
(88, 'KOSOVO'),
(89, 'KUWAIT'),
(90, 'KYRGYZSTAN'),
(91, 'LAOS'),
(92, 'LATVIA'),
(93, 'LEBANON'),
(94, 'LESOTHO'),
(95, 'LIBERIA'),
(96, 'LIBYA'),
(97, 'LIECHTENSTEIN'),
(98, 'LITHUANIA'),
(99, 'LUXEMBOURG'),
(100, 'MACEDONIA'),
(101, 'MADAGASCAR'),
(102, 'MALAWI'),
(103, 'MALAYSIA'),
(104, 'MALDIVES'),
(105, 'MALI'),
(106, 'MALTA'),
(107, 'MARSHALL ISLANDS'),
(108, 'MAURITANIA'),
(109, 'MAURITIUS'),
(110, 'MEXICO'),
(111, 'MOLDOVA'),
(112, 'MONACO'),
(113, 'MONGOLIA'),
(114, 'MONTENEGRO'),
(115, 'MOROCCO'),
(116, 'MOZAMBIQUE'),
(117, 'MYANMAR'),
(118, 'NAMIBIA'),
(119, 'NAURU'),
(120, 'NEPAL'),
(121, 'NETHERLANDS'),
(122, 'NEW ZEALAND'),
(123, 'NICARAGUA'),
(124, 'NIGER'),
(125, 'NIGERIA'),
(126, 'NORTH KOREA'),
(127, 'NORWAY'),
(128, 'OMAN'),
(129, 'PAKISTAN'),
(130, 'PALAU'),
(131, 'PALESTINE'),
(132, 'PANAMA'),
(133, 'PAPUA NEW GUINEA'),
(134, 'PARAGUAY'),
(135, 'PERU'),
(136, 'PHILIPPINES'),
(137, 'POLAND'),
(138, 'PORTUGAL'),
(139, 'QATAR'),
(140, 'REPUBLIC OF THE CONGO'),
(141, 'ROMANIA'),
(142, 'RUSSIA'),
(143, 'RWANDA'),
(144, 'SAINT KITTS & NEVIS'),
(145, 'SAINT LUCIA'),
(146, 'SAINT VINCENT & THE GRENADINES'),
(147, 'SAMOA'),
(148, 'SAN MARINO'),
(149, 'SO TOM & PRNCIPE'),
(150, 'SAUDI ARABIA'),
(151, 'SENEGAL'),
(152, 'SERBIA'),
(153, 'SEYCHELLES'),
(154, 'SIERRA LEONE'),
(155, 'SINGAPORE'),
(156, 'SLOVAKIA'),
(157, 'SLOVENIA'),
(158, 'SOLOMON ISLANDS'),
(159, 'SOMALIA'),
(160, 'SOUTH AFRICA'),
(161, 'SOUTH KOREA'),
(162, 'SOUTH SUDAN'),
(163, 'SPAIN'),
(164, 'SRI LANKA'),
(165, 'SUDAN'),
(166, 'SURINAME'),
(167, 'SWAZILAND'),
(168, 'SWEDEN'),
(169, 'SWITZERLAND'),
(170, 'SYRIA'),
(171, 'TAJIKISTAN'),
(172, 'TANZANIA'),
(173, 'THAILAND'),
(174, 'TIMOR-LESTE'),
(175, 'TOGO'),
(176, 'TONGA'),
(177, 'TRINIDAD & TOBAGO'),
(178, 'TUNISIA'),
(179, 'TURKEY'),
(180, 'TURKMENISTAN'),
(181, 'TUVALU'),
(182, 'UGANDA'),
(183, 'UKRAINE'),
(184, 'UNITED ARAB EMIRATES'),
(185, 'UNITED KINGDOM'),
(186, 'UNITED STATES'),
(187, 'URUGUAY'),
(188, 'UZBEKISTAN'),
(189, 'VANUATU'),
(190, 'VATICAN CITY'),
(191, 'VENEZUELA'),
(192, 'VIETNAM'),
(193, 'YEMEN'),
(194, 'ZAMBIA'),
(195, 'ZIMBABWE');

-- --------------------------------------------------------

--
-- Table structure for table `custaddress`
--

CREATE TABLE `custaddress` (
  `id` int(11) NOT NULL,
  `detail` text NOT NULL,
  `sub_district` varchar(50) DEFAULT NULL,
  `district` varchar(50) DEFAULT NULL,
  `province` varchar(50) DEFAULT NULL,
  `postal_code` int(11) NOT NULL,
  `country_id` int(11) DEFAULT NULL,
  `username` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `custaddress`
--

INSERT INTO `custaddress` (`id`, `detail`, `sub_district`, `district`, `province`, `postal_code`, `country_id`, `username`) VALUES
(1, 'FX SUDIRMAN LT 10', 'Sudirman', 'Jakarta Pusat', 'DKI Jakarta', 12839, 76, 'ezeutno'),
(4, 'Rumah Kelapa Sawit', 'Kampung Pulo', 'Jakarta Utara', 'DKI Jakarta', 184657, 76, 'david'),
(5, 'Gryia Permata 2 Blok G7 No 89', 'Ciledug', 'Kota Tangerang', 'Banten', 15258, 76, 'ezeutno'),
(7, 'a', 'a', 'a', 'a', 1, 2, '');

-- --------------------------------------------------------

--
-- Table structure for table `custdetail`
--

CREATE TABLE `custdetail` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `fname` varchar(50) NOT NULL,
  `lName` varchar(50) NOT NULL,
  `email` varchar(100) NOT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `birthday` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `custdetail`
--

INSERT INTO `custdetail` (`username`, `password`, `fname`, `lName`, `email`, `phone`, `birthday`) VALUES
('', '', '', '', '', '', '2000-01-01'),
('david', 'david123', 'David', 'Honasan', 'david.honasan@binus.ac.id', '6281763267842', '1999-09-26'),
('dgjfhgfdgfg', '12345678', 'lol', 'lol', 'lol@ghf.uyfghj', '08656564565', '2009-02-03'),
('ezeutno', '24091999', 'Ivan Ezechial', 'Suratno', 'ivan.suratno@gmail.com', '6281807825885', '1999-09-24'),
('jbarlian', '12345678', 'James', 'Barlian', 'jbarlian@aol.com', '7462318731289', '1995-06-14'),
('lol', '12345678', 'Frendy', 'B', 'frendy222@gmail.com', '63489327948', '1999-06-16'),
('sher', '12345678', 'qwertyasdfgh', 'asdfghfds', 'lol@gmail.com', '893719827332', '1995-06-14'),
('sm', '12345678', 'susan', 'margarita', 'msuratno@djhsh.com', '62387189237', '1992-03-11');

-- --------------------------------------------------------

--
-- Table structure for table `store`
--

CREATE TABLE `store` (
  `name` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `address_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `store`
--

INSERT INTO `store` (`name`, `username`, `address_id`) VALUES
('a', '', 7),
('Kampung Melayu', 'david', 4),
('Rumah Merdeka', 'ezeutno', 5);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `country`
--
ALTER TABLE `country`
  ADD PRIMARY KEY (`country_id`);

--
-- Indexes for table `custaddress`
--
ALTER TABLE `custaddress`
  ADD PRIMARY KEY (`id`),
  ADD KEY `country_id` (`country_id`);

--
-- Indexes for table `custdetail`
--
ALTER TABLE `custdetail`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `store`
--
ALTER TABLE `store`
  ADD PRIMARY KEY (`name`),
  ADD KEY `username` (`username`),
  ADD KEY `address_id` (`address_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `country`
--
ALTER TABLE `country`
  MODIFY `country_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=196;

--
-- AUTO_INCREMENT for table `custaddress`
--
ALTER TABLE `custaddress`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `custaddress`
--
ALTER TABLE `custaddress`
  ADD CONSTRAINT `custaddress_ibfk_1` FOREIGN KEY (`country_id`) REFERENCES `country` (`country_id`);

--
-- Constraints for table `store`
--
ALTER TABLE `store`
  ADD CONSTRAINT `store_ibfk_1` FOREIGN KEY (`username`) REFERENCES `custdetail` (`username`),
  ADD CONSTRAINT `store_ibfk_2` FOREIGN KEY (`address_id`) REFERENCES `custaddress` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
