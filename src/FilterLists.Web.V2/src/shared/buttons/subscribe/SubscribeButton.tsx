import { Button, Dropdown, Menu } from 'antd';
import { ButtonProps, ButtonType } from "antd/lib/button";
import React from 'react';
import './SubscribeButton.css';

//TODO: import DropdownButtonType from antd rather than redefining if they export the type
//import { DropdownButtonType } from "antd/lib/dropdown";
declare type DropdownButtonType = 'primary' | 'ghost' | 'dashed';

interface Props {
  name: string;
  viewUrl: string;
  viewUrlMirrors: string[];
};

export const SubscribeButton = (props: Props): JSX.Element =>
  (props.viewUrlMirrors && props.viewUrlMirrors.length > 0)
    ? <SubscribeButtonDropdown {...props} />
    : <div>
      <Button className={"single"} size="small" {...buildButtonProps(props.name, props.viewUrl)}>Subscribe</Button>
    </div>;

const SubscribeButtonDropdown = (props: Props): JSX.Element => {
  var buttonProps = buildButtonProps(props.name, props.viewUrl);
  //TODO: pass title (ref https://github.com/ant-design/ant-design/issues/18122)
  return <Dropdown.Button size="small"
    type={buttonProps.type as DropdownButtonType}
    href={buttonProps.href}
    overlay={
      <Menu>
        {props.viewUrlMirrors.map((viewUrlMirror: string, i: number) =>
          <Menu.Item key={i}>
            <Button size="small" {...buildButtonProps(props.name, viewUrlMirror)}>{`Mirror ${i + 1}`}</Button>
          </Menu.Item>)}
      </Menu>
    }>
    Subscribe
  </Dropdown.Button>;
};

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
