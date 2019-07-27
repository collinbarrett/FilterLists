import * as React from "react";
import { LinkButton } from "./LinkButton";

interface IProps {
    name: string;
    emailAddress: string;
};

export const EmailButton = (props: IProps) =>
    props.emailAddress
    ? <LinkButton href={`mailto:${props.emailAddress}`}
                  title={`Email ${props.name}.`}
                  text="Email"/>
    : null;