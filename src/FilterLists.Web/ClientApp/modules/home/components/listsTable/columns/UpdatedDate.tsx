import * as React from "react";
import { Column } from "react-table";
import * as moment from "moment";
import { IColumnVisibility } from "../../../interfaces";

export const UpdatedDate = (columnVisibility: IColumnVisibility[]) => {
    return {
        Header: "Updated",
        accessor: "updatedDate",
        sortMethod: (a: string, b: string) => sortMethod(a, b),
        Cell: (c: any) => Cell(c.value),
        style: { whiteSpace: "inherit" },
        width: 100,
        headerClassName: "d-none d-md-block",
        className: "d-none d-md-block",
        show: columnVisibility.filter((c: IColumnVisibility) => c.column === "Updated Date")[0].visible
    } as Column;
};

const sortMethod = (a: string, b: string) =>
    moment(a).isValid()
    ? (moment(b).isValid()
           ? (moment(a).isBefore(b)
                  ? -1
                  : 1)
           : 1)
    : -1;

const Cell = (updatedDate: string) =>
    updatedDate
    ? <div>
          {moment(updatedDate).isValid()
               ? moment(updatedDate).format("l")
               : null}
      </div>
    : null;