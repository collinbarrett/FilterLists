import { List } from "antd";

import { Maintainer } from "@/src/interfaces";

export const PopoverContent = ({
  url,
  emailAddress,
  twitterHandle,
}: Maintainer) => (
  <List size="small">
    {/* TODO: linkify/buttonify */}
    {url && <List.Item>{url}</List.Item>}
    {emailAddress && <List.Item>{emailAddress}</List.Item>}
    {twitterHandle && <List.Item>{twitterHandle}</List.Item>}
  </List>
);
