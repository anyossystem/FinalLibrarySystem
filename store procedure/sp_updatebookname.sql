CREATE PROCEDURE updatebookname
    @BookID INT,
    @NewBookName NVARCHAR(30),
    @NewAuthor NVARCHAR(50),
    @NewPublication NVARCHAR(50),
    @NewPurchaseDate DATE,
    @NewBookPrice DECIMAL(10, 2),
    @NewBookQuantity INT
AS
BEGIN
    UPDATE books
    SET 
        Book_Name = @NewBookName,
        Author = @NewAuthor,
        Publication = @NewPublication,
        Purchase_date = @NewPurchaseDate,
        Book_Price = @NewBookPrice,
        Book_Quantity = @NewBookQuantity
    WHERE 
        Book_ID = @BookID;
END


select * from books