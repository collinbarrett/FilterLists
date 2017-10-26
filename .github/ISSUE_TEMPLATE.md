<!-- The information below is for reference only; please delete it before submitting your issue. -->

FilterLists serves as a directory for interacting with various filter lists. We do not maintain any lists ourselves. If your issue is regarding a rule or other detail of a specific list, please contact the maintainer of that list directly.

Before submitting a new issue, please review the checklist below.

## General Issues:
* [ ] Have you verified that there are no related existing open issues that you would be duplicating?
* [ ] Have you provided enough relevant detail for others to understand and discuss your issue?

## New or Updated Lists:

* [ ] Have you considered submitting a [Pull Request](https://github.com/collinbarrett/FilterLists/pulls) directly to participate as a contributor?
* [ ] Have you provided all properties available for the list (see sample below)?
* [ ] Have you converted the list name to [title case](https://en.wikipedia.org/wiki/Letter_case#Title_case)?
* [ ] Have you ensured that all URLs are functioning properly?
* [ ] Have you ensured all URLs point to HTTPS if supported?

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