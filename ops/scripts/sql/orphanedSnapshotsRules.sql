SELECT SnapshotId, COUNT(*)
FROM snapshots_rules
JOIN snapshots ON snapshots_rules.SnapshotId = snapshots.Id
WHERE snapshots.WasSuccessful = FALSE
GROUP BY snapshots.Id;