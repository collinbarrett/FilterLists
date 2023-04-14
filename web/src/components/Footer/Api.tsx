import { ApiOutlined } from "@ant-design/icons";
import { Tag } from "antd";

export const Api = () => (
  <Tag>
    <a
      href={process.env.NEXT_PUBLIC_FILTERLISTS_API_URL}
      title="FilterLists API"
      target="_blank"
      rel="noopener noreferrer"
    >
      <ApiOutlined /> API
    </a>
  </Tag>
);
