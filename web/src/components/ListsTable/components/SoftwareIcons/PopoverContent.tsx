import { List } from "antd";
import { Software } from "@/src/interfaces";
import { DownloadOutlined, HomeOutlined } from "@ant-design/icons";
import { ButtonAnchorToExternal } from "@/src/components";
import { SupportsAbpUriSchemeListItem } from "./SupportsAbpUriSchemeListItem";
import { getAnchorPropsHomeUrl } from "./getAnchorProps";

export const PopoverContent = (software: Software) => (
  <List size="small">
    {software.description && (
      <List.Item>
        <p>{software.description}</p>
      </List.Item>
    )}
    <SupportsAbpUriSchemeListItem value={software.supportsAbpUrlScheme} />
    {software.homeUrl && (
      <List.Item>
        <ButtonAnchorToExternal
          block
          type="primary"
          {...getAnchorPropsHomeUrl(software)}
        >
          <HomeOutlined /> Website
        </ButtonAnchorToExternal>
      </List.Item>
    )}
    {software.downloadUrl && (
      <List.Item>
        <ButtonAnchorToExternal
          block
          href={software.downloadUrl}
          title={`Download ${software.name}.`}
        >
          <DownloadOutlined /> Download
        </ButtonAnchorToExternal>
      </List.Item>
    )}
  </List>
);
