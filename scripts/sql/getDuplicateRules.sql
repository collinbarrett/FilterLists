SELECT raw, COUNT(*) ct
FROM rules
GROUP BY raw
HAVING ct > 1;