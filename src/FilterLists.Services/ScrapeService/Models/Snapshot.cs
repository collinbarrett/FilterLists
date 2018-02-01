using System;

namespace FilterLists.Services.ScrapeService.Models
{
    public class Snapshot
    {
        public string Content
        {
            set
            {
                if (value == null) return;
                var rawRules = value.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.RemoveEmptyEntries);
                for (var i = 0; i < rawRules.Length; i++)
                    rawRules[i] = LintStringForMySql(rawRules[i]);
                RawRules = rawRules;
            }
        }

        public int FilterListId { get; set; }

        public string[] RawRules { get; private set; }

        private static string LintStringForMySql(string rule)
        {
            rule = TrimSingleBackslashFromEnd(rule);
            rule = DropIfContainsBackslashSingleQuote(rule);
            return rule;
        }

        private static string TrimSingleBackslashFromEnd(string rule)
        {
            return rule.EndsWith(@"\") && !rule.EndsWith(@"\\") ? rule.Remove(rule.Length - 1) : rule;
        }

        private static string DropIfContainsBackslashSingleQuote(string rule)
        {
            //TODO: resolve issue and/or log rule
            return rule.Contains(@"\'") ? null : rule;
        }
    }
}