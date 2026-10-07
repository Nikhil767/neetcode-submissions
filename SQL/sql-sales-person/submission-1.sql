-- Write your query below
SELECT SP.name
FROM sales_person SP
WHERE NOT EXISTS (
    SELECT 1
    FROM orders O
    JOIN company C ON C.com_id = O.com_id
    WHERE O.sales_id = SP.sales_id AND C.name = 'CRIMSON'
);

-- NOT WORKING
-- SELECT SP.name
-- FROM sales_person SP
-- LEFT JOIN orders O
-- ON SP.sales_id = O.sales_id
-- LEFT JOIN company C
-- ON C.com_id = O.com_id AND C.name = 'CRIMSON'
-- WHERE C.com_id IS NULL
-- ORDER BY SP.NAME