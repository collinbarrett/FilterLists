using Newtonsoft.Json;

namespace FilterLists.Api;

internal class OData<T>
{
    [JsonProperty("@odata.count")] public int? Count { get; set; }

    public T? Value { get; set; }
}