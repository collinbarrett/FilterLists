import * as React from "react";
import { LinkButton } from "./LinkButton";

interface IProps {
    name: string;
    url: string;
    text?: string;
};

export const SubscribeButton = (props: IProps) => {
    let buttonClass: string | undefined;
    let titlePrefix: string;
    
    if (props.url.indexOf(".onion/") > 0) {
        buttonClass = "btn-success";
        titlePrefix = "Tor address - ";
    } else if (props.url.indexOf("http://") === 0) {
        buttonClass = "btn-danger";
        titlePrefix = "Not Secure - ";
    } else {
        buttonClass = undefined;
        titlePrefix = "";
    }
    
    const hrefTitle = `${encodeURIComponent(props.name)}`;
    let href;
if (props.url.indexOf(".tpl") > 0) 
{
    href = `javascript:window.external.msAddTrackingProtectionList('${encodeURIComponent(props.url)}', '${hrefTitle}')`;
} else if (props.url.indexOf(".lsrules") > 0)
{
    href = `x-littlesnitch:subscribe-rules?url=${encodeURIComponent(props.url)}`;
} else if (props.url.indexOf("?hostformat=littlesnitch") > 0)
{
    href = `x-littlesnitch:subscribe-rules?url=${encodeURIComponent(props.url)}`;
} else {
    href = `abp:subscribe?location=${encodeURIComponent(props.url)}&amp;title=${hrefTitle}`;
};
    
    
    
    let title;
if (props.url.indexOf(".tpl") > 0) 
{
    title = `${titlePrefix}Subscribe to ${props.name} with Internet Explorer's Tracking Protection List feature.`;
} else if (props.url.indexOf(".lsrules") > 0)
{
    title = `${titlePrefix}Subscribe to ${props.name} with Little Snitch's rule group subscription feature.`;
} else if (props.url.indexOf("?hostformat=littlesnitch") > 0)
{
    title = `${titlePrefix}Subscribe to ${props.name} with Little Snitch's rule group subscription feature.`;
} else {
    title = `${titlePrefix}Subscribe to ${props.name} with a browser extension supporting the "abp:" protocol (e.g. uBlock Origin, Adblock Plus).`;
};

    return props.url
               ? <LinkButton href={href}
                             title={title}
                             buttonClass={buttonClass}
                             text={props.text || "Subscribe"}/>
               : null;
};
