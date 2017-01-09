function EncodeUrlSlug(slug) {
    if (slug instanceof Array) {
        for (i in slug) {
            slug[i] = EncodeUrlSlug(slug[i]);
        }
        return slug;
    } else {
        if (slug) {
            var charDict = [
                [" ", "%20"],
                ["\"", "%22"],
                [":", "%3A"],
                ["'", "%27"],
                ["+", "%2B"],
                ["(", "%28"],
                [")", "%29"],
                [".", ""]
            ];
            for (i = 0; i < charDict.length; ++i) {
                slug = slug.split(charDict[i][0]).join(charDict[i][1]);
            }
            return slug;
        } else {
            return "";
        }
    }
}

function GenerateHtmlAddLink(url, listName) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = GenerateHtmlAddLink(url[i], listName[i]);
        }
        return url;
    } else {
        if (url && url != "#N/A") {
            var html = "<a href=\"abp:subscribe?location=" + url + "&title=" + listName + "\" title=\"Subscribe to " + listName + " in your content blocker.\" class=\"button\">Add</a>";
            return html;
        } else {
            return "";
        }
    }
}

function GenerateHtmlChangelogLink(url, listName) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = GenerateHtmlChangelogLink(url[i], listName[i]);
        }
        return url;
    } else {
        if (url && url != "#N/A") {
            var html = "<a href=\"" + url + "\" title=\"" + listName + " Changelog\" class=\"button\">Log</a>";
            return html;
        } else {
            return "";
        }
    }
}

function GenerateHtmlDonateLink(url, listName) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = GenerateHtmlDonateLink(url[i], listName[i]);
        }
        return url;
    } else {
        if (url && url != "#N/A") {
            var html = "<a href=\"" + url + "\" title=\"Donate to support the maintainers of " + listName + ".\" class=\"button\">Donate</a>";
            return html;
        } else {
            return "";
        }
    }
}

function GenerateHtmlEmailLink(url, listName) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = GenerateHtmlEmailLink(url[i], listName[i]);
        }
        return url;
    } else {
        if (url && url != "#N/A") {
            var html = "<a href=\"mailto:" + url + "\" title=\"Contribute to " + listName + " via email.\" class=\"button\">Email</a>";
            return html;
        } else {
            return "";
        }
    }
}

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

function GenerateHtmlForumLink(url, listName) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = GenerateHtmlForumLink(url[i], listName[i]);
        }
        return url;
    } else {
        if (url && url != "#N/A") {
            var html = "<a href=\"" + url + "\" title=\"" + listName + " Forum\" class=\"button\">Forum</a>";
            return html;
        } else {
            return "";
        }
    }
}

function GenerateHtmlGuideLink(url, listName) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = GenerateHtmlGuideLink(url[i], listName[i]);
        }
        return url;
    } else {
        if (url && url != "#N/A") {
            var html = "<a href=\"" + url + "\" title=\"" + listName + " Guide\" class=\"button\">Guide</a>";
            return html;
        } else {
            return "";
        }
    }
}

function GenerateHtmlHomeLink(url, listName) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = GenerateHtmlHomeLink(url[i], listName[i]);
        }
        return url;
    } else {
        if (url && url != "#N/A") {
            var html = "<a href=\"" + url + "\" title=\"" + listName + " Home Page\" class=\"button\">Home</a>";
            return html;
        } else {
            return "";
        }
    }
}

function GenerateHtmlIssuesLink(url, listName) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = GenerateHtmlIssuesLink(url[i], listName[i]);
        }
        return url;
    } else {
        if (url && url != "#N/A") {
            var html = "<a href=\"" + url + "\" title=\"" + listName + " GitHub Issues\" class=\"button\">Issues</a>";
            return html;
        } else {
            return "";
        }
    }
}

function GenerateHtmlListName(listName) {
    if (listName instanceof Array) {
        for (i in listName) {
            listName[i] = GenerateHtmlListName(listName[i]);
        }
        return listName;
    } else {
        if (listName) {
            var html = "<h3 id=\"" + listName + "\">" + listName + "</h3>";
            return html;
        } else {
            return "";
        }
    }
}

function GenerateHtmlViewLink(url, listName) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = GenerateHtmlViewLink(url[i], listName[i]);
        }
        return url;
    } else {
        if (url && url != "#N/A") {
            var html = "<a href=\"" + url + "\" title=\"Preview " + listName + " in your browser.\" class=\"button\">View</a>";
            return html;
        } else {
            return "";
        }
    }
}

function TrimUrlSlug(slug) {
    if (slug instanceof Array) {
        for (i in slug) {
            slug[i] = TrimUrlSlug(slug[i]);
        }
        return slug;
    } else {
        if (slug) {
            var charDict = [
                [" ", ""],
                ["\"", ""],
                [":", ""],
                ["'", ""],
                ["+", ""],
                ["(", ""],
                [")", ""],
                [".", ""]
            ];
            for (i = 0; i < charDict.length; ++i) {
                slug = slug.split(charDict[i][0]).join(charDict[i][1]);
            }
            return slug;
        } else {
            return "";
        }
    }
}