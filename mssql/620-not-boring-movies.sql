-- https://leetcode.com/problems/not-boring-movies/

SELECT *
FROM [cinema]
WHERE [Id] % 2 = 1 AND [description] <> 'boring'
ORDER BY [rating] DESC