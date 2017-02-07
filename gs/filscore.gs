var filScoreWeight = [
    ["sumUniqueDailyVisitorsLast30", "1"]
];

function refreshFilScores() {
    var colIndexDataList = getColumnIndex(sData, "list");
    var colIndexFilScoreList = getColumnIndex(sFilScore, "list");
    copyRange(sData, colIndexDataList + "2:" + colIndexDataList, sFilScore, colIndexFilScoreList + "2:" + colIndexFilScoreList);
    var colIndexDataViewUrl = getColumnIndex(sData, "viewUrl");
    var colIndexFilScoreViewUrl = getColumnIndex(sFilScore, "viewUrl");
    copyRange(sData, colIndexDataViewUrl + "2:" + colIndexDataViewUrl, sFilScore, colIndexFilScoreViewUrl + "2:" + colIndexFilScoreViewUrl);
    getSumUniqueDailyVisitorsLast30();
    calculateFilScore();
    var colIndexFilScoreFilScore = getColumnIndex(sFilScore, "filScore");
    var colIndexFilScorePublic = getColumnIndex(sPublic, "filScore");
    copyRange(sFilScore, colIndexFilScoreFilScore + "2:" + colIndexFilScoreFilScore, sPublic, colIndexFilScorePublic + "2:" + colIndexFilScorePublic);
}

function getSumUniqueDailyVisitorsLast30() {
    var colRangePiwikApiTemp = sPiwikApiTemp.getRange("A2:B");
    colRangePiwikApiTemp.clearContent();
    var colTopPiwikApiTempSudv = sPiwikApiTemp.getRange("A2");
    colTopPiwikApiTempSudv.setValue("=ImportJson(CONCATENATE(\"" + piwikUrl + "?module=API&method=Actions.getDownloads&idSite=3&period=range&date=last30&flat=1&format=json&token_auth=" + piwikApiToken + "\"), \"/url,/sum_daily_nb_uniq_visitors\", \"noHeaders\")");
    var colDataPiwikApiTemp = colRangePiwikApiTemp.getDisplayValues();
    colRangePiwikApiTemp.clearContent();
    colRangePiwikApiTemp.setValues(colDataPiwikApiTemp);
    moveColumn(sPiwikApiTemp, 1, 2);
    var colIndexFilScoreSudv = getColumnIndex(sFilScore, "sumUniqueDailyVisitorsLast30");
    var colTopFilScoreSudv = sFilScore.getRange(colIndexFilScoreSudv + "2");
    var colRangeFilScoreSudv = sFilScore.getRange(colIndexFilScoreSudv + "2:" + colIndexFilScoreSudv);
    colRangeFilScoreSudv.clearContent();
    colTopFilScoreSudv.setValue("=ARRAYFORMULA(IF(ISBLANK($B2:B),\"\",IFERROR(VLOOKUP($B2:B,PiwikApiTemp!$A$2:$B,2,FALSE),0)))");
    var colDataFilScoreSudv = colRangeFilScoreSudv.getDisplayValues();
    colRangeFilScoreSudv.clearContent();
    colRangeFilScoreSudv.setValues(colDataFilScoreSudv);
}

function calculateFilScore() {
    var colIndexFilScoreFilScore = getColumnIndex(sFilScore, "filScore");
    var colRangeFilScoreFilScore = sFilScore.getRange(colIndexFilScoreFilScore + "2:" + colIndexFilScoreFilScore);
    colRangeFilScoreFilScore.clearContent();
    var colTopFilScoreFilScore = sFilScore.getRange(colIndexFilScoreFilScore + "2");
    var colIndexFilScoreSudv = getColumnIndex(sFilScore, "sumUniqueDailyVisitorsLast30");
    //colTopFilScoreFilScore.setValue("=ARRAYFORMULA(IF(ISBLANK($" + colIndexFilScoreSudv + "2:" + colIndexFilScoreSudv + "),\"\",ROUND((100-0)/(MAX($" + colIndexFilScoreSudv + "$2:$" + colIndexFilScoreSudv + ")-MIN($" + colIndexFilScoreSudv + "$2:$" + colIndexFilScoreSudv + "))*($" + colIndexFilScoreSudv + "2:" + colIndexFilScoreSudv + "-MAX($" + colIndexFilScoreSudv + "$2:$" + colIndexFilScoreSudv + "))+100)))");
    colTopFilScoreFilScore.setValue("=ARRAYFORMULA(IF(ISBLANK($" + colIndexFilScoreSudv + "2:" + colIndexFilScoreSudv + "),\"\",PERCENTRANK($" + colIndexFilScoreSudv + "$2:$" + colIndexFilScoreSudv + ",$" + colIndexFilScoreSudv + "2:$" + colIndexFilScoreSudv + ")))");
    var colDataFilScoreFilScore = colRangeFilScoreFilScore.getDisplayValues();
    colRangeFilScoreFilScore.clearContent();
    colRangeFilScoreFilScore.setValues(colDataFilScoreFilScore);
}