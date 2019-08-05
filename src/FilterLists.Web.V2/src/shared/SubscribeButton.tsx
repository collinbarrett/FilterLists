import { Button } from 'antd';
import { ButtonProps, ButtonType } from "antd/lib/button";
import * as React from "react";

interface Props {
  name: string;
  viewUrl: string;
  text?: string;
};

export const SubscribeButton = (props: Props) => props.viewUrl
  ? <Button {...buildButtonProps(props)}>{props.text || "Subscribe"}</Button>
  : null;

function buildButtonProps(props: Props): ButtonProps {
  let type: ButtonType = "primary";

  const hrefTitle = `${encodeURIComponent(props.name)}`;
  let href: string = `abp:subscribe?location=${encodeURIComponent(props.viewUrl)}&amp;title=${hrefTitle}`;

  let titlePrefix = "";
  let title: string = "";

  const contains = (match: string) => props.viewUrl.indexOf(match) > 0;

  switch (contains) {

    // HTTP protocols
    case contains(".onion/").valueOf:
      type = "ghost";
      titlePrefix = "Tor address - ";
      break;
    case contains("http://").valueOf:
      type = "danger";
      titlePrefix = "Not Secure - ";
      break;

    // Software protocols
    case contains(".tpl").valueOf:
      href = `javascript:window.external.msAddTrackingProtectionList('${encodeURIComponent(props.viewUrl)}', '${hrefTitle}')`;
      title = `${titlePrefix}Subscribe to ${props.name} with Internet Explorer's Tracking Protection List feature.`;
      break;
    case contains(".lsrules").valueOf:
      href = `x-littlesnitch:subscribe-rules?url=${encodeURIComponent(props.viewUrl)}`;
      title = `${titlePrefix}Subscribe to ${props.name} with Little Snitch's rule group subscription feature.`;
      break;
    case contains("?hostformat=littlesnitch").valueOf:
      href = `x-littlesnitch:subscribe-rules?url=${encodeURIComponent(props.viewUrl)}`;
      title = `${titlePrefix}Subscribe to ${props.name} with Little Snitch's rule group subscription feature.`;
      break;
    default:
      title = `${titlePrefix}Subscribe to ${props.name} with a browser extension supporting the "abp:" protocol (e.g. uBlock Origin, Adblock Plus).`;
      break;
  }

  return { type, href, title } as ButtonProps
}