# Gitmoji Mapping

Use this as the stable mapping set for this skill. This repository always uses the hybrid visible-emoji format and always includes at least one official gitmoji.

## Enforced Subject Pattern

- `type(scope): <emoji> [<emoji> ...] <summary>`
- Use Unicode emoji, not shortcodes, in commit subjects.
- Put the primary type-aligned emoji first.
- Add extra official gitmojis when they add real signal for the same cohesive change.
- Append `🤖` for materially AI-related changes.

## Local AI Extension

- `🤖` is not part of the official gitmoji catalog.
- In this repository, use `🤖` whenever the change materially affects AI behavior or AI-facing assets, such as agents, prompts, skills, models, embeddings, inference flows, LLM integrations, or Copilot-specific customization.
- `🤖` is supplemental. Keep at least one official gitmoji in front of it.
- Example: `feat(web): ✨ 🤖 add AI-assisted commit preview`

## Repository-Specific Notes

- Data changes should keep a semantic type such as `feat(data)` or `fix(data)` rather than collapsing everything to `chore`.
- For seed-data or migration-heavy work, `🌱` or `🗃️` can be added when they improve the summary, but the conventional type should still match the effect of the change.
- If a required EF migration accompanies a data update, write the commit around the data intent unless the migration itself is the only meaningful change.
- For dependency upgrades or downgrades, prefer `build` or `chore` with `⬆️`, `⬇️`, `➕`, `➖`, or `📌` when dependency movement is the main point of the commit.

## Official Gitmoji Catalog

The table below captures every official gitmoji from the gitmoji site and suggests the nearest Conventional Commits type or types for this repository.

