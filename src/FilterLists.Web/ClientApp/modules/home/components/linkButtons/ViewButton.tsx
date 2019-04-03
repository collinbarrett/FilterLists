import * as React from "react";
import { LinkButton } from "./LinkButton";

interface IProps {
    name: string;
    url: string;
    text?: string;
};

export const ViewButton = (props: IProps) => {
    
    let title;
    if (props.url.indexOf(".onion/") > 0) { title = `Tor address - View ${props.name} in its raw format.`; }
    else if (props.url.indexOf(".zip") > 0) { title = `Download ${props.name} as a compressed archive.`; }
    else { title = `View ${props.name} in its raw format`; };

return props.url
    ? <LinkButton href={props.url}
                  title={title}
                  text={props.text || "View"}/>
    : null;
}
