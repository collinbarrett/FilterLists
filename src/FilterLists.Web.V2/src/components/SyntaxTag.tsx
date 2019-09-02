import { Tag } from 'antd';
import * as React from 'react';

interface Props {
  name: string;
  definitionUrl: string;
};

export const SyntaxTag = (props: Props) =>
  props.name
    ? <>
      <h3>Syntax:</h3>
      <Tag>
        <TagContents
          name={props.name}
          definitionUrl={props.definitionUrl} />
      </Tag>
    </>
    : null;

const TagContents = (props: Props) =>
  props.definitionUrl
    ? <a href={props.definitionUrl}
      title={`View ${props.name}'s homepage.`}
      target="_blank"
      rel="noopener noreferrer">
      {props.name}
    </a>
    : <>
      {props.name}
    </>;