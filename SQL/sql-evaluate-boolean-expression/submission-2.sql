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


-- Dynamic SQL Solution

-- WITH resolved AS (
--     SELECT 
--         e.left_operand,
--         e.operator,
--         e.right_operand,
--         v1.value AS left_value,
--         v2.value AS right_value,
--         '(' || v1.value || ' ' || e.operator || ' ' || v2.value || ')' AS expr
--     FROM expressions e
--     JOIN variables v1 ON e.left_operand = v1.name
--     JOIN variables v2 ON e.right_operand = v2.name
-- ),
-- evaluated AS (
--     SELECT 
--         left_operand,
--         operator,
--         right_operand,
--         left_value,
--         right_value,
--         expr,
--         (SELECT eval(expr)) AS result
--     FROM resolved
-- )
-- SELECT
--     left_operand,
--     operator,
--     right_operand,
--     CASE WHEN result THEN 'true' ELSE 'false' END AS value
-- FROM evaluated;
