import * as React from "react";
import { IListLicense, IListSyntax, ISyntaxSupportedSoftware } from "../IListDetails";
import { ILanguage, ITag } from "../../../interfaces";
import { Description } from "./Description";
import { DiscontinuedDate } from "./DiscontinuedDate";
import { Languages } from "./Languages";
import { License } from "./License";
import { PublishedDate } from "./PublishedDate";
import { RuleCount } from "./RuleCount";
import { SoftwareIcon } from "../../softwareIcon";
import { Syntax } from "./Syntax";
import { TagGroup } from "../../TagGroup"
import { UpdatedDate } from "./UpdatedDate";

interface IProps {
    description: string;
    descriptionSourceUrl: string;
    discontinuedDate: string;
    languages: ILanguage[];
    license: IListLicense;
    name: string;
    publishedDate: string;
    ruleCount: number;
    syntax: IListSyntax;
    tags: ITag[];
    updatedDate: string;
};

export const InfoCard = (props: IProps) => 
           <div className="col-9">
               <TagGroup tags={props.tags}/>
               <div className="d-md-none">
                   {props.syntax
                        ? props.syntax.supportedSoftware.map(
                            (s: ISyntaxSupportedSoftware, i: number) => <a href={s.homeUrl} key={i}>
                                                                            <SoftwareIcon id={s.id} key={i}/>
                                                                        </a>)
                        : null}
               </div>
               <Description {...props} url={props.descriptionSourceUrl}/>
               <ul className="list-group list-group-flush">
                   <Languages languages={...props.languages}/>
                   <RuleCount {...props}/>
                   <DiscontinuedDate date={props.discontinuedDate}/>
                   <UpdatedDate {...props}/>
                   <PublishedDate date={props.publishedDate}/>
                   <Syntax {...props.syntax}/>
                   <License {...props.license}/>
               </ul>
           </div>;