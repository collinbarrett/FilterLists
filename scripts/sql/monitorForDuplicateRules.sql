SELECT raw, COUNT(*) ct
FROM rules
GROUP BY raw
HAVING c > 1;