import { ListsTable } from "@/src/components";
import { InferGetStaticPropsType } from "next";

import Head from "next/head";

const Home = ({
  filterLists,
  languages,
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
      <ListsTable
        lists={filterLists}
        languages={languages}
        licenses={licenses}
      />
    </main>
  </>
);

export default Home;

export const getStaticProps = async () => {
  const {
    filterLists,
    languages,
    licenses,
    maintainers,
    software,
    syntaxes,
    tags,
  } = await fetchListTable();
  return {
    props: {
      filterLists,
      languages,
      licenses,
      maintainers,
      software,
      syntaxes,
      tags,
    },
    revalidate: 86400,
  };
};

const fetchListTable = async () => {
  const baseUrl = process.env.FILTERLISTS_PRIVATE_API_URL;
  if (baseUrl === undefined)
    throw new Error("FILTERLISTS_PRIVATE_API_URL is undefined");
  const key = process.env.FILTERLISTS_PRIVATE_API_KEY;
  if (key === undefined)
    throw new Error("FILTERLISTS_PRIVATE_API_KEY is undefined");

  const listTableUrl = `${baseUrl}/list-table`;
  // TODO: optimize $count for max rows on max viewport? SEO impact?
  const params = new URLSearchParams({ $count: "true", $top: "10", code: key });
  const url = `${listTableUrl}?${params}`;

  const response = await fetch(url);
  return await response.json();
};
