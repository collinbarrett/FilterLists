import * as React from "react";
import { ISyntaxSupportedSoftwareDto } from "../detailsExpander/IFilterListDetailsDto";
import { SoftwareIcon } from "./SoftwareIcon"

interface IProps {
    software: ISyntaxSupportedSoftwareDto[];
    mdNone: boolean;
}

export const SoftwareIcons = (props: IProps) => {
    return props.software
               ? <div className={props.mdNone ? "d-md-none" : undefined}>
                     {props.software.map(
                         (s: ISyntaxSupportedSoftwareDto, i: any) => <SoftwareIcon id={s.id} key={i}/>)}
                 </div>
               : null;
};