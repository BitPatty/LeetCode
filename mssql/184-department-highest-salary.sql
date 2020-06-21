-- https://leetcode.com/problems/department-highest-salary/

WITH
  [Max_Salary]
  AS
  (
    SELECT [DepartmentId], MAX([Salary]) AS [Salary]
    FROM [Employee]
    GROUP BY [DepartmentId]
  )
SELECT [Department].[Name] AS [Department], [Employee].[Name] AS [Employee], [Employee].[Salary] AS [Salary]
FROM [Department]
  INNER JOIN [Max_Salary] ON [Department].[Id] = [Max_Salary].[DepartmentId]
  INNER JOIN [Employee] ON [Max_Salary].[DepartmentId] = [Employee].[DepartmentId] AND [Max_Salary].[Salary] = [Employee].[Salary]