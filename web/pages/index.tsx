import { ListsTable } from "@/src/components";
import { InferGetStaticPropsType } from "next";

import Head from "next/head";

export default function Home({
  jsonData,
}: InferGetStaticPropsType<typeof getStaticProps>) {
  return (
    <>
      <Head>
        <title>
          FilterLists | Subscriptions for uBlock Origin, Adblock Plus,
          AdGuard,...
        </title>
        <meta
          name="description"
          content="FilterLists is the independent, comprehensive directory of filter and host lists for advertisements, trackers, malware, and annoyances. By Collin M. Barrett."
        />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <link rel="icon" href="/favicon.ico" />
      </Head>
      <main>
        <ListsTable {...jsonData} />
      </main>
    </>
  );
}

export async function getStaticProps() {
  const url =
    `${process.env.NEXT_PUBLIC_FILTERLISTS_API_URL}/lists?` +
    new URLSearchParams({
      $count: "true",
      $top: "10",
    });
  const response = await fetch(url);
  const jsonData = await response.json();
  return {
    props: { jsonData },
  };
}
