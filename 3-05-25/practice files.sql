Create table students(
StudentID int primary key,
Firstname varchar(50),
Lastname varchar(50),
Age int,
Department varchar(50),
Marks int
);


INSERT INTO students (StudentID, Firstname, Lastname, Age, Department, Marks)
VALUES 
(1, 'Amit', 'sharma', 21, 'computer science', 85),
(2, 'Neha', 'Kumar', 22, 'Electronics', 78),
(3, 'Rahul', 'verma', 20, 'Mechanical', 66),
(4, 'Sneha', 'Singh', 23, 'computer science', 91);

SELECT TOP (1000) [studentID]
      ,[Firstname]
      ,[Lastname]
      ,[Age]
      ,[Department]
      ,[Marks]
  FROM [wipro_db].[dbo].[students]


select * from students
where department = 'computer science'

select firstname, marks from students
where marks>82

update students
set marks = 95
where studentid = 2

update students
set marks = 95
where studentid = 2;
update students
set marks = 90
where studentid = 1;

INSERT INTO students (StudentID, Firstname, Lastname, Age, Department, Marks)
VALUES 
(5, 'Ramya', 'Ane', 21, 'Electronics', 85),
(6, 'Soumya', 'Reddy', 22, 'Electrical', 90);

update students
set department = 'Civil'
where lastname = 'sharma'

delete from students where studentID = 4;

delete from students where marks<50;

delete from students where studentID = 4;
delete from students where studentID = 2;

truncate table students;

drop table students;
