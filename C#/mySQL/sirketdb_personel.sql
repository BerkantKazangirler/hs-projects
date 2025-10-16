-- MySQL dump 10.13  Distrib 8.0.21, for Win64 (x86_64)
--
-- Host: localhost    Database: sirketdb
-- ------------------------------------------------------
-- Server version	8.0.21

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `personel`
--

DROP TABLE IF EXISTS `personel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `personel` (
  `personel_id` int NOT NULL AUTO_INCREMENT,
  `ad_soyad` varchar(45) NOT NULL,
  `cinsiyet` varchar(7) NOT NULL,
  `departman` varchar(45) NOT NULL,
  `giris_tarihi` date NOT NULL,
  `maas` decimal(8,2) NOT NULL,
  `eposta` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`personel_id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personel`
--

LOCK TABLES `personel` WRITE;
/*!40000 ALTER TABLE `personel` DISABLE KEYS */;
INSERT INTO `personel` VALUES (1,'Berkant Kazangirler','Erkek','Yazılım','2023-05-02',10000.00,'berkantkazangirler@gmail.com'),(2,'Emir Kaan Özler','Erkek','Yazılım','2023-05-02',95000.00,'ronaldoemirkaan@gmail.com'),(8,'Mustafa S.','Erkek','Bilişim Teknolojileri','2023-05-02',12500.00,'mustafa@ornek.com'),(9,'Sinan K.','Erkek','Muhasebe','2019-10-27',7500.00,'sinan@ornek.com'),(10,'Ayşe A.','Kadın','Muhasebe','2017-01-13',8500.00,'ayse@ornek.com'),(11,'Büşra Y.','Kadın','Satış','2021-07-15',7000.00,'busra@deneme.com'),(12,'Samet T.','Erkek','Satış','2019-08-03',7500.00,NULL),(13,'Murat K.','Erkek','İnsan Kaynakları','2018-10-10',9000.00,'murat@deneme.com');
/*!40000 ALTER TABLE `personel` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-02 11:57:33
