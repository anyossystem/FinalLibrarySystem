create procedure ViewBooks
@Book_Name NVARCHAR(50)
AS
BEGIN
IF (@Book_Name='')
BEGIN
select * from books
END
ELSE
BEGIN
select * from books where Book_Name=@Book_Name
END

END
