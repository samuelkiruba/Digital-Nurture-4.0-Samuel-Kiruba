CREATE DATABASE SHOP;

USE SHOP;

CREATE TABLE Products(
ProductID int,
ProductName varchar(50),
Category varchar(50),
Price int
);

INSERT INTO Products(ProductID, ProductName, Category, Price)
VALUES
(1, 'Laptop', 'Hardware', 50000),
(2, 'Monitor', 'Hardware', 10000),
(3, 'RTX 5090', 'Hardware', 100000),
(4, 'Windows 11 License', 'Software', 5000),
(5, 'Intel i7-HX', 'Hardware', 100000),
(6, 'Windows 10 License', 'Software', 5000);

SELECT *
FROM (
    SELECT 
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
    FROM Products
) AS Ranked
WHERE RowNum <= 3;