-- phpMyAdmin SQL Dump
-- version 3.5.2.2
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 08, 2014 at 07:04 AM
-- Server version: 5.5.27
-- PHP Version: 5.4.7

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `stockapps`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin_history`
--

CREATE TABLE IF NOT EXISTS `admin_history` (
  `admin_history_id` varchar(50) NOT NULL,
  `users_id` int(11) DEFAULT '11',
  `log_type` int(11) DEFAULT NULL,
  `time_log` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`admin_history_id`),
  KEY `users_idfk_1_idx` (`users_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin_history`
--

INSERT INTO `admin_history` (`admin_history_id`, `users_id`, `log_type`, `time_log`) VALUES
('2-0-635351461865540028', 2, 0, '2014-05-08 04:43:06'),
('2-1-635351463939463670', 2, 1, '2014-05-08 04:46:33');

-- --------------------------------------------------------

--
-- Table structure for table `authorization`
--

CREATE TABLE IF NOT EXISTS `authorization` (
  `Authorization_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Authorization_Name` varchar(50) NOT NULL,
  `Authorization_Status` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Authorization_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Dumping data for table `authorization`
--

INSERT INTO `authorization` (`Authorization_ID`, `Authorization_Name`, `Authorization_Status`) VALUES
(1, 'Supplier', 1),
(2, 'Customer', 1),
(3, 'Purchasing', 1),
(4, 'Selling', 1),
(5, 'Product', 1),
(6, 'Administrator', 1),
(7, 'History', 1),
(8, 'Cash/Bank', 1);

-- --------------------------------------------------------

--
-- Table structure for table `bank`
--

CREATE TABLE IF NOT EXISTS `bank` (
  `Bank_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Bank_Name` varchar(45) NOT NULL,
  `Currency_ID` int(11) NOT NULL,
  `Bank_Current_Money` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Bank_Current_Money_Another` decimal(12,2) DEFAULT NULL,
  `Bank_Status` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Bank_ID`),
  KEY `Bank_fk1_idx` (`Currency_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `bank_transaction`
--

