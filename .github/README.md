![FilterLists](https://github.com/collinbarrett/FilterLists/blob/master/imgs/logo_filterlists.png)

[![Website](https://img.shields.io/website-up-down-green-red/http/shields.io.svg)](https://filterlists.com/)
[![Travis](https://img.shields.io/travis/collinbarrett/FilterLists.svg?label=travis)](https://travis-ci.org/collinbarrett/FilterLists)
[![License](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://github.com/collinbarrett/FilterLists/blob/master/LICENSE)

[filterlists.com](https://filterlists.com)

FilterLists is the independent and comprehensive directory of all public filter and hosts lists for advertisements, trackers, malware, and annoyances. For more information on its purpose and function, check out [About](https://filterlists.com/about/).

## Development Notice (Updated July 13, 2017)
FilterLists improvements are slow and tend to be in spurts. I care about this project as both a resource for the community and a learning tool for me. However, my day job comes first which often results in little to no work on the project at times. I happily welcome anyone that wants to contribute. The immediate projects are converting the data to an actual database (rather than a Google Sheet) and then exposing the data via a [.Net Core API](https://github.com/collinbarrett/FilterLists/projects/3). I would also love to build a more responsive front-end, but I am not a front-end developer and would welcome help on [this](https://github.com/collinbarrett/FilterLists/projects/4).

## Properties
[Source](https://github.com/collinbarrett/FilterLists/blob/master/data/DataSample.json) | [Schema](https://github.com/collinbarrett/FilterLists/blob/master/data/DataSchema.json)

| Property       | Description                              |
| -------------- | ---------------------------------------- |
| descr          | A brief description of the list's functionality. Preferably, this is quoted (if non-English, translate to English via translator or Google Translate for consistency) from the list's documentation or composed by a maintainer of the list. If neither is available, a generic description should be composed by the FilterLists contributor. |
| descrSourceUrl | The URL to the list's documentation page from which the description was quoted if applicable. |
| donateUrl      | The URL to the list's donation page. This could be a custom PayPal or similar link, or a link to a web page discussing various donation options. Pull requests that include changes to this link will undergo further verification to prevent fraud. |
| email          | The email address of the list's maintainer(s) if publicly available. |
| forumUrl       | The URL to the list's forum where issues, change requests, etc. are discussed. |
| homeUrl        | The URL to the list's home page. Preferably, this is stated in the header of the list. Alternatively, it could be a custom domain, GitHub page, blog post, forum post, etc. that serves as a primary source of information for the list. |
| issuesUrl      | The URL to the list's GitHub Issues.     |
| list           | The name of the list as stated by the list maintainer(s) in title case. |
| related        | List names that are directly related to the list. For example, if a list is a combination of other lists, its master lists would be considered "related." Sorted alphabetically by convention. |
| tagLang        | Array of ISO 639-1 language codes targeted by the list. |
| viewUrl        | The URL to the list in raw text format. zip files and other formats are acceptable if no text format is available. |