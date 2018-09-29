import * as React from "react";
import { Column, RowRenderProps } from "react-table";

export const DetailsButton = {
    Header: <span title="Learn more about the FilterList.">Details</span>,
    accessor: "id",
    sortable: false,
    expander: true,
    Expander: ({ isExpanded, row }: RowRenderProps) => Expander({ isExpanded, row }),
    style: { textAlign: "center" },
    width: 90
} as Column;

const Expander = (props: RowRenderProps) =>
    <div>
        {props.isExpanded
             ? <button className="btn btn-primary btn-block active"
                       title={`Collapse details about ${props.row.name}.`}>
                   Details
               </button>
             : <button className="btn btn-primary btn-block"
                       title={`Learn more about ${props.row.name}.`}>
                   Details
               </button>}
    </div>;