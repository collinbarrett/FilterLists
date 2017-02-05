function createHtmlViewLinkArray(url, listName) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = createHtmlViewLinkArray(url[i], listName[i]);
        }
        return url;
    } else {
        if (url && url != "#N/A") {
            return "<a href=\"" + url + "\" title=\"Preview " + listName + " in your browser.\" class=\"button piwik_download\">View</a>";
        } else {
            return "";
        }
    }
}

function createHtmlAddLinkArray(url, listName) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = createHtmlAddLinkArray(url[i], listName[i]);
        }
        return url;
    } else {
        if (url && url != "#N/A") {
            return "<a href=\"abp:subscribe?location=" + url + "&title=" + listName + "\" title=\"Subscribe to " + listName + " in your content blocker.\" class=\"button piwik_download\">Add</a>";
        } else {
            return "";
        }
    }
}

function createHtmlHomeLinkArray(url, listName) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = createHtmlHomeLinkArray(url[i], listName[i]);
        }
        return url;
    } else {
        if (url && url != "#N/A") {
            return "<a href=\"" + url + "\" title=\"" + listName + " Home Page\" class=\"button\">Home</a>";
        } else {
            return "";
        }
    }
}

function createHtmlForumLinkArray(url, listName) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = createHtmlForumLinkArray(url[i], listName[i]);
        }
        return url;
    } else {
        if (url && url != "#N/A") {
            return "<a href=\"" + url + "\" title=\"" + listName + " Forum\" class=\"button\">Forum</a>";
        } else {
            return "";
        }
    }
}

function createHtmlIssuesLinkArray(url, listName) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = createHtmlIssuesLinkArray(url[i], listName[i]);
        }
        return url;
    } else {
        if (url && url != "#N/A") {
            return "<a href=\"" + url + "\" title=\"" + listName + " GitHub Issues\" class=\"button\">Issues</a>";
        } else {
            return "";
        }
    }
}

function createHtmlEmailLinkArray(url, listName) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = createHtmlEmailLinkArray(url[i], listName[i]);
        }
        return url;
    } else {
        if (url && url != "#N/A") {
            return "<a href=\"mailto:" + url + "\" title=\"Contribute to " + listName + " via email.\" class=\"button\">Email</a>";
        } else {
            return "";
        }
    }
}

function createHtmlDonateLinkArray(url, listName) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = createHtmlDonateLinkArray(url[i], listName[i]);
        }
        return url;
    } else {
        if (url && url != "#N/A") {
            return "<a href=\"" + url + "\" title=\"Donate to support the maintainers of " + listName + ".\" class=\"button\">Donate</a>";
        } else {
            return "";
        }
    }
}

function createHtmlRelatedLinkArray(forkComboListName, filterListsPageSlug) {
    if (forkComboListName instanceof Array) {
        for (i in forkComboListName) {
            forkComboListName[i] = createHtmlRelatedLinkArray(forkComboListName[i], filterListsPageSlug[i]);
        }
        return forkComboListName;
    } else {
        if (forkComboListName == null) {
            return null;
        } else {
            return "<a href=\"https://filterlists.com" + filterListsPageSlug + "#" + trimUrlSlugArray(forkComboListName) + "\"";
        }
    }
}

function createHtmlListNameArray(listName) {
    if (listName instanceof Array) {
        for (i in listName) {
            listName[i] = createHtmlListNameArray(listName[i]);
        }
        return listName;
    } else {
        if (listName) {
            return "<h3 id=\"" + trimUrlSlugArray(listName) + "\">" + listName + "</h3>";
        } else {
            return "";
        }
    }
}