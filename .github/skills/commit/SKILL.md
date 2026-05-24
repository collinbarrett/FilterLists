---
name: commit
description: 'Create and execute git commits using Conventional Commits with enforced hybrid visible gitmoji formatting. Use when you want the agent to inspect current changes, determine logical commit boundaries, and commit the right slices directly from the working tree when possible while keeping Conventional Commits tooling compatibility.'
argument-hint: '[change summary, diff context, or desired mode]'
---

# Conventional Commits With Gitmoji

## When to Use
- The task is to create one or more git commits.
- The user invokes `/commit` and expects the agent to proceed with committing.
- The current changes span multiple areas and need a split-or-combine decision.
- The agent needs to stage the right files or hunks and commit them directly.

## Invocation Behavior
- When `/commit` is invoked, default to execution, not discussion.
- Inspect the current staged and unstaged changes, determine the right commit slices, stage them, and create the commit or commits.
- Prefer committing directly from unstaged working-tree changes for tracked files instead of using a separate stage-then-commit phase.
- Minimize shared index churn so parallel agents on the same branch do not interfere with each other unnecessarily.
- Do not stop at a draft or review phase unless the user explicitly asks for preview-only behavior.
- Only pause when genuinely blocked, such as no relevant changes, an unresolved merge state, or a repository error that prevents a safe commit.
- After committing, report what was committed and any remaining uncommitted changes.

## Default Policy
- Always use the hybrid visible-emoji subject shape:
  - `<type>[optional scope][!]: <emoji> [<emoji> ...] <summary>`
- Always include at least one official gitmoji in the subject.
- Use Unicode emoji, not shortcodes, in commit subjects.
- Multiple emojis are allowed and encouraged when they describe one cohesive change.
- Put the gitmoji that best matches the conventional type first, then any additional contextual gitmojis.
- If the change is materially AI-related, append `🤖` after the official gitmojis.
- `🤖` is a local extension for this repository, not part of the official gitmoji catalog.
- Do not output emoji-first subjects with this skill.
- Use the stable mappings in [gitmoji mapping](./references/gitmoji-mapping.md).

## Procedure
1. Inspect the change set.
   - Prefer the current changed files and working-tree diff.
   - Treat pre-existing staged changes carefully. Do not assume they belong to the current `/commit` invocation.
   - If you only have a vague summary, ask for the diff or infer the narrowest credible intent from the available context.
2. Decide whether one commit is appropriate.
   - Prefer one primary intent per commit.
   - If the change mixes unrelated intents, split it into separate logical commits instead of forcing one umbrella commit.
   - Keep tightly coupled code, tests, migrations, and follow-up fixes together when they are required for one coherent change to work and remain reviewable.
   - Do not split purely for the sake of atomization. Avoid tiny commits that only make sense when read together.
   - A good commit should usually be reversible, reviewable in one sitting, and understandable from its message plus diff.
3. Choose the conventional type.
   - Use `feat` for new capability, `fix` for bug repair, `docs` for documentation, `refactor` for structure-only changes, `perf` for performance work, `test` for tests, `ci` for workflow changes, `build` for build or dependency pipeline changes, `chore` for maintenance, and `revert` for reverts.
4. Choose an optional scope.
   - Add a scope only when it clarifies the affected area.
   - Prefer repository scopes such as `web`, `directory`, `api`, `infrastructure`, `migrations`, `data`, and `ci`.
   - Do not invent a scope when the area is unclear.
   - If a required EF migration accompanies a data change, scope to the underlying intent, usually `data`, not both `data` and `migrations`.
5. Draft the subject line.
   - Always use the enforced hybrid form:
     - `<type>[optional scope][!]: <emoji> [<emoji> ...] <summary>`
   - Use imperative mood and keep it concise.
   - Describe the outcome, not the implementation process.
   - Avoid trailing punctuation.
   - Use one or more Unicode emojis immediately after the colon.
   - Separate multiple emojis with single spaces.
   - Put the type-aligned emoji first.
   - Add `🤖` whenever AI, LLM, Copilot, prompt, model, inference, agent, embedding, or similar AI behavior is a material part of the change.
   - Example:
     - `fix(data): 🐛 🌱 correct filter list home URL and regenerate seed migration`
6. Decide whether a body is needed.
   - Add a body when rationale, migration steps, side effects, or repository-specific context matters.
   - Skip the body when the subject is already sufficient.
7. Decide whether footers are needed.
   - Use `BREAKING CHANGE:` for externally breaking behavior.
   - Use `!` after the type or scope only for real breaking changes.
   - Add other trailers such as `Refs:` only when the user or workflow needs them.
