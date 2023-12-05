create procedure sp_add_books
@Book_Name NVARCHAR(30),
@Author nvarchar(50),  
@Publication NVARCHAR(30),
@Purchase_date NVARCHAR(30),
@Book_Price NVARCHAR(30),
@Book_Quantity NVARCHAR(30)
AS
BEGIN
insert into books(Book_Name,Author,Publication,Purchase_Date,Book_Price, Book_Quantity)
values(@Book_Name,@Author,@Publication,@Purchase_date,@Book_Price,@Book_Quantity)

END

