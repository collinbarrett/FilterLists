import { Modal } from "./modal";

export default function ListModal({
  params: { id: listId },
}: {
  params: { id: string };
}) {
  return <Modal>{listId}</Modal>;
}
