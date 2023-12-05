create view studentdetails
as
select
    Student_ID,
    Student_Name,
    Enrollment_Number,
    Department,
    Contact,
    Email,
    Semester
from students;

select * from studentdetails

create view student
as
select
    Student_ID,
    Enrollment_Number,
    Department,
    Semester
from students;

select * from student