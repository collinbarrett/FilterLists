function refreshData() {
    var data = ImportJSON("https://raw.githubusercontent.com/collinbarrett/FilterLists/master/json-data/filterlists.json", "", "noTruncate,rawHeaders,noInherit");
    data = fill2dJsonArrayWithNulls(data);
    sData.clearContents();
    sData.getRange(1, 1, data.length, data[0].length).setValues(data);
    concatNamelessComboLists();
    sData.getRange(2, 1, data.length, data[0].length).sort(1);
    refreshParsed();
    refreshPublic();
}

function concatNamelessComboLists() {
    var numLists = getNumLists(sData);
    var colIndexNumDataList = getColIndexNum(sData, "list");
    var colRangeDataList = sData.getRange(2, colIndexNumDataList, numLists, 1).getValues();
    var colRangeDataRelated = sData.getRange(2, getColIndexNum(sData, "related"), numLists, 1).getValues();
    for (var i = 0; i < numLists; i++) {
        if (!colRangeDataList[i][0]) {
            colRangeDataList[i][0] = colRangeDataRelated[i][0].replace(/,/g, " + ");
        }
    }
    sData.getRange(2, colIndexNumDataList, numLists, 1).setValues(colRangeDataList);
}

function refreshParsed() {
    var parsedFields = ["tags", "viewUrl", "addUrl", "homeUrl", "forumUrl", "issuesUrl", "email", "donateUrl"];
    for (var i = 0, parsedFieldsLength = parsedFields.length; i < parsedFieldsLength; i++) {
        var colIndexParsedUrlType = getColIndex(sParsed, parsedFields[i]);
        var colRangeParsedUrlType = sParsed.getRange(colIndexParsedUrlType + "2:" + colIndexParsedUrlType);
        colRangeParsedUrlType.clearContent();
        var colTopParsedUrlType = sParsed.getRange(colIndexParsedUrlType + "2");
        switch (parsedFields[i]) {
            case "tags":
                colTopParsedUrlType.setValue("=createHtmlArrayTags()");
                break;
            case "viewUrl":
                colTopParsedUrlType.setValue("=createHtmlArrayLinkButton(\"viewUrl\",INDIRECT(\"Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colIndexParsedUrlType + "1,Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colIndexParsedUrlType + "1,Data!A1:1,0),4),\"1\",\"\")),Data!A2:A)");
                break;
            case "addUrl":
                var colIndexDataViewUrl = getColIndex(sData, "viewUrl");
                colTopParsedUrlType.setValue("=createHtmlArrayLinkButton(\"addUrl\",INDIRECT(\"Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(Data!" + colIndexDataViewUrl + "1,Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(Data!" + colIndexDataViewUrl + "1,Data!A1:1,0),4),\"1\",\"\")),Data!A2:A)");
                break;
            case "homeUrl":
                colTopParsedUrlType.setValue("=createHtmlArrayLinkButton(\"homeUrl\",INDIRECT(\"Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colIndexParsedUrlType + "1,Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colIndexParsedUrlType + "1,Data!A1:1,0),4),\"1\",\"\")),Data!A2:A)");
                break;
            case "forumUrl":
                colTopParsedUrlType.setValue("=createHtmlArrayLinkButton(\"forumUrl\",INDIRECT(\"Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colIndexParsedUrlType + "1,Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colIndexParsedUrlType + "1,Data!A1:1,0),4),\"1\",\"\")),Data!A2:A)");
                break;
            case "issuesUrl":
                colTopParsedUrlType.setValue("=createHtmlArrayLinkButton(\"issuesUrl\",INDIRECT(\"Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colIndexParsedUrlType + "1,Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colIndexParsedUrlType + "1,Data!A1:1,0),4),\"1\",\"\")),Data!A2:A)");
                break;
            case "email":
                colTopParsedUrlType.setValue("=createHtmlArrayLinkButton(\"email\",INDIRECT(\"Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colIndexParsedUrlType + "1,Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colIndexParsedUrlType + "1,Data!A1:1,0),4),\"1\",\"\")),Data!A2:A)");
                break;
            case "donateUrl":
                colTopParsedUrlType.setValue("=createHtmlArrayLinkButton(\"donateUrl\",INDIRECT(\"Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colIndexParsedUrlType + "1,Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(" + colIndexParsedUrlType + "1,Data!A1:1,0),4),\"1\",\"\")),Data!A2:A)");
                break;
            default:
        }
        var colDataParsedUrlType = colRangeParsedUrlType.getDisplayValues();
        colRangeParsedUrlType.clearContent();
        colRangeParsedUrlType.setValues(colDataParsedUrlType);
    }
}

