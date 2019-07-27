import * as React from "react";
import { Column, Filter } from "react-table";
import { IColumnVisibility } from "../../../interfaces/IColumnVisibility";
import { ISyntax } from "../../../interfaces/ISyntax";

//TODO: https://github.com/collinbarrett/FilterLists/issues/488
export const Syntax = (columnVisibility: IColumnVisibility[], syntaxes: ISyntax[]) => ({
    Header: <span title="A named set of rules that govern the format of the FilterList.">Syntax</span>,
    accessor: "syntaxId",
    filterable: true,
    filterMethod: (f: Filter, r: any[]) => filterMethod(f, r, syntaxes),
    Filter: ({ filter, onChange }: any) => filterSyntaxes({ onChange, filter }, syntaxes),
    Cell: (c: any) => Cell(c.value, syntaxes),
    width: 155,
    show: columnVisibility.filter((c: IColumnVisibility) => c.column === "Syntax")[0].visible
} as Column);

const filterMethod = (f: Filter, r: any[], syntaxes: ISyntax[]): boolean => {
    const listSyntaxId: number = r[f.id as any];
    if (f.value === "any") {
        return true;
    } else if (listSyntaxId) {
        const syntaxFiltered = syntaxes.filter((s: ISyntax) => s.id === parseInt(f.value));
        return syntaxFiltered[0].id
            ? syntaxFiltered[0].id === listSyntaxId
            : false;
    } else {
        return false;
    }
};

const filterSyntaxes = (props: any, syntaxes: ISyntax[]) =>
    <select
        onChange={(event: any) => props.onChange(event.target.value)}
        style={{ width: "100%" }}
        value={props.filter ? props.filter.value : "any"}>
        <option value="any">Any</option>
        {syntaxes.length > 0
            ? syntaxes.sort((a, b) => a.name.localeCompare(b.name)).map(
                (s: ISyntax, i: number) => <option value={s.id} key={i}>{s.name}</option>)
            : null}
    </select>;

const Cell = (listSyntaxId: number, syntaxes: ISyntax[]) =>
    listSyntaxId
        ? syntaxes.filter((s: ISyntax) => s.id === listSyntaxId)[0].name
        : null;