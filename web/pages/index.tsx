import { ListsTable } from "@/src/components";
import { InferGetStaticPropsType } from "next";

import Head from "next/head";

export default function Home({
  filterlists,
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
        <ListsTable lists={filterlists} />
      </main>
    </>
  );
}

export async function getStaticProps() {
  const res = await fetch(process.env.FILTERLISTS_API_URL + "/lists");
  const filterlists = await res.json();
  return {
    props: { filterlists },
  };
}
