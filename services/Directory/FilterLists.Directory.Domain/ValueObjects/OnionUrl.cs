using FilterLists.SharedKernel.Domain.SeedWork;

namespace FilterLists.Directory.Domain.ValueObjects;

public class OnionUrl : ValueObject
{
    private readonly Uri _uri;

    public OnionUrl(Uri url)
    {
        if (!(url.Host.Split('.')
                .LastOrDefault()
                ?.Equals("onion", StringComparison.InvariantCultureIgnoreCase) ?? false))
        {
            throw new ArgumentException("The onion URL must end in '.onion'.", nameof(url));
        }

        _uri = url;
    }

    public override string ToString()
    {
        return _uri.ToString();
    }

    protected override IEnumerable<object?> GetEqualityComponents()
    {
        yield return _uri;
    }
}
