# FilterLists
FilterLists is the community-driven, independent, and comprehensive directory of all public filter lists for advertisements, trackers, and annoyances.

## Intro to FilterLists v2
Version 2 of FilterLists is under live construction over at https://beta.filterlists.com. It is built on WordPress, so the entire project will not be open-sourced in this repo. But, the data and custom logic are here.

## Contributions
Issues and pull requests are welcome! More guidelines coming soon.

## Directory Structure
### gs
Google Script custom functions, triggers, etc. Google sheets is used as a lightweight database for this project, so the .gs files contain the custom logic which converts json-data files into html as well as other functionality.
### json-data
#### global.json
Lists that are actively maintained, unique, original (or fork of a stale master), and useful globally.
#### regional.json
Lists that are actively maintained, unique, original (or fork of a stale master), and useful for sites serving a specific region.
#### forked.json
Lists that are actively maintained forks of active or stale master lists.
#### combo.json
Lists that are actively maintained and combinations of two or more other lists.
#### stale.json
Lists that are no longer actively maintained. Archived for posterity.
### json-schema
The [JSON Schema](http://json-schema.org/) specification for each of the five list types contained in json-data. When contributing, please consult the schema files.
