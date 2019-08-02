import * as React from "react";
import { LinkButton } from "./LinkButton";

interface Props {
    name: string;
    twitterHandle: string;
};

export const TwitterButton = (props: Props) =>
    props.twitterHandle
        ? <LinkButton href={`https://twitter.com/${props.twitterHandle}`}
            title={`View ${props.name}'s Twitter profile.`}
            text="Twitter" />
        : null;