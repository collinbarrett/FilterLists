import { CopyrightOutlined } from "@ant-design/icons";
import { Tag } from "antd";

export const Copyright = () => (
  <Tag>
    <a
      href="https://collinmbarrett.com"
      title="Collin M. Barrett's Homepage"
      target="_blank"
      rel="noopener noreferrer"
    >
      <CopyrightOutlined /> {new Date().getFullYear()}&nbsp; Collin M. Barrett
    </a>
  </Tag>
);
