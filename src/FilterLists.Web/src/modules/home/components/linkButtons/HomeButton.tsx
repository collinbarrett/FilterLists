import * as React from "react";
import { LinkButton } from "./LinkButton";

interface Props {
    name: string;
    url: string;
};

export const HomeButton = (props: Props) =>
    props.url
        ? <LinkButton href={props.url}
            title={`View ${props.name}'s homepage.`}
            text="Home" />
        : null;