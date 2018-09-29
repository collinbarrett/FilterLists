import * as React from "react";

export const Syntax = (props: any) =>
    props.name
    ? (props.definitionUrl
           ? <li className="list-group-item">
                 <p>Syntax: <a href={props.definitionUrl}>{props.name}</a></p>
             </li>
           : <li className="list-group-item">
                 <p>Syntax: {props.name}</p>
             </li>)
    : null;