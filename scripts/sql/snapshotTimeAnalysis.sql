SELECT
 FilterListId,
 ModifiedDateUtc - CreatedDateUtc AS ProcessingTimeSecs,
 CreatedDateUtc,
 ModifiedDateUtc,
 WasSuccessful
FROM snapshots
WHERE ModifiedDateUtc - CreatedDateUtc > 30 OR WasSuccessful = 0
ORDER BY ProcessingTimeSecs DESC;