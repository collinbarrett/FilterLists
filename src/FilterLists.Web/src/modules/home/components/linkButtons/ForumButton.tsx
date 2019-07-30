import * as React from "react";
import { LinkButton } from "./LinkButton";

interface Props {
    name: string;
    url: string;
};

export const ForumButton = (props: Props) =>
    props.url
        ? <LinkButton href={props.url}
            title={`View the forum for ${props.name}.`}
            text="Forum" />
        : null;