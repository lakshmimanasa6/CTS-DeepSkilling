CREATE PROCEDURE GetEmployees
AS
BEGIN
    SELECT * FROM Employees;
END;
GO

EXEC GetEmployees;