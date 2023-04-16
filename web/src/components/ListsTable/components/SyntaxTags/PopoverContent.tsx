import { Button, List } from "antd";

import { Syntax } from "@/src/interfaces";
import { HomeOutlined } from "@ant-design/icons";

export const PopoverContent = ({ name, description, url }: Syntax) => (
  <List size="small">
    {description && (
      <List.Item>
        <p>{description}</p>
      </List.Item>
    )}
    {url && (
      <List.Item>
        <Button
          block
          type="primary"
          href={url}
          title={`View ${name}'s homepage.`}
          target="_blank"
          rel="noopener noreferrer"
        >
          <HomeOutlined />
          &nbsp;Website
        </Button>
      </List.Item>
    )}
  </List>
);
