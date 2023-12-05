create procedure issue_bookreport
@report nvarchar(30)
AS
BEGIN
IF(@report = 'Issue')
BEGIN
select * from issue_book where
 return_date = ''
 END
 ELSE if(@report = 'Return')
 BEGIN
 select * from issue_book where return_date !=''
 END
 END

