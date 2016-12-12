function GenerateHtmlHomeLink(url, listName) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = GenerateHtmlHomeLink(url[i], listName[i]);
        }
        return url;
    } else {
        if (url) {
            var html = "<a href=\"" + url + "\" title=\"" + listName + " Home Page\" class=\"button\">Home</a>";
            return html;
        } else {
            return "";
        }
    }
}