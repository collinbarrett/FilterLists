import { ListsTable } from "@/src/components";
import { InferGetStaticPropsType } from "next";

import Head from "next/head";

const Home = ({
  lists,
  licenses,
}: InferGetStaticPropsType<typeof getStaticProps>) => (
  <>
    <Head>
      <title>
        FilterLists | Subscriptions for uBlock Origin, Adblock Plus, AdGuard,...
      </title>
      <meta
        name="description"
        content="FilterLists is the independent, comprehensive directory of filter and host lists for advertisements, trackers, malware, and annoyances. By Collin M. Barrett."
      />
      <meta name="viewport" content="width=device-width, initial-scale=1" />
      <link rel="icon" href="/favicon.ico" />
    </Head>
    <main>
      <ListsTable lists={lists} licenses={licenses} />
    </main>
  </>
);

export default Home;

export async function getStaticProps() {
  const [lists, licenses] = await Promise.all([fetchLists(), fetchLicenses()]);
  return {
    props: { lists, licenses },
  };
}

async function fetchLists() {
  const url =
    `${process.env.NEXT_PUBLIC_FILTERLISTS_API_URL}/lists?` +
    new URLSearchParams({
      $count: "true",
      $top: "10",
    });
  const response = await fetch(url);
  return await response.json();
}

async function fetchLicenses() {
  const url = `${process.env.NEXT_PUBLIC_FILTERLISTS_API_URL}/licenses`;
  const response = await fetch(url);
  return await response.json();
}
