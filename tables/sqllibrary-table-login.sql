create database mySQLlibrary

use mySQLlibrary

CREATE TABLE Login_admin
(
    username NVARCHAR(20),
    password NVARCHAR(20),
    PRIMARY KEY (username, password)
);

insert into Login_admin (username,password)
values ('admin','admin123')

select * from Login_admin