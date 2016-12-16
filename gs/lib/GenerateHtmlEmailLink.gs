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
