import * as React from "react";
import { IColumnVisibility } from "../../interfaces";
import { IListDetails } from "./IListDetails";
import { InfoCard } from "./infoCard";
import { LinkButtonGroup } from "./LinkButtonGroup";
import { MaintainersInfoCard } from "./maintainersInfoCard";

interface IProps {
    columnVisibility: IColumnVisibility[];
    list: IListDetails;
};

export const DetailsExpander = (props: IProps) =>
    <div className="card border-primary">
        <div className="card-body p-2">
            <div className="container m-0">
                <div className="row">
                    <InfoCard columnVisibility={props.columnVisibility} {...props.list}/>
                    <LinkButtonGroup {...props.list}/>
                </div>
                <div className="row">
                    <MaintainersInfoCard maintainers={props.list.maintainers}/>
                </div>
            </div>
        </div>
    </div>;