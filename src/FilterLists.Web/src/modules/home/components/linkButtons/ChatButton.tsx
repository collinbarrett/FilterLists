import * as React from "react";
import { LinkButton } from "./LinkButton";

interface IProps {
    name: string;
    url: string;
};

export const ChatButton = (props: IProps) =>
    props.url
    ? <LinkButton href={props.url}
                  title={`Enter the chat room for ${props.name}.`}
                  text="Chat"/>
    : null;