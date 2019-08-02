import * as React from "react";
import { ViewButtonGroupDropdown } from "./ViewButtonGroupDropdown";
import { ViewButton } from "./ViewButton";

interface Props {
    name: string;
    url: string;
    urlMirrors?: string[];
};

export const ViewButtonGroup = (props: Props) =>
    props.url
        ? (props.urlMirrors && props.urlMirrors.length > 0)
            ? <ViewButtonGroupDropdown {...props} urlMirrors={props.urlMirrors} />
            : <ViewButton {...props} />
        : null;