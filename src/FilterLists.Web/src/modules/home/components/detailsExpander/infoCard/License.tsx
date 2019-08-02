import * as React from "react";
import { ILicense } from "../../../interfaces/ILicense";

interface Props {
    license: ILicense;
};

export const License = (props: Props) =>
    props.license.name
        ? (props.license.descriptionUrl
            ? <li className="list-group-item">
                <p>License: <a href={props.license.descriptionUrl}>{props.license.name}</a></p>
            </li>
            : <li className="list-group-item">
                <p>License: {props.license.name}</p>
            </li>)
        : null;