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

function createHtmlArrayTags() {
    var tagsHtml = [];
    var numLists = getNumLists(sData);
    var colIndicesDataTags = getColIndicesWithHeaderSubstring(sData, "tag");
    for (var i = 0, colIndicesDataTagsLength = colIndicesDataTags.length; i < colIndicesDataTagsLength; i++) {
        var colTopDataDataTag = sData.getRange(colIndicesDataTags[i] + "1").getValue();
        var colDataDataTag = sData.getRange(colIndicesDataTags[i] + "2:" + colIndicesDataTags[i]).getValues();
        for (var j = 0; j < numLists; j++) {
            if (i == 0) {
                tagsHtml[j] = "";
            }
            if (colDataDataTag[j].toString() != "") {
                var colDataDataTagParsed = colDataDataTag[j].toString().split(',');
                for (var k = 0, colDataDataTagParsedLength = colDataDataTagParsed.length; k < colDataDataTagParsedLength; k++) {
                    switch (colTopDataDataTag) {
                        case "tagLang":
                            tagsHtml[j] += "<img src=\"https://img.shields.io/badge/lang-" + colDataDataTagParsed[k] + "-red.svg\" alt=\"lang: " + colDataDataTagParsed[k] + "\">";
                            break;
                        default:
                    }
                }
            }
        }
    }
    return tagsHtml;
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
            var relatedHtml = "<p>";
            for (var i = 0, relatedArrayLength = relatedArray.length; i < relatedArrayLength; i++) {
                relatedHtml += "<a href=\"#" + trimUrlSlugArray(relatedArray[i]) + "\" class=\"related\"><span class=\"related\">" + relatedArray[i] + "</span></a>";
            }
            relatedHtml += "</p>";
            return relatedHtml;
        }
    }
}