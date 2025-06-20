/**
 * Cloudflare Worker for next.filterlists.com
 *
 * Azure App Service Free Tier Custom Domain: Proxies requests to `app-filterlists-web-prod-h2hecsdqbrach3dt.eastus2-01.azurewebsites.net`, allowing a custom domain (`next.filterlists.com`) with Azure's free tier.
 */
export default {
  async fetch(request, _, __) {
    const url = new URL(request.url);
    const azureHostname = "app-filterlists-web-prod-h2hecsdqbrach3dt.eastus2-01.azurewebsites.net";
    const originUrl = `https://${azureHostname}${url.pathname}${url.search}`;
    const originRequest = new Request(originUrl, request);

    // re-write Host header to trick App Service free tier into supporting custom domain
    originRequest.headers.set("Host", azureHostname);

    // delete cookie to trick Cloudflare into caching static HTML
    originRequest.headers.delete('cookie');
    
    return await fetch(originRequest);
  },
};
