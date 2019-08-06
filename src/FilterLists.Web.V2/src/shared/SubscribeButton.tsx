import { Button } from 'antd';
import { ButtonProps, ButtonType } from "antd/lib/button";
import * as React from "react";

interface Props {
  name: string;
  viewUrl: string;
};

export const SubscribeButton = (props: Props): JSX.Element | null => props.viewUrl
  ? <Button {...buildButtonProps(props)}>Subscribe</Button>
  : null;

const buildButtonProps = (props: Props): ButtonProps => {
  let type: ButtonType = "primary";

  const hrefLocation = `${encodeURIComponent(props.viewUrl)}`;
  const hrefTitle = `${encodeURIComponent(props.name)}`;
  let href = `abp:subscribe?location=${hrefLocation}&amp;title=${hrefTitle}`;

  const defaultTitle = (prefix?: string) => `${prefix || ""}Subscribe to ${props.name} with a browser extension supporting the "abp:" protocol (e.g. uBlock Origin, Adblock Plus).`;
  let title: string;

  switch (true) {

    // HTTP protocols
    case props.viewUrl.includes(".onion/"):
      type = "dashed";
      title = defaultTitle("Tor address - ");
      break;
    case props.viewUrl.includes("http://"):
      type = "danger";
      title = defaultTitle("Not Secure - ");
      break;

    // Software protocols
    case props.viewUrl.includes(".tpl"):
      href = `javascript:window.external.msAddTrackingProtectionList('${hrefLocation}', '${hrefTitle}')`;
      title = `Subscribe to ${props.name} with Internet Explorer's Tracking Protection List feature.`;
      break;
    case props.viewUrl.includes(".lsrules"):
      href = `x-littlesnitch:subscribe-rules?url=${hrefLocation}`;
      title = `Subscribe to ${props.name} with Little Snitch's rule group subscription feature.`;
      break;
    case props.viewUrl.includes("?hostformat=littlesnitch"):
      href = `x-littlesnitch:subscribe-rules?url=${hrefLocation}`;
      title = `Subscribe to ${props.name} with Little Snitch's rule group subscription feature.`;
      break;
    default:
      title = defaultTitle();
      break;
  }

  return { type, href, title } as ButtonProps
}
