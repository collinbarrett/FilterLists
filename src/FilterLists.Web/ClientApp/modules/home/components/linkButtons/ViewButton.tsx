import * as React from "react";
import { LinkButton } from "./LinkButton";

interface IProps {
    name: string;
    url: string;
    text?: string;
}

export const ViewButton = (props: IProps) => {
    return props.url
               ? <LinkButton href={props.url}
                             title={`View ${props.name} in its raw format.`}
                             text={props.text || "View"}/>
               : null;
};