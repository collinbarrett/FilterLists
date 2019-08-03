import * as React from "react";
import { IColumnVisibility } from "../../../interfaces/IColumnVisibility";
import { ILicense } from "../../../interfaces/ILicense";
import { ISoftware } from "../../../interfaces/ISoftware";
import { ISyntax } from "../../../interfaces/ISyntax";
import { ITag } from "../../../interfaces/ITag";
import { Language } from "../../../interfaces/Language";
import { SoftwareIcon } from "../../softwareIcon";
import { TagGroup } from "../../TagGroup";
import { Description } from "./Description";
import { Languages } from "./Languages";
import { License } from "./License";
import { PublishedDate } from "./PublishedDate";
import { Syntax } from "./Syntax";

interface Props {
    columnVisibility: IColumnVisibility[];
    description: string;
    descriptionSourceUrl: string;
    languages: Language[];
    license: ILicense;
    name: string;
    publishedDate: string;
    software: ISoftware[];
    syntax: ISyntax;
    tags: ITag[];
};

export const InfoCard = (props: Props) =>
    <div className="col-9">
        {props.columnVisibility.filter((c: IColumnVisibility) => c.column === "Tags")[0].visible
            ? null
            : <TagGroup tags={props.tags} />}
        <div>
            {props.columnVisibility.filter((c: IColumnVisibility) => c.column === "Software")[0].visible
                ? null
                : props.syntax
                    ? props.software.filter((s: ISoftware) => s.syntaxIds.indexOf(props.syntax.id) > -1)
                        .map((s: ISoftware, i: number) => <SoftwareIcon id={s.id} key={i} />)
                    : null}
        </div>
        <Description {...props} url={props.descriptionSourceUrl} />
        <ul className="list-group list-group-flush">
            <Languages {...props} />
            <PublishedDate date={props.publishedDate} />
            <Syntax {...props} />
            {props.columnVisibility.filter((c: IColumnVisibility) => c.column === "License")[0].visible
                ? null
                : <License {...props} />}
        </ul>
    </div>;