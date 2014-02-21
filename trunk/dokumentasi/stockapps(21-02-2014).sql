-- phpMyAdmin SQL Dump
-- version 3.4.5
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Feb 21, 2014 at 06:34 AM
-- Server version: 5.5.16
-- PHP Version: 5.3.8

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
-- Table structure for table `authorization`
--

CREATE TABLE IF NOT EXISTS `authorization` (
  `Authorization_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Authorization_Name` varchar(50) NOT NULL,
  `Authorization_Status` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Authorization_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

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
(7, 'History', 1);

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE IF NOT EXISTS `customer` (
  `Customer_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Customer_Name` varchar(50) NOT NULL,
  `Customer_Address` varchar(200) DEFAULT NULL,
  `Customer_Email` varchar(50) DEFAULT NULL,
  `Customer_Phone` varchar(12) DEFAULT NULL,
  `Customer_Status` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Customer_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`Customer_ID`, `Customer_Name`, `Customer_Address`, `Customer_Email`, `Customer_Phone`, `Customer_Status`) VALUES
(1, 'Customer1', 'alamat customer 1 di sini', 'customer1@customer.com', '080808080808', 1),
(2, 'Customer 2', 'alamat Customer 2', 'customer2@customer2.com', '78787878787', 1),
(3, 'coba', 'coba coba', 'coba@gmail.com', '7685393', 0);

-- --------------------------------------------------------

--
-- Table structure for table `customer_transaction`
--

CREATE TABLE IF NOT EXISTS `customer_transaction` (
  `Customer_Transaction_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Customer_ID` int(11) DEFAULT NULL,
  `Customer_Transaction_Total_Rupiah` decimal(12,2) DEFAULT NULL,
  `Customer_Transaction_Total_Dollar` decimal(12,2) DEFAULT NULL,
  `Customer_Transaction_Date` datetime NOT NULL,
  `Customer_Transaction_Status` int(11) NOT NULL,
  `Customer_Transaction_Description` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`Customer_Transaction_ID`),
  KEY `Customer_ID` (`Customer_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `customer_transaction_product`
--

CREATE TABLE IF NOT EXISTS `customer_transaction_product` (
  `Customer_Transaction_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Product_ID` int(11) NOT NULL,
  `Customer_Transaction_Product_Quantity` int(11) DEFAULT NULL,
  `Customer_Transaction_Product_Price_Dollar` decimal(12,2) DEFAULT NULL,
  `Customer_Transaction_Product_Price_Rupiah` decimal(12,2) DEFAULT NULL,
  PRIMARY KEY (`Customer_Transaction_ID`,`Product_ID`),
  KEY `Product_ID` (`Product_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `price_history`
--

CREATE TABLE IF NOT EXISTS `price_history` (
  `Price_History_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Product_ID` int(11) DEFAULT NULL,
  `Price_History_Price` decimal(10,2) NOT NULL,
  `Price_History_Kurs` int(11) NOT NULL,
  PRIMARY KEY (`Price_History_ID`),
  KEY `FK_Relationship_3` (`Product_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `privilege`
--

CREATE TABLE IF NOT EXISTS `privilege` (
  `Privilege_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Privilege_name` varchar(50) NOT NULL,
  PRIMARY KEY (`Privilege_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `privilege`
--

INSERT INTO `privilege` (`Privilege_ID`, `Privilege_name`) VALUES
(1, 'Super Administrator'),
(2, 'Administrator1');

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
(2, 3, 1),
(2, 4, 1),
(2, 5, 1),
(2, 6, 1);

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE IF NOT EXISTS `product` (
  `Product_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Supplier_ID` int(11) NOT NULL,
  `Product_Category_ID` int(11) DEFAULT NULL,
  `Stock_Type_ID` int(11) DEFAULT NULL,
  `Product_Name` varchar(20) NOT NULL,
  `Product_Stock` int(11) NOT NULL,
  `Product_Buy_Price_Dollar` decimal(12,2) DEFAULT NULL,
  `Product_Buy_Price_Rupiah` decimal(12,2) DEFAULT NULL,
  PRIMARY KEY (`Product_ID`),
  KEY `Supplier_ID` (`Supplier_ID`),
  KEY `Product_Category_ID` (`Product_Category_ID`),
  KEY `Stock_Type_ID` (`Stock_Type_ID`)
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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `product_category`
--

INSERT INTO `product_category` (`Product_Category_ID`, `Product_Category_Name`, `Product_Category_Status`) VALUES
(1, 'Pigmen Merah', 1),
(2, 'Pigmen Hijau', 1),
(3, 'sasas', 0);

-- --------------------------------------------------------

--
-- Table structure for table `stock_type`
--

CREATE TABLE IF NOT EXISTS `stock_type` (
  `Stock_Type_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Stock_Type_Name` varchar(50) NOT NULL,
  `Stock_Type_Kilogram` decimal(10,2) NOT NULL,
  PRIMARY KEY (`Stock_Type_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE IF NOT EXISTS `supplier` (
  `Supplier_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Supplier_Name` varchar(50) NOT NULL,
  `Supplier_Address` varchar(250) DEFAULT NULL,
  `Supplier_Email` varchar(200) DEFAULT NULL,
  `Supplier_Phone` longtext,
  `Supplier_Status` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Supplier_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`Supplier_ID`, `Supplier_Name`, `Supplier_Address`, `Supplier_Email`, `Supplier_Phone`, `Supplier_Status`) VALUES
(1, 'Supplier1', '1234', 'Supplier1@gmail.com', '0808080808', 0),
(2, 'Supplier2', 'lalala 1234', 'Supplier2@gmail.com', '808080808080', 1),
(3, 'Supplier1', 'asdasd', 'Supplier1@mail.com', '4547384', 1),
(4, 'tess', '1234', 'tes@tes.com', '12456', 0);

-- --------------------------------------------------------

--
-- Table structure for table `supplier_transaction`
--

CREATE TABLE IF NOT EXISTS `supplier_transaction` (
  `Supplier_Transaction_Total_Rupiah` decimal(12,2) DEFAULT NULL,
  `Supplier_Transaction_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Supplier_ID` int(11) DEFAULT NULL,
  `Supplier_Transaction_Total_Dollar` decimal(12,2) DEFAULT NULL,
  `Supplier_Transaction_Date` datetime NOT NULL,
  `Supplier_Transaction_Status` int(11) NOT NULL,
  `Supplier_Transaction_Description` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`Supplier_Transaction_ID`),
  KEY `Supplier_ID` (`Supplier_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `supplier_transaction_product`
--

CREATE TABLE IF NOT EXISTS `supplier_transaction_product` (
  `Product_ID` int(11) NOT NULL,
  `Supplier_Transaction_ID` int(11) NOT NULL,
  `Supplier_Transaction_Product_Quantity` int(11) NOT NULL,
  `Supplier_Transaction_Product_Price_Dollar` decimal(10,2) NOT NULL,
  `Supplier_Transaction_Product_Price_Rupiah` decimal(10,2) NOT NULL,
  PRIMARY KEY (`Product_ID`,`Supplier_Transaction_ID`),
  KEY `Supplier_Transaction_ID` (`Supplier_Transaction_ID`)
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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`users_id`, `Privilege_ID`, `users_username`, `users_password`, `users_email`, `users_status`) VALUES
(1, 1, 'admin', '21232f297a57a5a743894a0e4a801fc3', 'admin@admin.com', 1),
(2, 1, 'eric2', '9939ac67834e5d06dbf08fea9f726ec1', 'eric.gosno@gmail.com', 1);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `customer_transaction`
--
ALTER TABLE `customer_transaction`
  ADD CONSTRAINT `customer_transaction_ibfk_1` FOREIGN KEY (`Customer_ID`) REFERENCES `customer` (`Customer_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `customer_transaction_product`
--
ALTER TABLE `customer_transaction_product`
  ADD CONSTRAINT `customer_transaction_product_ibfk_1` FOREIGN KEY (`Customer_Transaction_ID`) REFERENCES `customer_transaction` (`Customer_Transaction_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `customer_transaction_product_ibfk_2` FOREIGN KEY (`Product_ID`) REFERENCES `product` (`Product_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `price_history`
--
ALTER TABLE `price_history`
  ADD CONSTRAINT `FK_Relationship_3` FOREIGN KEY (`Product_ID`) REFERENCES `product` (`Product_ID`);

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
  ADD CONSTRAINT `product_ibfk_1` FOREIGN KEY (`Supplier_ID`) REFERENCES `supplier` (`Supplier_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `product_ibfk_2` FOREIGN KEY (`Product_Category_ID`) REFERENCES `product_category` (`Product_Category_ID`),
  ADD CONSTRAINT `product_ibfk_3` FOREIGN KEY (`Stock_Type_ID`) REFERENCES `stock_type` (`Stock_Type_ID`);

--
-- Constraints for table `supplier_transaction`
--
ALTER TABLE `supplier_transaction`
  ADD CONSTRAINT `supplier_transaction_ibfk_1` FOREIGN KEY (`Supplier_ID`) REFERENCES `supplier` (`Supplier_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `supplier_transaction_product`
--
ALTER TABLE `supplier_transaction_product`
  ADD CONSTRAINT `supplier_transaction_product_ibfk_1` FOREIGN KEY (`Product_ID`) REFERENCES `product` (`Product_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `supplier_transaction_product_ibfk_2` FOREIGN KEY (`Supplier_Transaction_ID`) REFERENCES `supplier_transaction` (`Supplier_Transaction_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`Privilege_ID`) REFERENCES `privilege` (`Privilege_ID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
