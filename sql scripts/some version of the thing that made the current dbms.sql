CREATE TABLE Location (
  idLocation INTEGER  NOT NULL   IDENTITY ,
  Capacity INTEGER    ,
  isOpenSpace tinyint,
PRIMARY KEY(idLocation));
GO




CREATE TABLE Student (
  idStudent INTEGER  NOT NULL   IDENTITY ,
  Name VARCHAR  NOT NULL  ,
  ContactNo VARCHAR  NOT NULL  ,
  Department VARCHAR  NOT NULL  ,
  Batch INTEGER  NOT NULL  ,
  Password_2 VARCHAR  NOT NULL  ,
  Email VARCHAR  NOT NULL    ,
PRIMARY KEY(idStudent));
GO




CREATE TABLE Category (
  idCategory INTEGER  NOT NULL   IDENTITY ,
  Name VARCHAR  NOT NULL  ,
  Description VARCHAR      ,
PRIMARY KEY(idCategory));
GO




CREATE TABLE Event (
  idEvent INTEGER  NOT NULL  ,
  Category_idCategory INTEGER  NOT NULL  ,
  Name VARCHAR  NOT NULL  ,
  Budget INTEGER  NOT NULL  ,
  PathToMedia VARCHAR  NOT NULL  ,
  ZoomID VARCHAR      ,
PRIMARY KEY(idEvent)  ,
  FOREIGN KEY(Category_idCategory)
    REFERENCES Category(idCategory));
GO


CREATE INDEX Event_FKIndex1 ON Event (Category_idCategory);
GO


CREATE INDEX IFK_Rel_12 ON Event (Category_idCategory);
GO


CREATE TABLE Faculty (
  idFaculty INTEGER  NOT NULL   IDENTITY ,
  Faculty_Pod INTEGER  NOT NULL  ,
  Name VARCHAR    ,
  Department VARCHAR    ,
  HireDate DATETIME    ,
  IsAdjunct tinyint  NOT NULL  ,
  ContactNo VARCHAR      ,
PRIMARY KEY(idFaculty)  ,
  FOREIGN KEY(Faculty_Pod)
    REFERENCES Location(idLocation));
GO


CREATE INDEX Faculty_FKIndex1 ON Faculty (Faculty_Pod);
GO


CREATE INDEX IFK_Rel_07 ON Faculty (Faculty_Pod);
GO


CREATE TABLE EventTiming (
  Event_idEvent INTEGER  NOT NULL  ,
  Location_idLocation INTEGER  NOT NULL  ,
  StartTime DATETIME    ,
  EndTime DATETIME      ,
PRIMARY KEY(Event_idEvent, Location_idLocation)    ,
  FOREIGN KEY(Event_idEvent)
    REFERENCES Event(idEvent),
  FOREIGN KEY(Location_idLocation)
    REFERENCES Location(idLocation));
GO


CREATE INDEX Event_has_Location_FKIndex1 ON EventTiming (Event_idEvent);
GO
CREATE INDEX Event_has_Location_FKIndex2 ON EventTiming (Location_idLocation);
GO


CREATE INDEX IFK_Rel_10 ON EventTiming (Event_idEvent);
GO
CREATE INDEX IFK_Rel_11 ON EventTiming (Location_idLocation);
GO


CREATE TABLE Club (
  idClub INTEGER  NOT NULL   IDENTITY ,
  Treasurer INTEGER  NOT NULL  ,
  General_Secretary INTEGER  NOT NULL  ,
  Vice_President INTEGER  NOT NULL  ,
  President INTEGER  NOT NULL  ,
  Name VARCHAR  NOT NULL  ,
  AnnualBudget INTEGER  NOT NULL    ,
PRIMARY KEY(idClub)        ,
  FOREIGN KEY(President)
    REFERENCES Student(idStudent),
  FOREIGN KEY(Vice_President)
    REFERENCES Student(idStudent),
  FOREIGN KEY(General_Secretary)
    REFERENCES Student(idStudent),
  FOREIGN KEY(Treasurer)
    REFERENCES Student(idStudent));
GO


CREATE INDEX Student_idStudent_FKIndex1 ON Club (President);
GO
CREATE INDEX Student_idStudent_FKIndex2 ON Club (Vice_President);
GO
CREATE INDEX Student_idStudent_FKIndex3 ON Club (General_Secretary);
GO
CREATE INDEX Student_idStudent_FKIndex4 ON Club (Treasurer);
GO


