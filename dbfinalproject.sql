-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 03, 2018 at 07:25 AM
-- Server version: 10.1.31-MariaDB
-- PHP Version: 7.2.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbfinalproject`
--

-- --------------------------------------------------------

--
-- Table structure for table `brand`
--

CREATE TABLE `brand` (
  `id` int(11) NOT NULL,
  `name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `brand`
--

INSERT INTO `brand` (`id`, `name`) VALUES
(1, 'Samsung'),
(2, 'Apple'),
(3, 'LG'),
(4, 'Nokia'),
(5, 'Oneplus'),
(6, 'Xiaomi'),
(7, 'Oppo'),
(8, 'Vivo');

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
(7, 'Aribanda Luksamer', 'a', 'a', 'a', 1, 2, ''),
(8, 'Barinusa 3, 672, 9898', 'b', 'b', 'b', 1, 37, ''),
(10, 'Jalan Panjang', 'Kuntilanang', 'Jakarta Timur', 'DKI Jakarta', 87365, 76, 'sher'),
(11, 'Jawa Kuliang 6', 'Haji Kumeng 7', 'Jakarta Barat', 'DKI Jakarta', 54637, 76, 'jbarlian'),
(12, 'Jalan Kamboja 9', 'Rusunawa', 'Kaligede', 'Irian Jaya', 99854, 76, 'lol'),
(13, 'FX Sudirman, F6 Floor, Jl Jend. Sudirman', 'Gelora', 'Tanah Abang', 'Central Jakarta', 10270, 76, 'test_account');

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
('', '', 'Space Otter', 'Odd', '@.', '12345678', '2000-01-01'),
('david', 'david123', 'David', 'Honasan', 'david.honasan@binus.ac.id', '6281763267842', '1999-09-26'),
('ezeutno', '24091999', 'Ivan Ezechial', 'Suratno', 'ivan.suratno@gmail.com', '6281807825885', '1999-09-24'),
('jbarlian', '12345678', 'James', 'Barlian', 'jbarlian@aol.com', '7462318731289', '1995-06-14'),
('lol', '12345678', 'Frendy', 'B', 'frendy222@gmail.com', '63489327948', '1999-06-16'),
('sher', '12345678', 'Donald', 'Trump', 'lol@gmail.com', '893719827332', '1950-07-26'),
('sm', '12345678', 'susan', 'margarita', 'msuratno@djhsh.com', '62387189237', '1992-03-11'),
('test_account', 'test1234', 'Test', 'Account', 'test@example.com', '081234567890', '1991-02-28');

-- --------------------------------------------------------

--
-- Table structure for table `detailtrans`
--