8. If the agent is performing the commit.
   - If there are obvious multiple logical changes, create separate commits rather than one combined commit.
   - Prefer direct-from-working-tree commit flows for tracked files that belong wholly to one slice.
   - Avoid a long-lived two-phase stage and commit flow when Git can commit the slice directly by path.
   - If Git requires the index, such as for new untracked files or carefully selected hunks from a mixed file, stage the smallest possible slice immediately before the commit and avoid leaving unrelated staged state behind.
   - Never use broad staging commands such as `git add .` or `git add -A` for commit slicing.
   - Reuse the drafted message verbatim in the `git commit` command.
   - Do not silently rewrite the subject between preview and execution.
   - By default, proceed through all slices until the intended commits are created.
   - If there are leftover changes that do not belong in the current commit set, leave them unstaged or uncommitted and say so explicitly afterward.

## Commit Slicing Rules
- Split when the change set contains different intents, different conventional types, or independently understandable review units.
- Keep together changes that are mechanically or behaviorally inseparable, such as implementation plus the tests that verify it, a data change plus its required migration, or an API rename plus the call-site updates needed to keep the build coherent.
- When a whole tracked file belongs to one slice, prefer committing it directly from unstaged changes rather than staging it first.
- When a single file contains edits for multiple slices, use the narrowest Git flow available to isolate only the intended slice and keep any temporary index usage short-lived.
- Prefer separate commits for cases such as:
  - feature work plus unrelated refactoring
  - bug fix plus incidental documentation cleanup
  - dependency update plus unrelated product code changes
  - generated snapshots or lockfile churn that can stand alone cleanly
- Do not split when the result would create meaningless micro-commits such as one commit for a renamed symbol and another for the direct call sites of that same rename.
- Favor commits that preserve bisectability when practical: each commit should ideally compile, test, or at least fail for a deliberate reason such as a test-first workflow.
- For typical mixed work, default to the smallest number of commits that keeps each commit coherent. In practice this is often one to three commits, not a long chain of tiny edits.

## Ideal Commit Size
- Large enough that the commit expresses a complete idea.
- Small enough that a reviewer can understand the goal and inspect the diff without context switching across unrelated concerns.
- Usually centered on one user-visible change, one bug fix, one refactor, one dependency move, or one mechanical repository task.
- If you need a long explanation just to justify why unrelated edits belong together, the commit is probably too large.
- If the commit message becomes vague because the diff spans multiple stories, split the commit.

## Response Format
- If one commit is appropriate, create it and then report the final commit message.
- If the change should be split, commit each slice in order and then report the created commit messages in commit order.
- Only provide reasoning when the user asks for it or when a blocker forced a decision they should know about.
- Keep the post-commit summary short: what was committed, how it was split, whether any changes remain, and whether any temporary staging was required because Git could not commit the slice directly from the working tree.

## Repository Guidance
- `web`: React SPA behavior, components, hooks, styles, and client-side build changes.
- `data`: JSON seed data under `services/Directory/data/`.
- `directory`: backend or domain logic across the Directory service.
- `api`: minimal API endpoints, contracts, or API behavior.
- `infrastructure`: EF configuration, persistence, hosting, or service wiring.
- `migrations`: EF migration files when the migration itself is the point of the commit.
- `ci`: GitHub Actions and automation workflows.

## Quality Gates
- Prefer splitting commits when more than one conventional type clearly applies.
- Prefer splitting commits when one slice could be reviewed or reverted independently from the others.
- Keep the subject specific enough that it stands on its own in `git log`.
- Avoid stuffing file names, ticket IDs, or implementation trivia into the subject unless the workflow requires it.
- Do not claim a breaking change unless users or downstream automation will notice one.
- Use multiple emojis when they improve fidelity for one cohesive change, not to justify unrelated changes in one commit.
- Keep the emoji set honest and readable. One to three emojis is typical, but more are allowed if they clearly add signal.
- Use `🤖` for AI-related changes even though it is a local extension instead of an official gitmoji.
- Avoid over-granularity. If two adjacent commits would have nearly identical messages or only make sense together, they probably belong in one commit.
- Avoid disturbing unrelated staged work. If index use is unavoidable, keep it narrow, brief, and isolated to the current slice.

## Examples
Recommended default:

```text
feat(web): ✨ add language filter chips
```

Data change with required migration:

```text
fix(data): 🐛 🌱 correct EasyList home URL and regenerate seed migration
```

Breaking change:

```text
feat(api)!: ✨ 💥 rename filter list language field to locale

Align API responses and frontend usage around locale naming.

BREAKING CHANGE: API responses now expose `locale` instead of `language`.
```

AI-related change:

```text
chore(ci): 👷 🤖 tighten Copilot workflow triggers
```

Split mixed work into separate commits:

```text
refactor(directory): ♻️ simplify filter list query projection
test(directory): ✅ add coverage for simplified query projection
docs(api): 📝 clarify filter list response examples
```

Execution-first behavior:

```text
/commit
```

Expected behavior:
- inspect the working tree
- choose one or more logical commit slices
- stage each slice
- run `git commit` for each slice
- report the resulting commits and any remaining changes