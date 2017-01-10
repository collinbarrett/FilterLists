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