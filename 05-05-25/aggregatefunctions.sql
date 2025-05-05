select count(*) as totalstudents from students;

select avg(marks) as averagemarks from students;

select department,max(salary) as highestsalary
from employees 
group by department;
