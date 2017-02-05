var ss = SpreadsheetApp.getActiveSpreadsheet();
var sData = ss.getSheetByName("Data");
var sFilScore = ss.getSheetByName("FilScore");
var sHttpResponse = ss.getSheetByName("HttpResponse");
var sParsed = ss.getSheetByName("Parsed");
var sPublic = ss.getSheetByName("Public");

function onOpen() {
    var ui = SpreadsheetApp.getUi();
    ui.createMenu('Refresh').addItem('Refresh All', 'refreshAll').addSeparator().addItem('Refresh Data', 'refreshData').addItem('Refresh FilScores', 'refreshFilScores').addToUi();
}

function refreshAll() {
    refreshData();
    refreshFilScores();
}