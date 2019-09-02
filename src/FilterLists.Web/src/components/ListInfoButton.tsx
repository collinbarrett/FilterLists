import { Button, Icon } from 'antd';
import React from 'react';
import { RouteComponentProps } from 'react-router-dom';
import slugify from 'slugify';

interface Props {
  listName: string;
};

export const ListInfoButton = (props: RouteComponentProps & Props) => {
  const listPath = `/lists/${slugify(props.listName)}`;
  return (
    <Button
      type="primary"
      title={`View more information about ${props.listName}.`}
      onClick={() => props.location.pathname === listPath
        ? props.history.push("/")
        : props.history.push(listPath)} >
      <Icon type="info-circle" />
    </Button>
  );
};