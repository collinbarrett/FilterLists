---
applyTo: "services/Directory/data/*.json,services/Directory/FilterLists.Directory.Infrastructure.Migrations/**/*.cs"
---

## Directory Data Files

- JSON seed data under `services/Directory/data/` is the source of truth for directory content.
- Keep object ordering stable by running `services/Directory/data/lint.sh` after changing any JSON file.
- New IDs must be unique and monotonic within each file.
- Keep all foreign keys valid across the junction and relationship tables.
- `FilterList.name` must stay unique and in title case.
- `FilterListViewUrl` rows are only for mirrors or multi-part segments, not different list flavors.
- Every JSON change must ship with a generated migration under `services/Directory/FilterLists.Directory.Infrastructure.Migrations/Migrations/`.
- URL fields must stay valid absolute URIs, including the protocol.

## Migration Files

- Generate migrations from `services/Directory/` with `dotnet ef migrations add <MigrationName> -p FilterLists.Directory.Infrastructure.Migrations -s FilterLists.Directory.Api`.
- Review the generated `Up` and `Down` methods for unintended insert, update, or delete churn before finishing.
- Do not hand-edit generated timestamps or designer files unless the tooling output is clearly wrong and you understand the correction.