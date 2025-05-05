select firstname,marks,
	case
		when marks>=90 then 'A'
		when marks>=75 then 'B'
		when marks>=60 then 'C'
		else 'D'
	end as grade
from students;

select name,salary,
	case
		when salary>=70000 then 'high'
		when salary>=50000 then 'medium'
		else 'low'
	end as salaryband
from employees;