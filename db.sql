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
)


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
CREATE VIEW vw_UserDetails  AS
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
    capacity int NOT NULL
)
CREATE VIEW vw_ShowtimeDetails AS
SELECT s.ShowtimeID, s.movieID, m.movieName, s.showDate, s.startTime, s.endTime, s.capacity
FROM Showtimes s
JOIN Movie m 
ON s.movieID = m.movieId

CREATE PROCEDURE sp_UpdateShowtimes @ShowtimeID INT, @MovieID INT, @ShowDate DATE, @StartTime TIME, @EndTime TIME, @Capacity INT
AS
BEGIN
	UPDATE Showtimes
    SET movieID = @MovieID, showDate = @ShowDate, startTime = @StartTime, endTime = @EndTime, capacity = @Capacity
    WHERE ShowtimeID = @ShowtimeID;
END;

CREATE PROCEDURE sp_InsertShowtimes @MovieID INT, @ShowDate DATE, @StartTime TIME, @EndTime TIME, @Capacity INT
AS
BEGIN
    INSERT INTO Showtimes (movieID, showDate, startTime, endTime, capacity)
    VALUES (@MovieID, @ShowDate, @StartTime, @EndTime, @Capacity);
END;

CREATE PROCEDURE sp_DeleteShowtimes @ShowtimeID INT
AS
BEGIN
   DELETE FROM Showtimes WHERE ShowtimeID = @ShowtimeID;
END;



--Creates the Sales table
CREATE TABLE Sales (
    saleID INT PRIMARY KEY,
    showtimeID INT FOREIGN KEY REFERENCES Showtimes(showtimeID),
    customerName VARCHAR(100) NOT NULL,
    transactionDate DATETIME NOT NULL,
    movieID INT FOREIGN KEY REFERENCES Movie(movieID),    
	seatNumber INT NOT NULL,
    quantity INT NOT NULL,
    totalAmount DECIMAL(10, 2) NOT NULL,
    paidAmount DECIMAL(10, 2) NOT NULL,
    changeAmount DECIMAL(10, 2) NOT NULL,
    CONSTRAINT FK_Sales_Showtimes FOREIGN KEY (showtimeID) REFERENCES Showtimes(showtimeID),
    CONSTRAINT FK_Sales_Movie FOREIGN KEY (movieID) REFERENCES Movie(movieID)
);

SELECT * FROM Sales
CREATE PROCEDURE sp_InsertSales @ShowtimeID INT, @CustomerName VARCHAR(100), @TransactionDate DATETIME, @MovieID INT, @SeatNumber INT, @Quantity INT, @TotalAmount DECIMAL(10, 2), @PaidAmount DECIMAL(10, 2), @ChangeAmount DECIMAL(10, 2)
AS
BEGIN
    INSERT INTO Sales ( showtimeID, customerName, transactionDate, movieID, seatNumber, quantity, totalAmount, paidAmount, changeAmount)
    VALUES (@ShowtimeID,  @CustomerName, @TransactionDate,  @MovieID, @SeatNumber, @Quantity, @TotalAmount, @PaidAmount, @ChangeAmount);
END;

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

--CREATE PROCEDURE sp_newUser @userName nvarchar(50), @userPassword nvarchar(50), @createdBy int
--AS
--INSERT INTO UserAccount(userName, userPassword, createdBy) 
--	values (@userName, @userPassword, @createdBy)

CREATE PROCEDURE sp_UpdatedUsers
    @UserID INT,
    @UserName NVARCHAR(50),
    @UserPassword NVARCHAR(50)
AS
BEGIN
    UPDATE UserAccount
    SET UserName = @UserName, UserPassword = @UserPassword
    WHERE UserID = @UserID;
END;

CREATE PROCEDURE sp_RemovedUsers
    @UserID INT
AS
BEGIN
    DELETE FROM UserInformation WHERE UserID = @UserID;

    DELETE FROM UserAccount WHERE UserID = @UserID;
END;
	

-- Create a view to get transaction details for a user
CREATE VIEW vw_TransactionHistory
AS
SELECT s.saleID, s.showtimeID, st.movieID, m.movieName, s.customerName, s.transactionDate, s.seatNumber, s.quantity, s.totalAmount, s.paidAmount, s.changeAmount
FROM Sales s
JOIN Showtimes st 
ON s.showtimeID = st.showtimeID
JOIN Movie m 
ON st.movieID = m.movieId;


