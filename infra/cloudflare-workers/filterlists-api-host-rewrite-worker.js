/**
 * Cloudflare Worker for api.filterlists.com
 */
export default {
  async fetch(request, _, __) {
    const url = new URL(request.url);

    // Handle OPTIONS preflight requests for CORS
    if (request.method === "OPTIONS") {
      return handleOptions(request);
    }

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

    // Ensure CORS headers are present in the response
    return addCorsHeaders(response, request);
  },
};

/**
 * Handle OPTIONS preflight requests
 */
function handleOptions(request) {
  const origin = request.headers.get("Origin");
  
  // Allow CORS from filterlists.com domains and localhost
  const allowedOrigins = [
    "https://filterlists.com",
    "https://next.filterlists.com",
    "http://localhost:3000",
  ];
  
  // Check if origin is allowed or matches staging pattern
  const isAllowed = allowedOrigins.includes(origin) ||
    (origin && origin.startsWith("https://nice-water-05873140f-") && 
     origin.endsWith(".eastus2.5.azurestaticapps.net"));

  if (isAllowed) {
    return new Response(null, {
      status: 204,
      headers: {
        "Access-Control-Allow-Origin": origin,
        "Access-Control-Allow-Methods": "GET, OPTIONS",
        "Access-Control-Allow-Headers": request.headers.get("Access-Control-Request-Headers") || "*",
        "Access-Control-Max-Age": "86400",
      },
    });
  }

  return new Response(null, { status: 403 });
}

/**
 * Add CORS headers to response
 */
function addCorsHeaders(response, request) {
  const origin = request.headers.get("Origin");
  
  // Allow CORS from filterlists.com domains and localhost
  const allowedOrigins = [
    "https://filterlists.com",
    "https://next.filterlists.com",
    "http://localhost:3000",
  ];
  
  // Check if origin is allowed or matches staging pattern
  const isAllowed = allowedOrigins.includes(origin) ||
    (origin && origin.startsWith("https://nice-water-05873140f-") && 
     origin.endsWith(".eastus2.5.azurestaticapps.net"));

  if (!isAllowed) {
    return response;
  }

  // Clone the response so we can modify headers
  const newResponse = new Response(response.body, response);
  
  // Set CORS headers
  newResponse.headers.set("Access-Control-Allow-Origin", origin);
  newResponse.headers.set("Access-Control-Allow-Methods", "GET, OPTIONS");
  newResponse.headers.set("Vary", "Origin");
  
  return newResponse;
}
