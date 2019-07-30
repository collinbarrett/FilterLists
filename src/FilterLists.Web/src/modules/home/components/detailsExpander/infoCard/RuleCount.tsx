import * as React from "react";

interface Props {
    ruleCount: number;
};

export const RuleCount = (props: Props) =>
    props.ruleCount > 0
        ? <li className="list-group-item">
            <p>Rule Count: {props.ruleCount.toLocaleString()}</p>
        </li>
        : null;