function GenerateHtmlDonateLink(url, listName) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = GenerateHtmlDonateLink(url[i], listName[i]);
        }
        return url;
    } else {
        if (url) {
            var html = "<a href=\"" + url + "\" title=\"Donate to support the maintainers of " + listName + ".\" class=\"button\">Donate</a>";
            return html;
        } else {
            return "";
        }
    }
}