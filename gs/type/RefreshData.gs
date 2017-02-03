var typeSheetPrefix = {
    "FilterLists Global": "Global",
    "FilterLists Regional": "Regional",
    "FilterLists Forked": "Forked",
    "FilterLists Combo": "Combo",
    "FilterLists Stale": "Stale"
};

var typeGitHubUrl = {
    "FilterLists Global": "https://raw.githubusercontent.com/collinbarrett/FilterLists/master/json-data/global.json",
    "FilterLists Regional": "https://raw.githubusercontent.com/collinbarrett/FilterLists/master/json-data/regional.json",
    "FilterLists Forked": "https://raw.githubusercontent.com/collinbarrett/FilterLists/master/json-data/forked.json",
    "FilterLists Combo": "https://raw.githubusercontent.com/collinbarrett/FilterLists/master/json-data/combo.json",
    "FilterLists Stale": "https://raw.githubusercontent.com/collinbarrett/FilterLists/master/json-data/stale.json"
};

var ss = SpreadsheetApp.getActiveSpreadsheet(),
    options = [{
        name: "Refresh Data",
        functionName: "refreshJson"
    }, {
        name: "Refresh Scores",
        functionName: "refreshScores"
    }];

function onOpen() {
    ss.addMenu("Refresh Data", options);
    ss.addMenu("Refresh Scores", options);
}

function refreshJson() {
    var sheet = ss.getSheetByName(typeSheetPrefix[ss.getName()] + "Data");
    var data = ImportJson(typeGitHubUrl[ss.getName()], "", "noTruncate,rawHeaders,noInherit");
    for (i = 0; i < data.length; i++) {
        for (j = 0; j < data[0].length; j++) {
            if (data[i][j] == null) {
                data[i][j] = "";
            }
        }
    }
    sheet.clearContents();
    var range = sheet.getRange(1, 1, data.length, data[0].length);
    range.setValues(data);
    refreshParsed();
    refreshPublic();
}

function refreshParsed() {
    var sheetName = typeSheetPrefix[ss.getName()] + "Parsed";
    var sheet = ss.getSheetByName(sheetName);
    var viewColHeader = refreshViewUrl(sheet);
    if (typeSheetPrefix[ss.getName()] != "Combo") {
        refreshAddUrl(sheet, viewColHeader);
    } else {
        viewColHeader = refreshViewUrlCombo(sheet);
        refreshAddUrlCombo(sheet, viewColHeader);
    }
    refreshHomeUrl(sheet, viewColHeader);
    refreshGuideUrl(sheet, viewColHeader);
    refreshForumUrl(sheet, viewColHeader);
    refreshIssuesUrl(sheet, viewColHeader);
    refreshEmailUrl(sheet, viewColHeader);
    refreshChangelogUrl(sheet, viewColHeader);
    refreshDonateUrl(sheet, viewColHeader);
    refreshForksCombos(sheet);
    refreshMaster(sheet);
}

function refreshPublic() {
    var sheetName = typeSheetPrefix[ss.getName()] + "Public";
    var sheet = ss.getSheetByName(sheetName);
    if (typeSheetPrefix[ss.getName()] != "Combo") {
        refreshRegionPublic(sheet);
        refreshListPublic(sheet);
        refreshDescriptionPublic(sheet);
        refreshLinksPublic(sheet);
        refreshForksCombosPublic(sheet);
        refreshMasterPublic(sheet);
    } else {
        refreshListPublicCombo(sheet);
        refreshLinksPublicCombo(sheet);
    }
}

function findColumnHeader(sheet, header) {
    var headerRange = sheet.getRange("A1:1");
    var headerData = headerRange.getValues();
    for (i = 0; i < headerData[0].length; i++) {
        if (headerData[0][i] == header) {
            return String.fromCharCode(65 + i);
        }
    }
    return null;
}

function findUrlColumnHeaders(sheet) {
    var headerRange = sheet.getRange("A1:1");
    var headerData = headerRange.getValues();
    var urlHeaders = new Array();
    for (i = 0; i < headerData[0].length; i++) {
        if (headerData[0][i].indexOf("Url") != -1) {
            urlHeaders.push(headerData[0][i]);
        }
    }
    return urlHeaders;
}

