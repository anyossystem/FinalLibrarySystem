create procedure viewstudents
@EnrollmentNo NVARCHAR(20)
AS
BEGIN
IF (@EnrollmentNo='')
BEGIN
select * from students
END
ELSE
BEGIN
select * from students where Enrollment_Number=@EnrollmentNo
END

END