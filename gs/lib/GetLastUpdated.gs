//https://archive.org/help/wayback_api.php
//https://developers.google.com/apps-script/guides/services/external
//http://momentjs.com/
var moment = Moment.load();

function GetLastUpdated(urlToCheck) {
    urlToCheck = urlToCheck.replace("http://", "");
    urlToCheck = urlToCheck.replace("https://", "");
    var apiCall = 'http://archive.org/wayback/available?url=' + urlToCheck;
    try {
        var response = UrlFetchApp.fetch(apiCall);
    } catch (e) {
        var sleepTime = Math.floor(Math.random() * 9000) + 1000;
        Utilities.sleep(sleepTime);
        var response = UrlFetchApp.fetch(apiCall);
    }
    var json = response.getContentText();
    var data = JSON.parse(json);
    return moment(data.archived_snapshots.closest.timestamp, "YYYYMMDDhhmmss").fromNow();;
}
