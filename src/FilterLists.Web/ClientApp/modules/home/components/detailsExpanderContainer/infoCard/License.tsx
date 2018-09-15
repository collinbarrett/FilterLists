import * as React from "react";
import { IListLicenseDto } from "../IFilterListDetailsDto";

export const License = (props: IListLicenseDto) => {
    return props.name
               ? (props.descriptionUrl
                      ? <li className="list-group-item">
                            <p>License: <a href={props.descriptionUrl}>{props.name}</a></p>
                        </li>
                      : <li className="list-group-item">
                            <p>License: {props.name}</p>
                        </li>)
               : null;
};