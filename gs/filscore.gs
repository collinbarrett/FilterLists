var filScoreWeight = [
    ["sumUniqueDailyVisitorsLast30", "1"]
];

function refreshFilScores() {
    copyListToFilScore();
    copyViewUrlToFilScore();
    getSumUniqueDailyVisitorsLast30();
    calculateSumUniqueDailyVisitorsLast30Score();
    calculateFilScore();
    copyFilScoreToPublic();
}

function copyListToFilScore() {
    var colIndexDataList = getColIndex(sData, "list");
    var colIndexFilScoreList = getColIndex(sFilScore, "list");
    copyRange(sData, colIndexDataList + "2:" + colIndexDataList, sFilScore, colIndexFilScoreList + "2:" + colIndexFilScoreList);
}

function copyViewUrlToFilScore() {
    var colIndexDataViewUrl = getColIndex(sData, "viewUrl");
    var colIndexFilScoreViewUrl = getColIndex(sFilScore, "viewUrl");
    copyRange(sData, colIndexDataViewUrl + "2:" + colIndexDataViewUrl, sFilScore, colIndexFilScoreViewUrl + "2:" + colIndexFilScoreViewUrl);
}

function getSumUniqueDailyVisitorsLast30() {
    getDownloadsFromPiwikApi();
    moveColumn(sPiwikApiTemp, 1, 2);
    copyPiwikDownloadsToFilScore();
}

function getDownloadsFromPiwikApi() {
    var colRangePiwikApiTemp = sPiwikApiTemp.getRange("A2:B");
    colRangePiwikApiTemp.clearContent();
    var colTopPiwikApiTempSudv = sPiwikApiTemp.getRange("A2");
    colTopPiwikApiTempSudv.setValue("=ImportJson(CONCATENATE(\"" + piwikUrl + "?module=API&method=Actions.getDownloads&idSite=3&period=range&date=last30&flat=1&format=json&token_auth=" + piwikApiToken + "\"), \"/url,/sum_daily_nb_uniq_visitors\", \"noHeaders\")");
    var colDataPiwikApiTemp = colRangePiwikApiTemp.getDisplayValues();
    colRangePiwikApiTemp.clearContent();
    colRangePiwikApiTemp.setValues(colDataPiwikApiTemp);
}

function copyPiwikDownloadsToFilScore() {
    var colIndexFilScoreSudv = getColIndex(sFilScore, "sumUniqueDailyVisitorsLast30");
    var colTopFilScoreSudv = sFilScore.getRange(colIndexFilScoreSudv + "2");
    var colRangeFilScoreSudv = sFilScore.getRange(colIndexFilScoreSudv + "2:" + colIndexFilScoreSudv);
    colRangeFilScoreSudv.clearContent();
    colTopFilScoreSudv.setValue("=ARRAYFORMULA(IF(ISBLANK($B2:B),\"\",IFERROR(VLOOKUP($B2:B,PiwikApiTemp!$A$2:$B,2,FALSE),0)))");
    var colDataFilScoreSudv = colRangeFilScoreSudv.getDisplayValues();
    colRangeFilScoreSudv.clearContent();
    colRangeFilScoreSudv.setValues(colDataFilScoreSudv);
}

function calculateSumUniqueDailyVisitorsLast30Score() {
    var colIndexFilScoreSudvScore = getColIndex(sFilScore, "sumUniqueDailyVisitorsLast30Score");
    var colRangeFilScoreSudvScore = sFilScore.getRange(colIndexFilScoreSudvScore + "2:" + colIndexFilScoreSudvScore);
    colRangeFilScoreSudvScore.clearContent();
    var colTopFilScoreSudvScore = sFilScore.getRange(colIndexFilScoreSudvScore + "2");
    var colIndexFilScoreSudv = getColIndex(sFilScore, "sumUniqueDailyVisitorsLast30");
    colTopFilScoreSudvScore.setValue("=ARRAYFORMULA(IF(ISBLANK($" + colIndexFilScoreSudv + "2:" + colIndexFilScoreSudv + "),\"\",PERCENTRANK($" + colIndexFilScoreSudv + "$2:$" + colIndexFilScoreSudv + ",$" + colIndexFilScoreSudv + "2:$" + colIndexFilScoreSudv + ")))");
    var colDataFilScoreSudvScore = colRangeFilScoreSudvScore.getDisplayValues();
    colRangeFilScoreSudvScore.clearContent();
    colRangeFilScoreSudvScore.setValues(colDataFilScoreSudvScore);
}

function calculateFilScore() {
    var filScoreArrayFormula = "=ARRAYFORMULA(";
    for (var i = 0, filScoreWeightLength = filScoreWeight.length; i < filScoreWeightLength; i++) {
        var colIndex = getColIndex(sFilScore, filScoreWeight[i][0] + "Score");
        if (i > 0) {
            filScoreArrayFormula += "*";
        }
        filScoreArrayFormula += "(IF(ISBLANK($" + colIndex + "2:$" + colIndex + "),\"\"," + filScoreWeight[i][1] + "*$" + colIndex + "2:$" + colIndex + "))";
    }
    filScoreArrayFormula += ")";
    updateFilScoreArrayFormula(filScoreArrayFormula)
}

function updateFilScoreArrayFormula(filScoreArrayFormula) {
    var colIndexFilScoreFilScore = getColIndex(sFilScore, "filScore");
    var colRangeFilScoreFilScore = sFilScore.getRange(colIndexFilScoreFilScore + "2:" + colIndexFilScoreFilScore);
    colRangeFilScoreFilScore.clearContent();
    var colTopFilScoreFilScore = sFilScore.getRange(colIndexFilScoreFilScore + "2");
    colTopFilScoreFilScore.setValue(filScoreArrayFormula);
    var colDataFilScoreFilScore = colRangeFilScoreFilScore.getDisplayValues();
    colRangeFilScoreFilScore.clearContent();
    colRangeFilScoreFilScore.setValues(colDataFilScoreFilScore);
}

function copyFilScoreToPublic() {
    var colIndexFilScoreFilScore = getColIndex(sFilScore, "filScore");
    var colIndexFilScorePublic = getColIndex(sPublic, "filScore");
    copyRange(sFilScore, colIndexFilScoreFilScore + "2:" + colIndexFilScoreFilScore, sPublic, colIndexFilScorePublic + "2:" + colIndexFilScorePublic);
}