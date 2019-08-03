import * as React from "react";
import { EmailButton, HomeButton, TwitterButton } from "../../linkButtons";

interface Props {
    emailAddress: string;
    homeUrl: string;
    name: string;
    twitterHandle: string;
};

export const MaintainerLinkButtonGroup = (props: Props) =>
    <div className="btn-group-vertical">
        <HomeButton {...props} url={props.homeUrl} />
        <EmailButton {...props} />
        <TwitterButton {...props} />
    </div>;