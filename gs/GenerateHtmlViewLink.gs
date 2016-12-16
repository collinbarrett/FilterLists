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