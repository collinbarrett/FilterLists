using System;

namespace FilterLists.Services.Snapshot
{
    public static class RawRuleLinterExtensions
    {
        public static string LintRawRule(this string rule)
        {
            rule = rule.Trim();
            rule = rule.DropIfEmpty();
            rule = rule?.DropIfTooLong();
            rule = rule?.DropIfComment();
            rule = rule?.DropIfContainsBackslashSingleQuote();
            rule = rule?.TrimSingleBackslashFromEnd();
            return rule;
        }

        private static string DropIfEmpty(this string rule) =>
            rule == string.Empty ? null : rule;
        
        private static string DropIfTooLong(this string rule) =>
            rule.Length > 8192 ? null : rule;
        
        private static string DropIfComment(this string rule) =>
            rule.StartsWith(@"!", StringComparison.Ordinal) && !rule.StartsWith(@"!#", StringComparison.Ordinal) ||
            rule.StartsWith(@"!##", StringComparison.Ordinal)
                ? null
                : rule;

        private static string DropIfContainsBackslashSingleQuote(this string rule) =>
            rule.Contains(@"\'") ? null : rule;

        private static string TrimSingleBackslashFromEnd(this string rule) =>
            rule.EndsWith(@"\", StringComparison.Ordinal) && !rule.EndsWith(@"\\", StringComparison.Ordinal)
                ? rule.Remove(rule.Length - 1)
                : rule;
    }
}