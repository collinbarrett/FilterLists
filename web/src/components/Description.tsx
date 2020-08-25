import React from "react";

interface Props {
  description: string;
  descriptionSourceUrl: string;
}

export const Description = (props: Props) =>
  props.descriptionSourceUrl ? (
    <blockquote cite={props.descriptionSourceUrl}>
      {props.description}
    </blockquote>
  ) : (
    <p>{props.description}</p>
  );
