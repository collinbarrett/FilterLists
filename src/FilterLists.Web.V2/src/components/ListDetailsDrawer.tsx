import { Drawer } from 'antd';
import React from 'react';
import { RouteComponentProps } from 'react-router-dom';

import { List } from '../interfaces/List';
import { Description } from './Description';
import { SubscribeButton } from './subscribeButton';

interface Props {
  list: List;
};

export const ListDetailsDrawer = (props: RouteComponentProps & Props) =>
  <Drawer
    visible={true}
    onClose={() => props.history.push("/")}>
    <Description {...props.list} />
    <SubscribeButton {...props.list} />
  </Drawer>;