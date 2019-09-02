import { Button } from 'antd';
import { ButtonType } from 'antd/lib/button';
import React from 'react';

interface Props {
  name: string;
  viewUrl: string;
  viewUrlMirrors: string[];
};

export const SubscribeButtons = (props: Props) =>
  props.viewUrl
    ? <>
      <SubscribeButton
        name={props.name}
        viewUrl={props.viewUrl}
        text="Subscribe" />
      <MirrorButtons
        name={props.name}
        viewUrlMirrors={props.viewUrlMirrors} />
    </>
    : null;

interface MirrorButtonsProps {
  name: string;
  viewUrlMirrors: string[];
};

const MirrorButtons = (props: MirrorButtonsProps) =>
  <>
    {props.viewUrlMirrors && props.viewUrlMirrors.length
      ? props.viewUrlMirrors.map((viewUrlMirror: string, i: number) =>
        <SubscribeButton
          key={i}
          name={props.name}
          viewUrl={viewUrlMirror}
          text={`Subscribe (Mirror ${i + 1})`} />)
      : null}
  </>;

interface SubscribeButtonProps {
  name: string;
  viewUrl: string;
  text: string;
};

const SubscribeButton = (props: SubscribeButtonProps) => {
  const buttonProps = buildButtonProps(props.name, props.viewUrl);
  return (
    <Button
      disabled={buttonProps.disabled}
      block
      icon="import"
      type={buttonProps.type}
      href={buttonProps.href}
      title={buttonProps.title}>
      {props.text}
    </Button>
  );
};

const buildButtonProps = (name: string, viewUrl: string) => {
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
  };
  if (viewUrl.includes("http://")) {
    type = "danger";
    prefixes.push("INSECURE");
  };

  // Software protocols
  if (viewUrl.includes(".tpl")) {
    disabled = true; // IE not supported by FilterLists
  };
  if (viewUrl.includes(".lsrules") || viewUrl.includes("?hostformat=littlesnitch")) {
    href = `x-littlesnitch:subscribe-rules?url=${hrefLocation}`;
    message = `Subscribe to ${name} with Little Snitch's rule group subscription feature.`;
  };

  const title = `${prefixes.length ? prefixes.join(" | ") + " | " : ""}${message}`;

  return { disabled, type, href, title };
};