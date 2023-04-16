import { Button, List } from "antd";

import { Maintainer } from "@/src/interfaces";
import { HomeOutlined, MailOutlined, TwitterOutlined } from "@ant-design/icons";

export const PopoverContent = ({
  name,
  url,
  emailAddress,
  twitterHandle,
}: Maintainer) => (
  <List size="small">
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
    {emailAddress && (
      <List.Item>
        <Button
          block
          href={`mailto:${emailAddress}`}
          title={`Email ${name}.`}
          target="_blank"
          rel="noopener noreferrer"
        >
          <MailOutlined />
          &nbsp;Email
        </Button>
      </List.Item>
    )}
    {twitterHandle && (
      <List.Item>
        <Button
          block
          href={`https://twitter.com/${twitterHandle}`}
          title={`${twitterHandle} on Twitter`}
          target="_blank"
          rel="noopener noreferrer"
        >
          <TwitterOutlined />
          &nbsp;Twitter
        </Button>
      </List.Item>
    )}
  </List>
);
