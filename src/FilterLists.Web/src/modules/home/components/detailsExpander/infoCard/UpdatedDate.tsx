import moment from 'moment';
import * as React from "react";

interface Props {
    updatedDate: string;
};

export const UpdatedDate = (props: Props) =>
    props.updatedDate
        ? <li className="list-group-item">
            <p>Updated: {moment(props.updatedDate).isValid()
                ? moment(props.updatedDate).format("l")
                : "N/A"}</p>
        </li>
        : null;
