create procedure getproductsbyrevenue
	@productID int 
as
begin
	select 
		@productID as productID,
		sum(o.quantity * p.price) as totalrevenue
	from orders o 
	inner join products p on o.productID = p.productID
	where o.productID = @productID
end;