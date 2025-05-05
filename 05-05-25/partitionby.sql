select
	name,
	department,
	salary,
	avg(salary) over(partition by department) as deptavgsalary
from employees;