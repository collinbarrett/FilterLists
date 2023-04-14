import { EyeOutlined } from "@ant-design/icons";
import { Button } from "antd";

interface Props {
  listId: number;
  listName: string;
}

export const ShowListButton = (props: Props) => {
  return (
    <Button
      type="primary"
      title={`View more information about ${props.listName}.`}
    >
      <EyeOutlined />
    </Button>
  );
};
