import { Button } from 'antd';
import { ButtonType } from 'antd/lib/button';
import React from 'react';

interface Props {
  name: string;
  viewUrl: string;
  viewUrlMirrors: string[];
};

export const SubscribeButtons = (props: Props) =>
  <>
    <PrimaryButton name={props.name} viewUrl={props.viewUrl} />
    <MirrorButtons name={props.name} viewUrlMirrors={props.viewUrlMirrors} />
  </>;

interface PrimaryButtonProps {
  name: string;
  viewUrl: string;
};

const PrimaryButton = (props: PrimaryButtonProps) => {
  const buttonProps = buildButtonProps(props.name, props.viewUrl);
  return (
    <Button
      disabled={buttonProps.disabled}
      block
      icon="import"
      type={buttonProps.type}
      href={buttonProps.href}
      title={buttonProps.title}>
      Subscribe
    </Button>
  );
};

interface MirrorButtonsProps {
  name: string;
  viewUrlMirrors: string[];
};

const MirrorButtons = (props: MirrorButtonsProps) =>
  <>
    {props.viewUrlMirrors && props.viewUrlMirrors.length
      ? props.viewUrlMirrors.map((viewUrlMirror: string, i: number) =>
        <MirrorButton key={i} index={i} viewUrlMirror={viewUrlMirror} name={props.name} />)
      : null}
  </>;

interface MirrorButtonProps {
  index: number;
  viewUrlMirror: string;
  name: string;
};

const MirrorButton = (props: MirrorButtonProps) => {
  const buttonProps = buildButtonProps(props.name, props.viewUrlMirror);
  return (
    <Button
      disabled={buttonProps.disabled}
      block
      icon="import"
      type={buttonProps.type}
      href={buttonProps.href}
      title={buttonProps.title}>
      {`Subscribe (Mirror ${props.index + 1})`}
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