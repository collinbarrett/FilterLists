import React from 'react';

import { Software } from '../../interfaces/Software';
import styles from './SoftwareCloud.module.css';
import { SoftwareIcon } from './SoftwareIcon';

interface Props {
  software: Software[];
  showLabel?: boolean;
};

export const SoftwareCloud = (props: Props) =>
  props.software && props.software.length
    ? <div className={styles.grow}>
      {props.showLabel && <h3>{`Software:`}</h3>}
      {props.software.map((s: Software, i: number) =>
        s.homeUrl
          ? <a key={i}
            href={s.homeUrl}
            target="_blank"
            rel="noopener noreferrer">
            <SoftwareIcon id={s.id} />
          </a>
          : <SoftwareIcon key={i} id={s.id} />)}
    </div>
    : null;