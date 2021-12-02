select * from locations

INSERT INTO Locations (idLocation, Capacity, isOpenSpace)
VALUES ('E-001', 20, 0)

INSERT INTO [Events] (zoomId)
VALUES ('Hasan Shah')

ALTER Table EventTimings DROP constraint FK__EventTimi__Locat__6B24EA82
ALTER Table Faculty DROP constraint FK__Faculty__Locatio__5BE2A6F2
ALTER Table locations DROP constraint DF__Locations__idloc__14270015


ALTER Table locations DROP COLUMN idlocation 

ALTER Table Students
ADD studentid_full Varchar(7) NOT NULL

ALTER Table Locations
ADD roomCode Varchar(5) 


ALTER Table eventtimings
ALTER column Locations_idlocation varchar(5)

select * from EventTimings

ALTER Table EventTimings ADD Foreign key (Locations_idlocation) REFERENCES locations(idlocation)
