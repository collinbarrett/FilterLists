namespace FilterLists.SharedKernel.Domain.SeedWork;

public abstract class Entity
{
    public long Id { get; protected init; }

    // TODO: More fully implement (e.g., https://enterprisecraftsmanship.com/posts/entity-base-class/). Make sure equality doesn't break duplicate ViewUrls when adding newly created FilterList to DbContext (related to hi/lo and/or NRTs).
}
