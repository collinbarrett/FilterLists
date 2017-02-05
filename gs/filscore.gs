function refreshFilScores() {
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