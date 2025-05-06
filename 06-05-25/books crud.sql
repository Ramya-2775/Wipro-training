create table books(
	BookID int primary key ,
	Title varchar(50),
	Author varchar(50),
	Genre varchar(50),
	price Decimal(8,2),
	publishedyear int
);

Insert into books(BookID, Title, Author, Genre, Price, Publishedyear)
Values 
(1,'Think like a monk', 'Jayshetty', 'spirutuality', 700, 2020),
(2,'The boy who loved', 'Durjoy Datta', 'Contemporary fiction', 800, 2017);

Select * from books
select title, Author from books;
select * from books where genre = 'fiction';

update books
set price = 380.99
where bookID = 1;

delete from books 
where bookID = 1;





