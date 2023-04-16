import { DollarOutlined } from "@ant-design/icons";
import { Tag } from "antd";
import { AnchorToExternal } from "@/src/components";

export const Donate = () => (
  <Tag>
    <AnchorToExternal
      href="https://github.com/sponsors/collinbarrett"
      title="Sponsor Collin Barrett on GitHub"
    >
      <DollarOutlined /> Donate
    </AnchorToExternal>
  </Tag>
);
