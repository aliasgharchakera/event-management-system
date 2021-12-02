insert into External_Vendors(name,contactNo,email)
values('Rahim Bhai',546879,NULL);

insert into External_Vendors(name,contactNo,email)
values('Robert Bhai',876435,NULL);

insert into External_Vendors(name,contactNo,email)
values('Walls Company Vendor',973457,'vendor@walls.com');

insert into External_Vendors(name,contactNo,email)
values('Saleem Shah',964112,NULL);

insert into External_Vendors(name,contactNo,email)
values('Saddam Ali',441286,NULL);


insert into Sponsors(name,contact_name,email)
values('Habib Metro',	'Anwar ali',	'anwarali@metro.com');

insert into Sponsors(name,contact_name,email)
values('Lipton',	'Jason Ali',	'jasonali@lipton.com');

insert into Sponsors(name,contact_name,email)
values('Samsung',	'Sam Anwar',	'samanwar@samsung.com');

insert into Sponsors(name,contact_name,email)
values('Dell'	,'Barack Obama'	,'obama@dell.com');

insert into Sponsors(name,contact_name,email)
values('TCL',	'Bart Simpson',	'bartsimpson@tcl.com');

insert into Sponsors(name,contact_name,email)
values('IBM'	,'Homer Azmar'	,'homerazmat@ibm.com');



insert into Affiliates(name,contactperson_name,email)
values('ASIC'	,'Sam Smith'	,'samsmith@asic.com');

insert into Affiliates(name,contactperson_name,email)
values('CSEC',	'John Doe',	'doejohn@csec.com');

insert into Affiliates(name,contactperson_name,email)
values('FPGA',	'Nazim Nazeem'	,'nazimnazeem@fpga.com');

insert into Affiliates(name,contactperson_name,email)
values('FLD',	'Basheer manuel',	'basheer@fld.com');

insert into Affiliates(name,contactperson_name,email)
values('MLK'	,'Roshi Nasir',	'roshinasir@mlk.com');

insert into Affiliates(name,contactperson_name,email)
values('DTRJ',	'ahmed ahmed',	'ahmedahmed@dtrj.com');




insert into Guests(name,email,cellNumber)
values('Steve Jobs','	stevejobs@gmail.com','	12345678');

insert into Guests(name,email,cellNumber)
values('Elon Musk','	elonmush@gmail.com','	23456789');

insert into Guests(name,email,cellNumber)
values('Nikola Tesla','	tessla@gmail.com','	34567890');

insert into Guests(name,email,cellNumber)
values('Stephen Hawking','	hawking@outlook.com','	45678901');

insert into Guests(name,email,cellNumber)
values('Carl Jung','	carljung@gmail.com','	56789012');

insert into Guests(name,email,cellNumber)
values('Jeff Bezos','	evilrocketguy@gmail.com','	67890123');

insert into Guests(name,email,cellNumber)
values('Imran Khan','	tabdeeli@gmail.com','	78901234');

insert into Guests(name,email,cellNumber)
values('Jim Carrey',	'jimmy@gmail.com','	28562887');

insert into Guests(name,email,cellNumber)
values('Kendrick Lamar','kendrick@gmail.com'	,'78523455');

insert into Guests(name,email,cellNumber)
values('Lord Dalhousie',	'colonialguy@gmail.com'	,'90089113');

select * from Sponsors
select * from Affiliates
select * from Faculty
select * from Locations

alter table Locations
add locationName varchar(50)


insert into Locations (roomCode, locationName, Capacity, isOpenSpace)
values ('LB210', 'Library Room 210', 10, 0)
insert into Locations (roomCode, locationName, Capacity, isOpenSpace)
values ('LB209', 'Library Room 209', 10, 0)
insert into Locations (roomCode, locationName, Capacity, isOpenSpace)
values ('LB204', 'Library Room 204', 10, 0)
insert into Locations (roomCode, locationName, Capacity, isOpenSpace)
values ('W234', 'Classroom W234', 25, 0)
insert into Locations (roomCode, locationName, Capacity, isOpenSpace)
values ('E300a', 'Playground', 100, 0)
insert into Locations (roomCode, locationName, Capacity, isOpenSpace)
values (NULL, 'Earth Courtyard', 100, 1)
insert into Locations (roomCode, locationName, Capacity, isOpenSpace)
values (NULL, 'Air Courtyard', 50, 1)
insert into Locations (roomCode, locationName, Capacity, isOpenSpace)
values ('E110', 'Faculty Pod E110', 4, 0)
insert into Locations (roomCode, locationName, Capacity, isOpenSpace)
values ('C203', 'Faculty Pod C203', 4, 0)
insert into Locations (roomCode, locationName, Capacity, isOpenSpace)
values ('C200', 'Faculty Pod C200', 4, 0)
insert into Locations (roomCode, locationName, Capacity, isOpenSpace)
values ('W222', 'Faculty Pod W222', 4, 0)

/*update locations
set locationName = 'Faculty Pod 109', roomCode = 'E109'
where idLocation =11*/

