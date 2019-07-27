import * as React from "react";
import { Column } from "react-table";
import moment from 'moment';
import { IColumnVisibility } from "../../../interfaces/IColumnVisibility";

export const UpdatedDate = (columnVisibility: IColumnVisibility[]) =>
    ({
        Header: <span title="The estimated date that the FilterList was last updated by the maintainer.">Updated</span>,
        accessor: "updatedDate",
        sortMethod: (a: string, b: string) => sortMethod(a, b),
        Cell: (c: any) => Cell(c.value),
        style: { whiteSpace: "inherit" },
        width: 100,
        show: columnVisibility.filter((c: IColumnVisibility) => c.column === "Updated")[0].visible
    } as Column);

const sortMethod = (a: string, b: string) =>
    a && moment(a).isValid()
        ? (b && moment(b).isValid()
            ? (moment(a).isBefore(b)
                ? 1
                : -1)
            : -1)
        : 1;

const Cell = (updatedDate: string) =>
    updatedDate
        ? <div>
            {moment(updatedDate).isValid()
                ? moment(updatedDate).format("l")
                : null}
        </div>
        : null;