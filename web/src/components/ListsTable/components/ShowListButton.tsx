import { EyeOutlined } from "@ant-design/icons";
import { Button } from "antd";

interface Props {
  listId: number;
  listName: string;
}

export const ShowListButton = ({ listName }: Props) => (
  <Button type="primary" title={`View more information about ${listName}.`}>
    <EyeOutlined />
  </Button>
);
