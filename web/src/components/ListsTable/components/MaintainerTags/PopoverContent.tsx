import { List } from "antd";
import { Maintainer } from "@/src/interfaces";
import { HomeOutlined, MailOutlined, TwitterOutlined } from "@ant-design/icons";
import { ButtonAnchorToExternal } from "@/src/components";
import {
  getAnchorPropsEmailAddress,
  getAnchorPropsTwitter,
  getAnchorPropsUrl,
} from "./getAnchorProps";

export const PopoverContent = (maintainer: Maintainer) => (
  <List size="small">
    {maintainer.url && (
      <List.Item>
        <ButtonAnchorToExternal
          block
          type="primary"
          {...getAnchorPropsUrl(maintainer)}
        >
          <HomeOutlined /> Website
        </ButtonAnchorToExternal>
      </List.Item>
    )}
    {maintainer.emailAddress && (
      <List.Item>
        <ButtonAnchorToExternal
          block
          {...getAnchorPropsEmailAddress(maintainer)}
        >
          <MailOutlined /> Email
        </ButtonAnchorToExternal>
      </List.Item>
    )}
    {maintainer.twitterHandle && (
      <List.Item>
        <ButtonAnchorToExternal block {...getAnchorPropsTwitter(maintainer)}>
          <TwitterOutlined /> Twitter
        </ButtonAnchorToExternal>
      </List.Item>
    )}
  </List>
);
