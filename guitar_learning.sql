-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Време на генериране: 14 юни 2025 в 10:52
-- Версия на сървъра: 10.4.32-MariaDB
-- Версия на PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данни: `guitar_learning`
--

-- --------------------------------------------------------

--
-- Структура на таблица `favorites`
--

CREATE TABLE `favorites` (
  `Id` int(11) NOT NULL,
  `UserId` int(11) NOT NULL,
  `ItemId` int(11) NOT NULL,
  `ItemType` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура на таблица `lessons`
--

CREATE TABLE `lessons` (
  `id` int(11) NOT NULL,
  `title` varchar(255) NOT NULL,
  `filepath` varchar(255) NOT NULL,
  `is_favorite` tinyint(1) DEFAULT 0,
  `user_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `lessons`
--

INSERT INTO `lessons` (`id`, `title`, `filepath`, `is_favorite`, `user_id`) VALUES
(6, 'Ragnarok - Murder', 'Lessons\\Ragnarok - Murder.mp4', 0, NULL),
(11, 'Gorgoroth - Of ice and movement', 'Lessons\\Gorgoroth - Of ice and movement.mp4', 0, NULL),
(13, 'Gorgoroth - Of ice and movement', 'Lessons\\Gorgoroth - Of ice and movement.mp4', 0, NULL),
(14, 'Ragnarok - Murder', 'Lessons\\Ragnarok - Murder.mp4', 0, NULL),
(15, 'BURZUM - WAR - COVER (online-video-cutter.com)', 'Lessons\\BURZUM - WAR - COVER (online-video-cutter.com).mp4', 0, NULL),
(16, 'Gorgoroth - Of ice and movement', 'Lessons\\Gorgoroth - Of ice and movement.mp4', 0, NULL),
(17, 'Gorgoroth - Of ice and movement', 'Lessons\\Gorgoroth - Of ice and movement.mp4', 0, NULL),
(18, 'Gorgoroth - Of ice and movement', 'Lessons\\Gorgoroth - Of ice and movement.mp4', 0, NULL),
(19, 'Gorgoroth - Of ice and movement', 'Lessons\\Gorgoroth - Of ice and movement.mp4', 0, 1),
(20, 'Gorgoroth - Of ice and movement', 'Lessons\\Gorgoroth - Of ice and movement.mp4', 0, 4),
(21, 'Ragnarok - Murder', 'Lessons\\Ragnarok - Murder.mp4', 0, 1);

-- --------------------------------------------------------

--
-- Структура на таблица `records`
--

CREATE TABLE `records` (
  `id` int(11) NOT NULL,
  `title` varchar(255) DEFAULT NULL,
  `filepath` varchar(255) DEFAULT NULL,
  `user_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `records`
--

INSERT INTO `records` (`id`, `title`, `filepath`, `user_id`) VALUES
(2, 'Urgehal - Goatcraft torment', 'Records\\Urgehal - Goatcraft torment.mp3', 1),
(3, 'Darkthrone - Transilvanian hunger', 'Records\\Darkthrone - Transilvanian hunger.mp3', 1),
(4, 'Satanic Warmaster - Warmaster returns', 'Records\\Satanic Warmaster - Warmaster returns.mp3', 1),
(5, 'Ieschure - Among the swamps and darkness', 'Records\\Ieschure - Among the swamps and darkness.mp3', 1),
(6, 'Darzamat - Pain collector', 'Records\\Darzamat - Pain collector.mp3', 1),
(7, 'Satanic Warmaster - Warmaster returns', 'Records\\Satanic Warmaster - Warmaster returns.mp3', 4),
(8, 'The Perfect Girl - Mareux', 'Records\\The Perfect Girl - Mareux.mp3', 1),
(9, 'War - Burzum', 'Records\\War - Burzum.mp3', 1);

-- --------------------------------------------------------

--
-- Структура на таблица `tabs`
--

CREATE TABLE `tabs` (
  `id` int(11) NOT NULL,
  `title` varchar(255) NOT NULL,
  `filepath` varchar(255) NOT NULL,
  `is_favorite` tinyint(1) DEFAULT 0,
  `user_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `tabs`
--

INSERT INTO `tabs` (`id`, `title`, `filepath`, `is_favorite`, `user_id`) VALUES
(4, 'Goatcraft Torment', 'Tabs\\Goatcraft Torment.pdf', 0, NULL),
(8, '1349 - Celestial Deconstruction', 'Tabs\\1349 - Celestial Deconstruction.pdf', 0, NULL),
(9, 'Gorgoroth - Wound Upon Wound', 'Tabs\\Gorgoroth - Wound Upon Wound.pdf', 0, NULL),
(10, 'Gorgoroth - Prosperity And Beauty', 'Tabs\\Gorgoroth - Prosperity And Beauty.pdf', 0, NULL),
(12, 'Nattestid Ser Porten Vid I', 'Tabs\\Nattestid Ser Porten Vid I.pdf', 0, NULL),
(13, 'Mayhem - Impious Devious Leper Lord', 'Tabs\\Mayhem - Impious Devious Leper Lord.pdf', 0, NULL),
(14, '1349 - I Breathe Spears', 'Tabs\\1349 - I Breathe Spears.pdf', 0, NULL),
(26, 'Nightbringer I am the Gateway', 'C:\\Users\\presl\\Desktop\\Fjord-main\\WinFormsApp1\\bin\\Debug\\net8.0-windows\\Tabs\\Nightbringer I am the Gateway.pdf', 0, 1),
(27, 'One By One', 'C:\\Users\\presl\\Desktop\\Fjord-main\\WinFormsApp1\\bin\\Debug\\net8.0-windows\\Tabs\\One By One.pdf', 0, 1),
(29, 'Immortal - Tyrants', 'C:\\Users\\presl\\Desktop\\Fjord-main\\WinFormsApp1\\bin\\Debug\\net8.0-windows\\Tabs\\Immortal - Tyrants.pdf', 0, 1),
(30, 'Ascension - Fire and Faith', 'C:\\Users\\presl\\Desktop\\Fjord-main\\WinFormsApp1\\bin\\Debug\\net8.0-windows\\Tabs\\Ascension - Fire and Faith.pdf', 0, 4),
(31, 'Emperor - The Loss And Curse Of Reverence ', 'C:\\Users\\presl\\Desktop\\Fjord-main\\WinFormsApp1\\bin\\Debug\\net8.0-windows\\Tabs\\Emperor - The Loss And Curse Of Reverence .pdf', 0, 1),
(32, '1349 - I Breathe Spears', 'C:\\Users\\presl\\Desktop\\Fjord-main\\WinFormsApp1\\bin\\Debug\\net8.0-windows\\Tabs\\1349 - I Breathe Spears.pdf', 0, 1),
(33, 'Burzum - Jesus Tod', 'C:\\Users\\presl\\Desktop\\Fjord-main\\WinFormsApp1\\bin\\Debug\\net8.0-windows\\Tabs\\Burzum - Jesus Tod.pdf', 0, 1),
(34, 'Immortal - Withstand The Fall Of Time', 'C:\\Users\\presl\\Desktop\\Fjord-main\\WinFormsApp1\\bin\\Debug\\net8.0-windows\\Tabs\\Immortal - Withstand The Fall Of Time.pdf', 0, 1),
(35, 'Nattestid Ser Porten Vid I', 'C:\\Users\\presl\\Desktop\\Fjord-main\\WinFormsApp1\\bin\\Debug\\net8.0-windows\\Tabs\\Nattestid Ser Porten Vid I.pdf', 0, 1),
(36, 'Mayhem - Impious Devious Leper Lord', 'C:\\Users\\presl\\Desktop\\Fjord-main\\WinFormsApp1\\bin\\Debug\\net8.0-windows\\Tabs\\Mayhem - Impious Devious Leper Lord.pdf', 0, 1),
(37, '1349 - Celestial Deconstruction', 'C:\\Users\\presl\\Desktop\\Fjord-main\\WinFormsApp1\\bin\\Debug\\net8.0-windows\\Tabs\\1349 - Celestial Deconstruction.pdf', 0, 1),
(38, 'Dimmu - Blessings...Tyranny', 'C:\\Users\\presl\\Desktop\\Fjord-main\\WinFormsApp1\\bin\\Debug\\net8.0-windows\\Tabs\\Dimmu - Blessings...Tyranny.pdf', 0, 1);

-- --------------------------------------------------------

--
-- Структура на таблица `users`
--

CREATE TABLE `users` (
  `ID` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Password` varchar(256) NOT NULL,
  `ProfilePicture` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `users`
--

INSERT INTO `users` (`ID`, `Username`, `Email`, `Password`, `ProfilePicture`) VALUES
(1, 'Preslav', 'preslavgeorgiev26@itpg-varna.bg', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 'https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fwww.metal-archives.com%2Fimages%2F1%2F1%2F2%2F2%2F1122_logo.jpg%3F1953&f=1&nofb=1&ipt=bbce150bcc37c13e3dae1d5b7b81fb96fb66e9ba367bd7a40cee77d781e39374'),
(2, 'az', '@', '4654d793972c3b6a1d48fb0ab58d9cb0de46c3d33d605f9222c283dfaa12d420', NULL),
(4, 'a', 't@', '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b', NULL),
(5, 'tra', '@t', 'e629fa6598d732768f7c726b4b621285f9c3b85303900aa912017db7617d8bdb', NULL),
(6, 'ert', '@a', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', NULL),
(7, 'petyo', 'da@', '5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5', NULL),
(8, 'petyo1', 'da@', '8bb0cf6eb9b17d0f7d22b456f121257dc1254e1f01665370476383ea776df414', NULL);

--
-- Indexes for dumped tables
--

--
-- Индекси за таблица `favorites`
--
ALTER TABLE `favorites`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UserId` (`UserId`,`ItemId`,`ItemType`) USING HASH;

--
-- Индекси за таблица `lessons`
--
ALTER TABLE `lessons`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_id` (`user_id`);

--
-- Индекси за таблица `records`
--
ALTER TABLE `records`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_id` (`user_id`);

--
-- Индекси за таблица `tabs`
--
ALTER TABLE `tabs`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_tabs_user` (`user_id`);

--
-- Индекси за таблица `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `favorites`
--
ALTER TABLE `favorites`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `lessons`
--
ALTER TABLE `lessons`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `records`
--
ALTER TABLE `records`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tabs`
--
ALTER TABLE `tabs`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Ограничения за дъмпнати таблици
--

--
-- Ограничения за таблица `lessons`
--
ALTER TABLE `lessons`
  ADD CONSTRAINT `lessons_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`ID`);

--
-- Ограничения за таблица `records`
--
ALTER TABLE `records`
  ADD CONSTRAINT `records_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`ID`) ON DELETE CASCADE;

--
-- Ограничения за таблица `tabs`
--
ALTER TABLE `tabs`
  ADD CONSTRAINT `fk_tabs_user` FOREIGN KEY (`user_id`) REFERENCES `users` (`ID`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
