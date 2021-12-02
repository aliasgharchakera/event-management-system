--set identity_insert students on
insert into students(idstudent, email, [name], contactno, department, batch, password_2)
values(6923,'ma06423@st.habib.edu.pk', 'Muhammad Uzair Amin', 12345678, 'CS', 2024, 'hello6423')

insert into students(idstudent, email, [name], contactno, department, batch, password_2)
values(6949,'si06949@st.habib.edu.pk', 'Shafay Iqbal', 23456789, 'Undecided', 2024, 'hello6949')

insert into students(idstudent, email, [name], contactno, department, batch, password_2)
values(6993,'ay06993@st.habib.edu.pk', 'Ali Asghar Yousuf', 28414129, 'CE', 2024, 'hello6993')

insert into students(idstudent, email, [name], contactno, department, batch, password_2)
values(6777,'zu6777@st.habib.edu.pk', 'Zain Ahmed Usmani', 34567891, 'CS', 2024, 'hello6777')

insert into students(idstudent, email, [name], contactno, department, batch, password_2)
values(6565,'si06565@st.habib.edu.pk', 'Syed Ibrahim Ali', 45678912, 'CND', 2025, 'hello6565')

insert into students(idstudent, email, [name], contactno, department, batch, password_2)
values(6234,'ss6234@st.habib.edu.pk', 'Syed Shoaib', 56789123, 'CS', 2022, 'hello6234')

insert into students(idstudent, email, [name], contactno, department, batch, password_2)
values(6523,'na6523@st.habib.edu.pk', 'Nasir Ali', 67891234, 'EE', 2023, 'hello6523')


--Locations
--alter table locations
--add	locationName varchar (45)

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

select * from Locations

--Faculty
insert into Faculty (Locations_idLocation, [Name], Department, HireDate, IsAdjunct, ContactNo)
values (11, 'Junaid Ahmed Memon', 'DSSE', 01-01-2018, 0, '03002228888')
insert into Faculty (Locations_idLocation, [Name], Department, HireDate, IsAdjunct, ContactNo)
values (6, 'Jimmy Page', 'EE', 01-01-2019, 1, '03009228888')
insert into Faculty (Locations_idLocation, [Name], Department, HireDate, IsAdjunct, ContactNo)
values (5, 'Asmat Ullah', 'CS', 01-01-2018, 0, '03002228888')
insert into Faculty (Locations_idLocation, [Name], Department, HireDate, IsAdjunct, ContactNo)
values (3, 'Ahmed Usman', 'EE', 01-01-2018, 1, '03002233388')
insert into Faculty (Locations_idLocation, [Name], Department, HireDate, IsAdjunct, ContactNo)
values (4, 'Abdullah Bajwa', 'ENGR', 01-01-2020, 0, '03302233388')
insert into Faculty (Locations_idLocation, [Name], Department, HireDate, IsAdjunct, ContactNo)
values (10, 'Nauman Naqvi', 'CH', 01-01-2015, 0, '03222228888')


--Affiliates
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

select * from Affiliates

--External_Vendors
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

select * from External_Vendors

--Sponsors
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

select * from Sponsors

--Clubs
insert into Club_chapters(Sponsors_idSponsors, Affiliates_idAffiliates, Faculty_idFaculty, [Name], AnnualBudget)
values (4, 3, 18, 'CSEC', 200000)

insert into Club_chapters(Sponsors_idSponsors, Affiliates_idAffiliates, Faculty_idFaculty, [Name], AnnualBudget)
values (2, 5, 7, 'Math Club', 50000)

insert into Club_chapters(Sponsors_idSponsors, Affiliates_idAffiliates, Faculty_idFaculty, [Name], AnnualBudget)
values (1, 1, 16, 'SerVe Club', 150000)

insert into Club_chapters(Sponsors_idSponsors, Affiliates_idAffiliates, Faculty_idFaculty, [Name], AnnualBudget)
values (6, 4, 15, 'Sustainability Club', 100000)

insert into Club_chapters(Sponsors_idSponsors, Affiliates_idAffiliates, Faculty_idFaculty, [Name], AnnualBudget)
values (5, 6, 13, 'Brain Hack', 50000)

insert into Club_chapters(Sponsors_idSponsors, Affiliates_idAffiliates, Faculty_idFaculty, [Name], AnnualBudget)
values (3, 2, 17, 'Debate Club', 200000)

select * from Club_chapters


--Event Categories

insert into Event_Categories(categoryName,categoryDescription)
values ('Competition','Competition of any type');

insert into Event_Categories(categoryName,categoryDescription)
values ('Performance', 'Musical or Arts performances');

insert into Event_Categories(categoryName,categoryDescription)
values ('Exhibition','Exhibition of Projects, Artworks, Research, etc');

insert into Event_Categories(categoryName,categoryDescription)
values ('Seminar','Informative talks delivered by internal/external speakers');

insert into Event_Categories(categoryName,categoryDescription)
values ('Recreation','Recreational activities including indoor/outdoor sports, screenings and concerts');

insert into Event_Categories(categoryName,categoryDescription)
values ('Cultural', 'Celebrations of any Cultural Events');


--Events

insert into [Events](idEvent, Events_Categories_categoryID, [Name], Budget, PathToMedia, ZoomID, Organizer)
values (1, 1, 'Math Olympiad', 5000, 'www.google.com', null, 'Math Club')

insert into [Events](idEvent, Events_Categories_categoryID, [Name], Budget, PathToMedia, ZoomID, Organizer)
values (2, 6, 'Sindh Culture Day', 2000, 'www.sindh.com', null, 'Debate Club')

insert into [Events](idEvent, Events_Categories_categoryID, [Name], Budget, PathToMedia, ZoomID, Organizer)
values (3, 4, 'Earth Day', 30000, 'www.bruh.com', null, 'Sustainability Club')

insert into [Events](idEvent, Events_Categories_categoryID, [Name], Budget, PathToMedia, ZoomID, Organizer)
values (4, 1, 'HUMUN', 50000, 'www.humun.com', null, 'Debate Club')

insert into [Events](idEvent, Events_Categories_categoryID, [Name], Budget, PathToMedia, ZoomID, Organizer)
values (5, 5, 'Hamdast', 30000, 'www.serVe.com', null, 'SerVe Club')
		
select * from [Events]
select * from locations
--select * from 

create Procedure delete_event @event_id int as
delete from Event_has_Guests
where Events_idEvent = @event_id;
delete from Item_Bookings
where Events_idEvent = @event_id;
delete from EventTimings
where Events_idEvent = @event_id;
delete from Volunteers
where Events_idEvent = @event_id;
delete from Student_Participants
where Events_idEvent = @event_id;
delete from Faculty_Participants
where Events_idEvent = @event_id;
delete from Events
where idEvent = @event_id
GO