| Emoji | Code | Official meaning | Suggested conventional type(s) | Notes |
| --- | --- | --- | --- | --- |
| 🎨 | `:art:` | Improve structure / format of the code. | `refactor`, `chore` | Use when behavior is unchanged and the work is mostly structure or formatting. |
| ⚡️ | `:zap:` | Improve performance. | `perf` | Primary performance emoji. |
| 🔥 | `:fire:` | Remove code or files. | `refactor`, `chore` | Useful for cleanup-only removals. |
| 🐛 | `:bug:` | Fix a bug. | `fix` | Default bug-fix emoji. |
| 🚑️ | `:ambulance:` | Critical hotfix. | `fix` | Reserve for urgent fixes. |
| ✨ | `:sparkles:` | Introduce new features. | `feat` | Primary feature emoji. |
| 📝 | `:memo:` | Add or update documentation. | `docs` | Docs-only changes. |
| 🚀 | `:rocket:` | Deploy stuff. | `ci`, `build`, `chore` | Use when deployment mechanics are the point. |
| 💄 | `:lipstick:` | Add or update the UI and style files. | `feat`, `fix`, `refactor` | Supplemental for UI-heavy work. |
| 🎉 | `:tada:` | Begin a project. | `feat`, `chore` | Mostly useful at project bootstrap. |
| ✅ | `:white_check_mark:` | Add, update, or pass tests. | `test` | Standard test emoji. |
| 🔒️ | `:lock:` | Fix security or privacy issues. | `fix` | Security or privacy fix. |
| 🔐 | `:closed_lock_with_key:` | Add or update secrets. | `chore`, `build` | Use carefully; do not reveal secret values. |
| 🔖 | `:bookmark:` | Release / Version tags. | `chore`, `build` | Versioning or tagging work. |
| 🚨 | `:rotating_light:` | Fix compiler / linter warnings. | `fix`, `chore` | Good supplemental emoji for warning cleanup. |
| 🚧 | `:construction:` | Work in progress. | `chore` | Allowed, but avoid using it as the only signal in polished final commits. |
| 💚 | `:green_heart:` | Fix CI Build. | `ci`, `fix` | CI repair work. |
| ⬇️ | `:arrow_down:` | Downgrade dependencies. | `build`, `chore` | Dependency downgrade. |
| ⬆️ | `:arrow_up:` | Upgrade dependencies. | `build`, `chore` | Dependency upgrade. |
| 📌 | `:pushpin:` | Pin dependencies to specific versions. | `build`, `chore` | Dependency pinning. |
| 👷 | `:construction_worker:` | Add or update CI build system. | `ci` | Primary CI workflow emoji. |
| 📈 | `:chart_with_upwards_trend:` | Add or update analytics or track code. | `feat`, `chore` | Analytics or instrumentation. |
| ♻️ | `:recycle:` | Refactor code. | `refactor` | Primary refactor emoji. |
| ➕ | `:heavy_plus_sign:` | Add a dependency. | `build`, `chore` | Dependency addition. |
| ➖ | `:heavy_minus_sign:` | Remove a dependency. | `build`, `chore` | Dependency removal. |
| 🔧 | `:wrench:` | Add or update configuration files. | `chore`, `build`, `ci` | General config work. |
| 🔨 | `:hammer:` | Add or update development scripts. | `chore`, `build` | Script or tooling maintenance. |
| 🌐 | `:globe_with_meridians:` | Internationalization and localization. | `feat`, `fix` | Language or locale work. |
| ✏️ | `:pencil2:` | Fix typos. | `docs`, `fix` | Typos in docs, UI text, or code comments. |
| 💩 | `:poop:` | Write bad code that needs to be improved. | `chore`, `refactor` | Rarely useful; keep only if it adds real signal. |
| ⏪️ | `:rewind:` | Revert changes. | `revert` | Use for explicit revert commits. |
| 🔀 | `:twisted_rightwards_arrows:` | Merge branches. | `chore` | Mostly useful when the merge itself is the change. |
| 📦️ | `:package:` | Add or update compiled files or packages. | `build`, `chore` | Packaged or compiled artifacts. |
| 👽️ | `:alien:` | Update code due to external API changes. | `fix`, `feat` | External API drift or adaptation. |
| 🚚 | `:truck:` | Move or rename resources (e.g.: files, paths, routes). | `refactor`, `chore` | Renames and moves. |
| 📄 | `:page_facing_up:` | Add or update license. | `docs`, `chore` | License text or metadata. |
| 💥 | `:boom:` | Introduce breaking changes. | `any` with `!` or `BREAKING CHANGE:` | Supplemental breaking-change marker. |
| 🍱 | `:bento:` | Add or update assets. | `feat`, `chore` | Static assets, imagery, bundled media. |
| ♿️ | `:wheelchair:` | Improve accessibility. | `feat`, `fix` | Accessibility improvements. |
| 💡 | `:bulb:` | Add or update comments in source code. | `docs`, `chore` | Source comments or explanatory text. |
| 🍻 | `:beers:` | Write code drunkenly. | `chore` | Allowed but intentionally informal; use sparingly. |
| 💬 | `:speech_balloon:` | Add or update text and literals. | `feat`, `fix`, `docs` | Copy or literal text changes. |
| 🗃️ | `:card_file_box:` | Perform database related changes. | `feat`, `fix`, `chore` | Database, schema-adjacent, or persistence work. |
| 🔊 | `:loud_sound:` | Add or update logs. | `chore`, `fix` | Logging additions or changes. |
| 🔇 | `:mute:` | Remove logs. | `chore`, `refactor` | Logging removal or cleanup. |
| 👥 | `:busts_in_silhouette:` | Add or update contributor(s). | `docs`, `chore` | Contributor metadata or acknowledgments. |
| 🚸 | `:children_crossing:` | Improve user experience / usability. | `feat`, `fix` | UX or usability work. |
| 🏗️ | `:building_construction:` | Make architectural changes. | `refactor`, `chore` | Architecture-focused structural changes. |
| 📱 | `:iphone:` | Work on responsive design. | `feat`, `fix` | Responsive layout behavior. |
| 🤡 | `:clown_face:` | Mock things. | `test`, `chore` | Mocks, stubs, or fake implementations. |
| 🥚 | `:egg:` | Add or update an easter egg. | `feat`, `chore` | Novelty or easter-egg work. |
| 🙈 | `:see_no_evil:` | Add or update a .gitignore file. | `chore` | Ignore rule maintenance. |
| 📸 | `:camera_flash:` | Add or update snapshots. | `test` | Snapshot tests or fixture snapshots. |
| ⚗️ | `:alembic:` | Perform experiments. | `feat`, `chore` | Experimental work; use only when experimentation is the point. |
| 🔍️ | `:mag:` | Improve SEO. | `feat`, `chore` | Search optimization. |
| 🏷️ | `:label:` | Add or update types. | `refactor`, `fix`, `chore` | Type definitions or typing improvements. |
| 🌱 | `:seedling:` | Add or update seed files. | `feat`, `fix`, `chore` | Seed data and related data assets. |
| 🚩 | `:triangular_flag_on_post:` | Add, update, or remove feature flags. | `feat`, `chore` | Feature flag work. |
| 🥅 | `:goal_net:` | Catch errors. | `fix`, `feat` | Better error handling or guardrails. |
| 💫 | `:dizzy:` | Add or update animations and transitions. | `feat`, `fix` | Motion or transition work. |
| 🗑️ | `:wastebasket:` | Deprecate code that needs to be cleaned up. | `refactor`, `chore` | Deprecation markers or scheduled cleanup. |
| 🛂 | `:passport_control:` | Work on code related to authorization, roles and permissions. | `feat`, `fix` | Authn/authz changes. |
| 🩹 | `:adhesive_bandage:` | Simple fix for a non-critical issue. | `fix` | Small or low-risk fix. |
| 🧐 | `:monocle_face:` | Data exploration/inspection. | `chore`, `feat` | Exploratory or investigative data work. |
| ⚰️ | `:coffin:` | Remove dead code. | `refactor`, `chore` | Dead code removal. |
| 🧪 | `:test_tube:` | Add a failing test. | `test` | Failing test added first. |
| 👔 | `:necktie:` | Add or update business logic. | `feat`, `fix` | Domain or business rule changes. |
| 🩺 | `:stethoscope:` | Add or update healthcheck. | `feat`, `chore` | Healthcheck or readiness probe work. |
| 🧱 | `:bricks:` | Infrastructure related changes. | `chore`, `build`, `ci` | Infra and platform changes. |
| 🧑‍💻 | `:technologist:` | Improve developer experience. | `chore` | DX or contributor workflow improvements. |
| 💸 | `:money_with_wings:` | Add sponsorships or money related infrastructure. | `chore` | Billing, sponsorship, or cost-oriented infra. |
| 🧵 | `:thread:` | Add or update code related to multithreading or concurrency. | `feat`, `fix`, `perf` | Concurrency-related work. |
| 🦺 | `:safety_vest:` | Add or update code related to validation. | `feat`, `fix` | Validation logic. |
| ✈️ | `:airplane:` | Improve offline support. | `feat` | Offline-first or offline capability. |
| 🦖 | `:t-rex:` | Code that adds backwards compatibility. | `fix`, `feat` | Compatibility preservation or restoration. |