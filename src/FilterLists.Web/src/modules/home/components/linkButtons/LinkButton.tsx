import * as React from "react";
import { Button, ButtonProps } from "react-bootstrap";

interface Props {
    href: string;
    variant?: ButtonProps["variant"],
    title?: string;
    text: string;
};

export const LinkButton = (props: Props) =>
    props.href
        ? <Button
            href={props.href}
            variant={props.variant}
            title={props.title}>
            {props.text}
        </Button>
        : null;