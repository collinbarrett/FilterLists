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
    
    if (props.url.indexOf(".onion/")) and (props.url.indexOf("https://")) {
        buttonClass = "btn-onionSecure";
        titlePrefix = "Tor HTTPS address - ";
    } else if (props.url.indexOf(".onion/")) {
        buttonClass = "btn-onion";
        titlePrefix = "Tor address - ";
    } else if (props.url.indexOf(".zip")) or (props.url.indexOf(".7z")) {
        buttonClass = "btn-subscribeCompressed";
        titlePrefix = "Compressed archive - ";
    } else if (props.url.indexOf("http://")) {
        buttonClass = "btn-danger";
        titlePrefix = "Not Secure - ";
    } else {
        buttonClass = undefined;
        titlePrefix = "";
    }
    
    if (props.url.indexOf(".tpl") {
    const hrefTitle = `&amp;title=${encodeURIComponent(props.name)}`;
    const href = `https://github.com/collinbarrett/FilterLists/blob/master/data/TPLSubscriptionAssistant.html`;
    const title = 
        `${titlePrefix}Visit a TPL archive from which ${props.name
            } can be subscribed to with Internet Explorer.`;
    } else if (props.url.indexOf(".zip")) or (props.url.indexOf(".7z")) {
    const hrefTitle = `&amp;title=${encodeURIComponent(props.name)}`;
    const href = `https://github.com/collinbarrett/FilterLists/blob/master/data/TPLSubscriptionAssistant.html`;
    const title = 
        `${titlePrefix} ${props.name
            } is a compressed archive, so it can only be used as a local download.`;
    } else {
    const hrefTitle = `&amp;title=${encodeURIComponent(props.name)}`;
    const href = `abp:subscribe?location=${encodeURIComponent(props.url)}${hrefTitle}`;
    const title =
        `${titlePrefix}Subscribe to ${props.name
            } with a browser extension supporting the \"abp:\" protocol (e.g. uBlock Origin, Adblock Plus).`;
    }

    return props.url
               ? <LinkButton href={href}
                             title={title}
                             buttonClass={buttonClass}
                             text={props.text || "Subscribe"}/>
               : null;
};
