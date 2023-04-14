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

export const getStaticProps = async () => {
  const [lists, licenses, syntaxes, software, languages, tags, maintainers] =
    // TODO: consider creating a single protected (for UI-use only) endpoint that returns all data
    await Promise.all([
      fetchLists(),
      fetchLicenses(),
      fetchSyntaxes(),
      fetchSoftware(),
      fetchLanguages(),
      fetchTags(),
      fetchMaintainers(),
    ]);
  return {
    props: {
      lists,
      licenses,
      syntaxes,
      software,
      languages,
      tags,
      maintainers,
    },
    revalidate: 86400,
  };
};

const fetchLists = () =>
  fetchData("lists", new URLSearchParams({ $count: "true", $top: "10" }));
const fetchLicenses = () => fetchData("licenses");
const fetchSyntaxes = () => fetchData("syntaxes");
const fetchSoftware = () => fetchData("software");
const fetchLanguages = () => fetchData("languages");
const fetchTags = () => fetchData("tags");
const fetchMaintainers = () => fetchData("maintainers");

const fetchData = async (endpoint: string, params?: URLSearchParams) => {
  const base_url = `${process.env.NEXT_PUBLIC_FILTERLISTS_API_URL}/${endpoint}`;
  const url = params ? `${base_url}?${params}` : base_url;
  const response = await fetch(url);
  return await response.json();
};
