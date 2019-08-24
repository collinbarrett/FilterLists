import { Tag } from 'antd';
import React from 'react';

import styles from './LanguageCloud.module.css';

interface LanguageData {
  iso6391: string;
  name: string;
};

interface Props {
  languages: LanguageData[]
};

export const LanguageCloud = (props: Props): JSX.Element | null =>
  props.languages && props.languages.length
    ? <div className={styles.grow}>
      {props.languages.map((l: LanguageData, i: number) =>
        <Tag key={i} title={l.name}>{l.iso6391}</Tag>)}
    </div>
    : null;