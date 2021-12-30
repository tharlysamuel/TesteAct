CREATE DATABASE /*!32312 IF NOT EXISTS*/`testeact` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `testeact`;

/*Table structure for table `acoes` */

DROP TABLE IF EXISTS `acoes`;

CREATE TABLE `acoes` (
  `CodigoAcao` varchar(10) NOT NULL,
  `RazaoSocial` varchar(250) NOT NULL,
  PRIMARY KEY (`CodigoAcao`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Table structure for table `registrooperacoes` */

DROP TABLE IF EXISTS `registrooperacoes`;

CREATE TABLE `registrooperacoes` (
  `Id` binary(56) NOT NULL,
  `CodigoAcao` varchar(10) NOT NULL,
  `TipoOperacao` char(1) NOT NULL,
  `DataOperacao` datetime NOT NULL,
  `Quantidade` decimal(10,5) NOT NULL,
  `ValorAcao` decimal(10,5) NOT NULL,
  `ValorTotal` decimal(10,5) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `Fk_CodigoAcoes_idx` (`CodigoAcao`),
  CONSTRAINT `Fk_CodigoAcoes` FOREIGN KEY (`CodigoAcao`) REFERENCES `acoes` (`CodigoAcao`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


