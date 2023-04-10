/** @type {import('next').NextConfig} */
const nextConfig = {
  reactStrictMode: true,

  // https://learn.microsoft.com/en-us/azure/static-web-apps/deploy-nextjs-hybrid#enable-standalone-feature
  output: "standalone",
};

module.exports = nextConfig;
