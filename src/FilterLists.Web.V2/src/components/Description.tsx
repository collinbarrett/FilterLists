import React from 'react';

interface Props {
  description: string;
  descriptionSourceUrl: string;
};

export const Description = (props: Props) =>
  props.description
    ? <blockquote cite={props.description}>{props.description}</blockquote>
    : <p>{props.description}</p>;