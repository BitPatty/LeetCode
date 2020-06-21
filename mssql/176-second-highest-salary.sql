-- https://leetcode.com/problems/second-highest-salary

WITH
  [Indexed_Salary]
  AS
  (
    SELECT [Salary], ROW_NUMBER() OVER (ORDER BY [Salary] DESC) [Nr]
    FROM [Employee]
    GROUP BY [Salary]
  ),
  [Rows]
  AS
  (
    SELECT [Value]
    FROM (VALUES(2)) [a]([Value])
  )
SELECT [Indexed_Salary].[Salary] AS 'SecondHighestSalary'
FROM [Rows] LEFT JOIN [Indexed_Salary] ON [Rows].[Value] = [Indexed_Salary].[Nr]