CREATE TABLE IF NOT EXISTS `bank_transaction` (
  `Bank_Transaction_ID` varchar(50) NOT NULL,
  `Bank_ID` int(11) NOT NULL,
  `Bank_Transaction_Date` datetime NOT NULL,
  `Bank_Transaction_Code` varchar(10) DEFAULT NULL,
  `Bank_Transaction_IsDebit` int(11) NOT NULL,
  `Bank_Transaction_Money` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Bank_Transaction_Total_Now` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Bank_Transaction_Description` varchar(200) DEFAULT NULL,
  `Bank_Transaction_IsLast` int(11) NOT NULL DEFAULT '1',
  `Bank_Transaction_Kurs` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Bank_Transaction_Money_Another` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Bank_Transaction_Total_Another` decimal(12,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`Bank_Transaction_ID`),
  KEY `bank_transaction_fk1_idx` (`Bank_ID`),
  KEY `bank_transaction_date` (`Bank_Transaction_Date`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `currency`
--

CREATE TABLE IF NOT EXISTS `currency` (
  `Currency_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Currency_Name` varchar(45) NOT NULL,
  PRIMARY KEY (`Currency_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE IF NOT EXISTS `customer` (
  `Customer_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Customer_Name` varchar(100) NOT NULL,
  `Customer_Company_Name` varchar(100) DEFAULT NULL,
  `Customer_City` varchar(45) DEFAULT NULL,
  `Customer_Address` varchar(200) DEFAULT NULL,
  `Customer_Email` varchar(100) DEFAULT NULL,
  `Customer_Phone` varchar(100) DEFAULT NULL,
  `Customer_NPWP` varchar(20) DEFAULT NULL,
  `Customer_Debt_Rupiah` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Customer_Debt_Dollar` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Customer_Status` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Customer_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `customer_debt`
--

CREATE TABLE IF NOT EXISTS `customer_debt` (
  `Customer_Debt_ID` varchar(50) NOT NULL,
  `Customer_ID` int(11) NOT NULL,
  `Customer_Debt_Date` datetime NOT NULL,
  `Customer_Debt_Code` varchar(20) DEFAULT NULL,
  `Customer_Debt_IsDebit` int(11) NOT NULL DEFAULT '1',
  `Customer_Debt_Money_Dollar` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Customer_Debt_Total_Dollar` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Customer_Debt_Kurs` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Customer_Debt_Money_Rupiah` decimal(12,2) NOT NULL,
  `Customer_Debt_Total_Rupiah` decimal(12,2) NOT NULL,
  `Customer_Debt_Description` varchar(200) DEFAULT NULL,
  `Customer_Debt_IsLast` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Customer_Debt_ID`),
  KEY `customer_debt_fk1_idx` (`Customer_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `customer_payment`
--

CREATE TABLE IF NOT EXISTS `customer_payment` (
  `Customer_Payment_ID` varchar(50) NOT NULL,
  `Customer_ID` int(11) NOT NULL,
  `Bank_ID` int(11) NOT NULL,
  `Currency_ID` int(11) NOT NULL,
  `Payment_Category_ID` int(11) NOT NULL DEFAULT '1',
  `Customer_Payment_Date` datetime NOT NULL,
  `Customer_Payment_Deadline_Date` datetime NOT NULL,
  `Customer_Payment_Rupiah` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Customer_Payment_Dollar` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Customer_Payment_PPN_Rupiah` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Customer_Payment_PPN_Dollar` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Customer_Payment_Total_Rupiah` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Customer_Payment_Total_Dollar` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Customer_Payment_Kurs` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Customer_Payment_Status` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Customer_Payment_ID`),
  KEY `customer_payment_fk1_idx` (`Customer_ID`),
  KEY `customer_payment_fk2_idx` (`Bank_ID`),
  KEY `customer_payment_fk3_idx` (`Currency_ID`),
  KEY `customer_payment_fk3_idx1` (`Payment_Category_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `customer_payment_transaction`
--

CREATE TABLE IF NOT EXISTS `customer_payment_transaction` (
  `Customer_Payment_ID` varchar(50) NOT NULL,
  `Customer_Transaction_ID` varchar(50) NOT NULL,
  PRIMARY KEY (`Customer_Payment_ID`,`Customer_Transaction_ID`),
  KEY `customer_payment_transaction_fk1_idx` (`Customer_Transaction_ID`),
  KEY `customer_payment_transaction_fk2_idx` (`Customer_Payment_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `customer_transaction`
--

CREATE TABLE IF NOT EXISTS `customer_transaction` (
  `Customer_Transaction_ID` varchar(20) NOT NULL,
  `Customer_Transaction_Note_Number` varchar(20) DEFAULT NULL,
  `Customer_ID` int(11) NOT NULL,
  `Currency_ID` int(11) NOT NULL DEFAULT '1',
  `Customer_Transaction_Kurs` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Customer_Transaction_Rupiah` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Customer_Transaction_PPN_Rupiah` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Customer_Transaction_Total_Rupiah` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Customer_Transaction_Dollar` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Customer_Transaction_PPN_Dollar` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Customer_Transaction_Total_Dollar` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Customer_Transaction_Date` datetime NOT NULL,
  `Customer_Transaction_Description` varchar(200) DEFAULT NULL,
  `Customer_Transaction_Status` int(11) NOT NULL,
  PRIMARY KEY (`Customer_Transaction_ID`),
  KEY `Customer_ID` (`Customer_ID`),
  KEY `customer_transaction_ibfk_1_idx` (`Currency_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `customer_transaction_product`
--

CREATE TABLE IF NOT EXISTS `customer_transaction_product` (
  `Customer_Transaction_ID` varchar(20) NOT NULL,
  `Product_ID` int(11) NOT NULL,
  `Customer_Transaction_Product_Quantity` int(11) DEFAULT NULL,
  `Customer_Transaction_Product_Price_Dollar` decimal(12,2) DEFAULT NULL,
  `Customer_Transaction_Product_Total_Dollar` decimal(12,2) DEFAULT NULL,
  `Customer_Transaction_Product_Price_Rupiah` decimal(12,2) DEFAULT NULL,
  `Customer_Transaction_Product_Total_Rupiah` decimal(12,2) DEFAULT NULL,
  PRIMARY KEY (`Customer_Transaction_ID`,`Product_ID`),
  KEY `Product_ID` (`Product_ID`),
  KEY `customer_transaction_product_ibfk_1_idx` (`Customer_Transaction_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `identity`
--

CREATE TABLE IF NOT EXISTS `identity` (
  `Identity_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Identity_Name` varchar(100) DEFAULT NULL,
  `Identity_Company_Name` varchar(100) DEFAULT NULL,
  `Identity_Phone` varchar(20) DEFAULT NULL,
  `Identity_Fax` varchar(20) DEFAULT NULL,
  `Identity_Address` varchar(100) DEFAULT NULL,
  `Identity_City` varchar(45) DEFAULT NULL,
  `Identity_Postal_Code` varchar(20) DEFAULT NULL,
  `Identity_NPWP` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Identity_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `identity`
--

INSERT INTO `identity` (`Identity_ID`, `Identity_Name`, `Identity_Company_Name`, `Identity_Phone`, `Identity_Fax`, `Identity_Address`, `Identity_City`, `Identity_Postal_Code`, `Identity_NPWP`) VALUES
(1, 'Lwa Sek Liong', 'CV Warna Murni', '031-5954621', '031-5954621', 'Komplek Ruko Klampis Megah Blok I-30', 'Surabaya', '6117', '218321');

-- --------------------------------------------------------

--
-- Table structure for table `neraca_aktiva`
--

CREATE TABLE IF NOT EXISTS `neraca_aktiva` (
  `idneraca_aktiva` int(11) NOT NULL AUTO_INCREMENT,
  `tahun_aktiva` datetime DEFAULT NULL,
  `all_produk` varchar(45) DEFAULT NULL,
  `all_kas` varchar(45) DEFAULT NULL,
  `all_piutang` varchar(45) DEFAULT NULL,
  `all_inventaris` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idneraca_aktiva`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `neraca_aktiva_allinventaris`
--

CREATE TABLE IF NOT EXISTS `neraca_aktiva_allinventaris` (
  `idneraca_aktiva_allinventaris` int(11) NOT NULL AUTO_INCREMENT,
  `id_allinventaris` varchar(45) DEFAULT NULL,
  `nama` varchar(45) DEFAULT NULL,
  `jumlah` decimal(12,2) DEFAULT NULL,
  `status` int(11) DEFAULT NULL,
  `tahun_aktiva` datetime DEFAULT NULL,
  PRIMARY KEY (`idneraca_aktiva_allinventaris`),
  KEY `neraca_fk1_idx` (`tahun_aktiva`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `neraca_aktiva_allkas`
--

CREATE TABLE IF NOT EXISTS `neraca_aktiva_allkas` (
  `idneraca_aktiva_allkas` int(11) NOT NULL AUTO_INCREMENT,
  `id_allkas` varchar(45) DEFAULT NULL,
  `nama` varchar(45) DEFAULT NULL,
  `dollar` decimal(12,2) DEFAULT NULL,
  `rupiah` decimal(12,2) DEFAULT NULL,
  `tahun_aktiva` datetime DEFAULT NULL,
  PRIMARY KEY (`idneraca_aktiva_allkas`),
  KEY `neraca_allkas_fk1_idx` (`tahun_aktiva`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `neraca_aktiva_allpiutang`
--

CREATE TABLE IF NOT EXISTS `neraca_aktiva_allpiutang` (
  `idneraca_aktiva_allpiutang` int(11) NOT NULL AUTO_INCREMENT,
  `id_allpiutang` varchar(45) DEFAULT NULL,
  `nama` varchar(45) DEFAULT NULL,
  `nota` varchar(45) DEFAULT NULL,
  `jumlah` decimal(12,2) DEFAULT NULL,
  `tahun_aktiva` datetime DEFAULT NULL,
  PRIMARY KEY (`idneraca_aktiva_allpiutang`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `neraca_aktiva_allproduct`
--

CREATE TABLE IF NOT EXISTS `neraca_aktiva_allproduct` (
  `idneraca_aktiva_allproduct` int(11) NOT NULL AUTO_INCREMENT,
  `id_allproduct` varchar(45) DEFAULT NULL,
  `nama` varchar(45) DEFAULT NULL,
  `bg` varchar(45) DEFAULT NULL,
  `jumlah` decimal(12,2) DEFAULT NULL,
  `tahun_aktiva` datetime DEFAULT NULL,
  PRIMARY KEY (`idneraca_aktiva_allproduct`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `neraca_passiva`
--

CREATE TABLE IF NOT EXISTS `neraca_passiva` (
  `idneraca_passiva` int(11) NOT NULL AUTO_INCREMENT,
  `tahun_passiva` datetime DEFAULT NULL,
  PRIMARY KEY (`idneraca_passiva`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `neraca_passiva_pajak`
--

CREATE TABLE IF NOT EXISTS `neraca_passiva_pajak` (
  `idneraca_passiva_pajak` int(11) NOT NULL AUTO_INCREMENT,
  `nourut_pajak` varchar(45) DEFAULT NULL,
  `keterangan_pajak` varchar(500) DEFAULT NULL,
  `jumlah_pajak` decimal(12,2) DEFAULT NULL,
  `tahun_passiva` datetime DEFAULT NULL,
  PRIMARY KEY (`idneraca_passiva_pajak`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `neraca_passiva_ppjk`
--

CREATE TABLE IF NOT EXISTS `neraca_passiva_ppjk` (
  `idneraca_passiva_ppjk` int(11) NOT NULL AUTO_INCREMENT,
  `nourut_ppjk` varchar(45) DEFAULT NULL,
  `nota_ppjk` varchar(45) DEFAULT NULL,
  `nama_ppjk` varchar(45) DEFAULT NULL,
  `jumlah_ppjk` decimal(12,2) DEFAULT NULL,
  `tahun_passiva` datetime DEFAULT NULL,
  PRIMARY KEY (`idneraca_passiva_ppjk`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `neraca_passiva_saham`
--

CREATE TABLE IF NOT EXISTS `neraca_passiva_saham` (
  `idneraca_passiva_saham` int(11) NOT NULL AUTO_INCREMENT,
  `nourut_saham` varchar(45) DEFAULT NULL,
  `nama_saham` varchar(45) DEFAULT NULL,
  `jumlah_saham` decimal(12,2) DEFAULT NULL,
  `tahun_passiva` datetime DEFAULT NULL,
  PRIMARY KEY (`idneraca_passiva_saham`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `neraca_passiva_usaha`
--

CREATE TABLE IF NOT EXISTS `neraca_passiva_usaha` (
  `idneraca_passiva_usaha` int(11) NOT NULL AUTO_INCREMENT,
  `nourut_usaha` varchar(45) DEFAULT NULL,
  `nota_usaha` varchar(45) DEFAULT NULL,
  `nama_usaha` varchar(45) DEFAULT NULL,
  `jumlah_usaha` decimal(12,2) DEFAULT NULL,
  `tahun_passiva` datetime DEFAULT NULL,
  PRIMARY KEY (`idneraca_passiva_usaha`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `payment_category`
--

CREATE TABLE IF NOT EXISTS `payment_category` (
  `Payment_Category_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Payment_Category_Name` varchar(45) NOT NULL,
  PRIMARY KEY (`Payment_Category_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `price_history`
--

CREATE TABLE IF NOT EXISTS `price_history` (
  `Price_History_ID` varchar(45) NOT NULL,
  `Price_History_Date` datetime NOT NULL,
  `Product_ID` int(11) NOT NULL,
  `Price_History_Price` decimal(10,2) NOT NULL,
  `Currency_ID` int(11) NOT NULL,
  `Price_History_Stock` int(11) NOT NULL DEFAULT '0',
  `Price_History_Used_Stock` int(11) NOT NULL DEFAULT '0',
  `Price_History_IsLast` int(11) NOT NULL DEFAULT '0',
  `Price_History_Status` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Price_History_ID`),
  KEY `FK_Relationship_3` (`Product_ID`),
  KEY `FK_Relationship_4_idx` (`Currency_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `privilege`
--

CREATE TABLE IF NOT EXISTS `privilege` (
  `Privilege_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Privilege_name` varchar(50) NOT NULL,
  PRIMARY KEY (`Privilege_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `privilege`
--

INSERT INTO `privilege` (`Privilege_ID`, `Privilege_name`) VALUES
(1, 'administrator');

-- --------------------------------------------------------

--
-- Table structure for table `privilege_authorization`
--

CREATE TABLE IF NOT EXISTS `privilege_authorization` (
  `Privilege_ID` int(11) NOT NULL,
  `Authorization_ID` int(11) NOT NULL,
  `Privilege_Authorization_Status` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Privilege_ID`,`Authorization_ID`),
  KEY `FK_Relationship_103` (`Privilege_ID`),
  KEY `FK_Relationship_104` (`Authorization_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `privilege_authorization`
--

INSERT INTO `privilege_authorization` (`Privilege_ID`, `Authorization_ID`, `Privilege_Authorization_Status`) VALUES
(1, 1, 1),
(1, 2, 1),
(1, 3, 1),
(1, 4, 1),
(1, 5, 1),
(1, 6, 1),
(1, 7, 1),
(1, 8, 1);

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE IF NOT EXISTS `product` (
  `Product_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Supplier_ID` int(11) DEFAULT NULL,
  `Product_Category_ID` int(11) DEFAULT NULL,
  `Product_Name` varchar(20) NOT NULL,
  `Product_Stock` int(11) NOT NULL DEFAULT '0',
  `Product_Buy_Price` decimal(12,2) DEFAULT NULL,
  `Currency_ID` int(11) DEFAULT NULL,
  `Product_Packing_Name` varchar(45) DEFAULT NULL,
  `Product_Packing_Kilogram` int(11) DEFAULT NULL,
  `Product_Status` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Product_ID`),
  KEY `Supplier_ID` (`Supplier_ID`),
  KEY `Product_Category_ID` (`Product_Category_ID`),
  KEY `product_ibfk_4_idx` (`Currency_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `product_category`
--

CREATE TABLE IF NOT EXISTS `product_category` (
  `Product_Category_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Product_Category_Name` varchar(50) NOT NULL,
  `Product_Category_Status` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Product_Category_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE IF NOT EXISTS `supplier` (
  `Supplier_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Supplier_Name` varchar(100) NOT NULL,
  `Supplier_Company_Name` varchar(100) DEFAULT NULL,
  `Supplier_Address` varchar(250) DEFAULT NULL,
  `Supplier_Email` varchar(200) DEFAULT NULL,
  `Supplier_Phone` varchar(200) DEFAULT NULL,
  `Supplier_NPWP` varchar(100) DEFAULT NULL,
  `Supplier_Regional` int(1) NOT NULL,
  `Supplier_Credit_Dollar` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Supplier_Credit_Rupiah` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Supplier_Status` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Supplier_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `supplier_credit`
--

CREATE TABLE IF NOT EXISTS `supplier_credit` (
  `Supplier_Credit_ID` varchar(50) NOT NULL,
  `Supplier_ID` int(11) NOT NULL,
  `Supplier_Credit_Date` datetime NOT NULL,
  `Supplier_Credit_Code` varchar(20) DEFAULT NULL,
  `Supplier_Credit_IsDebit` int(11) NOT NULL DEFAULT '1',
  `Supplier_Credit_Money_Dollar` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Supplier_Credit_Total_Dollar` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Supplier_Credit_Kurs` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Supplier_Credit_Money_Rupiah` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Supplier_Credit_Total_Rupiah` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Supplier_Credit_Description` varchar(200) DEFAULT NULL,
  `Supplier_Credit_IsLast` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Supplier_Credit_ID`),
  KEY `supplier_credit_fk1_idx` (`Supplier_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `supplier_payment`
--

CREATE TABLE IF NOT EXISTS `supplier_payment` (
  `Supplier_Payment_ID` varchar(20) NOT NULL,
  `Supplier_ID` int(11) NOT NULL,
  `Bank_ID` int(11) NOT NULL,
  `Currency_ID` int(11) NOT NULL,
  `Payment_Category_ID` int(11) NOT NULL,
  `Supplier_Payment_Date` datetime NOT NULL,
  `Supplier_Payment_Deadline_Date` datetime NOT NULL,
  `Supplier_Payment_Rupiah` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Supplier_Payment_Dollar` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Supplier_Payment_PPN_Rupiah` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Supplier_Payment_PPN_Dollar` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Supplier_Payment_Total_Rupiah` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Supplier_Payment_Total_Dollar` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Supplier_Payment_Kurs` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Supplier_Payment_Status` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Supplier_Payment_ID`),
  KEY `supplier_payment_fk1_idx` (`Supplier_ID`),
  KEY `supplier_payment_fk2_idx` (`Currency_ID`),
  KEY `supplier_payment_fk3_idx` (`Bank_ID`),
  KEY `supplier_payment_fk4_idx` (`Payment_Category_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `supplier_payment_transaction`
--

CREATE TABLE IF NOT EXISTS `supplier_payment_transaction` (
  `Supplier_Transaction_ID` varchar(20) NOT NULL,
  `Supplier_Payment_ID` varchar(20) NOT NULL,
  PRIMARY KEY (`Supplier_Transaction_ID`,`Supplier_Payment_ID`),
  KEY `supplier_payment_transaction_fk1_idx` (`Supplier_Transaction_ID`),
  KEY `supplier_payment_transaction_fk2_idx` (`Supplier_Payment_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `supplier_transaction`
--

CREATE TABLE IF NOT EXISTS `supplier_transaction` (
  `Supplier_Transaction_ID` varchar(50) NOT NULL,
  `Supplier_ID` int(11) NOT NULL,
  `Supplier_Transaction_Note_Number` varchar(45) NOT NULL,
  `Supplier_Transaction_Invoice_Number` varchar(45) NOT NULL,
  `Currency_ID` int(11) NOT NULL,
  `Supplier_Transaction_Kurs` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Supplier_Transaction_Rupiah` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Supplier_Transaction_Dollar` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Supplier_Transaction_PPN_Rupiah` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Supplier_Transaction_PPN_Dollar` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Supplier_Transaction_Total_Rupiah` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Supplier_Transaction_Total_Dollar` decimal(12,2) NOT NULL DEFAULT '0.00',
  `Supplier_Transaction_Date` datetime NOT NULL,
  `Supplier_Transaction_Status` int(11) NOT NULL,
  `Supplier_Transaction_Description` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`Supplier_Transaction_ID`),
  KEY `Supplier_ID` (`Supplier_ID`),
  KEY `supplier_transaction_ibfk_2_idx` (`Currency_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `supplier_transaction_product`
--

CREATE TABLE IF NOT EXISTS `supplier_transaction_product` (
  `Product_ID` int(11) NOT NULL,
  `Supplier_Transaction_ID` varchar(20) NOT NULL,
  `Supplier_Transaction_Product_Quantity` int(11) NOT NULL,
  `Supplier_Transaction_Product_Price_Dollar` decimal(10,2) NOT NULL,
  `Supplier_Transaction_Product_Price_Rupiah` decimal(10,2) NOT NULL,
  PRIMARY KEY (`Product_ID`,`Supplier_Transaction_ID`),
  KEY `Supplier_Transaction_ID` (`Supplier_Transaction_ID`),
  KEY `supplier_transaction_product_ibfk_2_idx` (`Product_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `users_id` int(11) NOT NULL AUTO_INCREMENT,
  `Privilege_ID` int(11) NOT NULL,
  `users_username` varchar(50) NOT NULL,
  `users_password` varchar(40) NOT NULL,
  `users_email` varchar(50) DEFAULT NULL,
  `users_status` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`users_id`),
  KEY `FK_Relationship_102` (`Privilege_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`users_id`, `Privilege_ID`, `users_username`, `users_password`, `users_email`, `users_status`) VALUES
(2, 1, 'admin', '21232f297a57a5a743894a0e4a801fc3', NULL, 1);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `admin_history`
--
ALTER TABLE `admin_history`
  ADD CONSTRAINT `users_idfk_1` FOREIGN KEY (`users_id`) REFERENCES `users` (`users_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `bank`
--
ALTER TABLE `bank`
  ADD CONSTRAINT `Bank_fk1` FOREIGN KEY (`Currency_ID`) REFERENCES `currency` (`Currency_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `bank_transaction`
--
ALTER TABLE `bank_transaction`
  ADD CONSTRAINT `bank_transaction_fk1` FOREIGN KEY (`Bank_ID`) REFERENCES `bank` (`Bank_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `customer_debt`
--
ALTER TABLE `customer_debt`
  ADD CONSTRAINT `customer_debt_fk1` FOREIGN KEY (`Customer_ID`) REFERENCES `customer` (`Customer_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `customer_payment`
--
ALTER TABLE `customer_payment`
  ADD CONSTRAINT `customer_payment_fk1` FOREIGN KEY (`Customer_ID`) REFERENCES `customer` (`Customer_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `customer_payment_fk2` FOREIGN KEY (`Bank_ID`) REFERENCES `bank` (`Bank_ID`),
  ADD CONSTRAINT `customer_payment_fk3` FOREIGN KEY (`Currency_ID`) REFERENCES `currency` (`Currency_ID`),
  ADD CONSTRAINT `customer_payment_fk4` FOREIGN KEY (`Payment_Category_ID`) REFERENCES `payment_category` (`Payment_Category_ID`);

--
-- Constraints for table `customer_payment_transaction`
--
ALTER TABLE `customer_payment_transaction`
  ADD CONSTRAINT `customer_payment_transaction_fk1` FOREIGN KEY (`Customer_Transaction_ID`) REFERENCES `customer_transaction` (`Customer_Transaction_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `customer_payment_transaction_fk2` FOREIGN KEY (`Customer_Payment_ID`) REFERENCES `customer_payment` (`Customer_Payment_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `customer_transaction`
--
ALTER TABLE `customer_transaction`
  ADD CONSTRAINT `customer_transaction_ibfk_1` FOREIGN KEY (`Customer_ID`) REFERENCES `customer` (`Customer_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `customer_transaction_ibfk_2` FOREIGN KEY (`Currency_ID`) REFERENCES `currency` (`Currency_ID`);

--
-- Constraints for table `customer_transaction_product`
--
ALTER TABLE `customer_transaction_product`
  ADD CONSTRAINT `customer_transaction_product_ibfk_1` FOREIGN KEY (`Customer_Transaction_ID`) REFERENCES `customer_transaction` (`Customer_Transaction_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `customer_transaction_product_ibfk_2` FOREIGN KEY (`Product_ID`) REFERENCES `product` (`Product_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `price_history`
--
ALTER TABLE `price_history`
  ADD CONSTRAINT `FK_Relationship_3` FOREIGN KEY (`Product_ID`) REFERENCES `product` (`Product_ID`),
  ADD CONSTRAINT `FK_Relationship_4` FOREIGN KEY (`Currency_ID`) REFERENCES `currency` (`Currency_ID`);

--
-- Constraints for table `privilege_authorization`
--
ALTER TABLE `privilege_authorization`
  ADD CONSTRAINT `privilege_authorization_ibfk_1` FOREIGN KEY (`Privilege_ID`) REFERENCES `privilege` (`Privilege_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `privilege_authorization_ibfk_2` FOREIGN KEY (`Authorization_ID`) REFERENCES `authorization` (`Authorization_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `product_ibfk_2` FOREIGN KEY (`Product_Category_ID`) REFERENCES `product_category` (`Product_Category_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `product_ibfk_4` FOREIGN KEY (`Currency_ID`) REFERENCES `currency` (`Currency_ID`);

--
-- Constraints for table `supplier_credit`
--
ALTER TABLE `supplier_credit`
  ADD CONSTRAINT `supplier_credit_fk1` FOREIGN KEY (`Supplier_ID`) REFERENCES `supplier` (`Supplier_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `supplier_payment`
--
ALTER TABLE `supplier_payment`
  ADD CONSTRAINT `supplier_payment_fk1` FOREIGN KEY (`Supplier_ID`) REFERENCES `supplier` (`Supplier_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `supplier_payment_fk2` FOREIGN KEY (`Currency_ID`) REFERENCES `currency` (`Currency_ID`),
  ADD CONSTRAINT `supplier_payment_fk3` FOREIGN KEY (`Bank_ID`) REFERENCES `bank` (`Bank_ID`),
  ADD CONSTRAINT `supplier_payment_fk4` FOREIGN KEY (`Payment_Category_ID`) REFERENCES `payment_category` (`Payment_Category_ID`);

--
-- Constraints for table `supplier_payment_transaction`
--
ALTER TABLE `supplier_payment_transaction`
  ADD CONSTRAINT `supplier_payment_transaction_fk1` FOREIGN KEY (`Supplier_Transaction_ID`) REFERENCES `supplier_transaction` (`Supplier_Transaction_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `supplier_payment_transaction_fk2` FOREIGN KEY (`Supplier_Payment_ID`) REFERENCES `supplier_payment` (`Supplier_Payment_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `supplier_transaction`
--
ALTER TABLE `supplier_transaction`
  ADD CONSTRAINT `supplier_transaction_ibfk_1` FOREIGN KEY (`Supplier_ID`) REFERENCES `supplier` (`Supplier_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `supplier_transaction_ibfk_2` FOREIGN KEY (`Currency_ID`) REFERENCES `currency` (`Currency_ID`);

--
-- Constraints for table `supplier_transaction_product`
--
ALTER TABLE `supplier_transaction_product`
  ADD CONSTRAINT `supplier_transaction_product_ibfk_1` FOREIGN KEY (`Supplier_Transaction_ID`) REFERENCES `supplier_transaction` (`Supplier_Transaction_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `supplier_transaction_product_ibfk_2` FOREIGN KEY (`Product_ID`) REFERENCES `product` (`Product_ID`) ON UPDATE CASCADE;

--
-- Constraints for table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`Privilege_ID`) REFERENCES `privilege` (`Privilege_ID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
