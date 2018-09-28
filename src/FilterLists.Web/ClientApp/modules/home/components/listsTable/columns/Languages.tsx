import * as React from "react";
import { Column, Filter } from "react-table";
import { IColumnVisibility, ILanguage } from "../../../interfaces";

export const Languages = (columnVisibility: IColumnVisibility[], languages: ILanguage[]) =>
({
    Header: "Languages",
    accessor: "languageIds",
    filterable: true,
    filterMethod: (f: Filter, r: any[]) => filterMethod(f, r),
    Filter: ({ onChange, filter }: any) => Filter({ onChange, filter }, languages),
    sortMethod: (a: number[], b: number[]) => sortMethod(a, b, languages),
    Cell: (c: any) => Cell(c.value, languages),
    style: { whiteSpace: "inherit" },
    width: 95,
    show: columnVisibility.filter((c: IColumnVisibility) => c.column === "Languages")[0].visible
} as Column);

const filterMethod = (f: Filter, r: any[]): boolean => {
    const listLanguageIds = r[f.id as any];
    return f.value === "any" ||
    (listLanguageIds
         ? listLanguageIds.join(",").split(",").includes(f.value)
         : false);
};

const Filter = (props: any, languages: ILanguage[]) =>
    <select onChange={(event: any) => props.onChange(event.target.value)}
            style={{ width: "100%" }}
            value={props.filter ? props.filter.value : "any"}>
        <option value="any">Any</option>
        {languages.length > 0
             ? languages.sort((a, b) => a.name.localeCompare(b.name))
             .map((l: ILanguage, i: number) =>
                 <option value={l.id} key={i}>
                     {l.name} ({l.filterListIds ? l.filterListIds.length : 0})
                 </option>)
             : null}
    </select>;

const sortMethod = (a: number[], b: number[], languages: ILanguage[]) => {
    if (a && a.length > 0) {
        if (b && b.length > 0) {
            const aFirstLanguageName = languages.filter((l: ILanguage) => l.id === a[0])[0].name;
            const bFirstLanguageName = languages.filter((l: ILanguage) => l.id === b[0])[0].name;
            return aFirstLanguageName.toLowerCase() > bFirstLanguageName.toLowerCase() ? 1 : -1;
        } else {
            return -1;
        }
    } else {
        return 1;
    }
};

const Cell = (languageIds: number[], languages: ILanguage[]) =>
    languageIds
    ? <div className="fl-tag-container">
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