import { ApiOutlined } from "@ant-design/icons";
import { Tag } from "antd";

const Api = () => (
  <Tag>
    <a
      href="/api"
      title="FilterLists API"
      target="_blank"
      rel="noopener noreferrer"
    >
      <ApiOutlined /> API
    </a>
  </Tag>
);

export default Api;
