-- MySQL Script generated by MySQL Workbench
-- Tue May 21 16:50:40 2019
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema bdreservas
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema bdreservas
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `bdreservas` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `bdreservas` ;

-- -----------------------------------------------------
-- Table `bdreservas`.`reservas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bdreservas`.`reservas` (
  `DATA_ENT` DATETIME NULL DEFAULT NULL,
  `DATA_SAI` DATETIME NULL DEFAULT NULL,
  `VALOR_TOTAL` DECIMAL(15,2) NULL DEFAULT NULL,
  `ID` INT(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ID`))
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
