-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 27, 2024 at 04:03 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.11

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
  `id` int(11) NOT NULL,
  `nama` varchar(100) DEFAULT NULL,
  `tempat_lahir` varchar(200) NOT NULL,
  `ttl` date DEFAULT NULL,
  `gender` enum('P','L') DEFAULT NULL,
  `alamat` text DEFAULT NULL,
  `keluhan` varchar(200) NOT NULL,
  `poli_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pasien`
--

INSERT INTO `pasien` (`id`, `nama`, `tempat_lahir`, `ttl`, `gender`, `alamat`, `keluhan`, `poli_id`) VALUES
(26, 'sdfasdaf', 'cirebon', '2000-01-01', 'L', 'cirebon', 'Mata hilang', 4),
(27, 'zul sembuh', 'pohon', '2000-01-01', 'L', 'semarang', 'panas pusing', 1),
(28, 'cape buset', 'planet', '2024-05-26', 'L', 'semarang', 'cape', 1),
(29, 'agus sembuh', 'pohon', '2000-05-15', 'L', 'manggis', 'gasakit', 1);

-- --------------------------------------------------------

--
-- Table structure for table `poli`
--

CREATE TABLE `poli` (
  `id` int(11) NOT NULL,
  `nama_poli` varchar(100) DEFAULT NULL,
  `dokter` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `poli`
--

INSERT INTO `poli` (`id`, `nama_poli`, `dokter`) VALUES
(1, 'Poli Umum', 'Dr. Andi Wijaya'),
(2, 'Poli Anak', 'Dr. Budi Santoso'),
(3, 'Poli Gigi', 'Drg. Citra Lestari'),
(4, 'Poli Mata', 'Dr. Dewi Kartika'),
(5, 'Poli Kandungan', 'Dr. Eka Putri'),
(6, 'Poli Jantung', 'Dr. Fajar Prasetyo'),
(7, 'Poli Saraf', 'Dr. Gita Pramudya'),
(8, 'Poli Kulit', 'Dr. Hari Setiawan'),
(9, 'Poli THT', 'Dr. Ida Farida'),
(10, 'Poli Bedah', 'Dr. Joko Susilo');

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
-- Indexes for table `poli`
--
ALTER TABLE `poli`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pasien`
--
ALTER TABLE `pasien`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT for table `poli`
--
ALTER TABLE `poli`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

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
