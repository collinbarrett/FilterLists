using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilterLists.Data;
using FilterLists.Data.Entities;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Extensions;

namespace FilterLists.Services.Snapshot
{
    public class SnapshotBatchDe
    {
        private readonly FilterListsDbContext _dbContext;
        private readonly IEnumerable<string> _rawRules;
        private readonly Data.Entities.Snapshot _snapshot;
        private IQueryable<Rule> _rules;

        public SnapshotBatchDe(FilterListsDbContext dbContext, Data.Entities.Snapshot snapshot,
            IEnumerable<string> rawRules)
        {
            _dbContext = dbContext;
            _snapshot = snapshot;
            _rawRules = rawRules;
        }

        public async Task SaveSnapshotBatchAsync()
        {
            AddRules();
            AddSnapshotRules();
            await _dbContext.SaveChangesAsync();
        }

        private void AddRules()
        {
            var existingRules = _dbContext.Rules.Where(rule => _rawRules.Contains(rule.Raw));
            var newRawRules = _rawRules.Except(existingRules.Select(r => r.Raw));
            var newRules = newRawRules.Select(newRawRule => new Rule {Raw = newRawRule}).ToList();
            _dbContext.Rules.AddRange(newRules);
            _rules = existingRules.Concat(newRules);
        }

        private void AddSnapshotRules()
        {
            var snapshotRules = new List<SnapshotRule>();
            foreach (var rule in _rules)
                snapshotRules.Add(new SnapshotRule {Rule = rule});
            if (_snapshot.AddedSnapshotRules == null)
                _snapshot.AddedSnapshotRules = new List<SnapshotRule>();
            _snapshot.AddedSnapshotRules.AddRange(snapshotRules);
        }
    }
}