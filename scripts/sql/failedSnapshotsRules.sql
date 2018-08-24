SELECT snapshotid, COUNT(*)
FROM snapshots_rules
JOIN snapshots ON snapshots_rules.snapshotid = snapshots.id
WHERE snapshots.wassuccessful = FALSE
GROUP BY snapshots.id