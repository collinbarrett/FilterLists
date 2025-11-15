# Cloudflare Workers

## Deployment

Currently, these workers are manually deployed via the Cloudflare Portal UI:

1. Go to the [Cloudflare Workers dashboard](https://dash.cloudflare.com/)
2. Select the appropriate worker
3. Copy and paste the updated code from the respective `.js` file
4. Click "Save and Deploy"

## filterlists-api-host-rewrite-worker.js

This worker is deployed at `api.filterlists.com` and:

- Proxies requests to the Azure App Service backend
- Handles CORS preflight (OPTIONS) requests
- Adds CORS headers to responses for allowed origins
- Enables Cloudflare edge caching for API responses

### Allowed Origins

- `https://filterlists.com`
- `https://next.filterlists.com`
- `http://localhost:3000`
- Azure Static Web Apps staging environments matching the pattern: `https://nice-water-05873140f-*.eastus2.5.azurestaticapps.net`

**Important**: After updating this file, remember to manually deploy the changes via the Cloudflare Portal UI.
