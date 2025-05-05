select 
	name,
	department,
	salary,
	rank() over( order by salary desc) as rankbysalary
from employees;