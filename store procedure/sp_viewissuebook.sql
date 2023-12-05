create procedure sp_viewissuebook
@EnrollmentNo nvarchar (50)
AS
BEGIN
if(@EnrollmentNo = '')
BEGIN
select * from issue_book
END
ELSE
BEGIN
select * from issue_book where Enrollment_No=@EnrollmentNo
END

end