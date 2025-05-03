create table products(
	productID int primary key,
	productname varchar(100),
	price decimal(10, 2)
);

create table orders(
	orderID int primary key,
	productID int,
	quantity int,
	orderdate date,
	foreign key (productID) references products(productID)
);

insert into products (productID, productname, price)
values 
(1, 'Laptop', 70000.00),
(2, 'Smartphone', 30000.00),
(3, 'Tablet', 20000.00),
(4, 'Monitor', 15000.00);

insert into orders (orderID, productID, quantity, orderdate)
values
(101, 1, 2, '2024-12-01'),
(102, 2, 1, '2024-12-05'),
(103, 3, 3, '2024-12-10'),
(104, 1, 1, '2024-12-15'),
(105, 4, 2, '2024-12-20');

select 
	orders.orderID,
	products.productname,
	orders.quantity,
	products.price,
	(orders.quantity * products.price) as TotalAmount,
	orders.orderdate
from orders
inner join products on orders.productID = products.productID;

select 
	products.productID,
	products.productname,
	orders.orderID,
	orders.quantity,
	orders.orderdate
from products
left join orders on products.productID = orders.productID;

select 
	products.productID,
	products.productname,
	orders.orderID,
	orders.quantity,
	orders.orderdate
from products
right join orders on products.productID = orders.productID;

select
	products.productname,
	sum(orders.quantity) as totalunitsold
from orders
inner join products on orders.productID = products.productID
group by products.productname;
