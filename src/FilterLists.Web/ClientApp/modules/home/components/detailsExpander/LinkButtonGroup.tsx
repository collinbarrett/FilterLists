import * as React from "react";
import {
    ChatButton,
    DonateButton,
    EmailButton,
    ForumButton,
    HomeButton,
    IssuesButton,
    PolicyButton,
    SubmitButton,
    SubscribeButtonGroup,
    ViewButtonGroup
} from "../linkButtons";

interface IProps {
    chatUrl: string;
    donateUrl: string;
    emailAddress: string;
    forumUrl: string;
    homeUrl: string;
    issuesUrl: string;
    name: string;
    policyUrl: string;
    submissionUrl: string;
    viewUrl: string;
    viewUrlMirrors: string[];
};

export const LinkButtonGroup = (props: IProps) =>
    <div className="col-3 p-0 btn-group-vertical justify-content-start d-flex align-items-end">
        <SubscribeButtonGroup name={props.name} url={props.viewUrl} urlMirrors={props.viewUrlMirrors}/>
        <ViewButtonGroup name={props.name} url={props.viewUrl} urlMirrors={props.viewUrlMirrors}/>
        <HomeButton name={props.name} url={props.homeUrl}/>
        <PolicyButton name={props.name} url={props.policyUrl}/>
        <DonateButton name={props.name} url={props.donateUrl}/>
        <IssuesButton name={props.name} url={props.issuesUrl}/>
        <ForumButton name={props.name} url={props.forumUrl}/>
        <ChatButton name={props.name} url={props.chatUrl}/>
        <SubmitButton name={props.name} url={props.submissionUrl}/>
        <EmailButton name={props.name} emailAddress={props.emailAddress}/>
    </div>;