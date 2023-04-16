import { TwitterOutlined } from "@ant-design/icons";
import { Tag } from "antd";
import { AnchorToExternal } from "@/src/components";

export const Twitter = () => (
  <Tag>
    <AnchorToExternal
      href="https://twitter.com/FilterLists"
      title="FilterLists on Twitter"
    >
      <TwitterOutlined /> Twitter
    </AnchorToExternal>
  </Tag>
);