function refreshPublic() {
    var publicFields = ["list", "tags", "description", "links", "related"];
    for (var i = 0, publicFieldsLength = publicFields.length; i < publicFieldsLength; i++) {
        var colIndexPublicPublicField = getColIndex(sPublic, publicFields[i]);
        var colRangePublicPublicField = sPublic.getRange(colIndexPublicPublicField + "2:" + colIndexPublicPublicField);
        colRangePublicPublicField.clearContent();
        var colTopPublicPublicField = sPublic.getRange(colIndexPublicPublicField + "2");
        switch (publicFields[i]) {
            case "list":
                colTopPublicPublicField.setValue("=createHtmlArrayListName(INDIRECT(\"Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"list\",Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"list\",Data!A1:1,0),4),\"1\",\"\")))");
                break;
            case "tags":
                colTopPublicPublicField.setValue("=ARRAYFORMULA(INDIRECT(\"Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"tagLang\",Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"tagLang\",Data!A1:1,0),4),\"1\",\"\")))");
                break;
            case "description":
                if (getColIndex(sData, "descrSourceUrl")) {
                    colTopPublicPublicField.setValue("=ARRAYFORMULA(IF(ISBLANK(INDIRECT(\"Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"descrSourceUrl\",Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"descrSourceUrl\",Data!A1:1,0),4),\"1\",\"\"))),,\"<blockquote cite=\"\"\")&INDIRECT(\"Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"descrSourceUrl\",Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"descrSourceUrl\",Data!A1:1,0),4),\"1\",\"\"))&IF(ISBLANK(INDIRECT(\"Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"descrSourceUrl\",Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"descrSourceUrl\",Data!A1:1,0),4),\"1\",\"\"))),,\"\"\">\")&INDIRECT(\"Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"descr\",Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"descr\",Data!A1:1,0),4),\"1\",\"\"))&IF(ISBLANK(INDIRECT(\"Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"descrSourceUrl\",Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"descrSourceUrl\",Data!A1:1,0),4),\"1\",\"\"))),,\"</blockquote>\"))");
                } else {
                    colTopPublicPublicField.setValue("=ARRAYFORMULA(INDIRECT(\"Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"descr\",Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"descr\",Data!A1:1,0),4),\"1\",\"\")))");
                }
                break;
            case "links":
                colTopPublicPublicField.setValue("=ARRAYFORMULA(IF(Parsed!B2:B=\"\",\"\",\"<p>\"&Parsed!B2:B&Parsed!C2:C&Parsed!D2:D&Parsed!E2:E&Parsed!F2:F&Parsed!G2:G&Parsed!H2:H&\"</p>\"))");
                break;
            case "related":
                colTopPublicPublicField.setValue("=createHtmlArrayRelatedLists(INDIRECT(\"Data!\"&SUBSTITUTE(ADDRESS(1,MATCH(\"related\",Data!A1:1,0),4),\"1\",\"2\")&\":\"&SUBSTITUTE(ADDRESS(1,MATCH(\"related\",Data!A1:1,0),4),\"1\",\"\")))");
                break;
            default:
        }
        var colDataPublicPublicField = colRangePublicPublicField.getDisplayValues();
        colRangePublicPublicField.clearContent();
        colRangePublicPublicField.setValues(colDataPublicPublicField);
    }
}