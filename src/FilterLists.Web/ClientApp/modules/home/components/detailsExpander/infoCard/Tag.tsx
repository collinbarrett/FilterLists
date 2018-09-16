import * as React from "react";
import { IListTagDto } from "../IFilterListDetailsDto";
import { getContrast } from "../../../../../utils";

export const Tag = (props: IListTagDto) => {
    const style = props.colorHex
                      ? {
                          backgroundColor: `#${props.colorHex}`,
                          color: getContrast(`${props.colorHex}`)
                      }
                      : undefined;
    return props.name
               ? <span className="badge"
                       style={style}
                       title={props.description}>
                     {props.name}
                 </span>
               : null;
};