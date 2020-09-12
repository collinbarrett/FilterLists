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
import { TagCloud } from "../tagCloud";
import { useListDetails } from "../../hooks";
import { SyntaxCloud } from "../syntaxCloud";
import { Tag } from "../../interfaces/Tag";
import { License } from "../../interfaces/License";
import { Maintainer } from "../../interfaces/Maintainer";
import { Software } from "../../interfaces/Software";
import { Syntax } from "../../interfaces/Syntax";
import { Language } from "../../interfaces/Language";

interface Props {
  listId: number;
  languages: Language[];
  licenses: License[];
  maintainers: Maintainer[];
  software: Software[];
  syntaxes: Syntax[];
  tags: Tag[];
}

export const ListInfoDrawer = (props: RouteComponentProps & Props) => {
  const list = useListDetails(props.listId);

  const listLanguage = props.languages.filter((l) =>
    list?.iso6391s.includes(l.iso6391)
  );
  const listTags = props.tags.filter((t) => list?.tagIds.includes(t.id));
  const listLicense = props.licenses.find((l) => l.id === list?.id);
  const listSyntaxes = props.syntaxes.filter((s) =>
    list?.syntaxIds.includes(s.id)
  );
  const listSoftware = props.software.filter((s) =>
    s.syntaxIds.some((sid) => list?.syntaxIds.includes(sid))
  );
  const listMaintainers = props.maintainers.filter((m) =>
    list?.maintainerIds.includes(m.id)
  );

  const [originalTitle] = useState<string>(document.title);
  const listName = list?.name;
  useEffect(() => {
    const updateTitle = () =>
      (document.title = list?.name + " | " + originalTitle);
    updateTitle();
    return () => {
      document.title = originalTitle;
    };
  }, [list, originalTitle, listName]);
  const viewUrl = list?.viewUrls.find(
    (u) => u.primariness === 1 && u.segmentNumber === 1
  )?.url;
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
      <LanguageCloud languages={listLanguage} showLabel={true} />
      <TagCloud tags={listTags} showLabel={true} />
      {listLicense && (
        <LicenseTag
          name={listLicense.name}
          url={listLicense.url}
          showLabel={true}
        />
      )}
      {listSyntaxes && <SyntaxCloud syntaxes={listSyntaxes} showLabel={true} />}
      <SoftwareCloud software={listSoftware} showLabel={true} />
      <Maintainers maintainers={listMaintainers} />
      <Divider />
      <ButtonGroup style={{ display: "inherit" }}>
        {viewUrl && (
          <SubscribeButtons
            name={list.name}
            viewUrl={viewUrl}
            viewUrlMirrors={[]}
          />
        )}
        {viewUrl && (
          <LinkButton
            url={viewUrl}
            text="View"
            title={`View ${list.name} in its raw format`}
            icon={<SearchOutlined />}
          />
        )}
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
