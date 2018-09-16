import * as React from "react";
import { IListLicenseDto, IListSyntaxDto, IListTagDto } from "../IFilterListDetailsDto";
import { Description } from "./Description";
import { DiscontinuedDate } from "./DiscontinuedDate";
import { Languages } from "./Languages";
import { License } from "./License";
import { PublishedDate } from "./PublishedDate";
import { RuleCount } from "./RuleCount";
import { Syntax } from "./Syntax";
import { Tags } from "./Tags";
import { UpdatedDate } from "./UpdatedDate";

interface IProps {
    description: string;
    descriptionSourceUrl: string;
    discontinuedDate: string;
    languages: string[];
    license: IListLicenseDto;
    name: string;
    publishedDate: string;
    ruleCount: number;
    syntax: IListSyntaxDto;
    tags: IListTagDto[];
    updatedDate: string;
}

export const InfoCard = (props: IProps) => {
    return <div className="col-9">
               <Tags tags={props.tags}/>
               <Description {...props} url={props.descriptionSourceUrl}/>
               <ul className="list-group list-group-flush">
                   <Languages languages={props.languages}/>
                   <RuleCount {...props}/>
                   <DiscontinuedDate date={props.discontinuedDate}/>
                   <UpdatedDate {...props}/>
                   <PublishedDate date={props.publishedDate}/>
                   <Syntax {...props.syntax}/>
                   <License {...props.license}/>
               </ul>
           </div>;
};