-- Write your query below
SELECT name, 
COALESCE(SUM(R.distance), 0) AS travelled_distance
FROM users U
LEFT JOIN rides R
on U.id = R.user_id
Group by U.id, U.name
ORDER BY travelled_distance DESC,
U.name ASC;