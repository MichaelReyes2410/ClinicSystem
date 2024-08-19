-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 03, 2024 at 03:47 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbclinic`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts_t`
--

CREATE TABLE `accounts_t` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `manage_accounts` tinyint(1) NOT NULL,
  `manage_example1` tinyint(1) NOT NULL,
  `manage_example2` tinyint(1) NOT NULL,
  `admin` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `accounts_t`
--

INSERT INTO `accounts_t` (`id`, `name`, `username`, `password`, `manage_accounts`, `manage_example1`, `manage_example2`, `admin`) VALUES
(1, 'Name', 'admin', '000', 1, 1, 1, 1),
(2, 'User 1', 'user1', '000', 1, 0, 0, 0),
(3, 'User 2', 'user2', '000', 0, 1, 0, 0),
(4, 'User3', 'admin1', 'admin', 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `db_attendance`
--

CREATE TABLE `db_attendance` (
  `ID` int(11) NOT NULL,
  `STUDENT_ID` varchar(255) NOT NULL,
  `LOGDATE` varchar(255) NOT NULL,
  `TIMEIN` varchar(255) NOT NULL,
  `AM_STATUS` varchar(255) NOT NULL,
  `TIMEOUT` varchar(255) NOT NULL,
  `PM_STATUS` varchar(255) NOT NULL,
  `MINUTES` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `logindb`
--

CREATE TABLE `logindb` (
  `id` int(11) NOT NULL,
  `USERNAME` varchar(255) NOT NULL,
  `PASSWORD` varchar(255) NOT NULL,
  `TYPE` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `logindb`
--

INSERT INTO `logindb` (`id`, `USERNAME`, `PASSWORD`, `TYPE`) VALUES
(2, 'Admin', 'Admin', 'Admin'),
(3, 'User', 'User', 'User'),
(4, 'Nurse', 'Nurse', 'Nurse'),
(5, 'Guest', 'Guest\r\n', 'Guest\r\n');

-- --------------------------------------------------------

--
-- Table structure for table `patient_record`
--

CREATE TABLE `patient_record` (
  `ID` int(11) NOT NULL,
  `name` varchar(45) NOT NULL,
  `address` varchar(255) NOT NULL,
  `street` varchar(45) NOT NULL,
  `city` varchar(45) NOT NULL,
  `state` varchar(45) NOT NULL,
  `contact` varchar(45) NOT NULL,
  `p_birth` varchar(45) NOT NULL,
  `birthday` date NOT NULL,
  `height` varchar(45) NOT NULL,
  `weight` varchar(45) NOT NULL,
  `gender` varchar(255) NOT NULL,
  `medical_history` varchar(45) NOT NULL,
  `medical_problems` varchar(45) NOT NULL,
  `list_medication` varchar(45) NOT NULL,
  `list_allergies` varchar(45) NOT NULL,
  `others` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `patient_record_staff`
--

CREATE TABLE `patient_record_staff` (
  `id` int(255) NOT NULL,
  `faculty_id` varchar(255) NOT NULL,
  `l_name` varchar(255) NOT NULL,
  `f_name` varchar(255) NOT NULL,
  `department` varchar(255) NOT NULL,
  `age` varchar(255) NOT NULL,
  `reason` varchar(255) NOT NULL,
  `treatment` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `table_patient`
--

CREATE TABLE `table_patient` (
  `ID` int(11) NOT NULL,
  `STUDENT_ID` varchar(255) NOT NULL,
  `L_NAME` varchar(255) NOT NULL,
  `F_NAME` varchar(255) NOT NULL,
  `AGE` varchar(255) NOT NULL,
  `COURSE` varchar(255) NOT NULL,
  `REASON` varchar(255) NOT NULL,
  `TREATMENT` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts_t`
--
ALTER TABLE `accounts_t`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `db_attendance`
--
ALTER TABLE `db_attendance`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `logindb`
--
ALTER TABLE `logindb`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `patient_record`
--
ALTER TABLE `patient_record`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `patient_record_staff`
--
ALTER TABLE `patient_record_staff`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `table_patient`
--
ALTER TABLE `table_patient`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accounts_t`
--
ALTER TABLE `accounts_t`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `db_attendance`
--
ALTER TABLE `db_attendance`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `logindb`
--
ALTER TABLE `logindb`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `patient_record`
--
ALTER TABLE `patient_record`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `patient_record_staff`
--
ALTER TABLE `patient_record_staff`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `table_patient`
--
ALTER TABLE `table_patient`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
