import { Metadata } from "next";

import {
  Card,
  CardContent,
  CardDescription,
  CardHeader,
  CardTitle,
} from "@/components/ui/card";

import { metadata as siteMetadata, title } from "../metadata";

export const metadata: Metadata = {
  title: "About | " + title,
  openGraph: {
    ...siteMetadata.openGraph,
    title: "About | " + title,
  },
  twitter: {
    ...siteMetadata.twitter,
    title: "About | " + title,
  },
};

export default function About() {
  return (
    <div className="grid gap-4 md:gap-8 lg:grid-cols-2 xl:grid-cols-3">
      <Card className="col-span-full w-full" x-chunk="dashboard-01-chunk-4">
        <CardContent className="space-y-4 p-6 !pt-6">
          <p>
            {
              "FilterLists is the independent, comprehensive directory of filter and host lists for advertisements, trackers, malware, and annoyances."
            }
          </p>
          <p>
            {
              "FilterLists helps to protect your privacy and security when using the internet. It provides a comprehensive directory of subscription lists to block advertisements, malware, trackers, and other general annoyances. First, install one of the software tools that supports these lists. Then you can subscribe to a set of these lists inside of that software."
            }
          </p>
          <p>
            {
              "Using a software firewall or adblocker has become a key tool in protecting one's privacy online. While the current business model of the \"free\" internet relies upon advertising revenue, publishers have become too flippant about tracking users without their consent. Advertising networks track users' browsing habits around the internet building lucrative profiles to exploit for targeted marketing or big data research. Until internet publishers develop more transparency or a new business model, we must continue to take the protection of our privacy into our hands."
            }
          </p>
          <p>
            {
              "Typical adblockers run as an extension in popular web browsers. As we browse the internet, they compare HTTP requests to their list of hosts and filters to selectively block advertisements, trackers, and malware. This filtering helps to protect the surfer's privacy, prevents malvertising attacks, and reduces bandwidth requirements. Thousands of contributors work hard to maintain these FilterLists for anyone to use. Locating and selecting these lists, however, has not historically been very easy. This project was launched in 2015 to solve that problem."
            }
          </p>
        </CardContent>
      </Card>
    </div>
  );
}
