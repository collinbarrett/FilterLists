import { Tag } from 'antd';
import * as React from 'react';

import { License } from '../interfaces/License';

interface Props {
  license: License;
  showLabel?: boolean
};

export const LicenseTag = (props: Props) =>
  props.license && props.license.name
    ? <div>
      {props.showLabel && <h3>License:</h3>}
      <Tag>
        <TagContents {...props} />
      </Tag>
    </div>
    : null;

const TagContents = (props: Props) =>
  props.license.descriptionUrl
    ? <a href={props.license.descriptionUrl} target="_blank" rel="noopener noreferrer">
      {props.license.name}
    </a>
    : <span>{props.license.name}</span>