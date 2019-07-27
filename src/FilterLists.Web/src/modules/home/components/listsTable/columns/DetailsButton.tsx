import * as React from "react";
import { Column, RowRenderProps } from "react-table";
import "../../linkButtons/button.css";

export const DetailsButton = {
    Header: <span title="Learn more about the FilterList.">Details</span>,
    accessor: "id",
    sortable: false,
    expander: true,
    Expander: ({ isExpanded, row }: RowRenderProps) => Expander({ isExpanded, row }),
    style: { textAlign: "center" },
    width: 110
} as Column;

const Expander = (props: RowRenderProps) =>
    <div>
        {props.isExpanded
             ? <button className="btn btn-primary btn-block active fl-btn-link"
                       title={`Collapse details about ${props.row.name}.`}>
                   Details
               </button>
             : <button className="btn btn-primary btn-block fl-btn-link"
                       title={`Learn more about ${props.row.name}.`}>
                   Details
               </button>}
    </div>;