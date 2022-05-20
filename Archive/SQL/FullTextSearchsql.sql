CREATE DATABASE MySearchDB
go
USE MySearchDB

CREATE TABLE MyTBSearch ( 
SearchId INT PRIMARY KEY IDENTITY,
Title NVARCHAR(MAX),	
[Description] NVARCHAR(max)
)

go
INSERT INTO dbo.MyTBSearch
(Title, Description)
VALUES
(   N'Best city', -- Title - nvarchar(max)
    N'Mashhad,Tehran,Bandar,Shiraz and ...'  -- Description - nvarchar(max)
    )
	
INSERT INTO dbo.MyTBSearch
(Title,Description)
VALUES
(   N'Best city', -- Title - nvarchar(max)
    N'Mashhad,Tehran,Bandar,Shiraz and ...'  -- Description - nvarchar(max)
    )

INSERT INTO dbo.MyTBSearch
(Title,Description)
VALUES
(   N'Best city', -- Title - nvarchar(max)
    N'Mashhad,Tehran,Bandar,Shiraz and ...'  -- Description - nvarchar(max)
    )
	GO    
	
SELECT * FROM dbo.MyTBSearch WHERE [Description] = N'Tehran' -- No result
SELECT * FROM dbo.MyTBSearch WHERE [Description] LiKE N'%Tehran%' -- Worked
SELECT * FROM dbo.MyTBSearch WHERE [Description] LiKE N'%Tehran Mashhad%' -- No result
SELECT * FROM dbo.MyTBSearch WHERE FREETEXT ([Description], N'Tehran Mashhad') -- Worked  -- Used FullTextSearch

SELECT SERVERPROPERTY('IsFullTextInstalled')  -- Check installed fullTextSearch service