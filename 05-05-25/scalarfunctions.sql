select firstname, upper(firstname) as uppername from students;

select firstname,datediff(year,dob,getdate())as age from students;

select name,round(salary,-3) as roundedsalary from employees;