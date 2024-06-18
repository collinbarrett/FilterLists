import { Metadata } from "next";

import {
  Card,
  CardContent,
  CardDescription,
  CardHeader,
  CardTitle,
} from "@/components/ui/card";

import { metadata as siteMetadata } from "../metadata";

export const metadata: Metadata = {
  title:
    "About | FilterLists | Subscriptions for uBlock Origin, Adblock Plus, AdGuard, ...",
  openGraph: {
    ...siteMetadata.openGraph,
    title:
      "About | FilterLists | Subscriptions for uBlock Origin, Adblock Plus, AdGuard, ...",
  },
  twitter: {
    ...siteMetadata.twitter,
    title:
      "About | FilterLists | Subscriptions for uBlock Origin, Adblock Plus, AdGuard, ...",
  },
};

export default function About() {
  return (
    <div className="grid gap-4 md:gap-8 lg:grid-cols-2 xl:grid-cols-3">
      <Card className="col-span-full w-full" x-chunk="dashboard-01-chunk-4">
        <CardHeader className="flex flex-row items-center">
          <div className="grid gap-2">
            <CardTitle>FilterLists</CardTitle>
            <CardDescription></CardDescription>
          </div>
        </CardHeader>
        <CardContent>
          <p>
            FilterLists is the independent, comprehensive directory of filter
            and host lists for advertisements, trackers, malware, and
            annoyances. Subscriptions for uBlock Origin, Adblock Plus, AdGuard,
            ...
          </p>
        </CardContent>
      </Card>
    </div>
  );
}
