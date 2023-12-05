create procedure sp_LoginAdmin
@inputusername nvarchar(20),
@inputpassword nvarchar(20)
AS
BEGIN
select * from Login_admin where username=@inputusername and password = @inputpassword
END