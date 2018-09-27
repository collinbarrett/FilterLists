import * as React from "react";
import { LinkButton } from "./LinkButton";

interface IProps {
    name: string;
    url: string;
};

export const SubmitButton = (props: IProps) =>
    props.url
    ? <LinkButton href={props.url}
                  title={`Submit a new rule to be included in ${props.name}.`}
                  text="Submit"/>
    : null;