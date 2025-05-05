create procedure checkproductexist
	@productID int
as
begin
if exists (select 1 from products where productID = @productid)
	print 'product exist'
else
	print 'product does not exist'
end

// to execute 
exec checkproductexist @productid = 1;