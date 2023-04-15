using Newtonsoft.Json;

namespace FilterLists.Api.OData;

public class OData<T>
{
    [JsonProperty("@odata.count")] public int? Count { get; set; }

    public T? Value { get; set; }
}