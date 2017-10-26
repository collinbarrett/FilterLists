<!-- The information below is for reference only; please delete it before submitting your pull request. -->

Before submitting a new pull request, please review the checklist below.

## Closing Issues:
* [ ] Have you included "closes #XXXX" in your comment to auto-close the issue that your PR fixes?

## General Submissions:
* [ ] Is there an issue open for this change? If not, please open a new issue before submitting this PR. 

## Submissions for New or Updated Lists:

* [ ] Have you filled in all properties available for the list (see sample below)?
* [ ] Have you sorted the properties in alphabetical order?
* [ ] Have you converted the list name to [title case](https://en.wikipedia.org/wiki/Letter_case#Title_case)?
* [ ] Have you ensured that all URLs are functioning properly?
* [ ] Have you ensured all URLs point to HTTPS if supported?

### Sample List JSON Object:
[Source](https://github.com/collinbarrett/FilterLists/blob/master/data/DataSample.json) | [Schema](https://github.com/collinbarrett/FilterLists/blob/master/data/DataSchema.json)

```
{
  "Author": "John Doe",
  "Description": "A sample list to filter out advertisements.",
  "DescriptionSourceUrl": "https://mysample.list",
  "DonateUrl": "https://mysample.list/donate/",
  "Email": "contact@mysample.list",
  "ForumUrl": "https://mysample.list/forum/",
  "HomeUrl": "https://mysample.list/",
  "IssuesUrl": "https://github.com/mysamplelist/issues",
  "Name": "My Sample List",
  "ViewUrl": "https://mysample.list/list.txt"
}
```