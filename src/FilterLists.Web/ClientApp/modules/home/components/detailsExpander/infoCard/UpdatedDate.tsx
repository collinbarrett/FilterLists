import * as React from "react";

interface IProps {
    updatedDate: date;
};

export const UpdatedDate = (props: IProps) =>
    props.updatedDate
    ? <li className="list-group-item">
          <p>Updated: {props.updatedDate.toLocaleDateString()}</p>
      </li>
    : null;
