import "./maintainers.css";

import { Card, Icon } from "antd";
import React from "react";

import { Maintainer } from "../../interfaces/Maintainer";

interface Props {
  maintainers: Maintainer[];
}

export const Maintainers = (props: Props) =>
  props.maintainers && props.maintainers.length ? (
    <>
      <h3>Maintainer{props.maintainers.length > 1 ? "s" : ""}:</h3>
      {props.maintainers.map((m: Maintainer, index: number) => (
        <MaintainerComponent key={index} maintainer={m} />
      ))}
    </>
  ) : null;

interface MaintainerComponentProps {
  maintainer: Maintainer;
}

const MaintainerComponent = (props: MaintainerComponentProps) => {
  let actions = [];
  if (props.maintainer.homeUrl) {
    actions.push(
      <a
        href={props.maintainer.homeUrl}
        title={`View ${props.maintainer.name}'s homepage.`}
        target="_blank"
        rel="noopener noreferrer"
      >
        <Icon type="home" key="home" />
      </a>
    );
  }
  if (props.maintainer.emailAddress) {
    actions.push(
      <a
        href={`mailto:${props.maintainer.emailAddress}`}
        title={`Email ${props.maintainer.name}.`}
        target="_blank"
        rel="noopener noreferrer"
      >
        <Icon type="mail" key="mail" />
      </a>
    );
  }
  if (props.maintainer.twitterHandle) {
    actions.push(
      <a
        href={`https://twitter.com/${props.maintainer.twitterHandle}`}
        title={`${props.maintainer.twitterHandle} on Twitter`}
        target="_blank"
        rel="noopener noreferrer"
      >
        <Icon type="twitter" key="twitter" />
      </a>
    );
  }
  return <Card title={props.maintainer.name} actions={actions} />;
};
