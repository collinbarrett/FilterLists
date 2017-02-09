![FilterLists](https://github.com/collinbarrett/FilterLists/blob/master/imgs/logo_filterlists.png)

[![License](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://github.com/collinbarrett/FilterLists/blob/master/LICENSE)
[![Website](https://img.shields.io/website-up-down-green-red/http/shields.io.svg)](https://filterlists.com/)

[filterlists.com](https://filterlists.com)

FilterLists is the independent and comprehensive directory of all public filter and hosts lists for advertisements, trackers, malware, and annoyances. For more information on its purpose and function, check out [Start](https://filterlists.com/start/).

## Properties

| Property | Description |
|---|---|
| list | The name of the list as stated by the list maintainer(s) in title case. |
| descr | A brief description of the list's functionality. Preferably, this is quoted (if non-English, translate to English via translator or Google Translate for consistency) from the list's documentation or composed by a maintainer of the list. If neither are available, a generic description should be composed by the FilterLists contributor. |
| descrSourceUrl | The URL to the list's documentation page from which the description was quoted if applicable. |
| viewUrl | The URL to the list in raw text format. zip files and other formats are acceptable if no text format is available. |
| homeUrl | The URL to the list's home page. Preferably, this is stated in the header of the list. Alternatively, it could be a custom domain, GitHub page, blog post, forum post, etc. that serves as a primary source of information for the list. |
| guideUrl | The URL to the list's instruction guide if it is significantly different than the homeUrl. |
| forumUrl | The URL to the list's forum where issues, change requests, etc. are discussed. |
| issuesUrl | The URL to the list's GitHub Issues. |
| email | The email address of the list's maintainer(s) if publicly available. |
| changelogUrl | The URL to the list's changelog such as an RSS feed, GitHub commits log, Mercurial log, etc. |
| donateUrl | The URL to the list's donation page. This could be a custom PayPal or similar link, or a link to a web page discussing various donation options. Pull requests that include changes to this link will undergo further verification to prevent fraud. |
| related | List names that are directly related to the list. For example, if a list is a combination of other lists, its master lists would be considered "related". Sorted alphabetically by convention. |
| tagLang | Array of ISO 639-1 language codes targeted by the list. |

## Building
Essentially, for now, you "can't". As it stands, FilterLists is only pseudo-open-sourced, built on WordPress and Google Sheets. The data is all contained in this repository in .json form. The Google Apps Scripts used to parse the data are also maintained here. To build the production setup, though, requires creating custom Google Sheets, installing the apps scripts, and installing WordPress. In the future, it would be great to have the entire site open-sourced; but, it is what it is for now.
