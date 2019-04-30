import * as React from "react";
import { LinkButton } from "./LinkButton";

interface IProps {
    name: string;
    url: string;
};

export const DonateButton = (props: IProps) =>
    props.url
    ? <LinkButton href={props.url}
                  title={`Donate to the maintainer of ${props.name}.`}
                  text="Donate"/>
    : null;
