import * as React from "react";
import { Column, Filter } from "react-table";
import { IColumnVisibility } from "../../../interfaces/IColumnVisibility";
import { ILanguage } from "../../../interfaces/ILanguage";

export const Languages = (columnVisibility: IColumnVisibility[], languages: ILanguage[]) => {
    const languagesSorted = languages.sort((a, b) => a.name.localeCompare(b.name));
    return ({
        Header: <span title="Written forms of communication used by sites targeted by the FilterList.">Languages</span>,
        accessor: "languageIds",
        filterable: true,
        filterMethod: (f: Filter, r: any[]) => filterMethod(f, r),
        Filter: ({ onChange, filter }: any) => filterLanguages({ onChange, filter }, languagesSorted),
        sortMethod: (a: number[], b: number[]) => sortMethod(a, b, languagesSorted),
        Cell: (c: any) => Cell(c.value, languagesSorted),
        style: { whiteSpace: "inherit" },
        width: 95,
        show: columnVisibility.filter((c: IColumnVisibility) => c.column === "Languages")[0].visible
    } as Column);
};

const filterMethod = (f: Filter, r: any[]): boolean => {
    const listLanguageIds = r[f.id as any];
    return f.value === "any" ||
        (listLanguageIds
            ? listLanguageIds.join(",").split(",").includes(f.value)
            : f.value === "none");
};

const filterLanguages = (props: any, languages: ILanguage[]) =>
    <select onChange={(event: any) => props.onChange(event.target.value)}
        style={{ width: "100%" }}
        value={props.filter ? props.filter.value : "any"}>
        <option value="any">Any</option>
        <option value="none">None</option>
        {languages.length > 0
            ? languages.map((l: ILanguage, i: number) =>
                <option value={l.id} key={i}>
                    {l.name} ({l.filterListIds ? l.filterListIds.length : 0})
                 </option>)
            : null}
    </select>;

const sortMethod = (a: number[], b: number[], languages: ILanguage[]) => {
    if (a && a.length > 0) {
        if (b && b.length > 0) {
            const aLanguageNames =
                languages.filter((l: ILanguage) => a.indexOf(l.id) > -1).map((l: ILanguage) => l.name).join();
            const bLanguageNames =
                languages.filter((l: ILanguage) => b.indexOf(l.id) > -1).map((l: ILanguage) => l.name).join();
            return aLanguageNames.toLowerCase() > bLanguageNames.toLowerCase() ? 1 : -1;
        } else {
            return -1;
        }
    } else {
        return 1;
    }
};

const Cell = (languageIds: number[], languages: ILanguage[]) =>
    languageIds
        ? <div className="fl-wrap-cell">
            {languageIds.map((id: number, i: number) => {
                const language = languages.filter((l: ILanguage) => l.id === id)[0];
                return <span className="badge badge-secondary"
                    title={language.name}
                    key={i}>
                    {language.iso6391}
                </span>;
            })}
        </div>
        : null;