import { Tag } from 'antd';
import React from 'react';
import styles from './TagCloud.module.css';

interface TagData {
  description: string;
  name: string;
};

interface Props {
  tags?: TagData[]
};

export const TagCloud = (props: Props): JSX.Element | null => {
  return props.tags && props.tags.length
    ? <div className={styles.grow}>
      {props.tags.map((t: TagData, i: number) =>
        <Tag key={i} title={t.description}>{t.name}</Tag>)}
    </div>
    : null;
};