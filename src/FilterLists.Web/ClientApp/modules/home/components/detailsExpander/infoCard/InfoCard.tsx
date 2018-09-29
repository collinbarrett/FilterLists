import * as React from "react";
import { IColumnVisibility } from "../../../interfaces";
import { ILanguage, ISoftware, ISyntax, ITag } from "../../../interfaces";
import { Description } from "./Description";
import { DiscontinuedDate } from "./DiscontinuedDate";
import { Languages } from "./Languages";
import { PublishedDate } from "./PublishedDate";
import { RuleCount } from "./RuleCount";
import { SoftwareIcon } from "../../softwareIcon";
import { Syntax } from "./Syntax";
import { TagGroup } from "../../TagGroup"
import { UpdatedDate } from "./UpdatedDate";

interface IProps {
    columnVisibility: IColumnVisibility[];
    description: string;
    descriptionSourceUrl: string;
    discontinuedDate: string;
    languages: ILanguage[];
    name: string;
    publishedDate: string;
    ruleCount: number;
    software: ISoftware[];
    syntax: ISyntax;
    tags: ITag[];
    updatedDate: string;
};

export const InfoCard = (props: IProps) =>
    <div className="col-9">
        {props.columnVisibility.filter((c: IColumnVisibility) => c.column === "Tags")[0].visible
             ? null
             : <TagGroup tags={props.tags}/>}
        <div>
            {props.columnVisibility.filter((c: IColumnVisibility) => c.column === "Software")[0].visible
                 ? null
                 : props.syntax
                   ? props.software.filter((s: ISoftware) => s.syntaxIds.indexOf(props.syntax.id) > -1)
                   .map((s: ISoftware, i: number) => <SoftwareIcon id={s.id} key={i}/>)
                   : null}
        </div>
        <Description {...props} url={props.descriptionSourceUrl}/>
        <ul className="list-group list-group-flush">
            <Languages {...props}/>
            {props.columnVisibility.filter((c: IColumnVisibility) => c.column === "Rules")[0].visible
                 ? null
                 : <RuleCount {...props}/>}
            <DiscontinuedDate date={props.discontinuedDate}/>
            {props.columnVisibility.filter((c: IColumnVisibility) => c.column === "Updated")[0].visible
                 ? null
                 : <UpdatedDate {...props}/>}
            <PublishedDate date={props.publishedDate}/>
            <Syntax {...props.syntax}/>
            { /*<License {...props.license}/>*/ }
        </ul>
    </div>;