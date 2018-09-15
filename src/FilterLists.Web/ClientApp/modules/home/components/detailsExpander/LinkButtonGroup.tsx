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
    viewUrlMirror1: string;
    viewUrlMirror2: string;
}

export const LinkButtonGroup = (props: IProps) => {
    const viewUrlMirrors = new Array(props.viewUrlMirror1, props.viewUrlMirror2).filter(u => u);
    return <div className="col-3 p-0 btn-group-vertical justify-content-start d-flex align-items-end">
               <SubscribeButtonGroup {...props} url={props.viewUrl} urlMirrors={viewUrlMirrors}/>
               <ViewButtonGroup {...props} url={props.viewUrl} urlMirrors={viewUrlMirrors}/>
               <HomeButton {...props} url={props.homeUrl}/>
               <PolicyButton {...props} url={props.policyUrl}/>
               <DonateButton {...props} url={props.donateUrl}/>
               <IssuesButton {...props} url={props.issuesUrl}/>
               <ForumButton {...props} url={props.forumUrl}/>
               <ChatButton {...props} url={props.chatUrl}/>
               <SubmitButton {...props} url={props.submissionUrl}/>
               <EmailButton {...props} emailAddress={props.emailAddress}/>
           </div>;
};