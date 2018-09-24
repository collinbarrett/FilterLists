import * as React from "react";
import {
    ChatButton,
    DonateButton,
    DownloadButton,
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
    downloadUrl: string;
    viewUrl: string;
    viewUrlMirror1: string;
    viewUrlMirror2: string;
}

export const LinkButtonGroup = (props: IProps) => {
    const viewUrlMirrors = new Array(props.viewUrlMirror1, props.viewUrlMirror2).filter(u => u);
    return <div className="col-3 p-0 btn-group-vertical justify-content-start d-flex align-items-end">
               <SubscribeButtonGroup name={props.name} url={props.viewUrl} urlMirrors={viewUrlMirrors}/>
               <ViewButtonGroup name={props.name} url={props.viewUrl} urlMirrors={viewUrlMirrors}/>
               <DownloadButton name={props.name} url={props.downloadUrl}/>
               <HomeButton name={props.name} url={props.homeUrl}/>
               <PolicyButton name={props.name} url={props.policyUrl}/>
               <DonateButton name={props.name} url={props.donateUrl}/>
               <IssuesButton name={props.name} url={props.issuesUrl}/>
               <ForumButton name={props.name} url={props.forumUrl}/>
               <ChatButton name={props.name} url={props.chatUrl}/>
               <SubmitButton name={props.name} url={props.submissionUrl}/>
               <EmailButton name={props.name} emailAddress={props.emailAddress}/>
           </div>;
};
