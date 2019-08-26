import { Button } from 'antd';
import React from 'react';
import { RouteComponentProps } from 'react-router-dom';

import { List } from '../interfaces/List';

interface Props {
  list: List;
};

export const ListDetailsButton = (props: RouteComponentProps & Props) =>
  <Button
    type="primary"
    icon="info-circle"
    onClick={() => props.history.push(`/lists/${props.list.id}`)}>
    Details
  </Button>;