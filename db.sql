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

--Creates the user information table
CREATE TABLE UserInformation(
userInfoId int IDENTITY(1,1) PRIMARY KEY,
userInfLname varchar (MAX) NOT NULL,
userInfFname varchar (MAX) NOT NULL,
userInfAddress varchar (MAX) NOT NULL DEFAULT 'No Address',
userInfEmail varchar(MAX) NOT NULL,
userId int,
FOREIGN KEY (userId) REFERENCES UserAccount(userId)
)
SELECT * FROM UserInformation
--Creates the movie table
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
--test
SELECT * FROM Movie

--Creates the Showtimes table
CREATE TABLE Showtimes(
    showtimeID int PRIMARY KEY,
    movieID int FOREIGN KEY REFERENCES Movie(movieID),
    showDate date NOT NULL,
    startTime time NOT NULL,
    endTime time NOT NULL,
    ticketsSold int NOT NULL,
    capacity int NOT NULL
)
--Creates the Tickets table
CREATE TABLE Tickets(
    ticketID int PRIMARY KEY,
    showtimeID int FOREIGN KEY REFERENCES Showtimes(showtimeID),
	sectionNumber int NOT NULL,
	rowNumber int NOT NULL,
    seatNumber int NOT NULL
)
--Creates the Sales table
CREATE TABLE Sales(
	salesID int PRIMARY KEY,
	ticketID int FOREIGN KEY REFERENCES Tickets(ticketID),
	transactionAmount int NOT NULL,
	transactionDate date NOT NULL,
	transactionTime time NOT NULL
)

--Creates the Role table
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





