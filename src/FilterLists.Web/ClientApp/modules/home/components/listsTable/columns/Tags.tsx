import * as React from "react";
import { Column, Filter } from "react-table";
import { TagGroup } from "../../TagGroup";
import { IColumnVisibility, ITag } from "../../../interfaces";

export const Tags = (columnVisibility: IColumnVisibility[], tags: ITag[]) => {
    const tagsSorted = tags.sort((a: ITag, b: ITag) => a.name.localeCompare(b.name));
    return ({
        Header:
            <span title="Generic taxonomies applied to the FilterList to provide information about its contents and/or purpose.">Tags</span>,
        accessor: "tagIds",
        filterable: true,
        filterMethod: (f: Filter, r: any[]) => filterMethod(f, r),
        Filter: ({ onChange, filter }: any) => Filter({ onChange, filter }, tagsSorted),
        sortMethod: (a: number[], b: number[]) => sortMethod(a, b, tagsSorted),
        Cell: (c: any) => Cell(c.value, tagsSorted),
        width: 215,
        show: columnVisibility.filter((c: IColumnVisibility) => c.column === "Tags")[0].visible
    } as Column);
};

const filterMethod = (f: Filter, r: any[]): boolean => {
    const listTagIds = r[f.id as any];
    return f.value === "any" ||
    (listTagIds
         ? listTagIds.join(",").split(",").includes(f.value)
         : false);
};

const Filter = (props: any, tags: ITag[]) =>
    <select onChange={(event: any) => props.onChange(event.target.value)}
            style={{ width: "100%" }}
            value={props.filter ? props.filter.value : "any"}>
        <option value="any">Any</option>
        {tags.length > 0
             ? tags.map((t: ITag, i: number) =>
                 <option value={t.id} key={i}>
                     {t.name} ({t.filterListIds ? t.filterListIds.length : 0})
                 </option>)
             : null}
    </select>;

const sortMethod = (a: number[], b: number[], tags: ITag[]): any => {
    return a
               ? b
                 ? a.length === b.length
                   ? tags.filter((t: ITag) => a.indexOf(t.id) > -1).map((t: ITag) => t.name).join()
                     .toLowerCase() >
                     tags.filter((t: ITag) => b.indexOf(t.id) > -1).map((t: ITag) => t.name).join().toLowerCase()
                     ? 1
                     : -1
                   : a.length > b.length
                     ? -1
                     : 1
                 : -1
               : 1;
};

const Cell = (tagIds: number[], tags: ITag[]) =>
    tagIds
    ? <div className="fl-tag-container">
          <TagGroup tags={tags.filter((t: ITag) => tagIds.indexOf(t.id) > -1)}/>
      </div>
    : null;