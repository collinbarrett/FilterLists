import React from "react";

import { Syntax } from "../../interfaces/Syntax";
import { SyntaxTag } from "../SyntaxTag";
import styles from "./SyntaxCloud.module.css";

interface Props {
  syntaxes: Syntax[];
  showLabel?: boolean;
}

export const SyntaxCloud = (props: Props) =>
  props.syntaxes && props.syntaxes.length ? (
    <div className={styles.grow}>
      {props.showLabel && (
        <h3>{`Syntax${props.syntaxes.length > 1 ? "es" : ""}:`}</h3>
      )}
      {props.syntaxes.map((s: Syntax, i: number) => (
        <SyntaxTag name={s.name} definitionUrl={s.url} />
      ))}
    </div>
  ) : null;
