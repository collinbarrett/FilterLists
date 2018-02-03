namespace FilterLists.Services.SnapshotService
{
    public static class RawRuleLinterExtensions
    {
        public static string LintStringForMySql(this string rule)
        {
            rule = rule.TrimSingleBackslashFromEnd();
            rule = rule.DropIfContainsBackslashSingleQuote();
            rule = rule.DropIfTooLong();
            return rule;
        }

        private static string TrimSingleBackslashFromEnd(this string rule)
        {
            if (rule != null)
                return rule.EndsWith(@"\") && !rule.EndsWith(@"\\") ? rule.Remove(rule.Length - 1) : rule;
            return null;
        }

        private static string DropIfContainsBackslashSingleQuote(this string rule)
        {
            //TODO: resolve issue and/or track dropped rule
            if (rule != null)
                return rule.Contains(@"\'") ? null : rule;
            return null;
        }

        private static string DropIfTooLong(this string rule)
        {
            //TODO: resolve issue and/or track dropped rule
            return rule?.Length > 8192 ? null : rule;
        }
    }
}