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
                        if (!(urlResponseWhitelist.indexOf(url) > -1)) {
                            MailApp.sendEmail(noticeEmailAddress, urlStatus + ": " + url, urlStatus + ": " + url);
                        }
                    }
                } catch (err) {
                    rangeStatus.setValue(err.message);
                    if (!(urlResponseWhitelist.indexOf(url) > -1)) {
                        MailApp.sendEmail(noticeEmailAddress, "Error: " + url, "Error: " + url + "<br>" + err.message);
                    }
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