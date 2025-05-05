create procedure getallproducts
as
begin
select*from products;
end;

exec getallproducts