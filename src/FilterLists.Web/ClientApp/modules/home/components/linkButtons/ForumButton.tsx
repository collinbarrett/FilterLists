import * as React from "react";
import { LinkButton } from "./LinkButton";

interface IProps {
    name: string;
    url: string;
};

export const ForumButton = (props: IProps) =>
    props.url
    ? <LinkButton href={props.url}
                  title={`View the forum for ${props.name}.`}
                  text="Forum"/>
    : null;