SELECT Raw, COUNT(*) 'Count'
FROM rules
GROUP BY Raw COLLATE utf8mb4_bin --override default utf8mb4_unicode_520_ci
HAVING COUNT > 1;