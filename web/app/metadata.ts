import { Metadata } from "next";

export const metadata: Metadata = {
  metadataBase: new URL("https://filterlists.com"),
  title:
    "FilterLists | Subscriptions for uBlock Origin, Adblock Plus, AdGuard, ...",
  description:
    "FilterLists is the independent, comprehensive directory of filter and host lists for advertisements, trackers, malware, and annoyances. By Collin M. Barrett.",
  applicationName: "FilterLists",
  authors: [
    {
      name: "Collin M. Barrett",
      url: "https://collinmbarrett.com",
    },
  ],
  generator: "Next.js",
  keywords: [
    "filter lists",
    "ad block",
    "tracker block",
    "malware block",
    "hosts lists",
    "privacy",
    "security",
  ],
  referrer: "origin-when-cross-origin",
  creator: "Collin M. Barrett",
  publisher: "FilterLists",
  alternates: {
    canonical: "https://filterlists.com",
  },
  openGraph: {
    type: "website",
    url: "https://filterlists.com",
    title:
      "FilterLists | Subscriptions for uBlock Origin, Adblock Plus, AdGuard, ...",
    description:
      "FilterLists is the independent, comprehensive directory of filter and host lists for advertisements, trackers, malware, and annoyances. By Collin M. Barrett.",
    siteName: "FilterLists",
  },
  twitter: {
    card: "summary_large_image",
    site: "@FilterLists",
    creator: "@FilterLists",
    title:
      "FilterLists | Subscriptions for uBlock Origin, Adblock Plus, AdGuard, ...",
    description:
      "FilterLists is the independent, comprehensive directory of filter and host lists for advertisements, trackers, malware, and annoyances. By Collin M. Barrett.",
  },
  appleWebApp: {
    capable: true,
    title: "FilterLists",
    statusBarStyle: "black-translucent",
  },
  category: "Technology",
  classification: "Web Directory",
};
