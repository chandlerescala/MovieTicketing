create database DBSYS

use DBSYS

--Creates the user account table
CREATE TABLE UserAccount (
userId integer IDENTITY(1,1) primary key,
userName varchar (50) not null,
userPassword varchar (50) not null,
roleId int,
createdBy int,
userStatus varchar (10) not NULL default 'ACTIVE',
);
--To view the user account table

--Creates the user information table
CREATE TABLE UserInformation (
userInfoId integer IDENTITY(1,1) primary key,
userInfLname varchar (50) not null,
userInfFname varchar (50) not null,
userInfAddress varchar (50) not null default 'No Address',
userInfEmail varchar not null,
userId integer,
FOREIGN KEY (userId) REFERENCES UserAccount(userId)
)

CREATE TABLE Movie(
	movieId int IDENTITY(1,1) PRIMARY KEY,
	movieName varchar(MAX) NOT NULL,
	moviePrice int NOT NULL,
	movieReleaseYear int NOT NULL,
	movieGenre varchar(100) NOT NULL,
	movieDirector varchar(MAX) NOT NULL,
	moviePublisher varchar(MAX) NOT NULL,
	moviePathImg varchar(MAX) NOT NULL
)
SELECT * FROM Movie

CREATE TABLE [dbo].[Role](
	[roleId] [int] IDENTITY(1,1) NOT NULL,
	[roleName] [nvarchar](50) NULL,
	[roleDescription] [nvarchar](100) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[roleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

USE [DBSYS]
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([roleId], [roleName], [roleDescription]) VALUES (1, N'Customer', N'Customer ')
INSERT [dbo].[Role] ([roleId], [roleName], [roleDescription]) VALUES (2, N'Staff', N'Staff')
INSERT [dbo].[Role] ([roleId], [roleName], [roleDescription]) VALUES (3, N'Admin', N'Admin')
SET IDENTITY_INSERT [dbo].[Role] OFF

CREATE PROCEDURE sp_newUser @userName nvarchar(50), @userPassword nvarchar(50), @createdBy int
AS
INSERT INTO UserAccount(userName, userPassword, createdBy) 
	values (@userName, @userPassword, @createdBy)






