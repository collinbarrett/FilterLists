using FilterLists.Archival.Domain.Extensions;
using FilterLists.SharedKernel.Domain.SeedWork;

namespace FilterLists.Archival.Domain.ListArchives;

public sealed class ListFileExtension : ValueObject
{
    private static readonly IDictionary<string, (bool IsPlainText, bool IsMeaningfulToConsumer)> Info =
        new Dictionary<string, (bool, bool)>
        {
            { string.Empty, (true, false) },
            { ".txt", (true, false) },
            { ".7z", (false, false) },
            { ".action", (true, true) }, // Privoxy
            { ".all", (true, false) },
            { ".aspx", (true, false) },
            { ".bat", (true, true) },
            { ".blacklist", (true, false) },
            { ".cidr", (true, true) },
            { ".conf", (true, true) }, // dnsmasq / Unbound / BIND
            { ".csv", (true, true) },
            { ".dat", (true, true) }, // Halite for Windows
            { ".deny", (true, true) },
            { ".gz", (false, false) },
            { ".hosts", (true, true) },
            { ".ips", (true, false) },
            { ".ipset", (true, true) }, // Firehol
            { ".json", (true, true) },
            { ".list", (true, false) },
            { ".lsrules", (true, true) }, // Little Snitch
            { ".md", (true, true) },
            { ".netset", (true, true) }, // Firehol
            { ".p2p", (true, true) }, // Peer Guardian
            { ".php", (true, false) },
            { ".raw", (true, false) },
            { ".rpz", (true, true) }, // Response Policy Zone
            { ".tpl", (true, true) }, // Internet Explorer
            { ".uBl", (true, false) },
            { ".zip", (false, false) },
            { ".zone", (true, false) }
        };

    private ListFileExtension(string value)
    {
        Value = value;
    }

    public string Value { get; }

    public bool IsPlainText => Info[Value].IsPlainText;

    public bool IsMeaningfulToConsumer => Info[Value].IsMeaningfulToConsumer;

    public static ListFileExtension FromUri(Uri uri)
    {
        return new ListFileExtension(uri.GetFileExtension());
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        return new[] { Value };
    }
}
