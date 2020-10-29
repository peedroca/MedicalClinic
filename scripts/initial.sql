DROP TABLE IF EXISTS __efmigrationshistory;
DROP TABLE IF EXISTS schedules;
DROP TABLE IF EXISTS doctors;
DROP TABLE IF EXISTS customers;

CREATE TABLE IF NOT EXISTS `__efmigrationshistory` (
  `MigrationId` VARCHAR(150) NOT NULL,
  `ProductVersion` VARCHAR(32) NOT NULL,
  PRIMARY KEY (`MigrationId`));

CREATE TABLE IF NOT EXISTS `customers` (
  `Id` BIGINT(20) NOT NULL AUTO_INCREMENT,
  `Name` TEXT NULL DEFAULT NULL,
  `Phone` TEXT NULL DEFAULT NULL,
  PRIMARY KEY (`Id`));

CREATE TABLE IF NOT EXISTS `doctors` (
  `Id` BIGINT(20) NOT NULL AUTO_INCREMENT,
  `Name` TEXT NULL DEFAULT NULL,
  `Specialty` TEXT NULL DEFAULT NULL,
  `Phone` TEXT NULL DEFAULT NULL,
  PRIMARY KEY (`Id`));

CREATE TABLE IF NOT EXISTS `schedules` (
  `Id` BIGINT(20) NOT NULL AUTO_INCREMENT,
  `Date` DATETIME NOT NULL,
  `CustomerId` BIGINT(20) NULL DEFAULT NULL,
  `DoctorId` BIGINT(20) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`),
  INDEX `IX_Schedules_CustomerId` (`CustomerId` ASC),
  INDEX `IX_Schedules_DoctorId` (`DoctorId` ASC),
  CONSTRAINT `FK_Schedules_Customers_CustomerId`
    FOREIGN KEY (`CustomerId`)
    REFERENCES `20447_medicalclinic`.`customers` (`Id`),
  CONSTRAINT `FK_Schedules_Doctors_DoctorId`
    FOREIGN KEY (`DoctorId`)
    REFERENCES `20447_medicalclinic`.`doctors` (`Id`));
    
INSERT IGNORE INTO doctors VALUES(1, 'Dr. Pedro', 'Clínico Geral', '11941847395');  
INSERT IGNORE INTO doctors VALUES(2, 'Dr. Pedro Jr.', 'Cirurgião Plástico', '11937749829');
INSERT IGNORE INTO doctors VALUES(3, 'Dr. João Pedro', 'Pediatra', '11983840910');
INSERT IGNORE INTO doctors VALUES(4, 'Dr. Pedro Miguel', 'Ginicologista', '11904789182');

INSERT IGNORE INTO customers VALUES(1, 'José', '11917392837');  
INSERT IGNORE INTO customers VALUES(2, 'Marcio', '11947184928');
INSERT IGNORE INTO customers VALUES(3, 'Miguel', '11910394851');
INSERT IGNORE INTO customers VALUES(4, 'Antônio', '11941940193');

INSERT IGNORE INTO schedules VALUES(1, '2020-11-17 14:20', '1', '1');
INSERT IGNORE INTO schedules VALUES(2, '2020-11-17 15:20', '1', '3');
INSERT IGNORE INTO schedules VALUES(3, '2020-11-17 16:20', '3', '2');
INSERT IGNORE INTO schedules VALUES(4, '2020-11-17 20:00', '4', '4');

SHOW TABLES;
SELECT * FROM __efmigrationshistory;
SELECT * FROM customers;
SELECT * FROM doctors;
SELECT * FROM schedules;
