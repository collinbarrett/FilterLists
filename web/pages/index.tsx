import { Head, ListsTable } from "@/src/components";
import { FilterListTable } from "@/src/interfaces";
import { InferGetStaticPropsType } from "next";

const Home = (props: InferGetStaticPropsType<typeof getStaticProps>) => (
  <>
    <Head />
    <main>
      <ListsTable {...props} />
    </main>
  </>
);

export default Home;

export const getStaticProps = async () => ({
  props: {
    ...(await fetchListTable()),
  },
  revalidate: 86400,
});

const fetchListTable = async (): Promise<FilterListTable> => {
  const baseUrl = process.env.FILTERLISTS_PRIVATE_API_URL;
  if (baseUrl === undefined)
    throw new Error("FILTERLISTS_PRIVATE_API_URL is undefined");
  const key = process.env.FILTERLISTS_PRIVATE_API_KEY;
  if (key === undefined)
    throw new Error("FILTERLISTS_PRIVATE_API_KEY is undefined");

  const listTableUrl = `${baseUrl}/list-table`;
  const params = new URLSearchParams({ $count: "true", $top: "10", code: key });
  const url = `${listTableUrl}?${params}`;

  // TODO: use SWR? https://swr.vercel.app/
  const response = await fetch(url);
  return await response.json();
};
