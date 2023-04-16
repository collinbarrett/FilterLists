using Newtonsoft.Json;

namespace FilterLists.Api.OData;

public class OData<T>
{
    public T? Value { get; set; }
    [JsonProperty("@odata.count")] public int? Count { get; set; }
}