CREATE TABLE `detailtrans` (
  `id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `transaction_id` int(11) NOT NULL,
  `status` varchar(20) DEFAULT 'On Process'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `detailtrans`
--

INSERT INTO `detailtrans` (`id`, `item_id`, `quantity`, `transaction_id`, `status`) VALUES
(6, 12, 1, 6, 'FULLFILLED'),
(7, 15, 1, 8, 'FULLFILLED'),
(8, 13, 1, 8, 'FULLFILLED'),
(9, 14, 1, 14, 'FULLFILLED'),
(10, 1, 5, 11, 'FULLFILLED'),
(11, 8, 5, 11, 'REJECTED'),
(13, 3, 1, 16, 'REJECTED'),
(14, 11, 1, 18, 'FULLFILLED'),
(15, 9, 1, 19, 'FULLFILLED'),
(16, 7, 1, 19, 'FULLFILLED'),
(17, 9, 5, 20, 'FULLFILLED'),
(19, 3, 1, 22, 'FULLFILLED'),
(26, 3, 2, 24, 'FULLFILLED'),
(27, 2, 2, 24, 'FULLFILLED'),
(28, 6, 2, 24, 'REJECTED'),
(29, 13, 5, 25, 'REJECTED'),
(30, 1, 1, 17, 'FULLFILLED'),
(31, 16, 1, 15, 'REJECTED'),
(32, 7, 1, 23, 'FULLFILLED'),
(33, 8, 1, 26, 'FULLFILLED'),
(34, 12, 1, 26, 'On Process'),
(35, 1, 1, 26, 'REJECTED'),
(37, 1, 1, 30, 'REJECTED'),
(38, 17, 1, 28, 'FULLFILLED'),
(39, 12, 1, 32, 'On Process'),
(40, 14, 1, 24, 'On Process'),
(41, 6, 1, 27, 'On Process'),
(42, 22, 20, 29, 'On Process'),
(43, 6, 20, 35, 'REJECTED'),
(44, 1, 10, 35, 'On Process'),
(45, 10, 15, 35, 'On Process'),
(46, 7, 20, 35, 'FULLFILLED'),
(59, 15, 13, 34, 'On Process'),
(60, 13, 10, 38, 'On Process');

-- --------------------------------------------------------

--
-- Table structure for table `item`
--

CREATE TABLE `item` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `quantity` int(11) NOT NULL,
  `price` double NOT NULL,
  `brand_id` int(11) NOT NULL,
  `os_id` int(11) NOT NULL,
  `storage` double NOT NULL,
  `ram` double NOT NULL,
  `description` text NOT NULL,
  `imageloc` text NOT NULL,
  `store_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `item`
--

INSERT INTO `item` (`id`, `name`, `quantity`, `price`, `brand_id`, `os_id`, `storage`, `ram`, `description`, `imageloc`, `store_name`) VALUES
(1, 'Galaxy S9', 870, 13500000, 1, 1, 128, 4, '', 'http://gearopen.com/wp-content/uploads/2018/02/45-Q118-fg-StarStar2-PreReg-Samsung-S9-Lilac-White-Logo.mobile-695x695.png', 'Rooky'),
(2, 'iPhone 7', 78, 10000000, 2, 2, 128, 2, '', 'https://www.totalmobilemalta.com/wp-content/uploads/2016/10/apple-iphone7-plus.png', 'Rooky'),
(3, 'Galaxy S8 Plus', 100, 8500000, 1, 1, 64, 4, '', 'https://staticshop.o2.co.uk/product/images/samsung_galaxy_s8_64gb_midnight_black_front_sku_header.png?cb=80773a56ed8c7c3f0cb94cf8cdf159f6', 'Rooky'),
(6, 'G7+ Thin Q', 98, 11500000, 3, 1, 128, 6, '', 'https://www.bell.ca/Styles/wireless/all_languages/all_regions/catalog_images/LG-G7-ThinQ/LG_G7_ThinQ_Silver_lrg1.png', 'Rooky'),
(7, 'Nokia 6.1 2018', 0, 3500000, 4, 1, 64, 4, '', 'https://bab-assets1.babapi.ooo/img/othe/8687242/ed/9c/blackcoppernokia63.png.41951aed9c.999x600x550.png', 'Rooky'),
(8, 'iPhone X 2017', 90, 16500000, 2, 2, 128, 3, '', 'http://www.handybg.com/web/files/products/201710/4567/13978.png', 'Rooky'),
(9, 'Nokia 7 Plus', 20, 6500000, 4, 1, 64, 4, 'Android One', 'https://s1.poorvikamobile.com/image/cache/data/Mobiles/Nokia/Nokia%207%20Plus/1-600x800.png', 'Rooky'),
(10, 'Oneplus 6', 99985, 9500000, 5, 1, 128, 8, '', 'https://www.oppomart.com/media/catalog/product/cache/1/thumbnail/9df78eab33525d08d6e5fb8d27136e95/o/p/op6-official.png', 'Rooky'),
(11, 'G6', 7, 6500000, 3, 1, 128, 4, '', 'https://www.t-mobile.com/images/png/products/phones/LG-G6-Ice-Platinum/250x270_1.png', 'Rooky'),
(12, 'Galaxy Note 3', 283, 700000, 1, 1, 32, 3, '', 'http://www.techdepotinc.ca/wp-content/uploads/2014/08/note3.png', 'Rumah Merdeka'),
(13, 'Oneplus 5', 245, 6789999.99, 5, 1, 128, 8, '', 'https://staticshop.o2.co.uk/product/images/bau-33174-oneplus-5sku-header-master-midnight-black-090617.png?cb=d80fdf71fc912162777108eec9ba4c86', 'Kampung Melayu'),
(14, 'G5 SE', 180, 3500000, 3, 1, 128, 4, 'The best in class from 2 years back. Modular Design.', 'https://d243u7pon29hni.cloudfront.net/imagesOnDemand/get?imagePath=/images/movil-lg-g5-se-5-3-qhd-octa-core-32-gb-red-4g-gris-titan-1347966-1_l.png&width=480&height=480&quality=65&imgType=product', 'Kampung Melayu'),
(15, 'Nokia 8810 Reloaded', 475, 999999.89, 4, 3, 4, 0.512, 'The reborn of the matrix phone.', 'http://toancaumobile.vn/Data/upload/images/Product/Mobile/nokia-8810-4g.png', 'Masa Tua'),
(16, 'Mi Mix 2s', 20, 9500000, 6, 1, 128, 6, 'The first xiaomi phone to support beta android p program.', 'http://bestengine.humanoid.fr/uploads/products/xiaomi-mi-mix-2-final.png', 'Rumah Merdeka'),
(17, 'Galaxy S8', 56845, 5800000.89, 1, 1, 128, 6, 'Korea Version', 'https://staticshop.o2.co.uk/product/images/samsung_galaxy_s8_plus_64gb_midnight_black_front_sku_header.png?cb=e239faa68d7306d68d478bb01bc647c9', 'Jobs'),
(18, 'Galaxy A5 2016', 45, 5600000, 1, 1, 64, 3, 'Budget Waterproof', 'http://images.samsung.com/is/image/samsung/id-galaxy-a5-2017-a520-sm-a520fzkdxid-depan-hitam-thumb-61214901?$PG_PRD_CARD_PNG$', 'Jobs'),
(19, 'Galaxy A8 2018', 50, 7599999.99, 1, 1, 64, 4, '', 'https://www.bell.ca/Styles/wireless/all_languages/all_regions/catalog_images/SamsungA8/Samsung_Galaxy_A8_black_lrg1.png', 'Jobs'),
(20, 'Nokia 3310', 56, 500000, 4, 4, 0.016, 0.016, 'Reborn 3310, The people phone.', 'https://staticshop.o2.co.uk/product/images/nokia_3310_charcoal_sku_header.png?cb=1f48fe1fc55edc30a6b7df5449b6dab8', 'Jobs'),
(21, 'Oppo F5', 500, 4500000, 7, 1, 64, 6, '', 'https://i0.wp.com/www.mybigfone.com/wp-content/uploads/2017/11/Oppo-f5_image_1.png?fit=400%2C425', 'China store'),
(22, 'Oppo F7', 480, 3500000, 7, 1, 64, 6, '', 'https://cdn.tgdd.vn/Products/Images/42/155261/oppo-f7-bac-400x460.png', 'China store'),
(23, 'Vivo v7', 560, 4500000, 8, 1, 64, 4, '', 'https://cdn2.gsmarena.com/vv/bigpic/vivo-v7.jpg', 'China store');

-- --------------------------------------------------------

--
-- Table structure for table `os`
--

CREATE TABLE `os` (
  `id` int(11) NOT NULL,
  `name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `os`
--

INSERT INTO `os` (`id`, `name`) VALUES
(1, 'Android'),
(2, 'iOS'),
(3, 'KaiOS'),
(4, 'Smart Feature OS');

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
('China store', 'lol', 12),
('Jobs', 'jbarlian', 11),
('Kampung Melayu', 'david', 4),
('Masa Tua', 'sher', 10),
('Rooky', '', 8),
('Rumah Merdeka', 'ezeutno', 1);

-- --------------------------------------------------------

--
-- Table structure for table `transaction`
--

CREATE TABLE `transaction` (
  `id` int(11) NOT NULL,
  `purchased` tinyint(1) NOT NULL,
  `username` varchar(50) NOT NULL,
  `address_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `transaction`
--

INSERT INTO `transaction` (`id`, `purchased`, `username`, `address_id`) VALUES
(6, 1, '', 7),
(8, 1, '', 7),
(11, 1, 'ezeutno', 5),
(14, 1, '', 8),
(15, 1, '', 7),
(16, 1, 'ezeutno', 5),
(17, 1, 'ezeutno', 5),
(18, 1, 'david', 4),
(19, 1, 'david', 4),
(20, 1, 'david', 4),
(21, 0, 'david', NULL),
(22, 1, 'jbarlian', 11),
(23, 1, 'jbarlian', 11),
(24, 1, 'lol', 12),
(25, 1, 'sher', 10),
(26, 1, 'sher', 10),
(27, 0, 'ezeutno', NULL),
(28, 1, '', 8),
(29, 1, 'jbarlian', 11),
(30, 1, 'sher', 10),
(31, 0, 'sher', NULL),
(32, 1, '', 7),
(33, 0, 'lol', NULL),
(34, 1, '', 7),
(35, 1, 'jbarlian', 11),
(36, 0, 'jbarlian', NULL),
(37, 0, '', NULL),
(38, 1, 'test_account', 13),
(39, 0, 'test_account', NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `brand`
--
ALTER TABLE `brand`
  ADD PRIMARY KEY (`id`);

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
  ADD KEY `country_id` (`country_id`),
  ADD KEY `username` (`username`);

--
-- Indexes for table `custdetail`
--
ALTER TABLE `custdetail`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `detailtrans`
--
ALTER TABLE `detailtrans`
  ADD PRIMARY KEY (`id`),
  ADD KEY `item_id` (`item_id`),
  ADD KEY `transaction_id` (`transaction_id`);

--
-- Indexes for table `item`
--
ALTER TABLE `item`
  ADD PRIMARY KEY (`id`),
  ADD KEY `brand_id` (`brand_id`),
  ADD KEY `os_id` (`os_id`),
  ADD KEY `store_name` (`store_name`);

--
-- Indexes for table `os`
--
ALTER TABLE `os`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `store`
--
ALTER TABLE `store`
  ADD PRIMARY KEY (`name`),
  ADD KEY `username` (`username`),
  ADD KEY `address_id` (`address_id`);

--
-- Indexes for table `transaction`
--
ALTER TABLE `transaction`
  ADD PRIMARY KEY (`id`),
  ADD KEY `username` (`username`),
  ADD KEY `address_id` (`address_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `brand`
--
ALTER TABLE `brand`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `country`
--
ALTER TABLE `country`
  MODIFY `country_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=196;

--
-- AUTO_INCREMENT for table `custaddress`
--
ALTER TABLE `custaddress`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `detailtrans`
--
ALTER TABLE `detailtrans`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61;

--
-- AUTO_INCREMENT for table `item`
--
ALTER TABLE `item`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `os`
--
ALTER TABLE `os`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `transaction`
--
ALTER TABLE `transaction`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `custaddress`
--
ALTER TABLE `custaddress`
  ADD CONSTRAINT `custaddress_ibfk_1` FOREIGN KEY (`country_id`) REFERENCES `country` (`country_id`),
  ADD CONSTRAINT `custaddress_ibfk_2` FOREIGN KEY (`username`) REFERENCES `custdetail` (`username`);

--
-- Constraints for table `detailtrans`
--
ALTER TABLE `detailtrans`
  ADD CONSTRAINT `detailtrans_ibfk_1` FOREIGN KEY (`item_id`) REFERENCES `item` (`id`),
  ADD CONSTRAINT `detailtrans_ibfk_2` FOREIGN KEY (`transaction_id`) REFERENCES `transaction` (`id`);

--
-- Constraints for table `item`
--
ALTER TABLE `item`
  ADD CONSTRAINT `item_ibfk_1` FOREIGN KEY (`brand_id`) REFERENCES `brand` (`id`),
  ADD CONSTRAINT `item_ibfk_2` FOREIGN KEY (`os_id`) REFERENCES `os` (`id`),
  ADD CONSTRAINT `item_ibfk_3` FOREIGN KEY (`store_name`) REFERENCES `store` (`name`);

--
-- Constraints for table `store`
--
ALTER TABLE `store`
  ADD CONSTRAINT `store_ibfk_1` FOREIGN KEY (`username`) REFERENCES `custdetail` (`username`),
  ADD CONSTRAINT `store_ibfk_2` FOREIGN KEY (`address_id`) REFERENCES `custaddress` (`id`);

--
-- Constraints for table `transaction`
--
ALTER TABLE `transaction`
  ADD CONSTRAINT `transaction_ibfk_1` FOREIGN KEY (`username`) REFERENCES `custdetail` (`username`),
  ADD CONSTRAINT `transaction_ibfk_2` FOREIGN KEY (`address_id`) REFERENCES `custaddress` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
