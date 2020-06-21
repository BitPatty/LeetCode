-- https://leetcode.com/problems/department-top-three-salaries/

WITH
  [Max_Salary]
  AS
  (
    SELECT *
    FROM (SELECT [DepartmentId], [Salary], RANK() OVER (PARTITION BY [DepartmentId] ORDER BY [Salary] DESC) AS [R]
      FROM [Employee]
      GROUP BY [Salary], [DepartmentId]) [a]
    WHERE [R] < 4
  ),
  [Best_Earning_Employee]
  AS
  (
    SELECT [Employee].*
    FROM [Max_Salary] LEFT JOIN [Employee] ON [Max_Salary].[DepartmentId] = [Employee].[DepartmentId] AND [Max_Salary].[Salary] = [Employee].[Salary]
  )
SELECT [Department].[Name] AS [Department], [Best_Earning_Employee].[Name] AS [Employee], [Best_Earning_Employee].[Salary] AS [Salary]
FROM [Department]
  INNER JOIN [Best_Earning_Employee] ON [Department].[Id] = [Best_Earning_Employee].[DepartmentId]
ORDER BY [Department].[Id] ASC, [Best_Earning_Employee].[Salary] DESC, [Best_Earning_Employee].[Id] ASC