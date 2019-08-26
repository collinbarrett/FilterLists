import { Divider, Drawer } from 'antd';
import ButtonGroup from 'antd/lib/button/button-group';
import React from 'react';
import { RouteComponentProps } from 'react-router-dom';

import { Language } from '../interfaces/Language';
import { List } from '../interfaces/List';
import { Tag } from '../interfaces/Tag';
import { Description } from './Description';
import { LanguageCloud } from './languageCloud';
import { LinkButton } from './LinkButton';
import { SubscribeButton } from './SubscribeButton';
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
      placement={"left"}
      mask={false}
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
      {this.props.list.publishedDate
        ? <div>
          <h3>First Published Date:</h3>
          {new Date(this.props.list.publishedDate).toDateString()}
        </div>
        : null}
      <Divider />
      <ButtonGroup style={{ display: "inherit" }}>
        {this.props.list.viewUrl && <SubscribeButton {...this.props.list} />}
        {this.props.list.viewUrl &&
          <LinkButton url={this.props.list.viewUrl}
            text="View"
            title={`View ${this.props.list.name} in its raw format`}
            icon="search" />}
        {this.props.list.homeUrl &&
          <LinkButton url={this.props.list.homeUrl}
            text="Home"
            title={`View ${this.props.list.name}'s homepage.`}
            icon="home" />}
        {this.props.list.policyUrl &&
          <LinkButton url={this.props.list.policyUrl}
            text="Policy"
            title={`View the types of rules that ${this.props.list.name} includes.`}
            icon="file-exclamation" />}
        {this.props.list.emailAddress &&
          <LinkButton url={`mailto:${this.props.list.emailAddress}`}
            text="Email"
            title={`Email ${this.props.list.name}.`}
            icon="mail" />}
        {this.props.list.issuesUrl &&
          <LinkButton url={this.props.list.issuesUrl}
            text="GitHub Issues"
            title={`View the GitHub Issues for ${this.props.list.name}.`}
            icon="github" />}
        {this.props.list.submissionUrl &&
          <LinkButton url={this.props.list.submissionUrl}
            text="Submit a Rule"
            title={`Submit a new rule to be included in ${this.props.list.name}.`}
            icon="form" />}
        {this.props.list.forumUrl &&
          <LinkButton url={this.props.list.forumUrl}
            text="Forum"
            title={`View the forum for ${this.props.list.name}.`}
            icon="team" />}
        {this.props.list.chatUrl &&
          <LinkButton url={this.props.list.chatUrl}
            text="Chat"
            title={`Enter the chat room for ${this.props.list.name}.`}
            icon="message" />}
        {this.props.list.donateUrl &&
          <LinkButton url={this.props.list.donateUrl}
            text="Donate"
            title={`Donate to the maintainer of ${this.props.list.name}.`}
            icon="dollar" />}
      </ButtonGroup>
    </Drawer>
  }

  componentWillUnmount() {
    document.title = this.state.baseDocumentTitle
  }
}