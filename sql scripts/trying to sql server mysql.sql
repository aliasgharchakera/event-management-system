-- SQLINES DEMO *** rated by MySQL Workbench
-- SQLINES DEMO *** 23 2021
-- SQLINES DEMO ***    Version: 1.0
-- SQLINES DEMO *** orward Engineering

/* SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0; */
/* SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0; */
/* SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION'; */

-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ement
-- SQLINES DEMO *** ------------------------------------

-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ement
-- SQLINES DEMO *** ------------------------------------
-- CREATE SCHEMA IF NOT EXISTS EventManagement DEFAULT CHARACTER SET utf8 ;
USE [EventManagement] ;

-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ement`.`Student`
-- SQLINES DEMO *** ------------------------------------
-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE Student (
  [studentID] INT NOT NULL,
  [Email] VARCHAR(45) NOT NULL,
  [Name] VARCHAR(45) NOT NULL,
  [CellNumber] INT NOT NULL,
  [Major] VARCHAR(45) NOT NULL,
  [Batch] INT NOT NULL,
  PRIMARY KEY ([studentID]))
;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ement`.`Location`
-- SQLINES DEMO *** ------------------------------------
-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE Location (
  [locationID] VARCHAR(45) NOT NULL,
  [capacity] VARCHAR(45) NOT NULL,
  [isOpenSpace] SMALLINT NOT NULL,
  PRIMARY KEY ([locationID]))
;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ement`.`Faculty`
-- SQLINES DEMO *** ------------------------------------
-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE Faculty (
  [facultyID] INT NOT NULL,
  [name] VARCHAR(45) NOT NULL,
  [department] VARCHAR(45) NOT NULL,
  [email] VARCHAR(45) NOT NULL,
  [cellNumber] INT NOT NULL,
  [jobTitle] VARCHAR(45) NOT NULL,
  [hireDate] DATETIME2(0) NOT NULL,
  [facultyPod] VARCHAR(45) NOT NULL,
  PRIMARY KEY ([facultyID], [facultyPod]))
  CREATE INDEX [fk_Faculty_Location1_idx] ON Faculty ([facultyPod] ASC)  
  CONSTRAINT [fk_Faculty_Location1]
    FOREIGN dbo.KEY ([facultyPod])
    REFERENCES `EventManagement`.`Location` ([locationID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ement`.`Afflitiates`
-- SQLINES DEMO *** ------------------------------------
-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE EventManagement.Afflitiates (
  [affiliateID] INT NOT NULL,
  [name] VARCHAR(45) NOT NULL,
  [contactName] VARCHAR(45) NOT NULL,
  [email] VARCHAR(45) NOT NULL,
  PRIMARY KEY ([affiliateID]))
;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ement`.`Clubs_Chapters`
-- SQLINES DEMO *** ------------------------------------
-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE EventManagement.Clubs_Chapters (
  [ID] INT NOT NULL,
  [name] VARCHAR(45) NOT NULL,
  [president] INT NOT NULL,
  [vicePresident] INT NOT NULL,
  [generalSecretary] INT NOT NULL,
  [treasurer] INT NOT NULL,
  [facultyAdvisor] INT NOT NULL,
  [affiliate] INT NULL,
  [budget] INT NOT NULL,
  [annualBudget] INT NOT NULL,
  PRIMARY KEY ([ID], [president], [vicePresident], [generalSecretary], [treasurer], [facultyAdvisor], [affiliate])
  CREATE INDEX [fk_Clubs_Student1_idx] ON EventManagement.Clubs_Chapters ([president] ASC) VISIBLE,
  INDEX [fk_Clubs_Student2_idx] ([vicePresident] ASC) VISIBLE,
  INDEX [fk_Clubs_Student3_idx] ([generalSecretary] ASC) VISIBLE,
  INDEX [fk_Clubs_Student4_idx] ([treasurer] ASC) VISIBLE,
  INDEX [fk_Clubs_Faculty1_idx] ([facultyAdvisor] ASC) VISIBLE,
  INDEX [fk_Clubs/Chapters_Afflitiates1_idx] ([affiliate] ASC) VISIBLE,
  CONSTRAINT [fk_Clubs_Student1]
    FOREIGN dbo.KEY ([president])
    REFERENCES `EventManagement`.`Student` ([studentID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Clubs_Student2]
    FOREIGN dbo.KEY ([vicePresident])
    REFERENCES `EventManagement`.`Student` ([studentID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Clubs_Student3]
    FOREIGN dbo.KEY ([generalSecretary])
    REFERENCES `EventManagement`.`Student` ([studentID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Clubs_Student4]
    FOREIGN dbo.KEY ([treasurer])
    REFERENCES `EventManagement`.`Student` ([studentID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Clubs_Faculty1]
    FOREIGN dbo.KEY ([facultyAdvisor])
    REFERENCES `EventManagement`.`Faculty` ([facultyID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Clubs/Chapters_Afflitiates1]
    FOREIGN dbo.KEY ([affiliate])
    REFERENCES `EventManagement`.`Afflitiates` ([affiliateID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ement`.`Club_Members`
