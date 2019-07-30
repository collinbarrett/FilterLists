import * as React from "react";
import { DropdownButton, Dropdown } from "react-bootstrap";
import { SubscribeButton } from "./SubscribeButton";

interface Props {
    name: string;
    url: string;
    urlMirrors: string[];
};

export const SubscribeButtonGroupDropdown = (props: Props) => {
    let firstButtonText: string = "Original";
    let mirrorIndex: number = 0;

    if (props.url.indexOf("web.archive.org") !== -1) {
        firstButtonText = "Mirror 1";
        mirrorIndex++;
    }

    return <DropdownButton id="subscribe-dropdown" drop="left" variant="primary" title="Subscribe">
        <Dropdown.Item as='span'>
            <SubscribeButton {...props} text={firstButtonText} />
        </Dropdown.Item>
        {props.urlMirrors.map(
            (m: string, i: number) =>
                <Dropdown.Item key={i} as='span'>
                    <SubscribeButton {...props} url={m} text={`Mirror ${i + 1 + mirrorIndex}`} />
                </Dropdown.Item>)}
    </DropdownButton>;
};