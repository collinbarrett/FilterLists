import * as React from "react";
import { Column, Filter } from "react-table";
import { Tag } from "../../Tag"
import { IColumnVisibility, ITag } from "../../../interfaces";

export const Tags = (columnVisibility: IColumnVisibility[], tags: ITag[]) => {
    return {
        Header: "Tags",
        accessor: "tagIds",
        filterable: true,
        filterMethod: (f: Filter, r: any[]) => filterMethod(f, r, tags),
        sortMethod: (a: number[], b: number[]) => sortMethod(a, b),
        Cell: (c: any) => Cell(c.value, tags),
        width: 215,
        headerClassName: "d-none d-md-block",
        className: "d-none d-md-block",
        show: columnVisibility.filter((c: IColumnVisibility) => c.column === "Tags")[0].visible
    } as Column;
};

const filterMethod = (f: Filter, r: any[], tags: ITag[]): boolean => {
    const listTagIds = r[f.id as any];
    if (f.value.length > 0 && listTagIds && listTagIds.length > 0) {
        const listTags = tags.filter((t: ITag) => listTagIds.includes(t.id));
        const listTagNames = listTags.map((t: ITag) => t.name.toLowerCase()).join(",").split(",");
        return listTagNames.filter((l: string) => l.indexOf(f.value.toLowerCase()) > -1).length > 0;
    } else {
        return false;
    }
};

const sortMethod = (a: number[], b: number[]): any =>
    a
    ? b
      ? a.length > b.length
        ? 1
        : -1
      : 1
    : -1;

const Cell = (tagIds: number[], tags: ITag[]) =>
    tagIds
    ? <div className="fl-tag-container">
          {tagIds.map((tid: number, i: number) => {
              const tag = tags.filter((t: ITag) => t.id === tid)[0];
              return <Tag {...tag} key={i}/>;
          })}
      </div>
    : null;