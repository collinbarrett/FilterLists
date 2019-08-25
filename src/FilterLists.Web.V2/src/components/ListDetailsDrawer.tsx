import { Drawer } from 'antd';
import React from 'react';
import { RouteComponentProps } from 'react-router-dom';

import { List } from '../interfaces/List';
import { Description } from './Description';
import { SubscribeButton } from './subscribeButton';

interface Props {
  list: List;
};

interface State {
  baseDocumentTitle: string;
}

export class ListDetailsDrawer extends React.Component<RouteComponentProps & Props, State> {
  constructor(props: any) {
    super(props);
    this.state = {
      baseDocumentTitle: document.title
    };
  }

  componentDidMount() {
    document.title = this.props.list.name + " | " + this.state.baseDocumentTitle
  }

  render() {
    return <Drawer
      visible={true}
      onClose={() => this.props.history.push("/")}>
      <h2>{this.props.list.name}</h2>
      <Description {...this.props.list} />
      <SubscribeButton {...this.props.list} />
    </Drawer>
  }

  componentWillUnmount() {
    document.title = this.state.baseDocumentTitle
  }
}