CREATE INDEX IFK_Rel_03 ON Club (President);
GO
CREATE INDEX IFK_Rel_04 ON Club (Vice_President);
GO
CREATE INDEX IFK_Rel_05 ON Club (General_Secretary);
GO
CREATE INDEX IFK_Rel_06 ON Club (Treasurer);
GO


CREATE TABLE Member (
  Club_idClub INTEGER  NOT NULL  ,
  Student_idStudent INTEGER  NOT NULL    ,
PRIMARY KEY(Club_idClub, Student_idStudent)    ,
  FOREIGN KEY(Club_idClub)
    REFERENCES Club(idClub),
  FOREIGN KEY(Student_idStudent)
    REFERENCES Student(idStudent));
GO


CREATE INDEX Club_has_Student_FKIndex1 ON Member (Club_idClub);
GO
CREATE INDEX Club_has_Student_FKIndex2 ON Member (Student_idStudent);
GO


CREATE INDEX IFK_Rel_01 ON Member (Club_idClub);
GO
CREATE INDEX IFK_Rel_02 ON Member (Student_idStudent);
GO


CREATE TABLE ClubFacultyAffiliation (
  Club_idClub INTEGER  NOT NULL  ,
  Faculty_idFaculty INTEGER  NOT NULL    ,
PRIMARY KEY(Club_idClub, Faculty_idFaculty)    ,
  FOREIGN KEY(Club_idClub)
    REFERENCES Club(idClub),
  FOREIGN KEY(Faculty_idFaculty)
    REFERENCES Faculty(idFaculty));
GO


CREATE INDEX Club_has_Faculty_FKIndex1 ON ClubFacultyAffiliation (Club_idClub);
GO
CREATE INDEX Club_has_Faculty_FKIndex2 ON ClubFacultyAffiliation (Faculty_idFaculty);
GO


CREATE INDEX IFK_Rel_08 ON ClubFacultyAffiliation (Club_idClub);
GO
CREATE INDEX IFK_Rel_09 ON ClubFacultyAffiliation (Faculty_idFaculty);
GO


CREATE TABLE Location (
  idLocation INTEGER  NOT NULL   IDENTITY ,
  Capacity INTEGER    ,
  isOpenSpace tinyint,
PRIMARY KEY(idLocation));
GO




CREATE TABLE Student (
  idStudent INTEGER  NOT NULL   IDENTITY ,
  Name VARCHAR  NOT NULL  ,
  ContactNo VARCHAR  NOT NULL  ,
  Department VARCHAR  NOT NULL  ,
  Batch INTEGER  NOT NULL  ,
  Password_2 VARCHAR  NOT NULL  ,
  Email VARCHAR  NOT NULL    ,
PRIMARY KEY(idStudent));
GO




CREATE TABLE Category (
  idCategory INTEGER  NOT NULL   IDENTITY ,
  Name VARCHAR  NOT NULL  ,
  Description VARCHAR      ,
PRIMARY KEY(idCategory));
GO




CREATE TABLE Event (
  idEvent INTEGER  NOT NULL  ,
  Category_idCategory INTEGER  NOT NULL  ,
  Name VARCHAR  NOT NULL  ,
  Budget INTEGER  NOT NULL  ,
  PathToMedia VARCHAR  NOT NULL  ,
  ZoomID VARCHAR      ,
PRIMARY KEY(idEvent)  ,
  FOREIGN KEY(Category_idCategory)
    REFERENCES Category(idCategory));
GO


CREATE INDEX Event_FKIndex1 ON Event (Category_idCategory);
GO


CREATE INDEX IFK_Rel_12 ON Event (Category_idCategory);
GO


CREATE TABLE Faculty (
  idFaculty INTEGER  NOT NULL   IDENTITY ,
  Faculty_Pod INTEGER  NOT NULL  ,
  Name VARCHAR    ,
  Department VARCHAR    ,
  HireDate DATETIME    ,
  IsAdjunct tinyint  NOT NULL  ,
  ContactNo VARCHAR      ,
PRIMARY KEY(idFaculty)  ,
  FOREIGN KEY(Faculty_Pod)
    REFERENCES Location(idLocation));
GO


