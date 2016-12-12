function GenerateHtmlGuideLink(url, listName) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = GenerateHtmlGuideLink(url[i], listName[i]);
        }
        return url;
    } else {
        if (url) {
            var html = "<a href=\"" + url + "\" title=\"" + listName + " Guide\" class=\"button\">Guide</a>";
            return html;
        } else {
            return "";
        }
    }
}