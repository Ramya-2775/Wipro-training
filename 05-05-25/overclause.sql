select 
	name,
	department,
	salary,
	avg(salary) over() as avgsalary
from employees;