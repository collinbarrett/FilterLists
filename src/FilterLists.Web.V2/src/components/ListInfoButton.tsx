import { Button, Icon } from 'antd';
import React from 'react';
import { RouteComponentProps } from 'react-router-dom';

import { List } from '../interfaces/List';

interface Props {
  list: List;
};

export const ListInfoButton = (props: RouteComponentProps & Props): JSX.Element => {
  const listPath = `/lists/${props.list.id}`;
  return <Button
    type="primary"
    title={`View more information about ${props.list.name}.`}
    onClick={() => props.location.pathname === listPath
      ? props.history.push("/")
      : props.history.push(listPath)} >
    <Icon type="info-circle" />
  </Button>
};