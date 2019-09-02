import React from 'react';

interface Props {
  publishedDate: string;
};

export const PublishedDate = (props: Props) =>
  props.publishedDate
    ? <>
      <h3>First Published Date:</h3>
      {new Date(props.publishedDate).toDateString()}
    </>
    : null;