import React from 'react';

interface Props {
  publishedDate: string;
  showLabel?: boolean;
};

export const PublishedDate = (props: Props) =>
  props.publishedDate
    ? <>
      {props.showLabel && <h3>First Published Date:</h3>}
      {new Date(props.publishedDate).toDateString()}
    </>
    : null;