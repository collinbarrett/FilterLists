function EncodeUrl(url) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = EncodeUrl(url[i]);
        }
        return url;
    } else {
        return encodeURIComponent(url);
    }
}