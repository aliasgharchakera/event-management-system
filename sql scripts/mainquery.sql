Use Event_Management

CREATE TABLE Sponsors (
  idSponsors INTEGER  NOT NULL   IDENTITY ,
  name VARCHAR(45)    ,
  contact_name VARCHAR(45)    ,
  email VARCHAR(45)      ,
PRIMARY KEY(idSponsors));
GO




CREATE TABLE Event_Categories (
  categoryID INTEGER  NOT NULL   IDENTITY ,
  categoryName VARCHAR(45)  NOT NULL  ,
  categoryDescription VARCHAR(255)      ,
PRIMARY KEY(categoryID));
GO




CREATE TABLE External_Vendors (
  idExternal_Vendors INTEGER  NOT NULL   IDENTITY ,
  name VARCHAR(45)    ,
  contactNo INTEGER    ,
  email VARCHAR(45)      ,
PRIMARY KEY(idExternal_Vendors));
GO




CREATE TABLE Guests (
  idGuests INTEGER  NOT NULL   IDENTITY ,
  name VARCHAR(45)    ,
  email VARCHAR(45)    ,
  cellNumber INTEGER      ,
PRIMARY KEY(idGuests));
GO




CREATE TABLE Locations (
  idLocation INT  NOT NULL   IDENTITY ,
  roomCode VARCHAR(5)      ,	
  Capacity INTEGER    ,
  isOpenSpace TINYINT      ,
PRIMARY KEY(idLocation));
GO




CREATE TABLE Students (
  idStudent INT  NOT NULL   IDENTITY ,
  studentid_full VARCHAR(7) NOT NULL,
  Name VARCHAR(45)  NOT NULL  ,
  ContactNo VARCHAR(45)  NOT NULL  ,
  Department VARCHAR(45)  NOT NULL  ,
  Batch INTEGER  NOT NULL  ,
  Password_2 VARCHAR(45)  NOT NULL  ,
  Email VARCHAR(45)  NOT NULL    ,
PRIMARY KEY(idStudent));
GO




CREATE TABLE Categories (
  categoryId INTEGER  NOT NULL   IDENTITY ,
  name VARCHAR(45)      ,
PRIMARY KEY(categoryId));
GO




CREATE TABLE Affiliates (
  idAffiliates INTEGER  NOT NULL   IDENTITY ,
  name VARCHAR(45)    ,
  contactperson_name VARCHAR(45)    ,
  email VARCHAR(45)      ,
PRIMARY KEY(idAffiliates));
GO




CREATE TABLE Events (
  idEvent INTEGER  NOT NULL  ,
  Events_Categories_categoryID INTEGER  NOT NULL  ,
  Name VARCHAR(45)  NOT NULL  ,
  Budget INTEGER  NOT NULL  ,
  PathToMedia VARCHAR(255)  NOT NULL  ,
  ZoomID VARCHAR(100)    ,
  Organizer VARCHAR(45)      ,
PRIMARY KEY(idEvent)  ,
  FOREIGN KEY(Events_Categories_categoryID)
    REFERENCES Event_Categories(categoryID));
GO


CREATE INDEX Event_FKIndex1 ON Events (Events_Categories_categoryID);
GO


CREATE INDEX IFK_Rel_19 ON Events (Events_Categories_categoryID);
GO


CREATE TABLE Inventory_items (
  itemID INTEGER  NOT NULL   IDENTITY ,
  Categories_categoryId INTEGER  NOT NULL  ,
  name VARCHAR(45)    ,
  category INTEGER    ,
  stock INTEGER      ,
PRIMARY KEY(itemID)  ,
  FOREIGN KEY(Categories_categoryId)
    REFERENCES Categories(categoryId));
GO


CREATE INDEX Inventory_FKIndex1 ON Inventory_items (Categories_categoryId);
GO


CREATE INDEX IFK_Rel_23 ON Inventory_items (Categories_categoryId);
GO


CREATE TABLE Faculty (
  idFaculty INTEGER  NOT NULL   IDENTITY ,
  Locations_idLocation INT  NOT NULL  ,
  Name VARCHAR(45)    ,
  Department VARCHAR(45)    ,
  HireDate DATETIME    ,
  IsAdjunct TINYINT  NOT NULL  ,
  ContactNo VARCHAR(45)      ,
PRIMARY KEY(idFaculty)  ,
  FOREIGN KEY(Locations_idLocation)
    REFERENCES Locations(idLocation));
GO


