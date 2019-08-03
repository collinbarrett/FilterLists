import * as React from "react";
import { SubscribeButton } from "./SubscribeButton";
import { SubscribeButtonGroupDropdown } from "./SubscribeButtonGroupDropdown";

interface Props {
    name: string;
    url: string;
    urlMirrors?: string[];
};

export const SubscribeButtonGroup = (props: Props) =>
    props.url
        ? (props.urlMirrors && props.urlMirrors.length > 0)
            ? <SubscribeButtonGroupDropdown {...props} urlMirrors={props.urlMirrors} />
            : <SubscribeButton {...props} />
        : null;