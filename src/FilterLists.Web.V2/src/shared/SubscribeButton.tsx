import * as React from "react";
import { Button } from 'antd';
import { ButtonType, ButtonProps } from "antd/lib/button";

interface Props {
  name: string;
  viewUrl: string;
  text?: string;
};

export const SubscribeButton = (props: Props) => props.viewUrl
  ? <Button {...buildButtonProps(props)}>{props.text || "Subscribe"}</Button>
  : null;

function buildButtonProps(props: Props): ButtonProps {
  let type: ButtonType;
  let titlePrefix: string;

  if (props.viewUrl.indexOf(".onion/") > 0) {
    type = "ghost";
    titlePrefix = "Tor address - ";
  }
  else if (props.viewUrl.indexOf("http://") === 0) {
    type = "danger";
    titlePrefix = "Not Secure - ";
  }
  else {
    type = "primary";
    titlePrefix = "";
  }

  const hrefTitle = `${encodeURIComponent(props.name)}`;
  let href: string;
  let title: string;

  if (props.viewUrl.indexOf(".tpl") > 0) {
    href = `javascript:window.external.msAddTrackingProtectionList('${encodeURIComponent(props.viewUrl)}', '${hrefTitle}')`;
    title = `${titlePrefix}Subscribe to ${props.name} with Internet Explorer's Tracking Protection List feature.`;
  }
  else if (props.viewUrl.indexOf(".lsrules") > 0) {
    href = `x-littlesnitch:subscribe-rules?url=${encodeURIComponent(props.viewUrl)}`;
    title = `${titlePrefix}Subscribe to ${props.name} with Little Snitch's rule group subscription feature.`;
  }
  else if (props.viewUrl.indexOf("?hostformat=littlesnitch") > 0) {
    href = `x-littlesnitch:subscribe-rules?url=${encodeURIComponent(props.viewUrl)}`;
    title = `${titlePrefix}Subscribe to ${props.name} with Little Snitch's rule group subscription feature.`;
  }
  else {
    href = `abp:subscribe?location=${encodeURIComponent(props.viewUrl)}&amp;title=${hrefTitle}`;
    title = `${titlePrefix}Subscribe to ${props.name} with a browser extension supporting the "abp:" protocol (e.g. uBlock Origin, Adblock Plus).`;
  }
  
  return { type, href, title } as ButtonProps
}
