/** @type {import('next').NextConfig} */
const nextConfig = {
  experimental: {
    appDir: true,
  },

  // https://learn.microsoft.com/en-us/azure/static-web-apps/deploy-nextjs-hybrid#enable-standalone-feature
  output: "standalone",
};

module.exports = nextConfig;
