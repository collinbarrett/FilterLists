import * as React from "react";
import { LinkButton } from "../LinkButton";

interface Props {
    name: string;
    url: string;
    text?: string;
};

export const ViewButton = (props: Props) => {

    let title;
    if (props.url.indexOf(".onion/") > 0) { title = `Tor address - View ${props.name} in its raw format.`; }
    else if (props.url.indexOf(".zip") > 0) { title = `Download ${props.name} as a ZIP compressed archive.`; }
    else if (props.url.indexOf(".7z") > 0) { title = `Download ${props.name} as a 7Z compressed archive.`; }
    else if (props.url.indexOf(".tar.gz") > 0) { title = `Download ${props.name} as a compressed tarball archive.`; }
    else { title = `View ${props.name} in its raw format`; };

    return props.url
        ? <LinkButton href={props.url}
            title={title}
            text={props.text || "View"} />
        : null;
}
