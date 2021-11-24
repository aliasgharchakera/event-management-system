create Table student(
idStudent INT NOT NULL,
stName VarChar(45) NOT NULL,
pwd VARCHAR(45) NOT NULL,
email VARCHAR(45) NOT NULL,
PRIMARY KEY(idStudent)
);

insert into student(idStudent,stName,pwd,email)
values(06423,'Uzair','hello','ma06423@st.habib.edu.pk')

select * from student