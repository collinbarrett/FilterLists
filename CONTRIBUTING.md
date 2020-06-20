So you know of some lists you want to add, but you are very unsure about how to do so? Fear no more. Here's how to do it:

### Add/update lists, licenses, subscription links, homepages, and similar:
1. Right-click on the following link and choose "Save link": https://raw.githubusercontent.com/collinbarrett/FilterLists/master/data/FilterList.json
2. Open the downloaded _FilterList.json_ file in Sublime Text, Notepad++, or any similar raw-text editor who can handle large files and JSON indentations.
3. Add the desired changes. For new lists, "id", "name", "[syntaxId](https://github.com/collinbarrett/FilterLists/blob/master/data/Syntax.json)" and "viewUrl" are mandatory. "homeUrl" and "[licenseId](https://github.com/collinbarrett/FilterLists/blob/master/data/License.json)" are also important if they are applicable to the list. Other ones in active use are "description", "donateUrl", "emailAddress", "issuesUrl", "viewUrlMirror1" and "viewUrlMirror2".
4. Once you've performed the changes, save the file.
5. Before you can upload the changes to this repo, you must first create a branch of this repo. The easiest way to do so by far, is to take care of assigning tags to the list first (Explained below).
6. Once you're on a new branch, go to `https://github.com/[Your GitHub username]/FilterLists/tree/master/data` (The URL may be different under many circumstances, such as if you've contributed to FilterLists.com before), click "Upload" in the upper right, and choose the `FilterList.json` file that you saved.
7. Submit a PR, and we'll double-check it from there.

### Assign tags to lists (Mandatory for new lists):
1. Go to https://github.com/collinbarrett/FilterLists/edit/master/data/FilterListTag.json, and edit it online.
2. "filterListId" is the list's ID in FilterList.json. "tagId" is [one of these tags](https://github.com/collinbarrett/FilterLists/blob/master/data/Tag.json).
3. If you are 100% certain that none of the existing tags are suitable for a particular list, choose tagId 15 (Topical).
4. Save the file. This will create a new branch and/or fork, which will be convenient for list additions in general.

### Assign languages to lists:
_(This presumes you've already assigned tags to the lists.)_

1. Go to the branch you created after assigning tags.
2. Go to `.../data/FilterListLanguage.json` and begin editing it.
3. "languageId" is [one of a randomly numbered list of languages](https://github.com/collinbarrett/FilterLists/blob/master/data/Language.json). For instance, German is 167, while Japanese is 141.
4. Save the file.

### Assign contributors to lists:
_(This presumes you've already assigned tags to the lists.)_
 
1. Go to the branch you created after assigning tags.
2. Go to `.../data/FilterListMaintainer.json` and begin editing it.
3. "maintainerId" is [one of various filterlist makers](https://github.com/collinbarrett/FilterLists/blob/master/data/Maintainer.json). If you wish to assign someone who is not mentioned in that file, you are merrily welcome to add maintainer profiles to _Maintainer.json_
4. Save.
