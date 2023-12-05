create table issue_book
(
Issue_ID int identity (1,1) PRIMARY KEY not null,
Student_Name nvarchar (50) not null,
Enrollment_No nvarchar (50) not null,
Department nvarchar (50) not null,
Contact nvarchar (50) not null,
Email nvarchar (50) not null,
BookName nvarchar (50) not null,
Issue_Date nvarchar (50) not null,
)

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
