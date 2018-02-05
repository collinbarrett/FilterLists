using System.Collections.Generic;
using System.Linq;
using FilterLists.Data;
using FilterLists.Data.Entities;
using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.SnapshotService
{
    public class SnapshotBatchDe
    {
        private readonly FilterListsDbContext dbContext;
        private readonly IEnumerable<string> rawRules;
        private readonly Snapshot snapshot;
        private IEnumerable<Rule> newSnapshotRules;
        private IEnumerable<Rule> preExistingSnapshotRules;

        public SnapshotBatchDe(FilterListsDbContext dbContext, Snapshot snapshot, IEnumerable<string> rawRules)
        {
            this.dbContext = dbContext;
            this.snapshot = snapshot;
            this.rawRules = rawRules;
        }

        public void SaveSnapshotBatch()
        {
            AddNewRules();
            AddSnapshotRules();
            dbContext.SaveChanges();
        }

        private void AddNewRules()
        {
            preExistingSnapshotRules = dbContext.Rules.Where(rule => rawRules.Contains(rule.Raw));
            var newSnapshotRawRules = rawRules.Except(preExistingSnapshotRules.Select(x => x.Raw));
            newSnapshotRules = newSnapshotRawRules.Select(newSnapshotRawRule => new Rule {Raw = newSnapshotRawRule})
                                                  .ToList();
            dbContext.Rules.AddRange(newSnapshotRules);
        }

        private void AddSnapshotRules()
        {
            if (snapshot.SnapshotRules == null)
                snapshot.SnapshotRules = new List<SnapshotRule>();
            snapshot.SnapshotRules.AddRange(preExistingSnapshotRules
                                            .Concat(newSnapshotRules)
                                            .Select(rule => new SnapshotRule {Rule = rule, Snapshot = snapshot})
                                            .ToList());
        }
    }

    public static class CollectionExtensions
    {
        public static void AddRange<T>(this ICollection<T> destination, IEnumerable<T> source)
        {
            foreach (var item in source)
                destination.Add(item);
        }
    }
}