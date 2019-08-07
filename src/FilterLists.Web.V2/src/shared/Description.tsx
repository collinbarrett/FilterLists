import React from 'react';

interface Props {
  desription: string;
  desriptionSourceUrl: string;
};

export const Description = (props: Props): JSX.Element | null =>
  props.desriptionSourceUrl
    ? <blockquote cite={props.desriptionSourceUrl}>{props.desription}</blockquote>
    : <p>{props.desription}</p>;