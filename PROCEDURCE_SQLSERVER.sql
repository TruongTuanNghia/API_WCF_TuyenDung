create proc insert_Login @username varchar(50),@pas nvarchar(50),@status int,@type int
as
begin
	if not exists(select 1 from LOGIN_APP where userName=@username)
	begin
		insert into LOGIN_APP(userName,userPassword,statusLG,type)
		values(@username,@pas,@status,@type)
	end
	select @@ROWCOUNT as ResponseCode
end

create proc DoLogin @username varchar(50) ,@password nvarchar(50)
as
begin
	declare @res int
	if exists( select 1 from LOGIN_APP where userName=@username and userPassword=@password)
	begin
		update LOGIN_APP set statusLG=1 where userName=@username
		set  @res =(select LOGIN_APP.type from LOGIN_APP where userName=@username)		
	end
	else
	set @res=-1	
	select @res as ResponseCode
end
