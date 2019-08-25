import { Drawer } from 'antd';
import React from 'react';
import { RouteComponentProps } from 'react-router-dom';

import { Language } from '../interfaces/Language';
import { List } from '../interfaces/List';
import { Tag } from '../interfaces/Tag';
import { Description } from './Description';
import { LanguageCloud } from './languageCloud';
import { SubscribeButton } from './subscribeButton';
import { TagCloud } from './tagCloud';

interface Props {
  list: List;
  languages: Language[];
  tags: Tag[];
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
      width={350}
      title={this.props.list.name}
      destroyOnClose={true}
      onClose={() => this.props.history.push("/")}>
      <Description {...this.props.list} />
      {this.props.list.languageIds
        ? <LanguageCloud languages={this.props.languages.filter((l: Language) => this.props.list.languageIds.includes(l.id))} showLabel={true} />
        : null}
      {this.props.list.tagIds
        ? <TagCloud tags={this.props.tags.filter((t: Tag) => this.props.list.tagIds.includes(t.id))} showLabel={true} />
        : null}
      <SubscribeButton {...this.props.list} />
    </Drawer>
  }

  componentWillUnmount() {
    document.title = this.state.baseDocumentTitle
  }
}