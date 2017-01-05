# FilterLists
FilterLists is the community-driven, independent, and comprehensive directory of all public filter lists for advertisements, trackers, and annoyances. For more information on its purpose and function, check out the [Start](https://beta.filterlists.com/start/) page.

## Intro to FilterLists v2
Version 2 of FilterLists is under live construction over at https://beta.filterlists.com. It is built on WordPress, so the entire project will not be open-sourced in this repo. But, the data and custom parsing logic are here to facilitate community support.

## Contributions
Pull requests and issues are welcome! Please search current issues/pull requests and peruse CONTRIBUTING.md before submitting.

## Directory Structure
### gs
Google Script custom functions, triggers, etc. Google sheets is used as a lightweight database for this project, so the .gs files contain the custom JSON parsing logic.
### json-data
The data in JSON form for each of the five list types on FilterLists.
### json-schema
The [JSON Schema](http://json-schema.org/) specification for each of the five list types contained in json-data.
