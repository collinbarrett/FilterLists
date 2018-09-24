import * as React from "react";
import { Column, Filter } from "react-table";

export const Name = {
    Header: "Name",
    accessor: "name",
    filterable: true,
    filterMethod: (f: Filter, r: any[]) => filterMethod(f, r),
    sortMethod: (a: string, b: string) => sortMethod(a, b),
    Cell: (c: any) => Cell(c.value)
} as Column;

const filterMethod = (f: Filter, r: any[]): boolean =>
    r[f.id as any].toUpperCase().includes(f.value.toUpperCase());

const sortMethod = (a: string, b: string) =>
    a.toUpperCase() > b.toUpperCase() ? 1 : -1;

const Cell = (name: string) =>
    name
    ? <h2 className="mb-0">{name}</h2>
    : null;