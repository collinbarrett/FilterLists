import * as React from "react";
import { Column } from "react-table";
import { IColumnVisibility } from "../../../interfaces/IColumnVisibility";

export const RuleCount = (columnVisibility: IColumnVisibility[]) =>
  ({
    Header: <span title="The number of rules in the FilterList.">Rules</span>,
    accessor: "ruleCount",
    sortMethod: (a: string, b: string) => sortMethod(a, b),
    Cell: (c: any) => Cell(c.value),
    style: { whiteSpace: "inherit" },
    width: 85,
    show: columnVisibility.filter((c: IColumnVisibility) => c.column === "Rules")[0].visible
  } as Column);

const sortMethod = (a: string, b: string) =>
  a
    ? b
      ? a > b
        ? -1
        : 1
      : -1
    : 1;

const Cell = (ruleCount: number) =>
  ruleCount
    ? <span>{ruleCount.toLocaleString()}</span>
    : null;