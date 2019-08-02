import * as React from "react";
import { SubscribeButtonGroupDropdown } from "./SubscribeButtonGroupDropdown";
import { SubscribeButton } from "./SubscribeButton";

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