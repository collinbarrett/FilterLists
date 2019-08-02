import * as React from "react";
import { IMaintainer } from "../../../interfaces/IMaintainer";
import { MaintainerAdditionalLists } from "./MaintainerAdditionalLists";
import { MaintainerLinkButtonGroup } from "./MaintainerLinkButtonGroup";

interface Props {
    maintainer: IMaintainer;
};

export const MaintainerInfoCard = (props: Props) =>
    props.maintainer.name
        ? <div className="card">
            <div className="card-body">
                <h3 className="card-header">Maintained by {props.maintainer.name}</h3>
                <div className="container pt-1">
                    <div className="row">
                        <MaintainerAdditionalLists />
                        <MaintainerLinkButtonGroup {...props.maintainer} />
                    </div>
                </div>
            </div>
        </div>
        : null;