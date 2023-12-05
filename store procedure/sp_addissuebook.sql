create procedure sp_addissuebook
@Student_Name nvarchar (50) ,
@Enrollment_No nvarchar (50) ,
@Department nvarchar (50) ,
@Contact nvarchar (50) ,
@Email nvarchar (50) ,
@BookName nvarchar (50) ,
@Issue_Date nvarchar (50) 
AS
BEGIN

insert into issue_book (Student_Name, Enrollment_No,Department, Contact, Email, BookName ,Issue_Date )
values(@Student_Name ,@Enrollment_No,@Department,@Contact, @Email, @BookName ,@Issue_Date )

END

select * from issue_book