CREATE INDEX Faculty_FKIndex1 ON Faculty (Locations_idLocation);
GO


CREATE INDEX IFK_Rel_29 ON Faculty (Locations_idLocation);
GO


CREATE TABLE Volunteers (
  Events_idEvent INTEGER  NOT NULL  ,
  Students_idStudent INT  NOT NULL    ,
PRIMARY KEY(Events_idEvent, Students_idStudent)    ,
  FOREIGN KEY(Events_idEvent)
    REFERENCES Events(idEvent),
  FOREIGN KEY(Students_idStudent)
    REFERENCES Students(idStudent));
GO


CREATE INDEX Event_has_Student_FKIndex1 ON Volunteers (Events_idEvent);
GO
CREATE INDEX Event_has_Student_FKIndex2 ON Volunteers (Students_idStudent);
GO


CREATE INDEX IFK_Rel_32 ON Volunteers (Events_idEvent);
GO
CREATE INDEX IFK_Rel_33 ON Volunteers (Students_idStudent);
GO


CREATE TABLE Student_Participants (
  Events_idEvent INTEGER  NOT NULL  ,
  Students_idStudent INT  NOT NULL    ,
PRIMARY KEY(Events_idEvent, Students_idStudent)    ,
  FOREIGN KEY(Events_idEvent)
    REFERENCES Events(idEvent),
  FOREIGN KEY(Students_idStudent)
    REFERENCES Students(idStudent));
GO


CREATE INDEX Event_has_Student_FKIndex1 ON Student_Participants (Events_idEvent);
GO
CREATE INDEX Event_has_Student_FKIndex2 ON Student_Participants (Students_idStudent);
GO


CREATE INDEX IFK_Rel_28 ON Student_Participants (Events_idEvent);
GO
CREATE INDEX IFK_Rel_29 ON Student_Participants (Students_idStudent);
GO


CREATE TABLE Item_Bookings (
  Events_idEvent INTEGER  NOT NULL  ,
  Inventory_items_itemID INTEGER  NOT NULL    ,
PRIMARY KEY(Events_idEvent, Inventory_items_itemID)    ,
  FOREIGN KEY(Events_idEvent)
    REFERENCES Events(idEvent),
  FOREIGN KEY(Inventory_items_itemID)
    REFERENCES Inventory_items(itemID));
GO


CREATE INDEX Event_has_Inventory_FKIndex1 ON Item_Bookings (Events_idEvent);
GO
CREATE INDEX Event_has_Inventory_FKIndex2 ON Item_Bookings (Inventory_items_itemID);
GO


CREATE INDEX IFK_Rel_15 ON Item_Bookings (Events_idEvent);
GO
CREATE INDEX IFK_Rel_16 ON Item_Bookings (Inventory_items_itemID);
GO


CREATE TABLE EventTimings (
  Events_idEvent INTEGER  NOT NULL  ,
  Locations_idLocation INT  NOT NULL  ,
  StartTime DATETIME    ,
  EndTime DATETIME      ,
PRIMARY KEY(Events_idEvent, Locations_idLocation)    ,
  FOREIGN KEY(Events_idEvent)
    REFERENCES Events(idEvent),
  FOREIGN KEY(Locations_idLocation)
    REFERENCES Locations(idLocation));
GO


CREATE INDEX EventTiming_FKIndex1 ON EventTimings (Events_idEvent);
GO
CREATE INDEX EventTiming_FKIndex2 ON EventTimings (Locations_idLocation);
GO


CREATE INDEX IFK_Rel_20 ON EventTimings (Events_idEvent);
GO
CREATE INDEX IFK_Rel_21 ON EventTimings (Locations_idLocation);
GO


CREATE TABLE Event_has_Guests (
  Events_idEvent INTEGER  NOT NULL  ,
  Guests_idGuests INTEGER  NOT NULL  ,
  guestRole VARCHAR(45)      ,
PRIMARY KEY(Events_idEvent, Guests_idGuests)    ,
  FOREIGN KEY(Events_idEvent)
    REFERENCES Events(idEvent),
  FOREIGN KEY(Guests_idGuests)
    REFERENCES Guests(idGuests));
GO


CREATE INDEX Event_has_Guests_FKIndex1 ON Event_has_Guests (Events_idEvent);
GO
CREATE INDEX Event_has_Guests_FKIndex2 ON Event_has_Guests (Guests_idGuests);
GO


CREATE INDEX IFK_Rel_13 ON Event_has_Guests (Events_idEvent);
GO
CREATE INDEX IFK_Rel_14 ON Event_has_Guests (Guests_idGuests);
GO


