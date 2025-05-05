create table employees(
	EmpID int primary key,
	name varchar(50),
	Department varchar(50),
	Salary decimal(10,2),
	Joindate Date
);

insert into employees(EmpID,name, Department, Salary, Joindate)
VALUES
(1,'John','HR',50000,'2021-06-01'),
(2,'Priya','Finance',60000,'2020-09-15'),
(3,'Amit','IT',75000,'2019-01-10'),
(4,'Sara','IT',72000,'2023-02-05');