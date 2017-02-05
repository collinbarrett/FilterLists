function fill2dJsonArrayWithNulls(array2d) {
    for (i = 0; i < array2d.length; i++) {
        for (j = 0; j < array2d[0].length; j++) {
            if (array2d[i][j] == null) {
                array2d[i][j] = "";
            }
        }
    }
    return array2d;
}

function getColumnIndex(sheet, columnHeader) {
    var headerRange = sheet.getRange("A1:1");
    var headerData = headerRange.getValues();
    for (i = 0; i < headerData[0].length; i++) {
        if (headerData[0][i] == columnHeader) {
            return String.fromCharCode(65 + i);
        }
    }
    return null;
}

function getColumnIndicesWithHeaderSubstring(sheet, columnHeaderSubstring) {
    var headerRange = sheet.getRange("A1:1");
    var headerData = headerRange.getValues();
    var columnIndices = new Array();
    for (i = 0; i < headerData[0].length; i++) {
        if (headerData[0][i].indexOf(columnHeaderSubstring) != -1) {
            columnIndices.push(headerData[0][i]);
        }
    }
    return columnIndices;
}

function encodeUrlArray(urlArray) {
    if (urlArray instanceof Array) {
        for (i in urlArray) {
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
        for (i in slugArray) {
            slugArray[i] = trimUrlSlugArray(slugArray[i]);
        }
        return slugArray;
    } else {
        if (slugArray) {
            var trimCharacters = [" ", "\"", ":", "'", "+", "(", ")", "."];
            for (i = 0; i < trimCharacters.length; i++) {
                slugArray = slugArray.split(trimCharacters[i]).join("");
            }
            return slugArray;
        } else {
            return "";
        }
    }
}

function getNumLists(sheetData) {
    var listHeaderData = getColumnIndex(sData, "viewUrl");
    var listData = sheetData.getRange(listHeaderData + "2:" + listHeaderData);
    for (i = 1; i <= listData.getNumRows(); i++) {
        if (!(listData.getCell(i, 1).getValue())) {
            return i - 1;
        }
    }
}