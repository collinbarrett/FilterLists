# FilterLists
FilterLists is the community-driven, independent, and comprehensive directory of all public filter lists for advertisements, trackers, and annoyances. For more information on its purpose and function, check out the [Start](https://beta.filterlists.com/start/) page.

## UNDER CONSTRUCTION
Version 2 of FilterLists is under live construction over at https://beta.filterlists.com. It is built on WordPress, so the entire project will not be open-sourced in this repo. But, the data and custom parsing logic are here to facilitate community support.

## Contributions
Pull requests and issues are welcome! Please search current issues/pull requests and peruse [CONTRIBUTING.md](https://github.com/collinbarrett/FilterLists/blob/master/CONTRIBUTING.md) before submitting.

## Directory Structure
### [/gs](https://github.com/collinbarrett/FilterLists/tree/master/gs)
Contains Google Script custom functions, triggers, etc. Google sheets is used as a lightweight database for this project, so the .gs files contain the custom JSON parsing logic.
#### [/lib](https://github.com/collinbarrett/FilterLists/tree/master/gs/lib)
A single [GAS library](https://developers.google.com/apps-script/guide_libraries) used by all five list type spreadsheets and accessed via [type/Interface.gs](https://github.com/collinbarrett/FilterLists/blob/master/gs/type/Interface.gs)
#### [/type](https://github.com/collinbarrett/FilterLists/tree/master/gs/type)
Files copy/pasted into each of the five spreadsheets to workaround the Google Sheets/GAS permissions structure

### [/json-data](https://github.com/collinbarrett/FilterLists/tree/master/json-data)
The data in JSON format for each of the five list types on FilterLists

### [/json-schema](https://github.com/collinbarrett/FilterLists/tree/master/json-schema)
The [JSON Schema](http://json-schema.org/) specification for each of the five list types contained in /json-data

## Google Sheets
The Google Sheets that serve as a lightweight database for the site are at the links below. Data is pulled once daily from GitHub to the Google Sheets, and then once daily from the Google Sheets to https://filterlists.com.
 - [Global](https://docs.google.com/spreadsheets/d/1RB5zne9-tIoT5mIbAq1c6-5447UI0emWngOaTgjiCAE/edit?usp=sharing)
 - [Regional](https://docs.google.com/spreadsheets/d/1Xb1y9OZ71zjkq5MiBmyCHsvFYdUfVRx6PAnlS93lqd4/edit?usp=sharing)
 - [Forked](https://docs.google.com/spreadsheets/d/1TX29KMGNVxgj7f6TD0RiuMCLfKhM5qVIG1dkNTesV5Y/edit?usp=sharing)
 - [Combo](https://docs.google.com/spreadsheets/d/15OULPbqny8Lc7qtoftDvgIerUt8id6MdlSnIcwpsdJs/edit?usp=sharing)
 - [Stale](https://docs.google.com/spreadsheets/d/17SZKzZSMHfP0rz2xxAb0bGnfxTSkqpYCAyhjHO0cmAM/edit?usp=sharing)
