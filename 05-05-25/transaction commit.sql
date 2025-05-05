begin transaction ;
update employees
set salary = salary +2000
where department = 'IT';
commit;

