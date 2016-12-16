function EncodeUrlSlug(slug) {
    if (slug instanceof Array) {
        for (i in slug) {
            slug[i] = EncodeUrlSlug(slug[i]);
        }
        return slug;
    } else {
        if (slug) {
            var charDict = [
                [" ", "%20"],
                ["\"", "%22"],
                [":", "%3A"],
                ["'", "%27"],
                ["+", "%2B"],
                ["(", "%28"],
                [")", "%29"],
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
