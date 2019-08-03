import * as React from "react";
import { ChatButton, DonateButton, EmailButton, ForumButton, HomeButton, IssuesButton, PolicyButton, SubmitButton, SubscribeButton, ViewButton } from "../linkButtons";
import "./linkButtonGroup.css";

interface Props {
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

export const LinkButtonGroup = (props: Props) =>
    <div className="btn-group-vertical">
        <SubscribeButton name={props.name} url={props.viewUrl} urlMirrors={props.viewUrlMirrors} />
        <ViewButton name={props.name} url={props.viewUrl} urlMirrors={props.viewUrlMirrors} />
        <HomeButton name={props.name} url={props.homeUrl} />
        <PolicyButton name={props.name} url={props.policyUrl} />
        <DonateButton name={props.name} url={props.donateUrl} />
        <IssuesButton name={props.name} url={props.issuesUrl} />
        <ForumButton name={props.name} url={props.forumUrl} />
        <ChatButton name={props.name} url={props.chatUrl} />
        <SubmitButton name={props.name} url={props.submissionUrl} />
        <EmailButton name={props.name} emailAddress={props.emailAddress} />
    </div>;