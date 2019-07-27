import * as React from "react";
import { Column, Filter } from "react-table";
import { IColumnVisibility } from "../../../interfaces/IColumnVisibility";
import { IMaintainer } from "../../../interfaces/IMaintainer";

export const Maintainers = (columnVisibility: IColumnVisibility[], maintainers: IMaintainer[]) =>
    ({
        Header: <span title="Individuals, groups, or organizations who maintain the FilterList.">Maintainers</span>,
        accessor: "maintainerIds",
        filterable: true,
        filterMethod: (f: Filter, r: any[]) => filterMethod(f, r, maintainers),
        Filter: ({ filter, onChange }: any) => filterMaintainers({ onChange, filter }, maintainers),
        sortMethod: (a: number[], b: number[]) => sortMethod(a, b, maintainers),
        Cell: (c: any) => Cell(c.value, maintainers),
        width: 140,
        show: columnVisibility.filter((c: IColumnVisibility) => c.column === "Maintainers")[0].visible
    } as Column);

const filterMethod = (f: Filter, r: any[], maintainers: IMaintainer[]): boolean => {
    const listMaintainerIds: number[] = r[f.id as any];
    return f.value === "any" ||
        (listMaintainerIds
            ? f.value === "none"
                ? false
                : listMaintainerIds.indexOf(maintainers.filter((m: IMaintainer) => m.id === parseInt(f.value))[0].id) > -1
            : f.value === "none");
};

const filterMaintainers = (props: any, maintainers: IMaintainer[]) =>
    <select
        onChange={(event: any) => props.onChange(event.target.value)}
        style={{ width: "100%" }}
        value={props.filter ? props.filter.value : "any"}>
        <option value="any">Any</option>
        <option value="none">None</option>
        {maintainers.length > 0
            ? maintainers.sort((a, b) => a.name.localeCompare(b.name))
                .map((m: IMaintainer, i: number) =>
                    <option value={m.id} key={i}>
                        {m.name} ({m.filterListIds ? m.filterListIds.length : 0})
                 </option>)
            : null}
    </select>;

const sortMethod = (a: number[], b: number[], maintainers: IMaintainer[]) => {
    if (a && a.length > 0) {
        if (b && b.length > 0) {
            const aFirstMaintainerName = maintainers.filter((m: IMaintainer) => m.id === a[0])[0].name;
            const bFirstMaintainerName = maintainers.filter((m: IMaintainer) => m.id === b[0])[0].name;
            return aFirstMaintainerName.toLowerCase() > bFirstMaintainerName.toLowerCase() ? 1 : -1;
        } else {
            return -1;
        }
    } else {
        return 1;
    }
};

const Cell = (maintainerIds: number[], maintainers: IMaintainer[]) =>
    maintainerIds
        ? <div className="fl-wrap-cell">
            {maintainers.filter((m: IMaintainer) => maintainerIds.indexOf(m.id) > -1)
                .map((m: IMaintainer, i: number) => {
                    return m.homeUrl
                        ? <a href={m.homeUrl} key={i}>{m.name}</a>
                        : <span key={i}>{m.name}</span>;
                }).reduce(((prev: JSX.Element, curr: JSX.Element): any => [prev, ", ", curr]) as any)}
        </div>
        : null;