import * as React from "react";
import { SubscribeButton } from "./SubscribeButton";

interface IProps {
    name: string;
    url: string;
    urlMirrors?: string[];
}

export const SubscribeButtonGroup = (props: IProps) => {
    return props.url
               ? (props.urlMirrors && props.urlMirrors.length > 0)
                 ? <SubscribeButtonGroupDropdown {...props} urlMirrors={props.urlMirrors}/>
                 : <SubscribeButton {...props}/>
               : null;
};

interface ISubscribeButtonGroupDropdownProps {
    name: string;
    url: string;
    urlMirrors: string[];
}

const SubscribeButtonGroupDropdown = (props: ISubscribeButtonGroupDropdownProps) => {
    let firstButtonText: string = "Original";
    let mirrorIndex: number = 0;

    if (props.url.indexOf("web.archive.org") !== -1) {
        firstButtonText = "Mirror 1";
        mirrorIndex++;
    }

    return <div className="btn-group-vertical fl-btn-link" role="group">
               <BtnGroupDropSubscribe/>
               <div className="dropdown-menu" aria-labelledby="btnGroupDropSubscribe">
                   <SubscribeButton {...props} text={firstButtonText}/>
                   {props.urlMirrors.map(
                       (m, i) => <SubscribeButton {...props} url={m} text={`Mirror ${i + 1 + mirrorIndex}`}/>)}
               </div>
           </div>;
};

const BtnGroupDropSubscribe = () => {
    return <button id="btnGroupDropSubscribe"
                   type="button"
                   className="btn btn-primary dropdown-toggle"
                   data-toggle="dropdown"
                   aria-haspopup="true"
                   aria-expanded="false">
               Subscribe
           </button>;
};