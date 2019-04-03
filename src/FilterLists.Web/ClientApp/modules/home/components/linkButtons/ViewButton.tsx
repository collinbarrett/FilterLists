import * as React from "react";
import { LinkButton } from "./LinkButton";

interface IProps {
    name: string;
    url: string;
};

export const ViewButton = (props: IProps) => {
let buttonClass: string | undefined;
let text: string;
    
    if (props.url.indexOf(".onion/") > 0) {
        buttonClass = "btn-success";
        titlePrefix = "Tor address - ";
    } else if (props.url.indexOf(".7z",".zip") > 0) {
        buttonClass = "btn-warning";
        titlePrefix = "Not Secure - ";
    } else {
        buttonClass = undefined;
        titlePrefix = "";
    }
    
    let title;
    if (props.url.indexOf(".onion/") > 0) { title = `Tor address - View ${props.name} in its raw format.`; }
    else if (props.url.indexOf(".7z",".zip") > 0) { title = `Download ${props.name} as a compressed archive.`; }
    else { title = `View ${props.name} in its raw format`; };
    
    if (props.url.indexOf(".7z",".zip") > 0) { text = `Download`; }
else { text = `View`; };

return props.url
    ? <LinkButton href={props.url}
                  title={title}
                  text={text}/>
    : null;
