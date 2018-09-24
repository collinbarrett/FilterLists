import * as React from "react";
import { Column, Filter } from "react-table";
import { IColumnVisibility, ISoftware } from "../../../interfaces";
import { SoftwareIcon } from "../../softwareIcon";

export const Software = (columnVisibility: IColumnVisibility[], software: ISoftware[]) => {
    return {
        Header: "Software",
        accessor: "syntaxId",
        filterable: true,
        filterMethod: (f: Filter, r: any[]) => filterMethod(f, r, software),
        Filter: ({ filter, onChange }: any) => Filter({ onChange, filter }, software),
        sortable: false,
        Cell: (c: any) => Cell(c.value, software),
        width: 155,
        headerClassName: "d-none d-md-block",
        className: "d-none d-md-block",
        show: columnVisibility.filter((c: IColumnVisibility) => c.column === "Software")[0].visible
    } as Column;
};

const filterMethod = (f: Filter, r: any[], software: ISoftware[]): boolean => {
    const isAny = f.value === "any";
    const softwareFiltered = isAny ? software : software.filter((s: ISoftware) => s.id === parseInt(f.value));
    const listSyntaxId: number = r[f.id as any];
    const isMatch = softwareFiltered[0].syntaxIds ? softwareFiltered[0].syntaxIds.indexOf(listSyntaxId) > -1 : false;
    return isAny || (listSyntaxId ? isMatch : false);
};

const Filter = (props: any, software: ISoftware[]) =>
    <select
        onChange={(event: any) => props.onChange(event.target.value)}
        style={{ width: "100%" }}
        value={props.filter ? props.filter.value : "any"}>
        <option value="any">Any</option>
        {software.length > 0
             ? software.map(
                 (s: ISoftware, i: number) => <option value={s.id} key={i}>{s.name}</option>)
             : null}
    </select>;

const Cell = (listSyntaxId: number, software: ISoftware[]) =>
    listSyntaxId
    ? software.filter((s: ISoftware) => s.syntaxIds.indexOf(listSyntaxId) > -1)
              .map((s: ISoftware, i: number) => <SoftwareIcon id={s.id} key={i}/>)
    : null;