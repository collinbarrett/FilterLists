import { Button } from 'antd';
import { ButtonProps, ButtonType } from 'antd/lib/button';
import React from 'react';

interface Props {
  name: string;
  viewUrl: string;
  viewUrlMirrors: string[];
};

export const SubscribeButton = (props: Props) => {
  const buttonProps = buildButtonProps(props.name, props.viewUrl);
  return <span>
    <Button disabled={buttonProps[1]}
      block
      icon="import"
      {...buttonProps[0]}>
      Subscribe
    </Button>
    {props.viewUrlMirrors && props.viewUrlMirrors.length &&
      props.viewUrlMirrors.map((viewUrlMirror: string, i: number) => {
        const buttonProps = buildButtonProps(props.name, viewUrlMirror);
        return <Button key={i}
          disabled={buttonProps[1]}
          block
          icon="import"
          {...buttonProps[0]}>
          {`Subscribe (Mirror ${i + 1})`}
        </Button>
      })}
  </span>
};

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
  }
  if (viewUrl.includes(".lsrules") || viewUrl.includes("?hostformat=littlesnitch")) {
    href = `x-littlesnitch:subscribe-rules?url=${hrefLocation}`;
    message = `Subscribe to ${name} with Little Snitch's rule group subscription feature.`;
  }

  const title = `${prefixes.length ? prefixes.join(" | ") + " | " : ""}${message}`;

  return [{ type, href, title }, disabled]
}
