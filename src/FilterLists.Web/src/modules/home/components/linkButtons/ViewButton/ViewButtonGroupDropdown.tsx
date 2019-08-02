import * as React from "react";
import { DropdownButton, Dropdown } from "react-bootstrap";
import { ViewButton } from "./ViewButton";

interface Props {
    name: string;
    url: string;
    urlMirrors: string[];
};

export const ViewButtonGroupDropdown = (props: Props) => {
    let firstButtonText: string = "Original";
    let mirrorIndex: number = 0;

    if (props.url.indexOf("web.archive.org") !== -1) {
        firstButtonText = "Mirror 1";
        mirrorIndex++;
    }

    return <DropdownButton id="view-dropdown" drop="left" variant="primary" title="View">
        <Dropdown.Item as='span'>
            <ViewButton {...props} text={firstButtonText} />
        </Dropdown.Item>
        {props.urlMirrors.map(
            (m: string, i: number) =>
                <Dropdown.Item key={i} as='span'>
                    <ViewButton {...props} url={m} text={`Mirror ${i + 1 + mirrorIndex}`} />
                </Dropdown.Item>)}
    </DropdownButton>;
};