function refreshViewUrl(sheet) {
    var colHeader = findColumnHeader(sheet, "viewUrl");
    if (colHeader) {
        var rangeFull = sheet.getRange(colHeader + "2:" + colHeader);
        rangeFull.clearContent();
        var rangeTop = sheet.getRange(colHeader + "2");
        rangeTop.setValue("=GenerateHtmlViewLink(INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colHeader + "1," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colHeader + "1," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\"))," + typeSheetPrefix[ss.getName()] + "Data!" + colHeader + "2:" + colHeader + ")");
        var data = rangeFull.getDisplayValues();
        rangeFull.clearContent();
        rangeFull.setValues(data);
    }
    return colHeader;
}

function refreshViewUrlCombo(sheet) {
    var colHeader = findColumnHeader(sheet, "viewUrl");
    if (colHeader) {
        var rangeFull = sheet.getRange(colHeader + "2:" + colHeader);
        rangeFull.clearContent();
        var rangeTop = sheet.getRange(colHeader + "2");
        rangeTop.setValue("=GenerateHtmlViewLinkCombo(INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colHeader + "1," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colHeader + "1," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\"))," + typeSheetPrefix[ss.getName()] + "Data!" + colHeader + "2:" + colHeader + ",INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"master\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"master\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\")))");
        var data = rangeFull.getDisplayValues();
        rangeFull.clearContent();
        rangeFull.setValues(data);
    }
    return colHeader;
}

