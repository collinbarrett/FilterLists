import { ApiOutlined } from "@ant-design/icons";
import { Tag } from "antd";
import { AnchorToExternal } from "@/src/components";

export const Api = () => (
  <Tag>
    <AnchorToExternal
      href={process.env.NEXT_PUBLIC_FILTERLISTS_API_URL}
      title="FilterLists API"
    >
      <ApiOutlined /> API
    </AnchorToExternal>
  </Tag>
);
