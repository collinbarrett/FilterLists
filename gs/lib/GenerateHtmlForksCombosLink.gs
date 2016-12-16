function GenerateHtmlForksCombosLink(forkComboListName, filterListsPageSlug) {
    if (forkComboListName instanceof Array) {
        for (i in forkComboListName) {
            forkComboListName[i] = GenerateHtmlForksCombosLink(forkComboListName[i], filterListsPageSlug[i]);
        }
        return forkComboListName;
    } else {
        // return null if no List Name provided
        if (forkComboListName == null) {
            return null;
            // concatenate HTML link tag
        } else {
            var html = "<a href=\"https://beta.filterlists.com" + filterListsPageSlug + "#" + TrimUrlSlug(forkComboListName) + "\"";
            return html;
        }
    }
}
