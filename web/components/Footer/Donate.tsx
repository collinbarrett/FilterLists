import { DollarOutlined } from "@ant-design/icons";
import { Tag } from "antd";

export const Donate = () => (
  <Tag>
    <a
      href="https://github.com/sponsors/collinbarrett"
      title="Sponsor Collin Barrett on GitHub"
      target="_blank"
      rel="noopener noreferrer"
    >
      <DollarOutlined /> Donate
    </a>
  </Tag>
);
