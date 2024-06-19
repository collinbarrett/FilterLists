export default function ListPage({
  params: { id },
}: {
  params: { id: string };
}) {
  console.log("hello");
  return <div className="card">{id}</div>;
}
