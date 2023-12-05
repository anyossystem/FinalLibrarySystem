create procedure sp_add_students
@Student_Name NVARCHAR(50),
@Enrollment_Number NVARCHAR(20),
@Department NVARCHAR(50),
@Contact NVARCHAR(30),
@Email NVARCHAR(50),
@Semester NVARCHAR(25)
AS
BEGIN
      insert into students (Student_Name,Enrollment_Number,Department,Contact,Email,Semester)
	  values(@Student_Name,@Enrollment_Number,@Department,@Contact,@Email,@Semester)
END