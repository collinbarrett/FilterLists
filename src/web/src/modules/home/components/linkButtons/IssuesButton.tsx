import * as React from "react";
import { LinkButton } from "./LinkButton";

interface IProps {
    name: string;
    url: string;
};

export const IssuesButton = (props: IProps) =>
    props.url
    ? <LinkButton href={props.url}
                  title={`View the GitHub Issues for ${props.name}.`}
                  text="GH Issues"/>
    : null;