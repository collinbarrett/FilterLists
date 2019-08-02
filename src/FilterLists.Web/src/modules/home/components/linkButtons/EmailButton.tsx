import * as React from "react";
import { LinkButton } from "./LinkButton";

interface Props {
    name: string;
    emailAddress: string;
};

export const EmailButton = (props: Props) =>
    props.emailAddress
        ? <LinkButton href={`mailto:${props.emailAddress}`}
            title={`Email ${props.name}.`}
            text="Email" />
        : null;