select * from Locations
select * from Faculty
insert into Faculty (Locations_idLocation, [Name], Department, HireDate, IsAdjunct, ContactNo)
values (11, 'Junaid Ahmed Memon', 'DSSE', 01-01-2018, 0, '03002228888')
insert into Faculty (Locations_idLocation, [Name], Department, HireDate, IsAdjunct, ContactNo)
values (16, 'Jimmy Page', 'EE', 01-01-2019, 1, '03009228888')
insert into Faculty (Locations_idLocation, [Name], Department, HireDate, IsAdjunct, ContactNo)
values (15, 'Asmat Ullah', 'CS', 01-01-2018, 0, '03002228888')
insert into Faculty (Locations_idLocation, [Name], Department, HireDate, IsAdjunct, ContactNo)
values (13, 'Ahmed Usman', 'EE', 01-01-2018, 1, '03002233388')
insert into Faculty (Locations_idLocation, [Name], Department, HireDate, IsAdjunct, ContactNo)
values (14, 'Abdullah Bajwa', 'ENGR', 01-01-2020, 0, '03302233388')
insert into Faculty (Locations_idLocation, [Name], Department, HireDate, IsAdjunct, ContactNo)
values (16, 'Nauman Naqvi', 'CH', 01-01-2015, 0, '03222228888')


select * from Faculty
select * from Club_chapters
select * from events

alter table events
add	isApproved TINYINT

alter table inventory_items
drop column category

select * from inventory_items
select * from Affiliates

select * from Students

insert into Students(name,ContactNo,Department,Batch,Password_2,Email,studentid_full)
values('test','123','cs','202','123','email','hello');

select * from External_Vendors

update Events
set isApproved = 0
where idEvent  = 4


create Procedure add_event @event_name varchar (45), @event_cat varchar (45), @event_budget int, @organizer varchar (45), @location varchar (45), @start_date date, @start_time time, @duration int as
insert into Events(idEvent, [Name], Events_Categories_categoryID, Budget, PathToMedia, Organizer)
values ((select max(idevent) from Events) + 1, @event_name, (select categoryID from Event_Categories where categoryName = @event_cat), @event_budget, null, @organizer);

create Procedure add_vendor @name varchar(45), @number varchar(45), @email varchar(45) as
insert into external_vendors ([name], contactNo, email)
values (@name, @number, @email)
GO
insert into EventTimings(Events_idEvent, Locations_idLocation, StartTime, EndTime)
values ((select max(idevent) from Events) + 1, (select idLocation from Locations where locationName = @location), (SELECT CAST(@start_date AS DATETIME) + CAST(@start_time AS DATETIME)), (SELECT CAST(@start_date AS DATETIME) + dateadd(hour, @duration, CAST(@start_time AS DATETIME))))
GO
exec add_vendor @name = 'Chakera'
create Procedure delete_event_byname @event_name varchar(45) as

delete from Event_has_Guests
where Events_idEvent = (select idevent from [events] where [name] = @event_name);
delete from Item_Bookings
where Events_idEvent = (select idevent from [events] where [name] = @event_name);
delete from EventTimings
where Events_idEvent = (select idevent from [events] where [name] = @event_name);
delete from Volunteers
where Events_idEvent = (select idevent from [events] where [name] = @event_name);
delete from Student_Participants
where Events_idEvent = (select idevent from [events] where [name] = @event_name);
delete from Faculty_Participants
where Events_idEvent = (select idevent from [events] where [name] = @event_name);
delete from Events
where idEvent = (select idevent from [events] where [name] = @event_name)
GO

exec delete_event_byname @event_name = 'Hamdast_2'

select * from students

create view GridView1 as 
select Events.idEvent,Events.name as eventName,StartTime,EndTime,Locations.locationName,Events.Organizer,Event_Categories.categoryName as categoryName,Events.isApproved
from Events,EventTimings,Locations,Event_Categories
where Events.idEvent = EventTimings.Events_idEvent and EventTimings.Locations_idLocation = Locations.idLocation and Events.Events_Categories_categoryID = Event_Categories.categoryId

select * from Events
select * from Locations
select * from EventTimings

select * from GridView1

select * from Club_chapters

select * from Event_Categories

-- events
select * from EventTimings

select * from [Events]
-- timigns


alter table Inventory_Items
drop category;

select * from GridViewFinal

select * from Events

insert into Club_chapters(Sponsors_idSponsors, Affiliates_idAffiliates, Faculty_idFaculty, [Name], AnnualBudget)
values (4, 3, 1, 'CSEC', 200000)

insert into Club_chapters(Sponsors_idSponsors, Affiliates_idAffiliates, Faculty_idFaculty, [Name], AnnualBudget)
values (2, 5, 2, 'Math Club', 50000)

insert into Club_chapters(Sponsors_idSponsors, Affiliates_idAffiliates, Faculty_idFaculty, [Name], AnnualBudget)
values (1, 1, 3, 'SerVe Club', 150000)

insert into Club_chapters(Sponsors_idSponsors, Affiliates_idAffiliates, Faculty_idFaculty, [Name], AnnualBudget)
values (6, 4, 4, 'Sustainability Club', 100000)

insert into Club_chapters(Sponsors_idSponsors, Affiliates_idAffiliates, Faculty_idFaculty, [Name], AnnualBudget)
values (5, 6, 5, 'Brain Hack', 50000)

insert into Club_chapters(Sponsors_idSponsors, Affiliates_idAffiliates, Faculty_idFaculty, [Name], AnnualBudget)
values (3, 2, 6, 'Debate Club', 200000)

select * from 




System.Data.SqlClient.SqlException: 'Incorrect syntax near 'Olympiad'.'