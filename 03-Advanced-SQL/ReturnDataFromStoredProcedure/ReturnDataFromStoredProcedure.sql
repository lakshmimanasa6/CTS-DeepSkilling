USE CompanyDB;
GO

CREATE PROCEDURE GetEmployeeCountByDepartment
    @Department VARCHAR(30)
AS
BEGIN
    SELECT COUNT(*) AS TotalEmployees
    FROM Employee
    WHERE Department = @Department;
END;
GO

EXEC GetEmployeeCountByDepartment @Department = 'HR';
GO