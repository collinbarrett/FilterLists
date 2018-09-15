import * as React from "react";
import { IListMaintainerDto } from "../IFilterListDetailsDto";
import { MaintainerAdditionalLists } from "./MaintainerAdditionalLists";
import { MaintainerLinkButtonGroup } from "./MaintainerLinkButtonGroup";

export const MaintainerInfoCard = (props: IListMaintainerDto) => {
    return props.name
               ? <div className="card">
                     <div className="card-body">
                         <h3 className="card-header">Maintained by {props.name}</h3>
                         <div className="container pt-1">
                             <div className="row">
                                 <MaintainerAdditionalLists {...props}/>
                                 <MaintainerLinkButtonGroup {...props}/>
                             </div>
                         </div>
                     </div>
                 </div>
               : null;
};