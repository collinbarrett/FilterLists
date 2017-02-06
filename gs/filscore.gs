var filScoreWeight = [
    ["sumUniqueDailyVisitorsLast30", "1"]
];

function refreshFilScores() {
    var columnIndexListData = getColumnIndex(sData, "list");
    var columnIndexListFilScore = getColumnIndex(sFilScore, "list");
    copyRange(sData, columnIndexListData + "2:" + columnIndexListData, sFilScore, columnIndexListFilScore + "2:" + columnIndexListFilScore);
    var columnIndexViewUrlData = getColumnIndex(sData, "viewUrl");
    var columnIndexViewUrlFilScore = getColumnIndex(sFilScore, "viewUrl");
    copyRange(sData, columnIndexViewUrlData + "2:" + columnIndexViewUrlData, sFilScore, columnIndexViewUrlFilScore + "2:" + columnIndexViewUrlFilScore);
    getSumUniqueDailyVisitorsLast30();
    /*calculateFilScore();
    var columnIndexFilScoreFilScore = getColumnIndex(sFilScore, "filScore");
    var columnIndexFilScorePublic = getColumnIndex(sPublic, "filScore");
    copyRange(sFilScore, columnIndexFilScoreFilScore + "2:" + columnIndexFilScoreFilScore, sPublic, columnIndexFilScorePublic + "2:" + columnIndexFilScorePublic);*/
}

function getSumUniqueDailyVisitorsLast30() {
    var columnDataSudvPiwikApiTempRange = sPiwikApiTemp.getRange("A2:A");
    var columnDataSudvPiwikApiTempTopCell = sPiwikApiTemp.getRange("A2");
    columnDataSudvPiwikApiTempRange.clearContent();
    columnDataSudvPiwikApiTempTopCell.setValue("=ImportJson(CONCATENATE(\"" + piwikUrl + "?module=API&method=Actions.getDownloads&idSite=3&period=range&date=last30&flat=1&format=json&token_auth=" + piwikApiToken + "\"), \"/url,/sum_daily_nb_uniq_visitors\", \"noHeaders\")");
    var columnData = columnDataSudvPiwikApiTempRange.getDisplayValues();
    columnDataSudvPiwikApiTempRange.clearContent();
    columnDataSudvPiwikApiTempRange.setValues(columnData);
    moveColumn(sPiwikApiTemp, 1, 2);
    //var columnIndexSudvFilScore = getColumnIndex(sFilScore, "sumUniqueDailyVisitorsLast30");
    //var columnDataSudvFilScoreTopCell = sFilScore.getRange(columnIndexSudvFilScore + "2");
    //columnDataSudvFilScoreTopCell.setValue();
}

function calculateFilScore() {
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
}