import { List } from "antd";

import { Maintainer } from "@/src/interfaces";
import { HomeOutlined, MailOutlined, TwitterOutlined } from "@ant-design/icons";
import { ButtonAnchorToExternal } from "@/src/components/Common";

export const PopoverContent = ({
  name,
  url,
  emailAddress,
  twitterHandle,
}: Maintainer) => (
  <List size="small">
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
    {emailAddress && (
      <List.Item>
        <ButtonAnchorToExternal
          block
          href={`mailto:${emailAddress}`}
          title={`Email ${name}.`}
        >
          <MailOutlined />
          &nbsp;Email
        </ButtonAnchorToExternal>
      </List.Item>
    )}
    {twitterHandle && (
      <List.Item>
        <ButtonAnchorToExternal
          block
          href={`https://twitter.com/${twitterHandle}`}
          title={`${name} on Twitter`}
        >
          <TwitterOutlined />
          &nbsp;Twitter
        </ButtonAnchorToExternal>
      </List.Item>
    )}
  </List>
);
