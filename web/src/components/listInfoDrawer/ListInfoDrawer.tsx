import "./listInfoDrawer.css";

import { Divider, Drawer } from "antd";
import {
  DollarOutlined,
  FileExclamationOutlined,
  FormOutlined,
  GithubOutlined,
  HomeOutlined,
  MailOutlined,
  MessageOutlined,
  SearchOutlined,
  TeamOutlined,
} from "@ant-design/icons";
import React, { useEffect, useState } from "react";

import ButtonGroup from "antd/lib/button/button-group";
import { Description } from "../Description";
import { LanguageCloud } from "../languageCloud";
import { LicenseTag } from "../LicenseTag";
import { LinkButton } from "../LinkButton";
import { Maintainers } from "../maintainers";
import { RouteComponentProps } from "react-router-dom";
import { SoftwareCloud } from "../softwareCloud";
import { SubscribeButtons } from "../SubscribeButtons";
import { SyntaxTag } from "../SyntaxTag";
import { TagCloud } from "../tagCloud";
import {
  useListDetails,
  useLanguages,
  useLicenses,
  useMaintainers,
  useSoftware,
  useSyntaxes,
  useTags,
} from "../../hooks";

interface Props {
  listId: number;
}

export const ListInfoDrawer = (props: RouteComponentProps & Props) => {
  const list = useListDetails(props.listId);
  const languages = useLanguages();
  const licenses = useLicenses();
  const maintainers = useMaintainers();
  const software = useSoftware();
  const syntaxes = useSyntaxes();
  const tags = useTags();
  const [originalTitle] = useState<string>(document.title);
  useEffect(() => {
    const updateTitle = () =>
      (document.title = list?.name + " | " + originalTitle);
    updateTitle();
    return () => {
      document.title = originalTitle;
    };
  }, [list, originalTitle, list?.name]);
  return list ? (
    <Drawer
      visible={true}
      width={350}
      placement={"right"}
      mask={false}
      title={list.name}
      destroyOnClose={true}
      onClose={() => props.history.push("/")}
    >
      <Description description={list.description} />
      <LanguageCloud languages={languages} showLabel={true} />
      <TagCloud tags={tags} showLabel={true} />
      {/* {list.license && (
        <LicenseTag
          name={list.license.name}
          url={list.license.url}
          showLabel={true}
        />
      )}
      {list.syntax && (
        <SyntaxTag
          name={list.syntax.name}
          definitionUrl={list.syntax.url}
          showLabel={true}
        />
      )} */}
      <SoftwareCloud software={software} showLabel={true} />
      <Maintainers maintainers={maintainers} />
      <Divider />
      <ButtonGroup style={{ display: "inherit" }}>
        {/* <SubscribeButtons
          name={list.name}
          viewUrl={list.viewUrl}
          viewUrlMirrors={list.viewUrlMirrors}
        />
        <LinkButton
          url={list.viewUrl}
          text="View"
          title={`View ${list.name} in its raw format`}
          icon={<SearchOutlined />}
        /> */}
        <LinkButton
          url={list.homeUrl}
          text="Home"
          title={`View ${list.name}'s homepage.`}
          icon={<HomeOutlined />}
        />
        <LinkButton
          url={list.policyUrl}
          text="Policy"
          title={`View the types of rules that ${list.name} includes.`}
          icon={<FileExclamationOutlined />}
        />
        {list.emailAddress && (
          <LinkButton
            url={`mailto:${list.emailAddress}`}
            text="Email"
            title={`Email ${list.name}.`}
            icon={<MailOutlined />}
          />
        )}
        <LinkButton
          url={list.issuesUrl}
          text="GitHub Issues"
          title={`View the GitHub Issues for ${list.name}.`}
          icon={<GithubOutlined />}
        />
        <LinkButton
          url={list.submissionUrl}
          text="Submit a Rule"
          title={`Submit a new rule to be included in ${list.name}.`}
          icon={<FormOutlined />}
        />
        <LinkButton
          url={list.forumUrl}
          text="Forum"
          title={`View the forum for ${list.name}.`}
          icon={<TeamOutlined />}
        />
        <LinkButton
          url={list.chatUrl}
          text="Chat"
          title={`Enter the chat room for ${list.name}.`}
          icon={<MessageOutlined />}
        />
        <LinkButton
          url={list.donateUrl}
          text="Donate"
          title={`Donate to the maintainer of ${list.name}.`}
          icon={<DollarOutlined />}
        />
      </ButtonGroup>
    </Drawer>
  ) : null;
};
