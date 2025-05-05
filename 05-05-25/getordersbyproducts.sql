create procedure getordersbyproduct
	@productID int
as
begin
	select
	o.orderID,
	o.quantity,
	o.orderdate,
	p.productname,
	p.price
	from orders o
	inner join products p on o.productID = p.productID
	where o.productID = @productID;
end;

exec getordersbyproduct @productID =1;
select * from orders
