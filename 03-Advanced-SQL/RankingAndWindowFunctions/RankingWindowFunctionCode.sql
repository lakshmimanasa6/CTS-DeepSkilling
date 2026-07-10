USE CompanyDB;
GO

-- Verify data
SELECT * FROM Products;
GO

-- ROW_NUMBER
SELECT
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER(
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RowNumber
FROM Products;
GO

-- RANK
SELECT
    ProductName,
    Category,
    Price,
    RANK() OVER(
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS ProductRank
FROM Products;
GO

-- DENSE_RANK
SELECT
    ProductName,
    Category,
    Price,
    DENSE_RANK() OVER(
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS DenseRank
FROM Products;
GO