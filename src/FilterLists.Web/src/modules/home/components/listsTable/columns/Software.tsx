import * as React from "react";
import { Column, Filter } from "react-table";
import { IColumnVisibility } from "../../../interfaces/IColumnVisibility";
import { ISoftware } from "../../../interfaces/ISoftware";
import { SoftwareIcon } from "../../softwareIcon";

export const Software = (columnVisibility: IColumnVisibility[], software: ISoftware[]) => {
    const softwareSorted = software.sort((a, b) => a.name.localeCompare(b.name));
    return ({
        Header:
            <span title="Applications, browser extensions, or other utilities that consume the FilterList.">Software</span>,
        accessor: "syntaxId",
        filterable: true,
        filterMethod: (f: Filter, r: any[]) => filterMethod(f, r, softwareSorted),
        Filter: ({ filter, onChange }: any) => filterSoftware({ onChange, filter }, softwareSorted),
        sortMethod: (a: number, b: number) => sortMethod(a, b, softwareSorted),
        Cell: (c: any) => Cell(c.value, software),
        width: 155,
        show: columnVisibility.filter((c: IColumnVisibility) => c.column === "Software")[0].visible
    } as Column);
};

const filterMethod = (f: Filter, r: any[], software: ISoftware[]): boolean => {
    const isAny = f.value === "any";
    const softwareFiltered = isAny ? software : software.filter((s: ISoftware) => s.id === parseInt(f.value));
    const listSyntaxId: number = r[f.id as any];
    const isMatch = softwareFiltered[0].syntaxIds ? softwareFiltered[0].syntaxIds.indexOf(listSyntaxId) > -1 : false;
    return isAny || (listSyntaxId ? isMatch : false);
};

const filterSoftware = (props: any, software: ISoftware[]) =>
    <select
        onChange={(event: any) => props.onChange(event.target.value)}
        style={{ width: "100%" }}
        value={props.filter ? props.filter.value : "any"}>
        <option value="any">Any</option>
        {software.length > 0
            ? software.map((s: ISoftware, i: number) => <option value={s.id} key={i}>{s.name}</option>)
            : null}
    </select>;

const sortMethod = (a: number, b: number, software: ISoftware[]) => {
    if (a) {
        if (b) {
            const aSoftwareNames =
                software.filter((s: ISoftware) => s.syntaxIds.indexOf(a) > -1).map((s: ISoftware) => s.name);
            const bSoftwareNames =
                software.filter((s: ISoftware) => s.syntaxIds.indexOf(b) > -1).map((s: ISoftware) => s.name);
            if (aSoftwareNames.length === bSoftwareNames.length) {
                return aSoftwareNames.join().toLowerCase() > bSoftwareNames.join().toLowerCase() ? 1 : -1;
            } else if (aSoftwareNames.length > bSoftwareNames.length) {
                return -1;
            } else {
                return 1;
            }
        } else {
            return -1;
        }
    } else {
        return 1;
    }
};

const Cell = (listSyntaxId: number, software: ISoftware[]) =>
    listSyntaxId
        ? <div className="fl-wrap-cell">
            {software.filter((s: ISoftware) => s.syntaxIds.indexOf(listSyntaxId) > -1)
                .map((s: ISoftware, i: number) =>
                    s.homeUrl
                        ? <a href={s.homeUrl} key={i}>
                            <SoftwareIcon id={s.id} />
                        </a>
                        : <SoftwareIcon id={s.id} key={i} />)}
        </div>
        : null;