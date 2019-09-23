import "./listInfoDrawer.css";

import { Divider, Drawer } from "antd";
import ButtonGroup from "antd/lib/button/button-group";
import React, { useEffect, useState } from "react";
import { RouteComponentProps } from "react-router-dom";

import { Language } from "../../interfaces/Language";
import { License } from "../../interfaces/License";
import { List } from "../../interfaces/List";
import { Maintainer } from "../../interfaces/Maintainer";
import { Software } from "../../interfaces/Software";
import { Syntax } from "../../interfaces/Syntax";
import { Tag } from "../../interfaces/Tag";
import { Description } from "../Description";
import { LanguageCloud } from "../languageCloud";
import { LicenseTag } from "../LicenseTag";
import { LinkButton } from "../LinkButton";
import { Maintainers } from "../maintainers";
import { PublishedDate } from "../PublishedDate";
import { SoftwareCloud } from "../softwareCloud";
import { SubscribeButtons } from "../SubscribeButtons";
import { SyntaxTag } from "../SyntaxTag";
import { TagCloud } from "../tagCloud";

interface Props {
  list: List;
  languages: Language[];
  license: License | undefined;
  maintainers: Maintainer[];
  software: Software[];
  syntax: Syntax | undefined;
  tags: Tag[];
}

export const ListInfoDrawer = (props: RouteComponentProps & Props) => {
  const [originalTitle] = useState<string>(document.title);
  useEffect(() => {
    const updateTitle = () =>
      (document.title = props.list.name + " | " + originalTitle);
    updateTitle();
    return () => {
      document.title = originalTitle;
    };
  }, [props.list, originalTitle]);
  return (
    <Drawer
      visible={true}
      width={350}
      placement={"right"}
      mask={false}
      title={props.list.name}
      destroyOnClose={true}
      onClose={() => props.history.push("/")}
    >
      <Description
        description={props.list.description}
        descriptionSourceUrl={props.list.descriptionSourceUrl}
      />
      <LanguageCloud languages={props.languages} showLabel={true} />
      <TagCloud tags={props.tags} showLabel={true} />
      {props.license && (
        <LicenseTag
          name={props.license.name}
          descriptionUrl={props.license.descriptionUrl}
          showLabel={true}
        />
      )}
      {props.syntax && (
        <SyntaxTag
          name={props.syntax.name}
          definitionUrl={props.syntax.definitionUrl}
          showLabel={true}
        />
      )}
      <SoftwareCloud software={props.software} showLabel={true} />
      <PublishedDate publishedDate={props.list.publishedDate} />
      <Maintainers maintainers={props.maintainers} />
      <Divider />
      <ButtonGroup style={{ display: "inherit" }}>
        <SubscribeButtons
          name={props.list.name}
          viewUrl={props.list.viewUrl}
          viewUrlMirrors={props.list.viewUrlMirrors}
        />
        <LinkButton
          url={props.list.viewUrl}
          text="View"
          title={`View ${props.list.name} in its raw format`}
          icon="search"
        />
        <LinkButton
          url={props.list.homeUrl}
          text="Home"
          title={`View ${props.list.name}'s homepage.`}
          icon="home"
        />
        <LinkButton
          url={props.list.policyUrl}
          text="Policy"
          title={`View the types of rules that ${props.list.name} includes.`}
          icon="file-exclamation"
        />
        {props.list.emailAddress && (
          <LinkButton
            url={`mailto:${props.list.emailAddress}`}
            text="Email"
            title={`Email ${props.list.name}.`}
            icon="mail"
          />
        )}
        <LinkButton
          url={props.list.issuesUrl}
          text="GitHub Issues"
          title={`View the GitHub Issues for ${props.list.name}.`}
          icon="github"
        />
        <LinkButton
          url={props.list.submissionUrl}
          text="Submit a Rule"
          title={`Submit a new rule to be included in ${props.list.name}.`}
          icon="form"
        />
        <LinkButton
          url={props.list.forumUrl}
          text="Forum"
          title={`View the forum for ${props.list.name}.`}
          icon="team"
        />
        <LinkButton
          url={props.list.chatUrl}
          text="Chat"
          title={`Enter the chat room for ${props.list.name}.`}
          icon="message"
        />
        <LinkButton
          url={props.list.donateUrl}
          text="Donate"
          title={`Donate to the maintainer of ${props.list.name}.`}
          icon="dollar"
        />
      </ButtonGroup>
    </Drawer>
  );
};
