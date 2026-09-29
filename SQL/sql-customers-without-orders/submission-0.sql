-- Write your query below
SELECT C.name
FROM customers C
LEFT JOIN orders O
ON C.id = O.customer_id
WHERE O.id is null