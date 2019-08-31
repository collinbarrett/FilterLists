import { Divider, Drawer } from 'antd';
import ButtonGroup from 'antd/lib/button/button-group';
import React, { useEffect, useState } from 'react';
import { RouteComponentProps } from 'react-router-dom';

import { Language } from '../interfaces/Language';
import { License } from '../interfaces/License';
import { List } from '../interfaces/List';
import { Tag } from '../interfaces/Tag';
import { Description } from './Description';
import { LanguageCloud } from './languageCloud';
import { LicenseTag } from './LicenseTag';
import { LinkButton } from './LinkButton';
import { SubscribeButtons } from './SubscribeButtons';
import { TagCloud } from './tagCloud';

interface Props {
  list: List;
  languages: Language[];
  license?: License;
  tags: Tag[];
};

export const ListInfoDrawer = (props: RouteComponentProps & Props) => {
  const [originalTitle] = useState<string>(document.title);
  useEffect(() => {
    const updateTitle = () => document.title = props.list.name + " | " + originalTitle;
    updateTitle();
    return () => { document.title = originalTitle; };
  }, [props.list, originalTitle]);
  return (
    <Drawer
      visible={true}
      width={350}
      placement={"right"}
      mask={false}
      title={props.list.name}
      destroyOnClose={true}
      onClose={() => props.history.push("/")}>
      <Description {...props.list} />
      {props.list.languageIds
        ? <LanguageCloud languages={props.languages} showLabel={true} />
        : null}
      {props.list.tagIds
        ? <TagCloud tags={props.tags} showLabel={true} />
        : null}
      {props.license
        ? <LicenseTag license={props.license as License} showLabel={true} />
        : null}
      {props.list.publishedDate
        ? <div>
          <h3>First Published Date:</h3>
          {new Date(props.list.publishedDate).toDateString()}
        </div>
        : null}
      <Divider />
      <ButtonGroup style={{ display: "inherit" }}>
        {props.list.viewUrl && <SubscribeButtons {...props.list} />}
        {props.list.viewUrl &&
          <LinkButton url={props.list.viewUrl}
            text="View"
            title={`View ${props.list.name} in its raw format`}
            icon="search" />}
        {props.list.homeUrl &&
          <LinkButton url={props.list.homeUrl}
            text="Home"
            title={`View ${props.list.name}'s homepage.`}
            icon="home" />}
        {props.list.policyUrl &&
          <LinkButton url={props.list.policyUrl}
            text="Policy"
            title={`View the types of rules that ${props.list.name} includes.`}
            icon="file-exclamation" />}
        {props.list.emailAddress &&
          <LinkButton url={`mailto:${props.list.emailAddress}`}
            text="Email"
            title={`Email ${props.list.name}.`}
            icon="mail" />}
        {props.list.issuesUrl &&
          <LinkButton url={props.list.issuesUrl}
            text="GitHub Issues"
            title={`View the GitHub Issues for ${props.list.name}.`}
            icon="github" />}
        {props.list.submissionUrl &&
          <LinkButton url={props.list.submissionUrl}
            text="Submit a Rule"
            title={`Submit a new rule to be included in ${props.list.name}.`}
            icon="form" />}
        {props.list.forumUrl &&
          <LinkButton url={props.list.forumUrl}
            text="Forum"
            title={`View the forum for ${props.list.name}.`}
            icon="team" />}
        {props.list.chatUrl &&
          <LinkButton url={props.list.chatUrl}
            text="Chat"
            title={`Enter the chat room for ${props.list.name}.`}
            icon="message" />}
        {props.list.donateUrl &&
          <LinkButton url={props.list.donateUrl}
            text="Donate"
            title={`Donate to the maintainer of ${props.list.name}.`}
            icon="dollar" />}
      </ButtonGroup>
    </Drawer>
  );
};