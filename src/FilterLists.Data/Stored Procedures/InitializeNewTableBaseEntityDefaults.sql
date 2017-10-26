--TODO: Possibly convert to stored procedure
ALTER TABLE
    filterlistsdata.FilterList MODIFY COLUMN CreatedDateUtc DATETIME DEFAULT CURRENT_TIMESTAMP NOT NULL;
ALTER TABLE
    filterlistsdata.FilterList MODIFY COLUMN ModifiedDateUtc DATETIME DEFAULT NULL;
ON
UPDATE
    CURRENT_TIMESTAMP;