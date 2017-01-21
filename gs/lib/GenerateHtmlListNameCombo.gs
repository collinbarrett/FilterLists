function GenerateHtmlListNameCombo(listName, masterLists) {
    if (listName instanceof Array) {
        for (i in listName) {
            listName[i] = GenerateHtmlListNameCombo(listName[i], masterLists[i]);
        }
        return listName;
    } else {
        var masterListNames = "";
        masterLists.split(/\s*,\s*/).forEach(function(masterListsSplit) {
            masterListNames += masterListsSplit + " + ";
        });
        masterListNames = masterListNames.slice(0, -3)
        if (listName) {
            var html = "<h3 id=\"" + listName + "\">" + listName + "</h3><br>";
            html += masterListNames;
            return html;
        } else if (masterLists) {
            var html = "<h3 id=\"" + TrimUrlSlug(masterListNames) + "\">" + masterListNames + "</h3>";
            return html;
        } else {
            return "";
        }
    }
}