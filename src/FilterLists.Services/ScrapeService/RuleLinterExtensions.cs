namespace FilterLists.Services.ScrapeService
{
    public static class RuleLinterExtensions
    {
        public static string LintStringForMySql(this string rule)
        {
            rule = rule.TrimSingleBackslashFromEnd();
            rule = rule.DropIfContainsBackslashSingleQuote();
            return rule;
        }

        private static string TrimSingleBackslashFromEnd(this string rule)
        {
            return rule.EndsWith(@"\") && !rule.EndsWith(@"\\") ? rule.Remove(rule.Length - 1) : rule;
        }

        private static string DropIfContainsBackslashSingleQuote(this string rule)
        {
            //TODO: resolve issue and/or log rule
            return rule.Contains(@"\'") ? null : rule;
        }
    }
}