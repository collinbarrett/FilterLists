import * as React from "react";
import "./button.css";

interface IProps {
    href: string;
    title?: string;
    buttonClass?: string;
    text: string;
};

export const LinkButton = (props: IProps) =>
    props.href
    ? <a href={props.href}
         title={props.title}
         className={`btn ${props.buttonClass || "btn-primary"} fl-btn-link`}>
          {props.text}
      </a>
    : null;