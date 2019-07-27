import * as React from "react";
import "./description.css";

interface IProps {
    description: string;
    url: string;
};

export const Description = (props: IProps) =>
    props.description
    ? <h3 className="card-header fl-description">
          {props.url
               ? <blockquote cite={props.url} className="m-0">{props.description}</blockquote>
               : props.description}
      </h3>
    : null;