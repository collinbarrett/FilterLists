namespace FilterLists.Services.Snapshot
{
    public static class LineLinterExtensions
    {
        public static string LintLine(this string line)
        {
            line = line.Trim();
            line = line.DropIfTooLong();
            return line;
        }

        private static string DropIfTooLong(this string line) =>
            line.Length > 8192 ? null : line;
    }
}