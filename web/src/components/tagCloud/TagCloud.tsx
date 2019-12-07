import { Tag } from "antd";
import React from "react";

import { Tag as TagInterface } from "../../interfaces/Tag";
import styles from "./TagCloud.module.css";

interface Props {
  tags: TagInterface[];
  showLabel?: boolean;
}

export const TagCloud = (props: Props) =>
  props.tags && props.tags.length ? (
    <div className={styles.grow}>
      {props.showLabel && <h3>{`Tag${props.tags.length > 1 ? "s" : ""}:`}</h3>}
      {props.tags.map((t: TagInterface, i: number) => (
        <Tag key={i} title={t.description}>
          {t.name}
        </Tag>
      ))}
    </div>
  ) : null;
