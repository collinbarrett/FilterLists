/**
 * Cloudflare Worker for api.filterlists.com
 *
 * This worker enables two key functionalities:
 * 1. Azure App Service Free Tier Custom Domain: Proxies requests to `app-filterlists-directory-prod.azurewebsites.net`, allowing a custom domain (`api.filterlists.com`) with Azure's free tier.
 * 2. Respect Origin Cache-Control: Ensures Cloudflare's edge cache (via Cache API) honors the `Cache-Control` headers sent by the origin for all successful responses, optimizing caching for JSON APIs and static assets.
 */
export default {
  async fetch(request, _, ctx) {
    const cache = caches.default;
    const cacheKey = request;

    let response = await cache.match(cacheKey);

    if (response) {
      return response;
    }

    const url = new URL(request.url);
    const azureHostname = "app-filterlists-directory-prod.azurewebsites.net";
    const originUrl = `https://${azureHostname}${url.pathname}${url.search}`;
    const originRequest = new Request(originUrl, request);

    originRequest.headers.set("Host", azureHostname);

    response = await fetch(originRequest);

    if (response.ok) {
      const responseToCache = response.clone();
      ctx.waitUntil(cache.put(cacheKey, responseToCache));
    }

    return response;
  },
};
