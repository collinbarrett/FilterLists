import { List } from "antd";
import { Syntax } from "@/src/interfaces";
import { HomeOutlined } from "@ant-design/icons";
import { ButtonAnchorToExternal } from "@/src/components";
import { getAnchorPropsUrl } from "./getAnchorProps";

export const PopoverContent = (syntax: Syntax) => (
  <List size="small">
    {syntax.description && (
      <List.Item>
        <p>{syntax.description}</p>
      </List.Item>
    )}
    {syntax.url && (
      <List.Item>
        <ButtonAnchorToExternal
          block
          type="primary"
          {...getAnchorPropsUrl(syntax)}
        >
          <HomeOutlined /> Website
        </ButtonAnchorToExternal>
      </List.Item>
    )}
  </List>
);
