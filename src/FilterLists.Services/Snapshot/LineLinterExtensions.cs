namespace FilterLists.Services.Snapshot
{
    public static class LineLinterExtensions
    {
        public static string LintLine(this string line)
        {
            line = line.Trim();
            line = line.TruncateIfTooLong();
            return line;
        }

        private static string TruncateIfTooLong(this string line) =>
            line.Length > 191 ? line.Substring(0, 191) : line;
    }
}