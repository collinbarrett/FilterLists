import * as React from "react";

interface IProps {
    updatedDate: string;
};

export const UpdatedDate = (props: IProps) =>
    props.updatedDate
    ? <li className="list-group-item">
          <p>Updated: {props.updatedDate.format("l").toLocaleString()}</p>
      </li>
    : null;
