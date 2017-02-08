function createHtmlArrayLinkButton(htmlType, url, listName) {
    if (url instanceof Array) {
        for (var i in url) {
            url[i] = createHtmlArrayLinkButton(htmlType, url[i], listName[i]);
        }
        return url;
    } else {
        if (url && url != "#N/A") {
            switch (htmlType) {
                case "viewUrl":
                    return "<a href=\"" + url + "\" title=\"Preview " + listName + " in your browser.\" class=\"button piwik_download\">View</a>";
                    break;
                case "addUrl":
                    return "<a href=\"abp:subscribe?location=" + url + "&title=" + listName + "\" title=\"Subscribe to " + listName + " in your content blocker.\" class=\"button piwik_download\">Add</a>";
                    break;
                case "homeUrl":
                    return "<a href=\"" + url + "\" title=\"" + listName + " Home Page\" class=\"button\">Home</a>";
                    break;
                case "forumUrl":
                    return "<a href=\"" + url + "\" title=\"" + listName + " Forum\" class=\"button\">Forum</a>";
                    break;
                case "issuesUrl":
                    return "<a href=\"" + url + "\" title=\"" + listName + " GitHub Issues\" class=\"button\">Issues</a>";
                    break;
                case "email":
                    return "<a href=\"mailto:" + url + "\" title=\"Contribute to " + listName + " via email.\" class=\"button\">Email</a>";
                    break;
                case "donateUrl":
                    return "<a href=\"" + url + "\" title=\"Donate to support the maintainers of " + listName + ".\" class=\"button\">Donate</a>";
                    break;
                default:
                    return "";
            }
        } else {
            return "";
        }
    }
}

function createHtmlArrayListName(list) {
    if (list instanceof Array) {
        for (var i in list) {
            list[i] = createHtmlArrayListName(list[i]);
        }
        return list;
    } else {
        if (list) {
            return "<h3 id=\"" + trimUrlSlugArray(list) + "\">" + list + "</h3>";
        } else {
            return "";
        }
    }
}

function createHtmlArrayRelatedLists(related) {
    if (related instanceof Array) {
        for (var i in related) {
            related[i] = createHtmlArrayRelatedLists(related[i]);
        }
        return related;
    } else {
        if (!related) {
            return "";
        } else {
            var relatedArray = related.split(',');
            var relatedHtml = "<ul>";
            for (var i = 0,
                    var relatedArrayLength = relatedArray.length; i < relatedArrayLength; i++) {
                relatedHtml += "<li><a href=\"#" + trimUrlSlugArray(relatedArray[i]) + "\">" + relatedArray[i] + "</a></li>";
            }
            relatedHtml += "</ul>";
            return relatedHtml;
        }
    }
}