CREATE TABLE Faculty_Participants (
  Events_idEvent INTEGER  NOT NULL  ,
  Faculty_idFaculty INTEGER  NOT NULL    ,
PRIMARY KEY(Events_idEvent, Faculty_idFaculty)    ,
  FOREIGN KEY(Events_idEvent)
    REFERENCES Events(idEvent),
  FOREIGN KEY(Faculty_idFaculty)
    REFERENCES Faculty(idFaculty));
GO


CREATE INDEX Event_has_Faculty_FKIndex1 ON Faculty_Participants (Events_idEvent);
GO
CREATE INDEX Event_has_Faculty_FKIndex2 ON Faculty_Participants (Faculty_idFaculty);
GO


CREATE INDEX IFK_Rel_24 ON Faculty_Participants (Events_idEvent);
GO
CREATE INDEX IFK_Rel_25 ON Faculty_Participants (Faculty_idFaculty);
GO


CREATE TABLE External_Vendors_has_Event (
  External_Vendors_idExternal_Vendors INTEGER  NOT NULL  ,
  Events_idEvent INTEGER  NOT NULL    ,
PRIMARY KEY(External_Vendors_idExternal_Vendors, Events_idEvent)    ,
  FOREIGN KEY(External_Vendors_idExternal_Vendors)
    REFERENCES External_Vendors(idExternal_Vendors),
  FOREIGN KEY(Events_idEvent)
    REFERENCES Events(idEvent));
GO


CREATE INDEX External_Vendors_has_Event_FKIndex1 ON External_Vendors_has_Event (External_Vendors_idExternal_Vendors);
GO
CREATE INDEX External_Vendors_has_Event_FKIndex2 ON External_Vendors_has_Event (Events_idEvent);
GO


CREATE INDEX IFK_Rel_26 ON External_Vendors_has_Event (External_Vendors_idExternal_Vendors);
GO
CREATE INDEX IFK_Rel_27 ON External_Vendors_has_Event (Events_idEvent);
GO


CREATE TABLE Club_chapters (
  idClub INTEGER  NOT NULL   IDENTITY ,
  Sponsors_idSponsors INTEGER  NOT NULL  ,
  Affiliates_idAffiliates INTEGER  NOT NULL  ,
  Faculty_idFaculty INTEGER  NOT NULL  ,
  Name VARCHAR(45)  NOT NULL  ,
  AnnualBudget INTEGER  NOT NULL    ,
PRIMARY KEY(idClub)      ,
  FOREIGN KEY(Faculty_idFaculty)
    REFERENCES Faculty(idFaculty),
  FOREIGN KEY(Affiliates_idAffiliates)
    REFERENCES Affiliates(idAffiliates),
  FOREIGN KEY(Sponsors_idSponsors)
    REFERENCES Sponsors(idSponsors));
GO


CREATE INDEX Club_chapters_FKIndex1 ON Club_chapters (Faculty_idFaculty);
GO
CREATE INDEX Club_chapters_FKIndex2 ON Club_chapters (Affiliates_idAffiliates);
GO
CREATE INDEX Club_chapters_FKIndex3 ON Club_chapters (Sponsors_idSponsors);
GO


CREATE INDEX IFK_Rel_32 ON Club_chapters (Faculty_idFaculty);
GO
CREATE INDEX IFK_Rel_33 ON Club_chapters (Affiliates_idAffiliates);
GO
CREATE INDEX IFK_Rel_34 ON Club_chapters (Sponsors_idSponsors);
GO


CREATE TABLE Club_Memberships (
  Students_idStudent INT  NOT NULL  ,
  Club_chapters_idClub INTEGER  NOT NULL    ,
PRIMARY KEY(Students_idStudent, Club_chapters_idClub)    ,
  FOREIGN KEY(Students_idStudent)
    REFERENCES Students(idStudent),
  FOREIGN KEY(Club_chapters_idClub)
    REFERENCES Club_chapters(idClub));
GO


CREATE INDEX Student_has_Club_chapters_FKIndex1 ON Club_Memberships (Students_idStudent);
GO
CREATE INDEX Student_has_Club_chapters_FKIndex2 ON Club_Memberships (Club_chapters_idClub);
GO


CREATE INDEX IFK_Rel_30 ON Club_Memberships (Students_idStudent);
GO
CREATE INDEX IFK_Rel_31 ON Club_Memberships (Club_chapters_idClub);
GO