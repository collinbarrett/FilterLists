/** @type {import('next').NextConfig} */
const nextConfig = {
  reactStrictMode: true,

  // https://learn.microsoft.com/en-us/azure/static-web-apps/deploy-nextjs-hybrid#enable-standalone-feature
  output: "standalone",
  compiler: {
    relay: {
      src: "./",
      language: "typescript",
      artifactDirectory: "./__generated__",
    },
  },
};

module.exports = nextConfig;
