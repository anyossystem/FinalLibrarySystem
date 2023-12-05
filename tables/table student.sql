create table students
(
    Student_ID INT IDENTITY(1,1) PRIMARY KEY,
    Student_Name NVARCHAR(50),
    Enrollment_Number NVARCHAR(20),
    Department NVARCHAR(50),
    Contact NVARCHAR(30),
    Email NVARCHAR(50),
    Semester NVARCHAR(25)
);

select * from students
