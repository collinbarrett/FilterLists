SELECT
 FilterListId,
 ModifiedDateUtc - CreatedDateUtc As ProcessingTimeSecs,
 CreatedDateUtc,
 ModifiedDateUtc,
 WasSuccessful
FROM snapshots
WHERE ModifiedDateUtc - CreatedDateUtc > 30 OR IsCompleted = 0
ORDER BY ProcessingTimeSecs DESC