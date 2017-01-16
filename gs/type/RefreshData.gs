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
    }];

function onOpen() {
    ss.addMenu("Refresh Data", options);
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
    refreshAddUrl(sheet, viewColHeader);
    refreshHomeUrl(sheet, viewColHeader);
    refreshGuideUrl(sheet, viewColHeader);
    refreshForumUrl(sheet, viewColHeader);
    refreshIssuesUrl(sheet, viewColHeader);
    refreshEmailUrl(sheet, viewColHeader);
    refreshChangelogUrl(sheet, viewColHeader);
    refreshDonateUrl(sheet, viewColHeader);
    refreshForksCombos(sheet, viewColHeader);
}

function refreshPublic() {
    var sheetName = typeSheetPrefix[ss.getName()] + "Public";
    var sheet = ss.getSheetByName(sheetName);
    var viewColHeader = refreshViewUrl(sheet);
    refreshListPublic(sheet);
    refreshDescriptionPublic(sheet);
    refreshLinksPublic(sheet);
    refreshForksCombosPublic(sheet);
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