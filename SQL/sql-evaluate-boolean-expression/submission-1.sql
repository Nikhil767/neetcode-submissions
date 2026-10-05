-- Write your query below
SELECT 
    e.left_operand,
    e.operator,
    e.right_operand,
    CASE 
        WHEN e.operator = '>' AND v1.value > v2.value THEN 'true'
        WHEN e.operator = '<' AND v1.value < v2.value THEN 'true'
        WHEN e.operator = '=' AND v1.value = v2.value THEN 'true'
        ELSE 'false'
    END AS value
FROM expressions e
JOIN variables v1 ON e.left_operand = v1.name
JOIN variables v2 ON e.right_operand = v2.name;

-- with using SIGN
-- SELECT
--     e.left_operand,
--     e.operator,
--     e.right_operand,
--     CASE
--         WHEN e.operator = '>'  AND SIGN(v1.value - v2.value) = 1 THEN 'true'
--         WHEN e.operator = '<'  AND SIGN(v1.value - v2.value) = -1 THEN 'true'
--         WHEN e.operator = '='  AND SIGN(v1.value - v2.value) = 0 THEN 'true'
--         WHEN e.operator = '>=' AND SIGN(v1.value - v2.value) IN (0, 1) THEN 'true'
--         WHEN e.operator = '<=' AND SIGN(v1.value - v2.value) IN (0, -1) THEN 'true'
--         WHEN e.operator = '!=' AND SIGN(v1.value - v2.value) <> 0 THEN 'true'
--         ELSE 'false'
--     END AS value
-- FROM expressions e
-- JOIN variables v1 ON e.left_operand = v1.name
-- JOIN variables v2 ON e.right_operand = v2.name;
