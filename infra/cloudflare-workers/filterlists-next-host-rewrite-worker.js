/**
 * Cloudflare Worker for next.filterlists.com
 */
export default {
  async fetch(request, _, __) {
    const url = new URL(request.url);

    const azureHostname =
      "app-filterlists-web-prod-h2hecsdqbrach3dt.eastus2-01.azurewebsites.net";
    const originUrl = `https://${azureHostname}${url.pathname}${url.search}`;
    const originRequest = new Request(originUrl, request);

    // HACK: trick Azure App Service free tier into supporting custom domain
    originRequest.headers.set("Host", azureHostname);

    const response = await fetch(originRequest, {
      cf: {
        // force tiered edge caching for server components, next.js pages, etc.
        cacheEverything: true,
      },
    });

    return response;
  },
};
