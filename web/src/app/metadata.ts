import type { Metadata } from "next";

export const metadata: Metadata = {
  title: "FilterLists",
  description:
    "FilterLists is the independent, comprehensive directory of filter and host lists for advertisements, trackers, malware, and annoyances. By Collin M. Barrett.",
  keywords: [
    "adblock",
    "filter lists",
    "blocklists",
    "host lists",
    "privacy",
    "malware",
    "tracker",
    "adblock plus",
    "ublock origin",
    "adguard",
    "internet explorer tpl",
    "dns",
    "content blocking",
    "open source",
    "collin barrett",
  ],
  authors: [{ name: "Collin M. Barrett", url: "https://collinmbarrett.com" }],
  creator: "Collin M. Barrett",
  publisher: "Collin M. Barrett",
  metadataBase: new URL("https://filterlists.com"),
  alternates: {
    canonical: "https://filterlists.com/",
  },
  openGraph: {
    title: "FilterLists",
    description:
      "The independent, comprehensive directory of filter and host lists for advertisements, trackers, malware, and annoyances.",
    url: "https://filterlists.com/",
    siteName: "FilterLists",
    images: [
      {
        url: "/logo-filterlists.png",
        width: 1200,
        height: 280,
        alt: "FilterLists logo",
      },
    ],
    locale: "en_US",
    type: "website",
  },
  twitter: {
    card: "summary_large_image",
    title: "FilterLists",
    description:
      "The independent, comprehensive directory of filter and host lists for advertisements, trackers, malware, and annoyances.",
    images: [
      {
        url: "/logo-filterlists.png",
        alt: "FilterLists logo",
      },
    ],
  },
  icons: {
    icon: "/icon.svg",
  },
  applicationName: "FilterLists",
  generator: "Next.js",
  referrer: "no-referrer",
  appleWebApp: {
    capable: true,
    title: "FilterLists",
    statusBarStyle: "default",
  },
  abstract:
    "FilterLists is a directory of filter and host lists for adblockers and privacy tools.",
  category: "Internet",
  classification: "Web Directory",
};
