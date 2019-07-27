import * as React from "react";
import { ViewButton } from "./ViewButton";

interface IProps {
    name: string;
    url: string;
    urlMirrors?: string[];
};

export const ViewButtonGroup = (props: IProps) =>
    props.url
    ? (props.urlMirrors && props.urlMirrors.length > 0)
      ? <ViewButtonGroupDropdown {...props} urlMirrors={props.urlMirrors}/>
      : <ViewButton {...props}/>
    : null;

interface IViewButtonGroupDropdownProps {
    name: string;
    url: string;
    urlMirrors: string[];
};

const ViewButtonGroupDropdown = (props: IViewButtonGroupDropdownProps) => {
    let firstButtonText: string = "Original";
    let mirrorIndex: number = 0;

    if (props.url.indexOf("web.archive.org") !== -1) {
        firstButtonText = "Mirror 1";
        mirrorIndex++;
    }

    return <div className="btn-group-vertical dropleft fl-btn-link" role="group">
               <BtnGroupDropView/>
               <div className="dropdown-menu" aria-labelledby="btnGroupDropView">
                   <ViewButton {...props} text={firstButtonText}/>
                   {props.urlMirrors.map(
                       (m: string, i: number) =>
                       <ViewButton {...props} url={m} text={`Mirror ${i + 1 + mirrorIndex}`} key={i}/>)}
               </div>
           </div>;
};

const BtnGroupDropView = () =>
    <button id="btnGroupDropView"
            type="button"
            className="btn btn-primary dropdown-toggle"
            data-toggle="dropdown"
            aria-haspopup="true"
            aria-expanded="false">
        View
    </button>;