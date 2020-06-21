-- https://leetcode.com/problems/rising-temperature/

SELECT [Id]
FROM (SELECT [Id], [Temperature] AS [T1], [RecordDate] AS [D1], LAG([Temperature], 1) OVER (ORDER BY [RecordDate] ASC) [T2], LAG([RecordDate], 1) OVER (ORDER BY [RecordDate] ASC) [D2]
  FROM [Weather]) [a]
WHERE [T1] > [T2] AND DATEDIFF(day, [D1], [D2] ) = -1