-- SQLINES DEMO *** ------------------------------------
-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE EventManagement.Club_Members (
  [Student_studentID] INT NOT NULL,
  [Clubs_clubID] INT NOT NULL,
  PRIMARY KEY ([Student_studentID], [Clubs_clubID])
  CREATE INDEX [fk_Student_has_Clubs_Clubs1_idx] ON EventManagement.Club_Members ([Clubs_clubID] ASC) VISIBLE,
  INDEX [fk_Student_has_Clubs_Student1_idx] ([Student_studentID] ASC) VISIBLE,
  CONSTRAINT [fk_Student_has_Clubs_Student1]
    FOREIGN dbo.KEY ([Student_studentID])
    REFERENCES `EventManagement`.`Student` ([studentID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Student_has_Clubs_Clubs1]
    FOREIGN dbo.KEY ([Clubs_clubID])
    REFERENCES `EventManagement`.`Clubs_Chapters` ([ID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ement`.`Sponsors`
-- SQLINES DEMO *** ------------------------------------
-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE EventManagement.Sponsors (
  [sponsorID] INT NOT NULL,
  [name] VARCHAR(45) NOT NULL,
  [contactName] VARCHAR(45) NOT NULL,
  [email] VARCHAR(45) NOT NULL,
  PRIMARY KEY ([sponsorID]))
;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ement`.`Clubs_Chapters_has_Sponsors`
-- SQLINES DEMO *** ------------------------------------
-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE EventManagement.Clubs_Chapters_has_Sponsors (
  [Clubs_clubID] INT NOT NULL,
  [Sponsors_sponsorID] INT NOT NULL,
  [sponsoredAmmount] INT NOT NULL,
  PRIMARY KEY ([Clubs_clubID], [Sponsors_sponsorID])
  CREATE INDEX [fk_Clubs_has_Sponsors_Sponsors1_idx] ON EventManagement.Clubs_Chapters_has_Sponsors ([Sponsors_sponsorID] ASC) VISIBLE,
  INDEX [fk_Clubs_has_Sponsors_Clubs1_idx] ([Clubs_clubID] ASC) VISIBLE,
  CONSTRAINT [fk_Clubs_has_Sponsors_Clubs1]
    FOREIGN dbo.KEY ([Clubs_clubID])
    REFERENCES `EventManagement`.`Clubs_Chapters` ([ID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Clubs_has_Sponsors_Sponsors1]
    FOREIGN dbo.KEY ([Sponsors_sponsorID])
    REFERENCES `EventManagement`.`Sponsors` ([sponsorID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ement`.`Event_Categories`
-- SQLINES DEMO *** ------------------------------------
-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE EventManagement.Event_Categories (
  [categoryID] INT NOT NULL,
  [categoryName] VARCHAR(45) NOT NULL,
  PRIMARY KEY ([categoryID]))
;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ement`.`Events`
-- SQLINES DEMO *** ------------------------------------
-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE EventManagement.Events (
  [eventID] INT NOT NULL,
  [name] VARCHAR(45) NOT NULL,
  [organizer] INT NOT NULL,
  [budget] INT NOT NULL,
  [zoomID] INT NULL,
  [pathToMedia] VARCHAR(45) NOT NULL,
  [categoryID] INT NOT NULL,
  PRIMARY KEY ([eventID], [organizer], [categoryID])
  CREATE INDEX [fk_Events_Clubs/Chapters1_idx] ON EventManagement.Events ([organizer] ASC) VISIBLE,
  INDEX [fk_Events_EventCategories1_idx] ([categoryID] ASC) VISIBLE,
  CONSTRAINT [fk_Events_Clubs/Chapters1]
    FOREIGN dbo.KEY ([organizer])
    REFERENCES `EventManagement`.`Clubs_Chapters` ([ID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Events_EventCategories1]
    FOREIGN dbo.KEY ([categoryID])
    REFERENCES `EventManagement`.`Event_Categories` ([categoryID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ement`.`Event_Timings`
-- SQLINES DEMO *** ------------------------------------
-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE EventManagement.Event_Timings (
  [locationID] INT NOT NULL,
  [eventID] INT NOT NULL,
  [dateAndTime] DATETIME2(0) NOT NULL,
  PRIMARY KEY ([locationID], [eventID], [dateAndTime])
  CREATE INDEX [fk_Location_has_Events_Events1_idx] ON EventManagement.Event_Timings ([eventID] ASC) VISIBLE,
  INDEX [fk_Location_has_Events_Location1_idx] ([locationID] ASC) VISIBLE,
  CONSTRAINT [fk_Location_has_Events_Location1]
    FOREIGN dbo.KEY ([locationID])
    REFERENCES `EventManagement`.`Location` ([locationID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Location_has_Events_Events1]
    FOREIGN dbo.KEY ([eventID])
    REFERENCES `EventManagement`.`Events` ([eventID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ement`.`Categories`
-- SQLINES DEMO *** ------------------------------------
-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE EventManagement.Categories (
  [categoryID] INT NOT NULL,
  [name] VARCHAR(45) NOT NULL,
  PRIMARY KEY ([categoryID]))
;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ement`.`Inventory`
-- SQLINES DEMO *** ------------------------------------
-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE EventManagement.Inventory (
  [itemID] INT NOT NULL,
  [name] VARCHAR(45) NOT NULL,
  [categoryID] INT NOT NULL,
  [stock] INT NOT NULL,
  PRIMARY KEY ([itemID], [categoryID])
  CREATE INDEX [fk_Inventory_Categories1_idx] ON EventManagement.Inventory ([categoryID] ASC) VISIBLE,
  CONSTRAINT [fk_Inventory_Categories1]
    FOREIGN dbo.KEY ([categoryID])
    REFERENCES `EventManagement`.`Categories` ([categoryID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ement`.`Item_Bookings`
-- SQLINES DEMO *** ------------------------------------
-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE EventManagement.Item_Bookings (
  [eventID] INT NOT NULL,
  [itemID] INT NOT NULL,
  PRIMARY KEY ([eventID], [itemID])
  CREATE INDEX [fk_Events_has_Inventory_Inventory1_idx] ON EventManagement.Item_Bookings ([itemID] ASC) VISIBLE,
  INDEX [fk_Events_has_Inventory_Events1_idx] ([eventID] ASC) VISIBLE,
  CONSTRAINT [fk_Events_has_Inventory_Events1]
    FOREIGN dbo.KEY ([eventID])
    REFERENCES `EventManagement`.`Events` ([eventID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Events_has_Inventory_Inventory1]
    FOREIGN dbo.KEY ([itemID])
    REFERENCES `EventManagement`.`Inventory` ([itemID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ement`.`External_Vendors`
-- SQLINES DEMO *** ------------------------------------
-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE EventManagement.External_Vendors (
  [vendorID] INT NOT NULL,
  [name] VARCHAR(45) NOT NULL,
  [contactNo] INT NULL,
  [email] VARCHAR(45) NULL,
  PRIMARY KEY ([vendorID]))
;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ement`.`Guests`
-- SQLINES DEMO *** ------------------------------------
-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE EventManagement.Guests (
  [guestID] INT NOT NULL,
  [name] VARCHAR(45) NULL,
  [email] VARCHAR(45) NOT NULL,
  [cellNumber] INT NOT NULL,
  PRIMARY KEY ([guestID]))
;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ement`.`Events_has_Guests`
-- SQLINES DEMO *** ------------------------------------
-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE EventManagement.Events_has_Guests (
  [eventID] INT NOT NULL,
  [guestID] INT NOT NULL,
  [guestRole] VARCHAR(45) NOT NULL,
  PRIMARY KEY ([eventID], [guestID])
  CREATE INDEX [fk_Events_has_Guests_Guests1_idx] ON EventManagement.Events_has_Guests ([guestID] ASC) VISIBLE,
  INDEX [fk_Events_has_Guests_Events1_idx] ([eventID] ASC) VISIBLE,
  CONSTRAINT [fk_Events_has_Guests_Events1]
    FOREIGN dbo.KEY ([eventID])
    REFERENCES `EventManagement`.`Events` ([eventID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Events_has_Guests_Guests1]
    FOREIGN dbo.KEY ([guestID])
    REFERENCES `EventManagement`.`Guests` ([guestID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ement`.`Volunteers`
-- SQLINES DEMO *** ------------------------------------
-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE EventManagement.Volunteers (
  [studentID] INT NOT NULL,
  [eventID] INT NOT NULL,
  PRIMARY KEY ([studentID], [eventID])
  CREATE INDEX [fk_Student_has_Events_Events1_idx] ON EventManagement.Volunteers ([eventID] ASC) VISIBLE,
  INDEX [fk_Student_has_Events_Student1_idx] ([studentID] ASC) VISIBLE,
  CONSTRAINT [fk_Student_has_Events_Student1]
    FOREIGN dbo.KEY ([studentID])
    REFERENCES `EventManagement`.`Student` ([studentID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Student_has_Events_Events1]
    FOREIGN dbo.KEY ([eventID])
    REFERENCES `EventManagement`.`Events` ([eventID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ement`.`Student_Participants`
-- SQLINES DEMO *** ------------------------------------
-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE EventManagement.Student_Participants (
  [Student_studentID] INT NOT NULL,
  [Events_eventID] INT NOT NULL,
  PRIMARY KEY ([Student_studentID], [Events_eventID])
  CREATE INDEX [fk_Student_has_Events_Events2_idx] ON EventManagement.Student_Participants ([Events_eventID] ASC) VISIBLE,
  INDEX [fk_Student_has_Events_Student2_idx] ([Student_studentID] ASC) VISIBLE,
  CONSTRAINT [fk_Student_has_Events_Student2]
    FOREIGN dbo.KEY ([Student_studentID])
    REFERENCES `EventManagement`.`Student` ([studentID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Student_has_Events_Events2]
    FOREIGN dbo.KEY ([Events_eventID])
    REFERENCES `EventManagement`.`Events` ([eventID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ement`.`Faculty_Participants`
-- SQLINES DEMO *** ------------------------------------
-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE EventManagement.Faculty_Participants (
  [Faculty_facultyID] INT NOT NULL,
  [Events_eventID] INT NOT NULL,
  PRIMARY KEY ([Faculty_facultyID], [Events_eventID])
  CREATE INDEX [fk_Faculty_has_Events_Events1_idx] ON EventManagement.Faculty_Participants ([Events_eventID] ASC) VISIBLE,
  INDEX [fk_Faculty_has_Events_Faculty1_idx] ([Faculty_facultyID] ASC) VISIBLE,
  CONSTRAINT [fk_Faculty_has_Events_Faculty1]
    FOREIGN dbo.KEY ([Faculty_facultyID])
    REFERENCES `EventManagement`.`Faculty` ([facultyID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Faculty_has_Events_Events1]
    FOREIGN dbo.KEY ([Events_eventID])
    REFERENCES `EventManagement`.`Events` ([eventID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ement`.`Events_has_External_Vendors`
-- SQLINES DEMO *** ------------------------------------
-- SQLINES LICENSE FOR EVALUATION USE ONLY
CREATE TABLE EventManagement.Events_has_External_Vendors (
  [eventID] INT NOT NULL,
  [vendorID] INT NOT NULL,
  PRIMARY KEY ([eventID], [vendorID])
  CREATE INDEX [fk_Events_has_ExternalVendors_ExternalVendors1_idx] ON EventManagement.Events_has_External_Vendors ([vendorID] ASC) VISIBLE,
  INDEX [fk_Events_has_ExternalVendors_Events1_idx] ([eventID] ASC) VISIBLE,
  CONSTRAINT [fk_Events_has_ExternalVendors_Events1]
    FOREIGN dbo.KEY ([eventID])
    REFERENCES `EventManagement`.`Events` ([eventID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Events_has_ExternalVendors_ExternalVendors1]
    FOREIGN dbo.KEY ([vendorID])
    REFERENCES `EventManagement`.`External_Vendors` ([vendorID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


/* SET SQL_MODE=@OLD_SQL_MODE; */
/* SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS; */
/* SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS; */
