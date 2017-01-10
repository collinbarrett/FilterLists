function TrimUrlSlug(slug) {
    if (slug instanceof Array) {
        for (i in slug) {
            slug[i] = TrimUrlSlug(slug[i]);
        }
        return slug;
    } else {
        if (slug) {
            var charDict = [
                [" ", ""],
                ["\"", ""],
                [":", ""],
                ["'", ""],
                ["+", ""],
                ["(", ""],
                [")", ""],
                [".", ""]
            ];
            for (i = 0; i < charDict.length; ++i) {
                slug = slug.split(charDict[i][0]).join(charDict[i][1]);
            }
            return slug;
        } else {
            return "";
        }
    }
}