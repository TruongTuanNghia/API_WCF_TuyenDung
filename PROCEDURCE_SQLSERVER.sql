create proc insert_Login @username varchar(50),@pas nvarchar(50),@status int,@type int
as
begin
	if not exists(select 1 from LOGIN_APP where userName=@username)
	begin
		declare @ketQuaBam varchar(50)
		set @ketQuaBam=(SELECT CONVERT(VARCHAR(50), HashBytes('MD5',@pas ), 2))
		insert into LOGIN_APP(userName,userPassword,statusLG,type)
		values(@username,@ketQuaBam,@status,@type)
	end
	select @@ROWCOUNT as ResponseCode
end

create proc DoLogin @username varchar(50) ,@password nvarchar(50)
as
begin
	declare @res int,@ketQuaBam varchar(50)
	set @ketQuaBam=(SELECT CONVERT(VARCHAR(50), HashBytes('MD5',@password ), 2))
	if exists( select 1 from LOGIN_APP where userName=@username and userPassword=@ketQuaBam)
	begin
		update LOGIN_APP set statusLG=1 where userName=@username
		set  @res =(select  LOGIN_APP.type from LOGIN_APP where userName=@username)		
	end
	else
	set @res=-1	
	select @res as ResponseCode
end

create proc UpdateLogin @username varchar(50),@userPassword nvarchar(50),@newuserPassword nvarchar(50)
as
begin
	begin try
			  SET XACT_ABORT  ON
				BEGIN TRANSACTION
				declare @ketQua int, @ketQuaBamMatKhauMoi nvarchar(50),@ketQuaBamMatKhauCu nvarchar(50)
				set @ketQuaBamMatKhauCu=(SELECT CONVERT(VARCHAR(50), HashBytes('MD5',@userPassword ), 2))
				set @ketQuaBamMatKhauMoi=(SELECT CONVERT(VARCHAR(50), HashBytes('MD5',@newuserPassword ), 2))
				if exists( select 1 from LOGIN_APP where userName=@username and userPassword=@ketQuaBamMatKhauCu)
				begin
					update LOGIN_APP set userPassword=@ketQuaBamMatKhauMoi where userName=@username			
				end
				COMMIT TRANSACTION
				set @ketQua=1								
	end try
			begin catch
				ROLLBACK TRANSACTION
				set @ketQua=0		
			end catch
	select @ketQua as ResponseCode
end

create proc InserEXPERIENCES    @idExperiences int,
								@idUser int,
								@title nvarchar(50),
								@nameCompanny nvarchar(100),
								@startDay date,
								@endDay date,
								@statusDoingJob bit,
								@note nvarchar(250)
							
as
begin
	insert into  EXPERIENCES(idExperiences,IdUser,Title,NameCompanny,StartDay,EndDay, StatusDoingJob, Note)
	values(@idExperiences,@idUser,@title,@nameCompanny,@startDay,@endDay,@statusDoingJob,@note)
	select @@ROWCOUNT as ResponseCode
end

create proc updateExperiences	@idExperiences int,
								@idUser int,
								@title nvarchar(50),
								@nameCompanny nvarchar(100),
								@startDay date,
								@endDay date,
								@statusDoingJob bit,
								@note nvarchar(250)
as
begin
  update EXPERIENCES set Title=@title, NameCompanny=@nameCompanny, StartDay=@startDay,EndDay=@endDay,StatusDoingJob=@statusDoingJob,Note=@note
  where idExperiences=@idExperiences and IdUser=@idUser
  select @@ROWCOUNT as ResponseCode
end

create proc deleteExperiences   @idExperiences int,
								@idUser int
as
begin
	if exists(select 1 from EXPERIENCES where idExperiences=@idExperiences and IdUser=@idUser)
	begin 
		delete EXPERIENCES where idExperiences=@idExperiences and IdUser=@idUser
	end
	select @@ROWCOUNT as ResponseCode
end

create proc GetListExperience @idUser int
as
begin
 select * from EXPERIENCES where IdUser=@idUser
end

create proc insert_Candidate @userName varchar(50), --userName la id login
							@FullName nvarchar(50),
							@Address nvarchar(MAX),
							@School nvarchar(100),
							@PhoneNumber int,
							@Email varchar(50),
							@Skill varchar(100),
							@Image nvarchar(MAX),
							@CareerGoal nvarchar(MAX),
							@DateBirth varchar(25),
							@Specialized nvarchar(MAX),
							@Interests nvarchar(250)
as
begin
 insert into CANDIDATES(userName,FullName,Address,School,PhoneNumber,Email,Skill,Image,CareerGoals,DateBirth,Specialized,Interests)
 values(@userName,@FullName,@Address,@School,@PhoneNumber,@Email,@Skill,@Image,@CareerGoal,@DateBirth,@Specialized,@Interests)
 	select @@ROWCOUNT as ResponseCode
end

create proc update_Candidate @userName varchar(50),
							@FullName nvarchar(50),
							@Address nvarchar(MAX),
							@School nvarchar(100),
							@PhoneNumber int,
							@Email varchar(50),
							@Skill varchar(100),
							@Image nvarchar(MAX),
							@CareerGoal nvarchar(MAX),
							@DateBirth varchar(25),
							@Specialized nvarchar(MAX),
							@Interests nvarchar(250)
as
begin
	update CANDIDATES set FullName=@FullName,Address=@Address,School=@School,PhoneNumber=@PhoneNumber,Email=@Email,
	Skill=@Skill,Image=@Image,CareerGoals=@CareerGoal,DateBirth=@DateBirth,Specialized=Specialized,@Interests=Interests
	where userName=@userName
	select @@ROWCOUNT as ResponseCode
end

create proc getCandidate @idUser int
as
begin
	declare @usname varchar(50)
	set @usname=(select userName from LOGIN_APP where id=@idUser)
	select * from CANDIDATES c,EXPERIENCES e where  c.userName=@usname and e.IdUser=@idUser
end

create proc deleteLogin @idUser int
as
begin
begin try
			  SET XACT_ABORT  ON
				BEGIN TRANSACTION
				declare @usname varchar(50),@ketQua int
				set @usname=(select userName from LOGIN_APP where id=@idUser)
				delete EXPERIENCES where IdUser=@idUser
				delete CANDIDATES where UserName=@usname
				delete LOGIN_APP  where  id=@idUser
				COMMIT TRANSACTION
				set @ketQua=1								
	end try
			begin catch
				ROLLBACK TRANSACTION
				set @ketQua=0		
			end catch
	select @ketQua as ResponseCode
end

create proc insertCompany  @fullname nvarchar(200), 
							@idcompany int,
							@address nvarchar(100),
							@email nvarchar(50),
							@phonenumber int,
							@node nvarchar(max),
							@image varchar(100)
as
begin
 if not exists(select 1 from COMPANYS where IdCompany=@idcompany)
 begin
	insert into COMPANYS(IdCompany,FullName,Address,Email,PhoneNumber,Node,image)
	values(@idcompany,@fullname,@address,@email,@phonenumber,@node,@idcompany)
 end
 select @@ROWCOUNT as ResponseCode
end  

create proc updateCompany @fullname nvarchar(200), 
							@idcompany int,
							@address nvarchar(100),
							@email nvarchar(50),
							@phonenumber int,
							@node nvarchar(max),
							@image varchar(100)
as
begin
	update COMPANYS set FullName=@fullname,Address=@address,Email=@email,PhoneNumber=@phonenumber,
	Node=@node,image=@idcompany where IdCompany=@idcompany
	select @@ROWCOUNT as ResponseCode
end