CREATE INDEX Faculty_FKIndex1 ON Faculty (Faculty_Pod);
GO


CREATE INDEX IFK_Rel_07 ON Faculty (Faculty_Pod);
GO


CREATE TABLE EventTiming (
  Event_idEvent INTEGER  NOT NULL  ,
  Location_idLocation INTEGER  NOT NULL  ,
  StartTime DATETIME    ,
  EndTime DATETIME      ,
PRIMARY KEY(Event_idEvent, Location_idLocation)    ,
  FOREIGN KEY(Event_idEvent)
    REFERENCES Event(idEvent),
  FOREIGN KEY(Location_idLocation)
    REFERENCES Location(idLocation));
GO


CREATE INDEX Event_has_Location_FKIndex1 ON EventTiming (Event_idEvent);
GO
CREATE INDEX Event_has_Location_FKIndex2 ON EventTiming (Location_idLocation);
GO


CREATE INDEX IFK_Rel_10 ON EventTiming (Event_idEvent);
GO
CREATE INDEX IFK_Rel_11 ON EventTiming (Location_idLocation);
GO


CREATE TABLE Club (
  idClub INTEGER  NOT NULL   IDENTITY ,
  Treasurer INTEGER  NOT NULL  ,
  General_Secretary INTEGER  NOT NULL  ,
  Vice_President INTEGER  NOT NULL  ,
  President INTEGER  NOT NULL  ,
  Name VARCHAR  NOT NULL  ,
  AnnualBudget INTEGER  NOT NULL    ,
PRIMARY KEY(idClub)        ,
  FOREIGN KEY(President)
    REFERENCES Student(idStudent),
  FOREIGN KEY(Vice_President)
    REFERENCES Student(idStudent),
  FOREIGN KEY(General_Secretary)
    REFERENCES Student(idStudent),
  FOREIGN KEY(Treasurer)
    REFERENCES Student(idStudent));
GO


CREATE INDEX Student_idStudent_FKIndex1 ON Club (President);
GO
CREATE INDEX Student_idStudent_FKIndex2 ON Club (Vice_President);
GO
CREATE INDEX Student_idStudent_FKIndex3 ON Club (General_Secretary);
GO
CREATE INDEX Student_idStudent_FKIndex4 ON Club (Treasurer);
GO


CREATE INDEX IFK_Rel_03 ON Club (President);
GO
CREATE INDEX IFK_Rel_04 ON Club (Vice_President);
GO
CREATE INDEX IFK_Rel_05 ON Club (General_Secretary);
GO
CREATE INDEX IFK_Rel_06 ON Club (Treasurer);
GO


CREATE TABLE Member (
  Club_idClub INTEGER  NOT NULL  ,
  Student_idStudent INTEGER  NOT NULL    ,
PRIMARY KEY(Club_idClub, Student_idStudent)    ,
  FOREIGN KEY(Club_idClub)
    REFERENCES Club(idClub),
  FOREIGN KEY(Student_idStudent)
    REFERENCES Student(idStudent));
GO


CREATE INDEX Club_has_Student_FKIndex1 ON Member (Club_idClub);
GO
CREATE INDEX Club_has_Student_FKIndex2 ON Member (Student_idStudent);
GO


CREATE INDEX IFK_Rel_01 ON Member (Club_idClub);
GO
CREATE INDEX IFK_Rel_02 ON Member (Student_idStudent);
GO


CREATE TABLE ClubFacultyAffiliation (
  Club_idClub INTEGER  NOT NULL  ,
  Faculty_idFaculty INTEGER  NOT NULL    ,
PRIMARY KEY(Club_idClub, Faculty_idFaculty)    ,
  FOREIGN KEY(Club_idClub)
    REFERENCES Club(idClub),
  FOREIGN KEY(Faculty_idFaculty)
    REFERENCES Faculty(idFaculty));
GO


CREATE INDEX Club_has_Faculty_FKIndex1 ON ClubFacultyAffiliation (Club_idClub);
GO
CREATE INDEX Club_has_Faculty_FKIndex2 ON ClubFacultyAffiliation (Faculty_idFaculty);
GO


CREATE INDEX IFK_Rel_08 ON ClubFacultyAffiliation (Club_idClub);
GO
CREATE INDEX IFK_Rel_09 ON ClubFacultyAffiliation (Faculty_idFaculty);
GO


