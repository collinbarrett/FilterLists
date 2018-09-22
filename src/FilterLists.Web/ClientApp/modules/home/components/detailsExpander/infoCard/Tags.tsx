import * as React from "react";
import { IListTagDto } from "../IFilterListDetailsDto";
import { Tag } from "./Tag";

interface IProps {
    tags: IListTagDto[];
}

export const Tags = (props: IProps) => {
    return props.tags && props.tags.length > 0
               ? <div className="d-md-none">
                     {props.tags.map((t: IListTagDto, i: number) => <Tag {...t} key={i}/>)}
                 </div>
               : null;
};