import { CopyrightOutlined } from "@ant-design/icons";
import { Tag } from "antd";
import { AnchorToExternal } from "@/src/components";

export const Copyright = () => (
  <Tag>
    <AnchorToExternal
      href="https://collinmbarrett.com"
      title="Collin M. Barrett's Homepage"
    >
      <CopyrightOutlined /> {new Date().getFullYear()}&nbsp; Collin M. Barrett
    </AnchorToExternal>
  </Tag>
);
