import { Tag } from 'antd';
import * as React from 'react';

interface Props {
  name: string;
  descriptionUrl: string;
};

export const LicenseTag = (props: Props) =>
  props.name
    ? <>
      <h3>License:</h3>
      <Tag>
        <TagContents
          name={props.name}
          descriptionUrl={props.descriptionUrl} />
      </Tag>
    </>
    : null;

interface TagContentsProps {
  name: string;
  descriptionUrl: string;
};

const TagContents = (props: TagContentsProps) =>
  props.descriptionUrl
    ? <a href={props.descriptionUrl}
      target="_blank"
      rel="noopener noreferrer">
      {props.name}
    </a>
    : <>
      {props.name}
    </>;