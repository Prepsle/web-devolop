use Startup

create table Menu (
MenuID int identity(1,1)primary key,
MenuName nvarchar(50),
IsActive bit,
ControllerName nvarchar(50),
ActiveName nvarchar(50),
Levels int,
ParentID int,
Link nvarchar(50),
MenuOrder int,
Position int );

create table Post (
PostID bigint identity(1,1) primary key,
Title nvarchar(50),
Abstract nvarchar(50),
Contents ntext,
Images nvarchar(200),
Link nvarchar(200),
Author nvarchar(30),
CreatedDate datetime,
IsActive bit,
PostOrder int,
MenuID int,
Category int,
Status int );

create table AdminMenu (
AdminMenuID bigint identity(1,1) primary key,
ItemName nvarchar(50),
ItemLevel int,
ParentLevel int,
ItemOrder int,
IsActive bit,
ItemTarget nvarchar(20),
AreaName nvarchar(20),
ControllerName nvarchar(20),
ActionName nvarchar(20),
Icon nvarchar(50),
IdName nvarchar(50) );