function refreshAddUrl(sheet, viewColHeader) {
    var colHeader = findColumnHeader(sheet, "addUrl");
    if (colHeader) {
        var rangeFull = sheet.getRange(colHeader + "2:" + colHeader);
        rangeFull.clearContent();
        var rangeTop = sheet.getRange(colHeader + "2");
        rangeTop.setValue("=GenerateHtmlAddLink(INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(" + viewColHeader + "1," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(" + viewColHeader + "1," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\"))," + typeSheetPrefix[ss.getName()] + "Data!" + viewColHeader + "2:" + viewColHeader + ")");
        var data = rangeFull.getDisplayValues();
        rangeFull.clearContent();
        rangeFull.setValues(data);
    }
}

function refreshAddUrlCombo(sheet, viewColHeader) {
    var colHeader = findColumnHeader(sheet, "addUrl");
    if (colHeader) {
        var rangeFull = sheet.getRange(colHeader + "2:" + colHeader);
        rangeFull.clearContent();
        var rangeTop = sheet.getRange(colHeader + "2");
        rangeTop.setValue("=GenerateHtmlAddLinkCombo(INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(" + viewColHeader + "1," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(" + viewColHeader + "1," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\"))," + typeSheetPrefix[ss.getName()] + "Data!" + viewColHeader + "2:" + viewColHeader + ",INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"master\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"master\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\")))");
        var data = rangeFull.getDisplayValues();
        rangeFull.clearContent();
        rangeFull.setValues(data);
    }
}

function refreshHomeUrl(sheet, viewColHeader) {
    var colHeader = findColumnHeader(sheet, "homeUrl");
    if (colHeader) {
        var rangeFull = sheet.getRange(colHeader + "2:" + colHeader);
        rangeFull.clearContent();
        var rangeTop = sheet.getRange(colHeader + "2");
        rangeTop.setValue("=GenerateHtmlHomeLink(INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colHeader + "1," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colHeader + "1," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\"))," + typeSheetPrefix[ss.getName()] + "Data!" + viewColHeader + "2:" + viewColHeader + ")");
        var data = rangeFull.getDisplayValues();
        rangeFull.clearContent();
        rangeFull.setValues(data);
    }
}

function refreshGuideUrl(sheet, viewColHeader) {
    var colHeader = findColumnHeader(sheet, "guideUrl");
    if (colHeader) {
        var rangeFull = sheet.getRange(colHeader + "2:" + colHeader);
        rangeFull.clearContent();
        var rangeTop = sheet.getRange(colHeader + "2");
        rangeTop.setValue("=GenerateHtmlGuideLink(INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colHeader + "1," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colHeader + "1," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\"))," + typeSheetPrefix[ss.getName()] + "Data!" + viewColHeader + "2:" + viewColHeader + ")");
        var data = rangeFull.getDisplayValues();
        rangeFull.clearContent();
        rangeFull.setValues(data);
    }
}

function refreshForumUrl(sheet, viewColHeader) {
    var colHeader = findColumnHeader(sheet, "forumUrl");
    if (colHeader) {
        var rangeFull = sheet.getRange(colHeader + "2:" + colHeader);
        rangeFull.clearContent();
        var rangeTop = sheet.getRange(colHeader + "2");
        rangeTop.setValue("=GenerateHtmlForumLink(INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colHeader + "1," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colHeader + "1," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\"))," + typeSheetPrefix[ss.getName()] + "Data!" + viewColHeader + "2:" + viewColHeader + ")");
        var data = rangeFull.getDisplayValues();
        rangeFull.clearContent();
        rangeFull.setValues(data);
    }
}

function refreshIssuesUrl(sheet, viewColHeader) {
    var colHeader = findColumnHeader(sheet, "issuesUrl");
    if (colHeader) {
        var rangeFull = sheet.getRange(colHeader + "2:" + colHeader);
        rangeFull.clearContent();
        var rangeTop = sheet.getRange(colHeader + "2");
        rangeTop.setValue("=GenerateHtmlIssuesLink(INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colHeader + "1," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colHeader + "1," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\"))," + typeSheetPrefix[ss.getName()] + "Data!" + viewColHeader + "2:" + viewColHeader + ")");
        var data = rangeFull.getDisplayValues();
        rangeFull.clearContent();
        rangeFull.setValues(data);
    }
}

function refreshEmailUrl(sheet, viewColHeader) {
    var colHeader = findColumnHeader(sheet, "email");
    if (colHeader) {
        var rangeFull = sheet.getRange(colHeader + "2:" + colHeader);
        rangeFull.clearContent();
        var rangeTop = sheet.getRange(colHeader + "2");
        rangeTop.setValue("=GenerateHtmlEmailLink(INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colHeader + "1," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colHeader + "1," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\"))," + typeSheetPrefix[ss.getName()] + "Data!" + viewColHeader + "2:" + viewColHeader + ")");
        var data = rangeFull.getDisplayValues();
        rangeFull.clearContent();
        rangeFull.setValues(data);
    }
}

function refreshChangelogUrl(sheet, viewColHeader) {
    var colHeader = findColumnHeader(sheet, "changelogUrl");
    if (colHeader) {
        var rangeFull = sheet.getRange(colHeader + "2:" + colHeader);
        rangeFull.clearContent();
        var rangeTop = sheet.getRange(colHeader + "2");
        rangeTop.setValue("=GenerateHtmlChangelogLink(INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colHeader + "1," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colHeader + "1," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\"))," + typeSheetPrefix[ss.getName()] + "Data!" + viewColHeader + "2:" + viewColHeader + ")");
        var data = rangeFull.getDisplayValues();
        rangeFull.clearContent();
        rangeFull.setValues(data);
    }
}

function refreshDonateUrl(sheet, viewColHeader) {
    var colHeader = findColumnHeader(sheet, "donateUrl");
    if (colHeader) {
        var rangeFull = sheet.getRange(colHeader + "2:" + colHeader);
        rangeFull.clearContent();
        var rangeTop = sheet.getRange(colHeader + "2");
        rangeTop.setValue("=GenerateHtmlDonateLink(INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colHeader + "1," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colHeader + "1," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\"))," + typeSheetPrefix[ss.getName()] + "Data!" + viewColHeader + "2:" + viewColHeader + ")");
        var data = rangeFull.getDisplayValues();
        rangeFull.clearContent();
        rangeFull.setValues(data);
    }
}

function refreshForksCombos(sheet) {
    var colHeader = findColumnHeader(sheet, "forksCombos");
    if (colHeader) {
        var rangeFull = sheet.getRange(colHeader + "2:" + colHeader);
        rangeFull.clearContent();
        var rangeTop = sheet.getRange(colHeader + "2");
        rangeTop.setValue("=ARRAYFORMULA(SUBSTITUTE(INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"forksCombos\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"forksCombos\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\")),\",\",\"<br>\"))");
        var data = rangeFull.getDisplayValues();
        rangeFull.clearContent();
        rangeFull.setValues(data);
    }
}

function refreshMaster(sheet) {
    var colHeader = findColumnHeader(sheet, "master");
    if (colHeader) {
        var rangeFull = sheet.getRange(colHeader + "2:" + colHeader);
        rangeFull.clearContent();
        var rangeTop = sheet.getRange(colHeader + "2");
        rangeTop.setValue("=ARRAYFORMULA(SUBSTITUTE(INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"master\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"master\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\")),\",\",\"<br>\"))");
        var data = rangeFull.getDisplayValues();
        rangeFull.clearContent();
        rangeFull.setValues(data);
    }
}

function refreshRegionPublic(sheet) {
    var colHeader = findColumnHeader(sheet, "Region");
    if (colHeader) {
        var rangeFull = sheet.getRange(colHeader + "2:" + colHeader);
        rangeFull.clearContent();
        var rangeTop = sheet.getRange(colHeader + "2");
        rangeTop.setValue("=ARRAYFORMULA(INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"lang\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"lang\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\")))");
        var data = rangeFull.getDisplayValues();
        rangeFull.clearContent();
        rangeFull.setValues(data);
    }
}

function refreshListPublic(sheet) {
    var colHeader = findColumnHeader(sheet, "List");
    if (colHeader) {
        var rangeFull = sheet.getRange(colHeader + "2:" + colHeader);
        rangeFull.clearContent();
        var rangeTop = sheet.getRange(colHeader + "2");
        rangeTop.setValue("=GenerateHtmlListName(INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"list\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"list\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\")))");
        var data = rangeFull.getDisplayValues();
        rangeFull.clearContent();
        rangeFull.setValues(data);
    }
}

function refreshListPublicCombo(sheet) {
    var colHeader = findColumnHeader(sheet, "List");
    if (colHeader) {
        var rangeFull = sheet.getRange(colHeader + "2:" + colHeader);
        rangeFull.clearContent();
        var rangeTop = sheet.getRange(colHeader + "2");
        rangeTop.setValue("=GenerateHtmlListNameCombo(INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"list\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"list\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\")),INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"master\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"master\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\")))");
        var data = rangeFull.getDisplayValues();
        rangeFull.clearContent();
        rangeFull.setValues(data);
    }
}

function refreshDescriptionPublic(sheet) {
    var dataSheetName = typeSheetPrefix[ss.getName()] + "Data";
    var dataSheet = ss.getSheetByName(dataSheetName);
    var sourceUrlColHeader = findColumnHeader(dataSheet, "descrSourceUrl");
    var colHeader = findColumnHeader(sheet, "Description");
    if (colHeader) {
        var rangeFull = sheet.getRange(colHeader + "2:" + colHeader);
        rangeFull.clearContent();
        var rangeTop = sheet.getRange(colHeader + "2");
        if (sourceUrlColHeader) {
            rangeTop.setValue("=ARRAYFORMULA(IF(ISBLANK(INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"descrSourceUrl\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"descrSourceUrl\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\"))),,\"<blockquote cite=\"\"\")&INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"descrSourceUrl\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"descrSourceUrl\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\"))&IF(ISBLANK(INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"descrSourceUrl\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"descrSourceUrl\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\"))),,\"\"\">\")&INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"descr\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"descr\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\"))&IF(ISBLANK(INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"descrSourceUrl\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"descrSourceUrl\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\"))),,\"</blockquote>\"))");
        } else {
            rangeTop.setValue("=ARRAYFORMULA(INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"descr\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"descr\"," + typeSheetPrefix[ss.getName()] + "Data!A1:1,0),4),\"1\",\"\")))");
        }
        var data = rangeFull.getDisplayValues();
        rangeFull.clearContent();
        rangeFull.setValues(data);
    }
}

function refreshLinksPublic(sheet) {
    var colHeader = findColumnHeader(sheet, "Links");
    if (colHeader) {
        var rangeFull = sheet.getRange(colHeader + "2:" + colHeader);
        rangeFull.clearContent();
        var rangeTop = sheet.getRange(colHeader + "2");
        rangeTop.setValue("=ARRAYFORMULA(IF(" + typeSheetPrefix[ss.getName()] + "Parsed!A2:A=\"\",\"\",\"<p>\"&" + typeSheetPrefix[ss.getName()] + "Parsed!A2:A&" + typeSheetPrefix[ss.getName()] + "Parsed!B2:B&" + typeSheetPrefix[ss.getName()] + "Parsed!C2:C&" + typeSheetPrefix[ss.getName()] + "Parsed!D2:D&" + typeSheetPrefix[ss.getName()] + "Parsed!E2:E&" + typeSheetPrefix[ss.getName()] + "Parsed!F2:F&" + typeSheetPrefix[ss.getName()] + "Parsed!G2:G&" + typeSheetPrefix[ss.getName()] + "Parsed!H2:H&" + typeSheetPrefix[ss.getName()] + "Parsed!I2:I&\"</p>\"))");
        var data = rangeFull.getDisplayValues();
        rangeFull.clearContent();
        rangeFull.setValues(data);
    }
}

function refreshLinksPublicCombo(sheet) {
    var colHeader = findColumnHeader(sheet, "Links");
    if (colHeader) {
        var rangeFull = sheet.getRange(colHeader + "2:" + colHeader);
        rangeFull.clearContent();
        var rangeTop = sheet.getRange(colHeader + "2");
        rangeTop.setValue("=ARRAYFORMULA(IF(" + typeSheetPrefix[ss.getName()] + "Parsed!A2:A=\"\",\"\",\"<p>\"&" + typeSheetPrefix[ss.getName()] + "Parsed!A2:A&" + typeSheetPrefix[ss.getName()] + "Parsed!B2:B&\"</p>\"))");
        var data = rangeFull.getDisplayValues();
        rangeFull.clearContent();
        rangeFull.setValues(data);
    }
}

function refreshForksCombosPublic(sheet) {
    var colHeader = findColumnHeader(sheet, "Forks & Combos");
    if (colHeader) {
        var rangeFull = sheet.getRange(colHeader + "2:" + colHeader);
        rangeFull.clearContent();
        var rangeTop = sheet.getRange(colHeader + "2");
        rangeTop.setValue("=ARRAYFORMULA(INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Parsed!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"forksCombos\"," + typeSheetPrefix[ss.getName()] + "Parsed!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"forksCombos\"," + typeSheetPrefix[ss.getName()] + "Parsed!A1:1,0),4),\"1\",\"\")))");
        var data = rangeFull.getDisplayValues();
        rangeFull.clearContent();
        rangeFull.setValues(data);
    }
}

function refreshMasterPublic(sheet) {
    var colHeader = findColumnHeader(sheet, "Master");
    if (colHeader) {
        var rangeFull = sheet.getRange(colHeader + "2:" + colHeader);
        rangeFull.clearContent();
        var rangeTop = sheet.getRange(colHeader + "2");
        rangeTop.setValue("=ARRAYFORMULA(INDIRECT(\"" + typeSheetPrefix[ss.getName()] + "Parsed!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"master\"," + typeSheetPrefix[ss.getName()] + "Parsed!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"master\"," + typeSheetPrefix[ss.getName()] + "Parsed!A1:1,0),4),\"1\",\"\")))");
        var data = rangeFull.getDisplayValues();
        rangeFull.clearContent();
        rangeFull.setValues(data);
    }
}

// refresh each type of url with a separate trigger due to Apps Script execution time limitations
function triggerRefreshHttpResponses1() {
    refreshHttpResponses(1);
}

function triggerRefreshHttpResponses2() {
    refreshHttpResponses(2);
}

function triggerRefreshHttpResponses3() {
    refreshHttpResponses(3);
}

function triggerRefreshHttpResponses4() {
    refreshHttpResponses(4);
}

function triggerRefreshHttpResponses5() {
    refreshHttpResponses(5);
}

function triggerRefreshHttpResponses6() {
    refreshHttpResponses(6);
}

function triggerRefreshHttpResponses7() {
    refreshHttpResponses(7);
}

function triggerRefreshHttpResponses8() {
    refreshHttpResponses(8);
}

function refreshHttpResponses(triggerNum) {
    var sheetNameData = typeSheetPrefix[ss.getName()] + "Data";
    var sheetData = ss.getSheetByName(sheetNameData);
    var sheetNameStatuses = typeSheetPrefix[ss.getName()] + "UrlStatuses";
    var sheetStatuses = ss.getSheetByName(sheetNameStatuses);
    copyListNamesToStatuses(sheetData, sheetStatuses);
    var listDataMax = getNumLists(sheetData)
    var urlHeaders = findUrlColumnHeaders(sheetData);
    if (urlHeaders.length >= triggerNum) {
        var currentUrlType = urlHeaders[triggerNum - 1];
        var colHeaderData = findColumnHeader(sheetData, currentUrlType);
        var colHeaderStatuses = findColumnHeader(sheetStatuses, currentUrlType);
        var rangeData = sheetData.getRange(colHeaderData + "2:" + colHeaderData + (1 + listDataMax));
        var rangeStatuses = sheetStatuses.getRange(colHeaderStatuses + "2:" + colHeaderStatuses);
        rangeStatuses.clearContent();
        for (i = 2; i <= rangeData.getNumRows() + 1; i++) {
            var rangeStatus = sheetStatuses.getRange(colHeaderStatuses + i);
            var url = rangeData.getCell(i - 1, 1).getValue();
            if (url) {
                try {
                    var urlStatus = UrlFetchApp.fetch(url).getResponseCode();
                    rangeStatus.setValue(urlStatus);
                    if (urlStatus != 200) {
                        MailApp.sendEmail(noticeEmailAddress, urlStatus + ": " + url, urlStatus + ": " + url);
                    }
                } catch (err) {
                    rangeStatus.setValue(err.message);
                    MailApp.sendEmail(noticeEmailAddress, "Error: " + url, "Error: " + url + "<br>" + err.message);
                }
            }
        }
    }
}

function copyListNamesToStatuses(sheetData, sheetStatuses) {
    var sourceRange = sheetData.getRange("A1:A");
    var targetRange = sheetStatuses.getRange("A1:A");
    targetRange.clearContent();
    sourceRange.copyTo(targetRange);
}

function getNumLists(sheetData) {
    var listHeaderData = findColumnHeader(sheetData, "viewUrl");
    var listData = sheetData.getRange(listHeaderData + "2:" + listHeaderData);
    for (i = 1; i <= listData.getNumRows(); i++) {
        if (!(listData.getCell(i, 1).getValue())) {
            return i - 1;
        }
    }
}

function refreshScores() {
    var sheetNameData = typeSheetPrefix[ss.getName()] + "Data";
    var sheetData = ss.getSheetByName(sheetNameData);
    var sheetNameScores = typeSheetPrefix[ss.getName()] + "Scores";
    var sheetScores = ss.getSheetByName(sheetNameScores);
    var sheetNamePublic = typeSheetPrefix[ss.getName()] + "Public";
    var sheetPublic = ss.getSheetByName(sheetNamePublic);
    copyListNamesAndViewUrlsToScore(sheetData, sheetScores);
    var colHeader = findColumnHeader(sheetScores, "sumUniqueDailyVisitorsLast30");
    if (colHeader) {
        var rangeFull = sheetScores.getRange(colHeader + "2:" + colHeader);
        rangeFull.clearContent();
        var numLists = getNumLists(sheetScores);
        for (i = 2; i <= numLists + 1; i++) {
            var cellCur = sheetScores.getRange(colHeader + i);
            cellCur.setValue("=ImportJson(CONCATENATE(\"" + piwikUrl + "?module=API&method=Actions.getDownload&downloadUrl=\",EncodeUrl(B" + i + "),\"&idSite=3&date=last30&period=range&format=json&token_auth=" + piwikApiToken + "\"), \"/sum_daily_nb_uniq_visitors\", \"noHeaders\")");
        }
        var data = rangeFull.getDisplayValues();
        rangeFull.clearContent();
        rangeFull.setValues(data);
        for (i = 2; i <= numLists + 1; i++) {
            var sumUniqueDailyVisitorsLast30 = sheetScores.getRange(colHeader + i).getValue();
            if (sumUniqueDailyVisitorsLast30 == "#REF!") {
                var cellCur = sheetScores.getRange(colHeader + i);
                cellCur.setValue("=ImportJson(CONCATENATE(\"" + piwikUrl + "?module=API&method=Actions.getOutlink&outlinkUrl=\",EncodeUrl(B" + i + "),\"&idSite=3&date=last30&period=range&format=json&token_auth=" + piwikApiToken + "\"), \"/sum_daily_nb_uniq_visitors\", \"noHeaders\")");
            }
        }
        var data = rangeFull.getDisplayValues();
        rangeFull.clearContent();
        rangeFull.setValues(data);
        for (i = 2; i <= numLists + 1; i++) {
            var sumUniqueDailyVisitorsLast30 = sheetScores.getRange(colHeader + i).getValue();
            if (sumUniqueDailyVisitorsLast30 == "#REF!") {
                var cellCur = sheetScores.getRange(colHeader + i);
                cellCur.setValue(0);
            }
        }
    }
    var colHeader = findColumnHeader(sheetScores, "score");
    var colHeaderVisitors = findColumnHeader(sheetScores, "sumUniqueDailyVisitorsLast30");
    if (colHeader) {
        var rangeFull = sheetScores.getRange(colHeader + "2:" + colHeader);
        rangeFull.clearContent();
        var numLists = getNumLists(sheetScores);
        for (i = 2; i <= numLists + 1; i++) {
            var cellCur = sheetScores.getRange(colHeader + i);
            cellCur.setValue("=ROUND((100-0)/(MAX($" + colHeaderVisitors + "$2:$" + colHeaderVisitors + ")-MIN($" + colHeaderVisitors + "$2:$" + colHeaderVisitors + "))*($" + colHeaderVisitors + i + "-MAX($" + colHeaderVisitors + "$2:$" + colHeaderVisitors + "))+100)");
        }
        var data = rangeFull.getDisplayValues();
        rangeFull.clearContent();
        rangeFull.setValues(data);
    }
    copyScoresToPublic(sheetScores, sheetPublic);
}

function copyListNamesAndViewUrlsToScore(sheetData, sheetScores) {
    var sourceRangeListNames = sheetData.getRange("A1:A");
    var targetRangeListNames = sheetScores.getRange("A1:A");
    targetRangeListNames.clearContent();
    sourceRangeListNames.copyTo(targetRangeListNames);

    var viewUrlColumn = findColumnHeader(sheetData, "viewUrl");
    var sourceRangeScores = sheetData.getRange(viewUrlColumn + "1:" + viewUrlColumn);
    var targetRangeScores = sheetScores.getRange("B1:B");
    targetRangeScores.clearContent();
    sourceRangeScores.copyTo(targetRangeScores);
}

function copyScoresToPublic(sheetScores, sheetPublic) {
    var colHeaderSource = findColumnHeader(sheetScores, "score");
    var colHeaderTarget = findColumnHeader(sheetPublic, "FilScore");
    var sourceRangeListNames = sheetScores.getRange(colHeaderSource + "2:" + colHeaderSource);
    var targetRangeListNames = sheetPublic.getRange(colHeaderTarget + "2:" + colHeaderTarget);
    targetRangeListNames.clearContent();
    sourceRangeListNames.copyTo(targetRangeListNames);
}