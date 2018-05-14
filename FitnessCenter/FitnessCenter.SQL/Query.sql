use FitnessCenter
go

CREATE TABLE Users 
(
	[UserID] int PRIMARY KEY identity(1,1),
	[FirstName] nvarchar(50) NOT NULL,
	[LastName] nvarchar(50) NOT NUll,
	[BirthDate] date NOT NULL
)
GO

create table Subscriptions
		(SubscriptionID INT PRIMARY KEY NOT NULL identity(1,1),
		[NameService]  NVARCHAR(50) NOT null,
		[Description]  NVARCHAR(250))
go

create table SubscriptionsOfUsers 
		(ID_User INT NOT NULL,
		 ID_Subscription INT NOT Null,
		CONSTRAINT PK_SubscriptionsOfUsers Primary key (ID_User, ID_Subscription),
		CONSTRAINT FK_SubscriptionsOfUsers_Users foreign key (ID_User) references Users(UserID) on delete cascade,
		CONSTRAINT FK_SubscriptionsOfUsers_Subscriptions foreign key (ID_Subscription) references Subscriptions(SubscriptionID) on delete cascade)
GO

INSERT INTO Users 
	VALUES
('Дмитриева', 'Анна', '23.09.1990'),
('Свирин', 'Вячеслав', '08.04.1997'),
('Петрухина', 'Ярослава', '17.07.1994')
go

Insert into Subscriptions values
('Стрейчинг', 'Расстяжка'),
('Кардио', '')
go

Insert into SubscriptionsOfUsers values
(1, 2),
(2, 1),
(2, 2)


select Users.[FirstName], Users.[LastName], Subscriptions.NameService
from (SubscriptionsOfUsers left join Users on ID_User = UserID) 
		left join Subscriptions on SubscriptionsOfUsers.ID_Subscription = Subscriptions.SubscriptionID 
go

 create Proc AddUser
(@firstName nvarchar(50), @lastName nvarchar(50), @birthdate date, @ids [intTable] READONLY)
as
declare @usersID table(id int)
declare @userID int
insert into Users
Output inserted.UserID into @usersID
 values (@firstName, @lastName, @birthDate)
 set @userID = (select * from @usersID)
 insert into SubscriptionsOfUsers select @userID, id from @ids
 go

create Proc UpdateUser
(@id int,@firstName nvarchar(50), @lastName nvarchar(50), @birthDate date, @ids [intTable] readOnly)
as
delete 
from SubscriptionsOfUsers 
where ID_User = @id
update Users
set [FirstName] = @firstName,
[LastName] = @lastName,
[BirthDate] = @birthDate
where UserID = @id 
insert into SubscriptionsOfUsers select @id, id from @ids
go

create proc DeleteUser (@id int)
as 
delete
from Users
Where UserID = @id
go

create proc AddSubscription (@nameService nvarchar(50), @description nvarchar(150))
as
insert into Subscriptions values (@nameService, @description)
go

create proc UpdateSubscription
(@id int,@nameService nvarchar(50), @description nvarchar(150))
as
update Subscriptions
set [NameService] = @nameService,
[Description] = @description
where SubscriptionID = @id 
go

create proc DeleteSubscription (@id int)
as 
delete
from Subscriptions
Where SubscriptionID = @id
go

create proc GetUsers
as 
select Users.UserID,Users.FirstName, Users.LastName, Users.BirthDate
from Users
go

create proc GetSubscriptions
as 
select SubscriptionID,NameService,[Description]
from Subscriptions
go

create proc GetUserById (@id int)
as
select UserID,FirstName, LastName, BirthDate
from Users
where UserID=@id
go

create proc GetSubscriptionById (@id int)
as
select SubscriptionID,NameService, [Description]
from Subscriptions
where SubscriptionID=@id
go

create type [intTable] 
as Table([id] int)
go

create proc ShowSubscriptionsOfUser (@id int)
as
select SubscriptionID
from Subscriptions right join SubscriptionsOfUsers on  SubscriptionID=ID_Subscription
where ID_User=@id
go


