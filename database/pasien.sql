-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: May 30, 2024 at 05:03 PM
-- Server version: 8.0.30
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `datapasien`
--

-- --------------------------------------------------------

--
-- Table structure for table `pasien`
--

CREATE TABLE `pasien` (
  `id` int NOT NULL,
  `nama` varchar(100) DEFAULT NULL,
  `tempat_lahir` varchar(200) NOT NULL,
  `ttl` date DEFAULT NULL,
  `gender` enum('P','L') DEFAULT NULL,
  `alamat` text,
  `keluhan` varchar(200) NOT NULL,
  `poli_id` int DEFAULT NULL,
  `diagnosa` text CHARACTER SET utf8mb4 
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pasien`
--

INSERT INTO `pasien` (`id`, `nama`, `tempat_lahir`, `ttl`, `gender`, `alamat`, `keluhan`, `poli_id`, `diagnosa`) VALUES
(1, 'John Doe', 'Jakarta', '1990-05-10', 'L', 'Jl. Menteng No. 123', 'Demam', 1, ''),
(2, 'Jane Smith', 'Surabaya', '1985-08-15', 'P', 'Jl. Diponegoro No. 45', 'Flu', 2, ''),
(3, 'Michael Johnson', 'Bandung', '1978-12-20', 'L', 'Jl. Pahlawan No. 67', 'Sakit Kepala', 3, ''),
(4, 'Emily Brown', 'Yogyakarta', '1992-03-25', 'P', 'Jl. Malioboro No. 89', 'Batuk', 4, ''),
(5, 'Daniel Wilson', 'Semarang', '1980-06-30', 'L', 'Jl. Gajah Mada No. 12', 'Pusing', 5, ''),
(6, 'Olivia Martinez', 'Medan', '1987-09-05', 'P', 'Jl. Merdeka No. 34', 'Demam', 6, ''),
(7, 'William Taylor', 'Makassar', '1995-01-15', 'L', 'Jl. Sudirman No. 56', 'Flu', 7, ''),
(8, 'Sophia Anderson', 'Palembang', '1983-04-20', 'P', 'Jl. Veteran No. 78', 'Sakit Perut', 8, ''),
(9, 'Alexander Garcia', 'Bali', '1989-07-10', 'L', 'Jl. Pantai No. 90', 'Mual', 9, ''),
(10, 'Ava Thomas', 'Lombok', '1975-10-05', 'P', 'Jl. Raya No. 11', 'Sakit Tenggorokan', 10, ''),
(11, 'Michael Clark', 'Surabaya', '1988-09-22', 'L', 'Jl. Diponegoro No. 25', 'Demam', 1, ''),
(12, 'Emma Lee', 'Bandung', '1993-07-18', 'P', 'Jl. Pahlawan No. 76', 'Flu', 2, ''),
(13, 'Matthew Rodriguez', 'Yogyakarta', '1981-12-05', 'L', 'Jl. Malioboro No. 67', 'Sakit Kepala', 3, ''),
(14, 'Isabella Wilson', 'Semarang', '1990-02-14', 'P', 'Jl. Gajah Mada No. 32', 'Batuk', 4, ''),
(15, 'David Martinez', 'Medan', '1985-05-30', 'L', 'Jl. Merdeka No. 56', 'Pusing', 5, ''),
(16, 'Olivia Thompson', 'Makassar', '1979-10-10', 'P', 'Jl. Sudirman No. 78', 'Demam', 6, ''),
(17, 'James White', 'Palembang', '1997-03-15', 'L', 'Jl. Veteran No. 22', 'Flu', 7, ''),
(18, 'Sophia Garcia', 'Bali', '1982-08-08', 'P', 'Jl. Pantai No. 45', 'Sakit Perut', 8, ''),
(19, 'Alexander Miller', 'Lombok', '1978-11-25', 'L', 'Jl. Raya No. 34', 'Mual', 9, ''),
(20, 'Ava Harris', 'Jakarta', '1989-06-12', 'P', 'Jl. Menteng No. 56', 'Sakit Tenggorokan', 10, ''),
(21, 'Michael Scott', 'Surabaya', '1990-10-15', 'L', 'Jl. Diponegoro No. 45', 'Demam', 1, ''),
(22, 'Emma Johnson', 'Bandung', '1985-07-20', 'P', 'Jl. Pahlawan No. 67', 'Flu', 2, ''),
(23, 'Noah Anderson', 'Yogyakarta', '1978-02-25', 'L', 'Jl. Malioboro No. 89', 'Sakit Kepala', 3, ''),
(24, 'Emma Martinez', 'Semarang', '1992-05-30', 'P', 'Jl. Gajah Mada No. 12', 'Batuk', 4, ''),
(25, 'William Wilson', 'Medan', '1980-08-05', 'L', 'Jl. Merdeka No. 34', 'Pusing', 5, ''),
(26, 'Olivia Taylor', 'Makassar', '1995-01-15', 'P', 'Jl. Sudirman No. 56', 'Demam', 6, ''),
(27, 'James Brown', 'Palembang', '1983-04-20', 'L', 'Jl. Veteran No. 78', 'Flu', 7, ''),
(28, 'Sophia Garcia', 'Bali', '1989-07-10', 'P', 'Jl. Pantai No. 90', 'Sakit Perut', 8, ''),
(29, 'Alexander Davis', 'Lombok', '1975-10-05', 'L', 'Jl. Raya No. 11', 'Mual', 9, ''),
(30, 'Ava Miller', 'Jakarta', '1987-12-20', 'P', 'Jl. Menteng No. 123', 'Sakit Tenggorokan', 10, ''),
(31, 'Liam Wilson', 'Surabaya', '1990-10-15', 'L', 'Jl. Diponegoro No. 45', 'Demam', 1, ''),
(32, 'Olivia Johnson', 'Bandung', '1985-07-20', 'P', 'Jl. Pahlawan No. 67', 'Flu', 2, ''),
(33, 'Noah Anderson', 'Yogyakarta', '1978-02-25', 'L', 'Jl. Malioboro No. 89', 'Sakit Kepala', 3, ''),
(34, 'Emma Martinez', 'Semarang', '1992-05-30', 'P', 'Jl. Gajah Mada No. 12', 'Batuk', 4, ''),
(35, 'William Wilson', 'Medan', '1980-08-05', 'L', 'Jl. Merdeka No. 34', 'Pusing', 5, ''),
(36, 'Olivia Taylor', 'Makassar', '1995-01-15', 'P', 'Jl. Sudirman No. 56', 'Demam', 6, ''),
(37, 'James Brown', 'Palembang', '1983-04-20', 'L', 'Jl. Veteran No. 78', 'Flu', 7, ''),
(38, 'Sophia Garcia', 'Bali', '1989-07-10', 'P', 'Jl. Pantai No. 90', 'Sakit Perut', 8, ''),
(39, 'Alexander Davis', 'Lombok', '1975-10-05', 'L', 'Jl. Raya No. 11', 'Mual', 9, ''),
(40, 'Ava Miller', 'Jakarta', '1987-12-20', 'P', 'Jl. Menteng No. 123', 'Sakit Tenggorokan', 10, ''),
(41, 'Liam Wilson', 'Surabaya', '1990-10-15', 'L', 'Jl. Diponegoro No. 45', 'Demam', 1, ''),
(42, 'Olivia Johnson', 'Bandung', '1985-07-20', 'P', 'Jl. Pahlawan No. 67', 'Flu', 2, ''),
(43, 'Noah Anderson', 'Yogyakarta', '1978-02-25', 'L', 'Jl. Malioboro No. 89', 'Sakit Kepala', 3, ''),
(44, 'Emma Martinez', 'Semarang', '1992-05-30', 'P', 'Jl. Gajah Mada No. 12', 'Batuk', 4, ''),
(45, 'William Wilson', 'Medan', '1980-08-05', 'L', 'Jl. Merdeka No. 34', 'Pusing', 5, ''),
(46, 'Olivia Taylor', 'Makassar', '1995-01-15', 'P', 'Jl. Sudirman No. 56', 'Demam', 6, ''),
(47, 'James Brown', 'Palembang', '1983-04-20', 'L', 'Jl. Veteran No. 78', 'Flu', 7, ''),
(48, 'Sophia Garcia', 'Bali', '1989-07-10', 'P', 'Jl. Pantai No. 90', 'Sakit Perut', 8, ''),
(49, 'Alexander Davis', 'Lombok', '1975-10-05', 'L', 'Jl. Raya No. 11', 'Mual', 9, ''),
(50, 'Ava Miller', 'Jakarta', '1987-12-20', 'P', 'Jl. Menteng No. 123', 'Sakit Tenggorokan', 10, '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pasien`
--
ALTER TABLE `pasien`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_Pasien_Poli` (`poli_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pasien`
--
ALTER TABLE `pasien`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `pasien`
--
ALTER TABLE `pasien`
  ADD CONSTRAINT `FK_Pasien_Poli` FOREIGN KEY (`poli_id`) REFERENCES `poli` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;