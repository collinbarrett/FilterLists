import { Button, Drawer } from 'antd';
import React from 'react';

import { Description } from '..';
import { List } from '../../interfaces/List';
import { SubscribeButton } from '../buttons';

interface State {
  visible: boolean;
}

interface Props {
  list: List;
};

export class ListDetails extends React.Component<Props, State> {
  constructor(props: any) {
    super(props);
    this.state = {
      visible: false
    };
  }

  render() {
    return (
      <span>
        <Button
          type="primary"
          onClick={() => this.setState({ visible: true, })}>
          Details
          </Button>
        <Drawer
          visible={this.state.visible}
          onClose={() => this.setState({ visible: false, })}>
          <Description {...this.props.list} />
          <SubscribeButton {...this.props.list} />
        </Drawer>
      </span>
    )
  }
}