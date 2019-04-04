import * as React from "react";

interface IProps {
    updatedDate: string;
};

options = { timeZone: 'utc' };

export const UpdatedDate = (props: IProps) =>
    props.updatedDate
    ? <li className="list-group-item">
          <p>Updated: (props.updatedDate).isValid()
                           ? (props.updatedDate)Intl.DateTimeFormat().format(date)
                           : "N/A"}</p>
      </li>
    : null;
