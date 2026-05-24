# FilterLists Cloud Agent Instructions

These instructions are for GitHub Copilot cloud agent sessions started from GitHub issue assignment or pull request comments.

## Directory Data Workflow

If the assigned issue has the `directory-data` label, or the issue body explicitly says `Task type: directory-data`, treat it as a directory data maintenance task and follow this workflow. For all other issues, follow the repository baseline instructions and ignore the specialized workflow below.

1. If the issue is minimal and directs Copilot to finish an already-open pull request, inspect the referenced pull request first. When the existing commits implement the requested JSON or migration work cleanly, prefer `git cherry-pick -x` of the contributor's commits over reimplementing the change so the original author keeps commit authorship and the new branch records where the work came from.
2. Start with fresh research before editing JSON. Validate the issue against current public sources such as the list home page, source repository, README, release notes, maintainers, license files, and related documentation.
3. Use the FilterLists wiki as the schema reference: https://github.com/collinbarrett/FilterLists/wiki. Fill in as many supported fields and relationships as the sources justify, not just the fields explicitly requested in the issue.
4. If live research is blocked by firewall rules, missing MCP tools, or missing credentials, state that limitation in the session and pull request. Do not invent facts.
5. Update only the JSON files under `services/Directory/data/` plus the required EF Core migration files. Never create or edit JSON data files outside that directory.
6. Keep identifiers and constraints valid before committing any data changes:
   - new numeric IDs must be unique and greater than the current maximum in their file
   - `FilterList.name` must remain unique and title case
   - `FilterListViewUrl` must remain unique by (`filterListId`, `segmentNumber`, `primariness`)
   - all foreign keys must reference existing rows
   - distinct list flavors belong in separate `FilterList` rows; use extra `FilterListViewUrl` rows only for mirrors or multi-part lists
7. After JSON edits, run `./lint.sh` from `services/Directory/data/`.
8. Always generate an EF Core migration from `services/Directory/` with this exact command:

   ```bash
   dotnet ef migrations add <MigrationName> -p FilterLists.Directory.Infrastructure.Migrations -s FilterLists.Directory.Api
   ```

9. Review the generated migration to confirm it captures only the intended data changes.
10. Run a focused validation step for the touched Directory slice before handing the pull request back.
11. Summarize the external sources used, any cherry-picked commits, and the key data-model additions in the pull request or final session message.
12. If current upstream research shows a filter list is fully dead and all published URLs are gone, prefer removing the dead `FilterList` rows and their dependent seed data instead of keeping discontinued placeholder entries.

## Guardrails

- Prefer minimal, targeted data changes over unrelated cleanup.
- Do not modify the web app or unrelated backend code unless the data task directly requires it.
- When an issue asks for a new variant of an existing list, verify whether it is a mirror, a multi-part list, or a distinct flavor before adding `FilterListViewUrl` rows.
- If cherry-picking from an existing contributor pull request is feasible, prefer that over recreating the same JSON changes manually.