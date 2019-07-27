import * as React from "react";
import { Column, Filter } from "react-table";
import { IColumnVisibility } from "../../../interfaces/IColumnVisibility";
import { ILicense } from "../../../interfaces/ILicense";

export const License = (columnVisibility: IColumnVisibility[], licenses: ILicense[]) =>
    ({
        Header: <span title="A legal document governing the use or redistribution of a FilterList.">License</span>,
        accessor: "licenseId",
        filterable: true,
        filterMethod: (f: Filter, r: any[]) => filterMethod(f, r, licenses),
        Filter: ({ filter, onChange }: any) => filterLicenses({ onChange, filter }, licenses),
        sortMethod: (a: number, b: number) => sortMethod(a, b, licenses),
        Cell: (c: any) => Cell(c.value, licenses),
        width: 75,
        show: columnVisibility.filter((c: IColumnVisibility) => c.column === "License")[0].visible
    } as Column);

const filterMethod = (f: Filter, r: any[], licenses: ILicense[]): boolean => {
    const listLicenseId: number = r[f.id as any];
    if (f.value === "any") {
        return true;
    } else if (listLicenseId) {
        const licenseFiltered = licenses.filter((l: ILicense) => l.id === parseInt(f.value))[0];
        return listLicenseId === licenseFiltered.id;
    } else {
        return false;
    }
};

const filterLicenses = (props: any, licenses: ILicense[]) =>
    <select
        onChange={(event: any) => props.onChange(event.target.value)}
        style={{ width: "100%" }}
        value={props.filter ? props.filter.value : "any"}>
        <option value="any">Any</option>
        {licenses.length > 0
            ? licenses.sort((a, b) => a.name.replace(/['"]+/g, "").localeCompare(b.name.replace(/['"]+/g, ""))).map(
                (l: ILicense, i: number) =>
                    <option value={l.id} key={i}>
                        {l.name} ({l.filterListIds ? l.filterListIds.length : 0})
                 </option>)
            : null}
    </select>;

const sortMethod = (a: number, b: number, licenses: ILicense[]) => {
    if (a) {
        if (b) {
            const aLicenseName = licenses.filter((l: ILicense) => l.id === a)[0].name.replace(/['"]+/g, "");
            const bLicenseName = licenses.filter((l: ILicense) => l.id === b)[0].name.replace(/['"]+/g, "");
            return aLicenseName.toLowerCase() > bLicenseName.toLowerCase() ? 1 : -1;
        } else {
            return -1;
        }
    } else {
        return 1;
    }
};

const Cell = (licenseId: number, licenses: ILicense[]) => {
    const license = licenses.filter((l: ILicense) => licenseId === l.id)[0];
    return license
        ? <div>
            <span title={license.name}>
                {license.descriptionUrl ? <a href={license.descriptionUrl}>{license.name}</a> : license.name}
            </span>
        </div>
        : null;
};