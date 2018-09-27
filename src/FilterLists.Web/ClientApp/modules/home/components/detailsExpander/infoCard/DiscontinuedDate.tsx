import * as React from "react";
import * as moment from "moment";

interface IProps {
    date: string;
};

export const DiscontinuedDate = (props: IProps) =>
    props.date
    ? <li className="list-group-item">
          <p>Discontinued: {moment(props.date).format("l")}</p>
      </li>
    : null;