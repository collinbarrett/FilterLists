using FilterLists.Directory.Domain.ValueObjects;
using Xunit;

namespace FilterLists.Directory.Domain.Tests.ValueObjects;

public class OnionUrlTests
{
    public static IEnumerable<object[]> ValidOnionUrls =>
        new List<object[]>
        {
            new object[] { new Uri("https://an.onion") },
            new object[] { new Uri("https://an.ONION") }
        };

    public static IEnumerable<object[]> InvalidOnionUrls =>
        new List<object[]>
        {
            new object[] { new Uri("https://notanonion.com") },
            new object[] { new Uri("https://notanonion.co.uk") },
            new object[] { new Uri("https://notanonion") }
        };

    [Theory]
    [MemberData(nameof(ValidOnionUrls))]
    public void CreateWithValidOnionUrl_Creates(Uri url)
    {
        var onionUrl = new OnionUrl(url);
        Assert.IsType<OnionUrl>(onionUrl);
    }

    [Theory]
    [MemberData(nameof(InvalidOnionUrls))]
    public void CreateWithInvalidOnionUrl_Throws(Uri url)
    {
        Assert.Throws<ArgumentException>(() => new OnionUrl(url));
    }
}
