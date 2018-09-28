import * as React from "react";
import { Column, Filter } from "react-table";
import { IColumnVisibility, IMaintainer } from "../../../interfaces";

export const Maintainers = (columnVisibility: IColumnVisibility[], maintainers: IMaintainer[]) =>
({
    Header: "Maintainers",
    accessor: "maintainerIds",
    filterable: true,
    filterMethod: (f: Filter, r: any[]) => filterMethod(f, r, maintainers),
    Filter: ({ filter, onChange }: any) => Filter({ onChange, filter }, maintainers),
    sortMethod: (a: number[], b: number[]) => sortMethod(a, b, maintainers),
    Cell: (c: any) => Cell(c.value, maintainers),
    width: 140,
    show: columnVisibility.filter((c: IColumnVisibility) => c.column === "Maintainers")[0].visible
} as Column);

const filterMethod = (f: Filter, r: any[], maintainers: IMaintainer[]): boolean => {
    const listMaintainerIds: number[] = r[f.id as any];
    if (f.value === "any") {
        return true;
    } else if (listMaintainerIds) {
        const maintainerFiltered = maintainers.filter((m: IMaintainer) => m.id === parseInt(f.value))[0];
        return listMaintainerIds.indexOf(maintainerFiltered.id) > -1;
    } else {
        return false;
    }
};

const Filter = (props: any, maintainers: IMaintainer[]) =>
    <select
        onChange={(event: any) => props.onChange(event.target.value)}
        style={{ width: "100%" }}
        value={props.filter ? props.filter.value : "any"}>
        <option value="any">Any</option>
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
    ? <div className="fl-tag-container">
          {maintainers.filter((m: IMaintainer) => maintainerIds.indexOf(m.id) > -1).map((m: IMaintainer) => m.name)
              .join(", ")}
      </div>
    : null;