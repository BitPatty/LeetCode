-- https://leetcode.com/problems/employees-earning-more-than-their-managers/

SELECT [a].[name] AS [Employee]
FROM [employee] [a]
        INNER JOIN [employee] [b]
        ON [a].[managerid] = [b].[id]
                AND [a].[salary] > [b].[salary] 