<!-- The information below is for reference only, please delete it before submitting your issue. -->

_FilterLists serves as a directory for interacting with various filter lists. We do not actually maintain any lists ourselves. If your issue is regarding a rule, etc. of a specific list, please contact the maintainer of that list directly._

### General Issues:
* [ ] Have you verified that there are no related existing open issues that you would be duplicating?
* [ ] Have you provided enough relevant detail for others to understand and disucss your issue?

### New or Updated Lists:

* [ ] Have you considered submitting a [Pull Request](https://github.com/collinbarrett/FilterLists/pulls) directly to particpate as a contributor?
* [ ] Have you provided all properties available for the list (see sample below)?
* [ ] Have you converted the list name to [title case](https://en.wikipedia.org/wiki/Letter_case#Title_case)?
* [ ] Have you ensured that all URLs are functioning properly?
* [ ] Have you ensured all URLs point to HTTPS if supported?

#### Sample List JSON Object:
[Source](https://github.com/collinbarrett/FilterLists/blob/master/data/ListSample.json)

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