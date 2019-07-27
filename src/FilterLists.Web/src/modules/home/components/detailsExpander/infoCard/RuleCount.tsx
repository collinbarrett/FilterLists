import * as React from "react";

interface IProps {
    ruleCount: number;
};

export const RuleCount = (props: IProps) =>
    props.ruleCount > 0
    ? <li className="list-group-item">
          <p>Rule Count: {props.ruleCount.toLocaleString()}</p>
      </li>
    : null;