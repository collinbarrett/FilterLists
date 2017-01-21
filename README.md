# FilterLists
FilterLists is the independent and comprehensive directory of all public filter lists for advertisements, trackers, malware, and annoyances. For more information on its purpose and function, check out [Start](https://filterlists.com/start/).

## Contributions
See [CONTRIBUTING](https://github.com/collinbarrett/FilterLists/blob/master/CONTRIBUTING.md).

## Directory Structure

### [/gs/lib](https://github.com/collinbarrett/FilterLists/tree/master/gs/lib)
A single [GAS library](https://developers.google.com/apps-script/guide_libraries) used by all five list type spreadsheets and accessed via [/gs/type/Interface.gs](https://github.com/collinbarrett/FilterLists/blob/master/gs/type/Interface.gs)

### [/gs/type](https://github.com/collinbarrett/FilterLists/tree/master/gs/type)
Scripts copied into each of the five list type spreadsheets to workaround the Google Sheets/GAS permissions structure

### [/json-data](https://github.com/collinbarrett/FilterLists/tree/master/json-data)
The data in JSON format for each of the five list types on FilterLists

### [/json-schema](https://github.com/collinbarrett/FilterLists/tree/master/json-schema)
The [JSON Schema](http://json-schema.org/) specification for each of the five list types contained in [/json-data](https://github.com/collinbarrett/FilterLists/tree/master/json-data)

## Google Sheets
Google Sheets is used as a lightweight database for this site. Data is pulled once daily from GitHub to Google Sheets, and then once daily from Google Sheets to https://filterlists.com.
 - [Global](https://docs.google.com/spreadsheets/d/1RB5zne9-tIoT5mIbAq1c6-5447UI0emWngOaTgjiCAE/edit?usp=sharing)
 - [Regional](https://docs.google.com/spreadsheets/d/1Xb1y9OZ71zjkq5MiBmyCHsvFYdUfVRx6PAnlS93lqd4/edit?usp=sharing)
 - [Forked](https://docs.google.com/spreadsheets/d/1TX29KMGNVxgj7f6TD0RiuMCLfKhM5qVIG1dkNTesV5Y/edit?usp=sharing)
 - [Combo](https://docs.google.com/spreadsheets/d/15OULPbqny8Lc7qtoftDvgIerUt8id6MdlSnIcwpsdJs/edit?usp=sharing)
 - [Stale](https://docs.google.com/spreadsheets/d/17SZKzZSMHfP0rz2xxAb0bGnfxTSkqpYCAyhjHO0cmAM/edit?usp=sharing)
