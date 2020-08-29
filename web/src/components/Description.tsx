import React from "react";

interface Props {
  description: string;
}

export const Description = (props: Props) => <p>{props.description}</p>;
