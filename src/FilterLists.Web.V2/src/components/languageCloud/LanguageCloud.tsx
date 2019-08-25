import { Tag } from 'antd';
import React from 'react';

import styles from './LanguageCloud.module.css';

interface LanguageData {
  iso6391: string;
  name: string;
};

interface Props {
  languages: LanguageData[]
  showLabel?: boolean
};

export const LanguageCloud = (props: Props): JSX.Element | null =>
  props.languages && props.languages.length
    ? <div className={styles.grow}>
      {props.showLabel && <h3>{`Language${props.languages.length > 1 ? "s" : ""}:`}</h3>}
      {props.languages.map((l: LanguageData, i: number) =>
        <Tag key={i} title={l.name}>{l.iso6391}</Tag>)}
    </div>
    : null;