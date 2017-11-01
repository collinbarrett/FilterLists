![FilterLists](https://github.com/collinbarrett/FilterLists/blob/master/imgs/logo_filterlists.png)

[![Website](https://img.shields.io/website-up-down-green-red/http/shields.io.svg)](https://filterlists.com/)
[![Travis](https://img.shields.io/travis/collinbarrett/FilterLists.svg?label=travis)](https://travis-ci.org/collinbarrett/FilterLists)
[![License](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://github.com/collinbarrett/FilterLists/blob/master/LICENSE)

[filterlists.com](https://filterlists.com)

FilterLists is the independent and comprehensive directory of all public filter and hosts lists for advertisements, trackers, malware, and annoyances. For more information on its purpose and function, check out [About](https://filterlists.com/about/).

## Links
| Site                                        | API                                               |
| ------------------------------------------- | ------------------------------------------------- |
| [v3 (Alpha)](https://beta.filterlists.com/) | [v1 (Alpha)](https://api.filterlists.com/docs) |
| [v2 (Stable)](https://filterlists.com/)     |                                                   |
| [v1 (Legacy)](https://v1.filterlists.com/)  |                                                   |

## Submitting or Updating Lists

To suggest a new list or update the information of an existing list, please open a new [Issue](https://github.com/collinbarrett/FilterLists/issues). Provide all of the information in the Properties section below that is available.

## Development Notice (Updated November 1, 2017)
FilterLists improvements are slow and tend to be in spurts. I care about this project as both a resource for the community and a learning tool for me. However, my day job comes first which often results in little to no work on the project at times. I happily welcome anyone that wants to contribute.

The immediate projects are converting the data to an actual web application (rather than a Google Sheet back-end and a WordPress front-end), and then exposing the data via a .Net Core API.

## Properties

### Maintainers

| Property      | Description                                |
|---------------|--------------------------------------------|
| EmailAddress  | The maintainer's email address             |
| HomeUrl       | The URL to the maintainer's home page      |
| Name          | The maintainer's name                      |
| TwitterHandle | The maintainer's twitter handle            |
| *FilterLists  | Collection of the maintainer's FilterLists |

### FilterLists

| Property             | Description                                                                                                                                                                                                                                                                                                                                    |
|----------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Description          | A brief description of the list's functionality. Preferably, this is quoted (if non-English, translate to English via translator or Google Translate for consistency) from the list's documentation or composed by a maintainer of the list. If neither is available, a generic description should be composed by the FilterLists contributor. |
| DescriptionSourceUrl | The URL to the list's documentation page from which the description was quoted if applicable.                                                                                                                                                                                                                                                  |
| DonateUrl            | The URL to the list's donation page. This could be a custom PayPal or similar link, or a link to a web page discussing various donation options. Pull requests that include changes to this link will undergo further verification to prevent fraud.                                                                                           |
| EmailAddress         | |
| ForumUrl             | The URL to the list's forum where issues, change requests, etc. are discussed.                                                                                                                                                                                                                                                                 |
| HomeUrl              | The URL to the list's home page. Preferably, this is stated in the header of the list. Alternatively, it could be a custom domain, GitHub page, blog post, forum post, etc. that serves as a primary source of information for the list.                                                                                                       |
| IssuesUrl            | The URL to the list's GitHub Issues.                                                                                                                                                                                                                                                                                                           |
| Name                 | The name of the list as stated by the list maintainer(s) in title case.                                                                                                                                                                                                                                                                        |
| SubmissionUrl        | The URL to the list's contact form for suggesting new and updated filter rules.                                                                                                                                                                                                                                                                |
| ViewUrl              | The URL to the list in raw text format. zip files and other formats are acceptable if no text format is available.                                                                                                                                                                                                                             |