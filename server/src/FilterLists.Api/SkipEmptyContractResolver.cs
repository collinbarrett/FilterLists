using System;
using System.Collections;
using System.Reflection;
using Humanizer;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FilterLists.Api
{
    // REF: https://stackoverflow.com/a/18486790/2343739
    public class SkipEmptyContractResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);
            property.PropertyName = property.PropertyName.Camelize();
            var isDefaultValueIgnored =
                ((property.DefaultValueHandling ?? DefaultValueHandling.Ignore) & DefaultValueHandling.Ignore) != 0;
            if (!isDefaultValueIgnored || typeof(string).IsAssignableFrom(property.PropertyType) ||
                !typeof(IEnumerable).IsAssignableFrom(property.PropertyType))
                return property;

            bool NewShouldSerialize(object obj)
            {
                return !(property.ValueProvider.GetValue(obj) is ICollection collection) || collection.Count != 0;
            }

            var oldShouldSerialize = property.ShouldSerialize;
            property.ShouldSerialize = oldShouldSerialize != null
                ? o => oldShouldSerialize(o) && NewShouldSerialize(o)
                : (Predicate<object>)NewShouldSerialize;
            return property;
        }
    }
}