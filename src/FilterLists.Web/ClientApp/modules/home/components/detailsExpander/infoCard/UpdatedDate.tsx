import * as React from "react";

interface IProps {
    updatedDate: string;
};

export const UpdatedDate = (props: IProps) =>
    props.updatedDate
    ? <li className="list-group-item">
          <p>Updated: (props.updatedDate).isValid()
                             options = { timeZone: 'utc' };
                           ? (props.updatedDate)Intl.DateTimeFormat(['nb-NO'], options).format(date)
                           : "N/A"}</p>
      </li>
    : null;
