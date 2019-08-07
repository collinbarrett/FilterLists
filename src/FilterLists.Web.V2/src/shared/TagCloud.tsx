import { Tag } from 'antd';
import * as React from "react";

interface TagData {
  description: string;
  name: string;
};

interface Props {
  tags?: TagData[]
};

export const TagCloud = (props: Props): JSX.Element | null => {
  return props.tags
    ? <div>
      {props.tags.map((t: TagData, i: number) =>
        <Tag key={i} title={t.description}>{t.name}</Tag>)}
    </div>
    : null;
};