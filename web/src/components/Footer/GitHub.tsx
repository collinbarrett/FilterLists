import { GithubOutlined } from "@ant-design/icons";
import { Tag } from "antd";
import { AnchorToExternal } from "@/src/components";

export const GitHub = () => (
  <Tag>
    <AnchorToExternal
      href="https://github.com/collinbarrett/FilterLists"
      title="FilterLists git repository on GitHub"
    >
      <GithubOutlined /> GitHub
    </AnchorToExternal>
  </Tag>
);
