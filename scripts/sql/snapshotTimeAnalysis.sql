SELECT
FilterListId,
 ModifiedDateUtc - CreatedDateUtc,
 CreatedDateUtc,
 ModifiedDateUtc,
 IsCompleted
FROM snapshots
WHERE ModifiedDateUtc - CreatedDateUtc > 30 OR IsCompleted = 0
ORDER BY ModifiedDateUtc - CreatedDateUtc DESC