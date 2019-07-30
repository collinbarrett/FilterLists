import * as React from "react";
import moment from 'moment';

interface Props {
    date: string;
};

export const PublishedDate = (props: Props) =>
    props.date
        ? <li className="list-group-item">
            <p>Published: {moment(props.date).format("l")}</p>
        </li>
        : null;