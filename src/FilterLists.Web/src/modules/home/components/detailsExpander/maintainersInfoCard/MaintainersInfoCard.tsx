import * as React from "react";
import { IMaintainer } from "../../../interfaces/IMaintainer";
import { MaintainerInfoCard } from "./MaintainerInfoCard";

interface Props {
    maintainers: IMaintainer[];
};

export const MaintainersInfoCard = (props: Props) =>
    props.maintainers && props.maintainers.length > 0
        ? <div className="w-100">
            {props.maintainers.map((m: IMaintainer, i: number) => <MaintainerInfoCard maintainer={m} key={i} />)}
        </div>
        : null;