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