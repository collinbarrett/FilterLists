function fill2dJsonArrayWithNulls(array2d) {
    for (var i = 0,
            var array2dLength = array2d.length; i < array2dLength; i++) {
        for (var j = 0,
                var array2dLength2 = array2d[0].length; j < array2dLength2; j++) {
            if (array2d[i][j] == null) {
                array2d[i][j] = "";
            }
        }
    }
    return array2d;
}

function getColIndex(sheet, colHeader) {
    var headerData = sheet.getRange("A1:1").getValues();
    for (var i = 0,
            var headerDataLength = headerData[0].length; i < headerDataLength; i++) {
        if (headerData[0][i] == colHeader) {
            return String.fromCharCode(65 + i);
        }
    }
    return null;
}

function getColIndexNum(sheet, colHeader) {
    var headerData = sheet.getRange("A1:1").getValues();
    for (var i = 0,
            var headerDataLength = headerData[0].length; i < headerDataLength; i++) {
        if (headerData[0][i] == colHeader) {
            return i + 1;
        }
    }
    return null;
}

function encodeUrlArray(urlArray) {
    if (urlArray instanceof Array) {
        for (var i in urlArray) {
            urlArray[i] = encodeUrlArray(urlArray[i]);
        }
        return urlArray;
    } else {
        if (urlArray) {
            return encodeURIComponent(urlArray);
        } else {
            return "";
        }
    }
}

function trimUrlSlugArray(slugArray) {
    if (slugArray instanceof Array) {
        for (var i in slugArray) {
            slugArray[i] = trimUrlSlugArray(slugArray[i]);
        }
        return slugArray;
    } else {
        if (slugArray) {
            var trimCharacters = [" ", "\"", ":", "'", "+", "(", ")", "."];
            for (var i = 0,
                    var trimCharactersLength = trimCharacters.length; i < trimCharactersLength; i++) {
                slugArray = slugArray.split(trimCharacters[i]).join("");
            }
            return slugArray;
        } else {
            return "";
        }
    }
}

function getNumLists(sheetData) {
    var colIndexDataViewUrl = getColIndex(sData, "viewUrl");
    var colRangeDataViewUrl = sheetData.getRange(colIndexDataViewUrl + "2:" + colIndexDataViewUrl);
    for (var i = 1,
            var colRangeDataViewUrlLength = colRangeDataViewUrl.getNumRows(); i <= colRangeDataViewUrlLength; i++) {
        if (!colRangeDataViewUrl.getCell(i, 1).getValue()) {
            return i - 1;
        }
    }
}

function copyRange(sheetSource, rangeSource, sheetTarget, rangeTarget) {
    var targetRangeListNames = sheetTarget.getRange(rangeTarget);
    targetRangeListNames.clearContent();
    sheetSource.getRange(rangeSource).copyTo(targetRangeListNames);
}
// https://stackoverflow.com/questions/21145080/moving-a-column-in-google-spreadsheet/21152273#21152273
function moveColumn(sheet, iniCol, finCol) {
    var dataRange = sheet.getDataRange();
    var data = arrayMoveColumn(dataRange.getValues(), iniCol - 1, finCol - 1);
    dataRange.setValues(data);
}

function arrayMoveColumn(data, from, to) {
    if (!(data instanceof Array && data[0] instanceof Array)) throw new TypeError('need 2d array');
    if (from >= data[0].length || to >= data[0].length) throw new Error('index out of bounds');
    for (var row = 0,
            var dataLength = data.length; row < dataLength; row++) {
        var temp = data[row].splice(from, 1);
        data[row].splice(to, 0, temp[0]);
    }
    return data;
}