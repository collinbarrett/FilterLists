var typeSheet = {
    "FilterLists Global": "GlobalData",
    "FilterLists Regional": "RegionalData",
    "FilterLists Forked": "ForkedData",
    "FilterLists Combo": "ComboData",
    "FilterLists Stale": "StaleData"
};

var typeGitHubUrl = {
    "FilterLists Global": "https://raw.githubusercontent.com/collinbarrett/FilterLists/master/json-data/global.json",
    "FilterLists Regional": "https://raw.githubusercontent.com/collinbarrett/FilterLists/master/json-data/regional.json",
    "FilterLists Forked": "https://raw.githubusercontent.com/collinbarrett/FilterLists/master/json-data/forked.json",
    "FilterLists Combo": "https://raw.githubusercontent.com/collinbarrett/FilterLists/master/json-data/combo.json",
    "FilterLists Stale": "https://raw.githubusercontent.com/collinbarrett/FilterLists/master/json-data/stale.json"
};

function onOpen() {
    var ss = SpreadsheetApp.getActiveSpreadsheet(),
        options = [{
            name: "Refresh Data",
            functionName: "refreshJson"
        }, ];
    ss.addMenu("Refresh Data", options);
}

function refreshJson() {
    var ss = SpreadsheetApp.getActiveSpreadsheet();
    var sheet = ss.getSheetByName(typeSheet[ss.getName()]);
    var data = ImportJSON(typeGitHubUrl[ss.getName()], "", "noTruncate,rawHeaders,noInherit");
    for (i = 0; i < data.length; i++) {
        for (j = 0; j < data[0].length; j++) {
            if (data[i][j] == null) {
                data[i][j] = "";
            }
        }
    }
    sheet.clearContents();
    var range = sheet.getRange(1, 1, data.length, data[0].length);
    range.setValues(data)
}