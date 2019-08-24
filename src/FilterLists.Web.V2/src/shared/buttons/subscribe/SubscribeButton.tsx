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
      <Button disabled={buildButtonProps(props.name, props.viewUrl)[1]}
        className={styles.single} size="small"
        {...buildButtonProps(props.name, props.viewUrl)[0]}>
        Subscribe
        </Button>
    </div>;

const ButtonDropdown = (props: Props): JSX.Element => {
  var buttonProps = buildButtonProps(props.name, props.viewUrl);
  return <Dropdown.Button
    disabled={buttonProps[1]}
    size="small"
    placement="bottomRight"
    type={buttonProps[0].type as DropdownButtonType}
    href={buttonProps[0].href}
    title={buttonProps[0].title}
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
      <Menu.Item className={styles.sub_li} key={i}>
        <Button disabled={buildButtonProps(props.name, viewUrlMirror)[1]}
          className={styles.sub_a} size="small"
          {...buildButtonProps(props.name, viewUrlMirror)[0]}>
          {`Mirror ${i + 1}`}
        </Button>
      </Menu.Item>
    )}
  </Menu>;

const buildButtonProps = (name: string, viewUrl: string): [ButtonProps, boolean] => {
  let type: ButtonType = "primary";
  let disabled: boolean = false;

  const hrefLocation = `${encodeURIComponent(viewUrl)}`;
  const hrefTitle = `${encodeURIComponent(name)}`;
  let href = `abp:subscribe?location=${hrefLocation}&amp;title=${hrefTitle}`;

  let prefixes: string[] = [];
  let message = `Subscribe to ${name} with a browser extension supporting the "abp:" protocol (e.g. uBlock Origin, Adblock Plus).`;

  // HTTP protocols
  if (viewUrl.includes(".onion/")) {
    type = "dashed";
    prefixes.push("TOR");
  }
  if (viewUrl.includes("http://")) {
    type = "danger";
    prefixes.push("INSECURE");
  }

  // Software protocols
  if (viewUrl.includes(".tpl")) {
    disabled = true; // IE not supported by FilterLists
    // href = `javascript:window.external.msAddTrackingProtectionList('${hrefLocation}', '${hrefTitle}')`;
    // message = `Subscribe to ${name} with Internet Explorer's Tracking Protection List feature.`;
  }
  if (viewUrl.includes(".lsrules") || viewUrl.includes("?hostformat=littlesnitch")) {
    href = `x-littlesnitch:subscribe-rules?url=${hrefLocation}`;
    message = `Subscribe to ${name} with Little Snitch's rule group subscription feature.`;
  }

  const title = `${prefixes.length ? prefixes.join(" | ") + " | " : ""}${message}`;

  return [{ type, href, title }, disabled]
}
