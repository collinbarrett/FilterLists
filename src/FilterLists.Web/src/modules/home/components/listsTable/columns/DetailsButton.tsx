import * as React from "react";
import { Button } from "react-bootstrap";
import { Column, RowRenderProps } from "react-table";

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
            ? <Button
                variant={'primary'}
                title={`Collapse details about ${props.row.name}.`}>
                Details
              </Button>
            : <Button
                variant={'primary'}
                title={`Learn more about ${props.row.name}.`}>
                Details
              </Button>}
    </div>;