create table students(
	studentID int primary key,
	firstname  varchar(50),
	marks int,
	DOB date,
);

insert into students(studentID,firstname,marks,DOB)
VALUES
(1,'amit',92,'2003-05-10'),
(2,'Neha',78,'2002-11-15'),
(3,'Rahul',61,'2004-01-20'),
(4,'Sneha',49,'2003-09-01');