import * as React from "react";
import { ISyntax } from "../../../interfaces/ISyntax";

interface Props {
    syntax: ISyntax;
};

export const Syntax = (props: Props) =>
    props.syntax
        ? (props.syntax.definitionUrl
            ? <li className="list-group-item">
                <p>Syntax: <a href={props.syntax.definitionUrl}>{props.syntax.name}</a></p>
            </li>
            : <li className="list-group-item">
                <p>Syntax: {props.syntax.name}</p>
            </li>)
        : null;