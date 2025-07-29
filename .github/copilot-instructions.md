# FilterLists AI Coding Instructions

## Architecture Overview

FilterLists is a dual-stack application that serves as a comprehensive directory of filter and host lists for blocking advertisements, trackers, and malware:

- **Backend**: .NET 9 Aspire application with clean architecture (Application/Infrastructure/API layers)
- **Frontend**: React + TypeScript SPA with Ant Design UI components
- **Database**: SQL Server with Entity Framework Core for data persistence
- **Deployment**: Containerized API on Azure, Static Web App frontend

## Project Structure

```
services/                    # .NET backend solution
├── FilterLists.AppHost/     # .NET Aspire orchestrator (main entry point)
├── Directory/               # Core domain logic
│   ├── FilterLists.Directory.Api/          # Minimal API endpoints
│   ├── FilterLists.Directory.Application/  # Query handlers (no MediatR)
│   ├── FilterLists.Directory.Infrastructure/ # EF Core, DbContext
│   └── data/                # JSON seed data files
web/                         # React frontend
infra/cloudflare-workers/    # CDN edge workers
```

## Key Patterns & Conventions

### Data-Driven Architecture

- **Seed Data**: All domain data lives in JSON files under `services/Directory/data/`
- **Migrations**: EF Core migrations are auto-generated from JSON changes via `lint.sh`
- **Read-Only DbContext**: `QueryDbContext` throws on save operations - data changes only via migrations

### Query Pattern (No CQRS/MediatR)

```csharp
public static class GetLists
{
    public class Query(QueryDbContext ctx)
    {
        public async Task<List<Response>> ExecuteAsync(CancellationToken ct) =>
            await ctx.FilterLists.Select(f => new Response(...)).ToListAsync(ct);
    }
    public sealed record Response(...);
}
```

### Entity Configuration Pattern

```csharp
internal sealed class FilterListTypeConfiguration : IEntityTypeConfiguration<FilterList>
{
    public void Configure(EntityTypeBuilder<FilterList> builder) =>
        builder.HasDataJsonFile<FilterList>(); // Loads from JSON
}
```

## Development Workflows

### Local Development

```bash
# Start with .NET Aspire (includes SQL Server container)
cd services/FilterLists.AppHost
dotnet run

# Frontend development server
cd web
npm start
```

### Data Changes

1. Edit JSON files in `services/Directory/data/`
2. Run `./lint.sh` to sort/format JSON consistently
3. Generate migration: `dotnet ef migrations add <Name> -p FilterLists.Directory.Infrastructure.Migrations -s FilterLists.Directory.Api`
4. Migration auto-applies on startup via `MigrationService`

### Adding EF Migrations

Always run from `services/Directory/` with these specific parameters:

```bash
dotnet ef migrations add <MigrationName> -p FilterLists.Directory.Infrastructure.Migrations -s FilterLists.Directory.Api
```

## Data Change Requests via GitHub Issues

When assigned to GitHub Issues requesting data updates, follow this comprehensive approach:

### Issue Analysis & Research

1. **Parse the request**: Identify specific changes mentioned in the issue
2. **Research thoroughly**: Use web search to gather comprehensive information about the filter list(s)
3. **Consult documentation**: Reference the FilterLists wiki for all supported properties: https://github.com/collinbarrett/FilterLists/wiki

### Data Model Population Strategy

**Objective**: Fill out as much of the data model as possible, not just the minimum requested changes.

**Research Sources**:

- Filter list's official website/repository
- GitHub repository metadata (if applicable)
- Documentation and README files
- License files and terms of service
- Maintainer information and contact details

**Key Properties to Research**:

- **Basic Info**: Name, description, home page URL
- **Technical Details**: Syntax type, view URLs, download URLs
- **Relationships**: Maintainers, languages, tags, licenses
- **Dependencies**: Upstream forks, merges, software compatibility
- **Metadata**: Publication date, update frequency, target audience

### Implementation Process

1. **JSON Updates**: Modify relevant files in `services/Directory/data/`
2. **Relationship Mapping**: Update junction tables (FilterListMaintainer, FilterListTag, etc.)
3. **Data Validation**: Ensure unique names (title case), valid relationships
4. **Migration Generation**: Follow standard EF migration process
5. **Testing**: Verify changes don't break existing functionality

### Quality Standards

- **Completeness**: Research and populate all discoverable properties
- **Accuracy**: Verify information from authoritative sources
- **Consistency**: Follow existing naming conventions and data patterns
- **Documentation**: Provide clear commit messages explaining changes

## Domain Model Key Relationships

- **FilterList**: Core entity with many-to-many relationships via junction tables
- **Maintainer**: People/orgs who maintain filter lists
- **License**: Legal permissions for filter list usage
- **Syntax**: Technical format (Adblock Plus, hosts file, etc.)
- **Language**: Target languages for localized lists
- **Tag**: Categorization (ads, trackers, malware, etc.)

Complex relationships: Fork (upstream/downstream), Merge (includes/included), Dependent (dependencies).

## API Conventions

### Minimal API Endpoints

- Endpoints defined in `FilterLists.Directory.Api/Endpoints.cs`
- Output caching with 1-day expiration for all GET endpoints
- OpenAPI documentation with detailed examples
- CORS enabled for web frontend consumption

### Response Patterns

All endpoints return strongly-typed records with XML documentation examples:

```csharp
/// <param name="Id" example="301">The identifier.</param>
public sealed record Response(int Id, string Name, ...);
```

## Build & Deployment

### GitHub Actions

- **Directory API**: Builds Docker image, deploys to Azure Container Registry
- **Web Frontend**: Builds static assets, deploys to Azure Static Web Apps
- **Path-based triggers**: Only builds when relevant files change

### Docker Configuration

API containerized with multi-stage build. Database runs in Docker volume with persistent storage (configure password via user secrets).

## React Frontend Specifics

### Tech Stack

- React 19 + TypeScript
- Ant Design 4.x components
- React Router 5.x (class-based routing)
- Custom proxy configuration for API calls

### Component Patterns

- Functional components with hooks
- Props interfaces defined inline or in `interfaces/` folder
- Ant Design `Table` component for main list display
- Tag clouds for maintainers, languages, syntaxes

## Critical Notes

- **No MediatR**: Use direct query pattern instead
- **JSON-first**: All data changes start with JSON edits, not EF model changes
- **Read-only runtime**: Database modifications only via migrations
- **Aspire orchestration**: Always start development via `FilterLists.AppHost`
- **Unique naming**: All FilterList names must be unique and in title case
