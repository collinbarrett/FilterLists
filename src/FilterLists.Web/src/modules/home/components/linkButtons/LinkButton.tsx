import * as React from "react";
import { Button, ButtonProps } from "react-bootstrap";
import "./button.css";

interface IProps {
    variant: ButtonProps["variant"],
    href: string;
    title?: string;
    text: string;
};

export const LinkButton = (props: IProps) =>
    props.href
        ? <Button variant={props.variant}
            href={props.href}
            title={props.title}
            className={`fl-btn-link`}>
            {props.text}
        </Button>
        : null;