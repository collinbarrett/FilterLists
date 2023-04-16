import { Button, List } from "antd";

import { Syntax } from "@/src/interfaces";
import { HomeOutlined } from "@ant-design/icons";
import { ButtonAnchorToExternal } from "@/src/components";

export const PopoverContent = ({ name, description, url }: Syntax) => (
  <List size="small">
    {description && (
      <List.Item>
        <p>{description}</p>
      </List.Item>
    )}
    {url && (
      <List.Item>
        <ButtonAnchorToExternal
          block
          type="primary"
          href={url}
          title={`View ${name}'s homepage.`}
        >
          <HomeOutlined />
          &nbsp;Website
        </ButtonAnchorToExternal>
      </List.Item>
    )}
  </List>
);
