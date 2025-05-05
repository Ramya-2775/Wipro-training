select 
	name,
	department,
	salary,
	row_number() over(partition by department order by salary desc) as rownum
from employees;