import { Button, Dropdown, Menu } from 'antd';
import { ButtonProps, ButtonType } from "antd/lib/button";
import React from 'react';
import styles from './SubscribeButton.module.css';

//TODO: import DropdownButtonType from antd rather than redefining if they export the type
//import { DropdownButtonType } from "antd/lib/dropdown";
declare type DropdownButtonType = 'primary' | 'ghost' | 'dashed';

interface Props {
  name: string;
  viewUrl: string;
  viewUrlMirrors: string[];
};

export const SubscribeButton = (props: Props): JSX.Element =>
  (props.viewUrlMirrors && props.viewUrlMirrors.length)
    ? <ButtonDropdown {...props} />
    : <div>
      <Button className={styles.single} size="small" {...buildButtonProps(props.name, props.viewUrl)}>Subscribe</Button>
    </div>;

const ButtonDropdown = (props: Props): JSX.Element => {
  var buttonProps = buildButtonProps(props.name, props.viewUrl);
  //TODO: pass title (ref https://github.com/ant-design/ant-design/issues/18122)
  return <Dropdown.Button size="small"
    type={buttonProps.type as DropdownButtonType}
    href={buttonProps.href}
    overlay={<DropdownOverlay viewUrlMirrors={props.viewUrlMirrors} name={props.name} />}>
    Subscribe
  </Dropdown.Button>;
};

interface DropdownOverlayProps {
  name: string;
  viewUrlMirrors: string[];
};

const DropdownOverlay = (props: DropdownOverlayProps) =>
  <Menu>
    {props.viewUrlMirrors.map((viewUrlMirror: string, i: number) =>
      <Menu.Item key={i}>
        <Button className={styles.sub} size="small" {...buildButtonProps(props.name, viewUrlMirror)}>{`Mirror ${i + 1}`}</Button>
      </Menu.Item>
    )}
  </Menu>;

const buildButtonProps = (name: string, viewUrl: string): ButtonProps => {
  let type: ButtonType = "primary";

  const hrefLocation = `${encodeURIComponent(viewUrl)}`;
  const hrefTitle = `${encodeURIComponent(name)}`;
  let href = `abp:subscribe?location=${hrefLocation}&amp;title=${hrefTitle}`;

  let prefixes: string[] = [];
  let message = `Subscribe to ${name} with a browser extension supporting the "abp:" protocol (e.g. uBlock Origin, Adblock Plus).`;

  // HTTP protocols
  if (viewUrl.includes(".onion/")) {
    type = "dashed";
    prefixes.push("Tor");
  }
  if (viewUrl.includes("http://")) {
    type = "danger";
    prefixes.push("Insecure");
  }

  // Software protocols
  if (viewUrl.includes(".tpl")) {
    href = `javascript:window.external.msAddTrackingProtectionList('${hrefLocation}', '${hrefTitle}')`;
    message = `Subscribe to ${name} with Internet Explorer's Tracking Protection List feature.`;
  }
  if (viewUrl.includes(".lsrules") || viewUrl.includes("?hostformat=littlesnitch")) {
    href = `x-littlesnitch:subscribe-rules?url=${hrefLocation}`;
    message = `Subscribe to ${name} with Little Snitch's rule group subscription feature.`;
  }

  const title = `${prefixes.length ? prefixes.join(" | ") : ""}${message}`;

  return { type, href, title }
}
