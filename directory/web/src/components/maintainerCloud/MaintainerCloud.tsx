import { Tag } from "antd";
import React from "react";

import { Maintainer } from "../../interfaces/Maintainer";
import styles from "./MaintainerCloud.module.css";

interface Props {
  maintainers: Maintainer[];
}

export const MaintainerCloud = (props: Props) =>
  props.maintainers && props.maintainers.length ? (
    <div className={styles.grow}>
      {props.maintainers.map((m: Maintainer, i: number) =>
        m.homeUrl ? (
          <Tag key={i}>
            <a
              href={m.homeUrl}
              title={`View ${m.name}'s homepage.`}
              target="_blank"
              rel="noopener noreferrer"
            >
              {m.name}
            </a>
          </Tag>
        ) : (
          <Tag key={i}>{m.name}</Tag>
        )
      )}
    </div>
  ) : null;
