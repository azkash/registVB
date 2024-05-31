-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: May 31, 2024 at 07:26 AM
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
-- Table structure for table `antrian`
--

CREATE TABLE `antrian` (
  `id_antrian` int NOT NULL,
  `id_poli` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

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
  `diagnosa` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

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

-- --------------------------------------------------------

--
-- Table structure for table `poli`
--

CREATE TABLE `poli` (
  `id` int NOT NULL,
  `nama_poli` varchar(100) DEFAULT NULL,
  `dokter` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

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

-- --------------------------------------------------------

--
-- Table structure for table `roles`
--

CREATE TABLE `roles` (
  `id_role` int NOT NULL,
  `nama_role` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `roles`
--

INSERT INTO `roles` (`id_role`, `nama_role`) VALUES
(1, 'admin'),
(2, 'user');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role_id` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `role_id`) VALUES
(1, 'admin', 'admin123', 1),
(2, 'zulvikar', 'zulvikar123', 1),
(3, 'azka', 'azka123', 1),
(4, 'user1', 'password123', 2),
(5, 'user2', 'password123', 2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `antrian`
--
ALTER TABLE `antrian`
  ADD PRIMARY KEY (`id_antrian`),
  ADD KEY `id_poli` (`id_poli`);

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
-- Indexes for table `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`id_role`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD KEY `role_id` (`role_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pasien`
--
ALTER TABLE `pasien`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT for table `poli`
--
ALTER TABLE `poli`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `roles`
--
ALTER TABLE `roles`
  MODIFY `id_role` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `antrian`
--
ALTER TABLE `antrian`
  ADD CONSTRAINT `antrian_ibfk_1` FOREIGN KEY (`id_poli`) REFERENCES `poli` (`id`);

--
-- Constraints for table `pasien`
--
ALTER TABLE `pasien`
  ADD CONSTRAINT `FK_Pasien_Poli` FOREIGN KEY (`poli_id`) REFERENCES `poli` (`id`);

--
-- Constraints for table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`role_id`) REFERENCES `roles` (`id_role`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
