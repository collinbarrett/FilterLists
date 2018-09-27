import * as React from "react";
import { LinkButton } from "./LinkButton";

interface IProps {
    name: string;
    url: string;
};

export const HomeButton = (props: IProps) =>
    props.url
    ? <LinkButton href={props.url}
                  title={`View ${props.name}'s homepage.`}
                  text="Home"/>
    : null;