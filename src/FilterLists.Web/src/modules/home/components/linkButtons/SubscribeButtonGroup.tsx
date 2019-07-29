import * as React from "react";
import { DropdownButton, Dropdown } from "react-bootstrap";
import { SubscribeButton } from "./SubscribeButton";

interface IProps {
    name: string;
    url: string;
    urlMirrors?: string[];
};

export const SubscribeButtonGroup = (props: IProps) =>
    props.url
        ? (props.urlMirrors && props.urlMirrors.length > 0)
            ? <SubscribeButtonGroupDropdown {...props} urlMirrors={props
                .urlMirrors} />
            : <SubscribeButton {...props} />
        : null;

interface ISubscribeButtonGroupDropdownProps {
    name: string;
    url: string;
    urlMirrors: string[];
};

const SubscribeButtonGroupDropdown = (props: ISubscribeButtonGroupDropdownProps) => {
    let firstButtonText: string = "Original";
    let mirrorIndex: number = 0;

    if (props.url.indexOf("web.archive.org") !== -1) {
        firstButtonText = "Mirror 1";
        mirrorIndex++;
    }

    return <DropdownButton id="subscribe-dropdown" drop="left" variant="primary" title="Subscribe" className="fl-btn-link">
        <Dropdown.Item >
            <SubscribeButton {...props} text={firstButtonText} />
        </Dropdown.Item>
        {props.urlMirrors.map(
            (m: string, i: number) =>
                <Dropdown.Item key={i}>
                    <SubscribeButton {...props} url={m} text={`Mirror ${i + 1 + mirrorIndex}`} />
                </Dropdown.Item>)}
    </DropdownButton>;
};
