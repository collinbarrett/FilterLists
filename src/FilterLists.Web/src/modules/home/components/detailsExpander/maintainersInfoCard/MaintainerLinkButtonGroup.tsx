import * as React from "react";
import { EmailButton, HomeButton, TwitterButton } from "../../linkButtons";

interface IProps {
    emailAddress: string;
    homeUrl: string;
    name: string;
    twitterHandle: string;
};

export const MaintainerLinkButtonGroup = (props: IProps) =>
    <div className="col-3 p-0 btn-group-vertical justify-content-start d-flex align-items-end" role="group">
        <HomeButton {...props} url={props.homeUrl}/>
        <EmailButton {...props}/>
        <TwitterButton {...props}/>
    </div>;