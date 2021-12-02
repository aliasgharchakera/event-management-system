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
values (16, 'Jimmy Page', 'EE', 01-01-2019, 1, '03009228888')
insert into Faculty (Locations_idLocation, [Name], Department, HireDate, IsAdjunct, ContactNo)
values (15, 'Asmat Ullah', 'CS', 01-01-2018, 0, '03002228888')
insert into Faculty (Locations_idLocation, [Name], Department, HireDate, IsAdjunct, ContactNo)
values (13, 'Ahmed Usman', 'EE', 01-01-2018, 1, '03002233388')
insert into Faculty (Locations_idLocation, [Name], Department, HireDate, IsAdjunct, ContactNo)
values (14, 'Abdullah Bajwa', 'ENGR', 01-01-2020, 0, '03302233388')
insert into Faculty (Locations_idLocation, [Name], Department, HireDate, IsAdjunct, ContactNo)
values (16, 'Nauman Naqvi', 'CH', 01-01-2015, 0, '03222228888')


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


--Clubs
insert into Club_chapters(Sponsors_idSponsors, Affiliates_idAffiliates, Faculty_idFaculty, [Name], AnnualBudget)
values (4, 3, 4, 'CSEC', 200000)

insert into Club_chapters(Sponsors_idSponsors, Affiliates_idAffiliates, Faculty_idFaculty, [Name], AnnualBudget)
values (2, 5, 7, 'Math Club', 50000)

insert into Club_chapters(Sponsors_idSponsors, Affiliates_idAffiliates, Faculty_idFaculty, [Name], AnnualBudget)
values (1, 1, 8, 'SerVe Club', 150000)

insert into Club_chapters(Sponsors_idSponsors, Affiliates_idAffiliates, Faculty_idFaculty, [Name], AnnualBudget)
values (6, 4, 3, 'Sustainability Club', 100000)

insert into Club_chapters(Sponsors_idSponsors, Affiliates_idAffiliates, Faculty_idFaculty, [Name], AnnualBudget)
values (5, 6, 9, 'Brain Hack', 50000)

insert into Club_chapters(Sponsors_idSponsors, Affiliates_idAffiliates, Faculty_idFaculty, [Name], AnnualBudget)
values (3, 2, 11, 'Debate Club', 200000)




--Events
insert into [Events](Events_Categories_categoryID, [Name], Budget, PathToMedia, ZoomID, Organizer)
values (1, 'Math Olympiad', 5000, 'www.google.com', null, 'Math Club')

insert into [Events](Events_Categories_categoryID, [Name], Budget, PathToMedia, ZoomID, Organizer)


values (6, 'Sindh Culture Day', 2000, 'www.sindh.com', null, '')