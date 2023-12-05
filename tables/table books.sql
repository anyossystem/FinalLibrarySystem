
	CREATE TABLE books
(
    Book_ID INT not null  IDENTITY(1,1) PRIMARY KEY,
    Book_Name NVARCHAR(50)not null,
    Author nvarchar(50)not null,  
    Publication NVARCHAR(50)not null,
    Purchase_date NVARCHAR(50)not null,
    Book_Price NVARCHAR(50)not null,
    Book_Quantity NVARCHAR(50)not null,
)


select * from books

