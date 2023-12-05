create procedure return_book
@ID nvarchar(30),
@return_date nvarchar(30)
AS
BEGIN
 update issue_book set return_date = @return_date where Issue_ID = @ID
 END

drop procedure return_book