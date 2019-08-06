import { Button, Dropdown, Icon, Menu } from 'antd';
import { ButtonProps, ButtonType } from "antd/lib/button";
import * as React from "react";

interface Props {
  name: string;
  viewUrl: string;
  viewUrlMirrors: string[];
};

export const SubscribeButton = (props: Props): JSX.Element | null =>
  (props.viewUrlMirrors && props.viewUrlMirrors.length > 0)
    ? <SubscribeButtonDropdown {...props} />
    : props.viewUrl
      ? <Button {...buildButtonProps(props.name, props.viewUrl)}>Subscribe</Button>
      : null;

const SubscribeButtonDropdown = (props: Props): JSX.Element =>
  <Dropdown overlay={
    <Menu>
      {props.viewUrlMirrors.map(
        (viewUrlMirror: string, i: number) =>
          <Menu.Item key={i}>
            <Button {...buildButtonProps(props.name, viewUrlMirror)}>{`Mirror ${i}`}</Button>
          </Menu.Item>)}
    </Menu>
  }>
    <Button {...buildButtonProps(props.name, props.viewUrl)}>
      Subscribe <Icon type="down" />
    </Button>
  </Dropdown>;

const buildButtonProps = (name: string, viewUrl: string): ButtonProps => {
  let type: ButtonType = "primary";

  const hrefLocation = `${encodeURIComponent(viewUrl)}`;
  const hrefTitle = `${encodeURIComponent(name)}`;
  let href = `abp:subscribe?location=${hrefLocation}&amp;title=${hrefTitle}`;

  const defaultTitle = (prefix?: string) => `${prefix || ""}Subscribe to ${name} with a browser extension supporting the "abp:" protocol (e.g. uBlock Origin, Adblock Plus).`;
  let title: string;

  switch (true) {

    // HTTP protocols
    case viewUrl.includes(".onion/"):
      type = "dashed";
      title = defaultTitle("Tor address - ");
      break;
    case viewUrl.includes("http://"):
      type = "danger";
      title = defaultTitle("Not Secure - ");
      break;

    // Software protocols
    case viewUrl.includes(".tpl"):
      href = `javascript:window.external.msAddTrackingProtectionList('${hrefLocation}', '${hrefTitle}')`;
      title = `Subscribe to ${name} with Internet Explorer's Tracking Protection List feature.`;
      break;
    case viewUrl.includes(".lsrules"):
      href = `x-littlesnitch:subscribe-rules?url=${hrefLocation}`;
      title = `Subscribe to ${name} with Little Snitch's rule group subscription feature.`;
      break;
    case viewUrl.includes("?hostformat=littlesnitch"):
      href = `x-littlesnitch:subscribe-rules?url=${hrefLocation}`;
      title = `Subscribe to ${name} with Little Snitch's rule group subscription feature.`;
      break;
    default:
      title = defaultTitle();
      break;
  }

  return { type, href, title } as ButtonProps
}
