import * as React from "react";
import { LinkButton } from "./LinkButton";

interface IProps {
    name: string;
    url: string;
};

export const PolicyButton = (props: IProps) =>
    props.url
    ? <LinkButton href={props.url}
                  title={`View the types of rules that ${props.name} includes.`}
                  text="Policy"/>
    : null;