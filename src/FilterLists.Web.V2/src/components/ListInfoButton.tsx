import { Button } from 'antd';
import React from 'react';
import { RouteComponentProps } from 'react-router-dom';

import { List } from '../interfaces/List';

interface Props {
  list: List;
};

export const ListInfoButton = (props: RouteComponentProps & Props) =>
  <Button
    type="primary"
    icon="info-circle"
    onClick={() => props.location.pathname === `/lists/${props.list.id}`
      ? props.history.push("/")
      : props.history.push(`/lists/${props.list.id}`)} >
    Info
    </Button>;