CREATE DATABASE SalesDB
GO

USE SalesDB
GO

CREATE TABLE Products (
ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
ProductName VARCHAR(120) NOT NULL,
Stock INT NOT NULL,
Price FLOAT NOT NULL 
)

INSERT INTO Products VALUES('Leche', 10, 32.00), ('Fideos', 23, 21.00), ('Arroz', 15, 18.00)

SELECT * FROM Products