/**
 * Cloudflare Worker for api.filterlists.com
 */
export default {
  async fetch(request, _, __) {
    const url = new URL(request.url);

    const azureHostname = "app-filterlists-directory-prod.azurewebsites.net";
    const originUrl = `https://${azureHostname}${url.pathname}${url.search}`;
    const originRequest = new Request(originUrl, request);

    // HACK: trick Azure App Service free tier into supporting custom domain
    originRequest.headers.set("Host", azureHostname);

    const response = await fetch(originRequest, {
      cf: {
        // force tiered edge caching for API responses
        cacheEverything: true,
      },
    });

    return response;
  },
};
