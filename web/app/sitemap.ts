import { MetadataRoute } from "next";

export default function sitemap(): MetadataRoute.Sitemap {
  return [
    {
      url: "https://filterlists.com",
      lastModified: new Date(),
      changeFrequency: "daily",
      priority: 1,
    },
    {
      url: "https://filterlists.com/about",
      lastModified: new Date(),
      changeFrequency: "monthly",
      priority: 2,
    },
  ];
}
