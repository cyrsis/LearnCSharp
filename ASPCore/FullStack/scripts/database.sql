CREATE DATABASE Cubo
USE Cubo

CREATE TABLE Buckets (
	Id uniqueidentifier primary key not null,
	Name nvarchar(100) not null,
	CreatedAt datetime not null
)

CREATE TABLE Items (
	Id uniqueidentifier primary key not null,
    BucketId uniqueidentifier not null FOREIGN KEY REFERENCES Buckets(Id),
	[Key] nvarchar(100) not null,
    Value nvarchar(MAX) not null
)

SELECT * FROM Buckets;
SELECT * FROM Items;

DELETE FROM Items;
DELETE FROM Buckets;