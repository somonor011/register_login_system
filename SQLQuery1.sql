create table tbl_user_login_register (
	id int primary key IDENTITY(1,1),
	username nvarchar(50) UNIQUE NOT NULL,
	user_pw nvarchar(50) NOT NULL
)

select * from dbo.tbl_user_login_register

