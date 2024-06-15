import { MetadataRoute } from "next";

export default function robots(): MetadataRoute.Robots {
  return {
    rules: {
      userAgent: "*",
      //   allow: "/", // TODO: allow all when going live
      disallow: "/",
    },
    sitemap: "https://filterlists.com/sitemap.xml",
  };
}
