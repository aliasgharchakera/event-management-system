insert into student([name], contactno, department, batch, password_2, email)
values ('Zain', '1234', 'CS', 2024, 'hello', 'zu06777@st.habib.edu.pk')

select * from student

insert into category([name], [description])
values ('Birthday', 'Birthday bottom text')

insert into category([name], [description])
values ('Competition', 'competition bottom text')

insert into event(idevent, [name], budget, organizer, zoomid, category_idcategory, pathtomedia)
values (1, 'Zains Birthday', 5000, 'Student Life', '999999920', 1, 'www.google.com')


insert into event(idevent, [name], budget, organizer, category_idcategory, pathtomedia)
values (2, 'Math Olympiad', 20000, 'Math Club', 2, 'www.math.com')
set identity_insert location on

insert into location(idlocation, capacity, isopenspace)
values (1142, 50, 0)

insert into eventtiming(event_idevent, location_idlocation, starttime, endtime)
values (1, 1142, GETDATE(), dateadd(hh, 1, GETDATE()))
