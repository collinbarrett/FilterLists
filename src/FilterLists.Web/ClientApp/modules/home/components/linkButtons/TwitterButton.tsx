import * as React from "react";
import { LinkButton } from "./LinkButton";

interface IProps {
    name: string;
    twitterHandle: string;
};

export const TwitterButton = (props: IProps) =>
    props.twitterHandle
    ? <LinkButton href={`https://twitter.com/${props.twitterHandle}`}
                  title={`View ${props.name}'s Twitter profile.`}
                  text="Twitter"/>
    : null;