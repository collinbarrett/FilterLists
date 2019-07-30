import * as React from "react";
import { ISoftware } from "../../interfaces/ISoftware";
import { IColumnVisibility } from "../../interfaces/IColumnVisibility";
import { IListDetails } from "../IListDetails";
import { InfoCard } from "./infoCard";
import { LinkButtonGroup } from "./LinkButtonGroup";
import { MaintainersInfoCard } from "./maintainersInfoCard";

interface Props {
    columnVisibility: IColumnVisibility[];
    list: IListDetails;
    software: ISoftware[];
};

export const DetailsExpander = (props: Props) =>
    <div className="card border-primary">
        <div className="card-body p-2">
            <div className="container m-0">
                <div className="row">
                    <InfoCard columnVisibility={props.columnVisibility} software={props.software} {...props.list} />
                    <LinkButtonGroup {...props.list} />
                </div>
                <div className="row">
                    <MaintainersInfoCard maintainers={props.list.maintainers} />
                </div>
            </div>
        </div>
    </div>;