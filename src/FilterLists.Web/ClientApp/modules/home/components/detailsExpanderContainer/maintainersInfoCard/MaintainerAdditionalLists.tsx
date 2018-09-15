import * as React from "react";
import { IMaintainerAdditionalListDto } from "../IFilterListDetailsDto";

interface IProps {
    name: string;
    additionalLists: IMaintainerAdditionalListDto[];
}

export const MaintainerAdditionalLists = (props: IProps) => {
    return props.additionalLists.length > 0
               ? <div className="col-9">
                     <div>
                         <h4>More by {props.name}:</h4>
                         <ul>
                             {props.additionalLists.map((l: IMaintainerAdditionalListDto) => <li>{l.name}</li>)}
                         </ul>
                     </div>
                 </div>
               : null;
};