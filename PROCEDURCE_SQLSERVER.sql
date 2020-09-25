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

create proc UpdateLogin @username varchar(50),@userPassword nvarchar(50),@newuserPassword nvarchar(50)
as
begin
	if exists( select 1 from LOGIN_APP where userName=@username and userPassword=@userPassword)
	begin
		update LOGIN_APP set userPassword=@newuserPassword where userName=@username			
	end
	select @@ROWCOUNT as ResponseCode
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

create proc insert_Candidate @userName varchar(50),
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