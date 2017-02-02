![FilterLists](https://github.com/collinbarrett/FilterLists/blob/master/imgs/logo_filterlists.png)

[![License](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://github.com/collinbarrett/FilterLists/blob/master/LICENSE)
[![Website](https://img.shields.io/website-up-down-green-red/http/shields.io.svg)](https://filterlists.com/)

[filterlists.com](https://filterlists.com)

FilterLists is the independent and comprehensive directory of all public filter lists for advertisements, trackers, malware, and annoyances. For more information on its purpose and function, check out [Start](https://filterlists.com/start/).

## Types & Properties

List Types:
 - **Global**: Lists that are actively maintained, unique, original (or fork of a stale master), and useful globally.
 - **Regional**: Lists that are actively maintained, unique, original (or fork of a stale master), and useful for sites serving a specific region.
 - **Forked**: Lists that are actively maintained forks of active or stale master lists.
 - **Combo**: Lists that are actively maintained and combinations of two or more other lists.
 - **Stale**: Lists that are no longer actively maintained. Archived for posterity.

Matrix Key:
 - X : Required
 - ? : Optional
 - ( ) : Not Available/Not Supported
 
| | Global | Regional | Forked | Combo | Stale | Description |
|---|---|---|---|---|---|---|
| list | X | X | X | ? | X | The name of the list as stated by the list maintainer(s) in title case. |
| lang | | X | ? | | ? | The comma-separated list of ISO 639-1 codes targeted by the list. |
| descr | X | X | X | | X | A brief description of the list's functionality. Preferably, this is quoted (if non-English, translate to English via translator or Google Translate for consistency) from the list's documentation or composed by a maintainer of the list. If neither are available, a generic description should be composed by the FilterLists contributor. |
| descrSourceUrl | ? | ? | ? | | ? | The URL to the list's documentation page from which the description was quoted if applicable. |
| viewUrl | X | X | X | X | X | The URL to the list in raw text format. zip files and other formats are acceptable if no text format is available. |
| homeUrl | ? | ? | ? | | ? | The URL to the list's home page. Preferably, this is stated in the header of the list. Alternatively, it could be a custom domain, GitHub page, blog post, forum post, etc. that serves as a primary source of information for the list. |
| guideUrl | ? | ? | ? | | ? | The URL to the list's instruction guide if it is significantly different than the homeUrl. |
| forumUrl | ? | ? | ? | | ? | The URL to the list's forum where issues, change requests, etc. are discussed. |
| issuesUrl | ? | ? | ? | | ? | The URL to the list's GitHub Issues. |
| email | ? | ? | ? | | ? | The email address of the list's maintainer(s) if publicly available. |
| changelogUrl | ? | ? | ? | | ? | The URL to the list's changelog such as an RSS feed, GitHub commits log, Mercurial log, etc. |
| donateUrl | ? | ? | ? | | ? | The URL to the list's donation page. This could be a custom PayPal or similar link, or a link to a web page discussing various donation options. Pull requests that include changes to this link will undergo further verification to prevent fraud. |
| forksCombos | ? | ? | | | ? | List names that are either a fork or a combo of list. Sorted alphabetically by convention. |
| master | | | X | X | | List names which are combined to create the list (if a combo) or list name from which the list is forked (if a fork). Sorted alphabetically by convention. |

## Contributions
See [CONTRIBUTING](https://github.com/collinbarrett/FilterLists/blob/master/CONTRIBUTING.md).

## Directory Structure

### [/json-data](https://github.com/collinbarrett/FilterLists/tree/master/json-data)
The data in JSON format for each of the five list types on FilterLists. If you are looking for the core data of FilterLists (information on all of the lists), this is it.

### [/json-schema](https://github.com/collinbarrett/FilterLists/tree/master/json-schema)
The [JSON Schema](http://json-schema.org/) specification for each of the five list types contained in [/json-data](https://github.com/collinbarrett/FilterLists/tree/master/json-data). Since all lists do not have values for all supported data properties, these explain all of the possible properties that FilterLists currently supports rather than including a bunch of null values in the .json data files.

### [/gs/lib](https://github.com/collinbarrett/FilterLists/tree/master/gs/lib)
A single [GAS library](https://developers.google.com/apps-script/guide_libraries) used by all five list type spreadsheets and accessed via [/gs/type/Interface.gs](https://github.com/collinbarrett/FilterLists/blob/master/gs/type/Interface.gs)

### [/gs/type](https://github.com/collinbarrett/FilterLists/tree/master/gs/type)
Scripts copied into each of the five list type spreadsheets to workaround the Google Sheets/GAS permissions structure

## Building
Essentially, for now, you "can't". As it stands, FilterLists is only pseudo-open-sourced, built on WordPress and Google Sheets. The data is all contained in this repository in .json form. The Google Apps Scripts used to parse the data are also maintained here. To build the production setup, though, requires creating custom Google Sheets, installing the apps scripts, and installing WordPress. In the future, it would be great to have the entire site open-sourced; but, it is what it is for now.

## Google Sheets
Google Sheets is used as a lightweight database for this site. Data is pulled once daily from GitHub to Google Sheets, and then once daily from Google Sheets to FilterLists. Below are links to the production Sheets for reference.
 - [Global](https://docs.google.com/spreadsheets/d/1RB5zne9-tIoT5mIbAq1c6-5447UI0emWngOaTgjiCAE/edit?usp=sharing)
 - [Regional](https://docs.google.com/spreadsheets/d/1Xb1y9OZ71zjkq5MiBmyCHsvFYdUfVRx6PAnlS93lqd4/edit?usp=sharing)
 - [Forked](https://docs.google.com/spreadsheets/d/1TX29KMGNVxgj7f6TD0RiuMCLfKhM5qVIG1dkNTesV5Y/edit?usp=sharing)
 - [Combo](https://docs.google.com/spreadsheets/d/15OULPbqny8Lc7qtoftDvgIerUt8id6MdlSnIcwpsdJs/edit?usp=sharing)
 - [Stale](https://docs.google.com/spreadsheets/d/17SZKzZSMHfP0rz2xxAb0bGnfxTSkqpYCAyhjHO0cmAM/edit?usp=sharing)
