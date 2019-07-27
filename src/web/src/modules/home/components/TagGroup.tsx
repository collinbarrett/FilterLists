import * as React from "react";
import { ITag } from "../interfaces/ITag";
import { getContrast } from "../../../utils";

interface IProps {
    tags: ITag[];
};

export const TagGroup = (props: IProps) =>
    props.tags && props.tags.length > 0
    ? <div className="fl-wrap-cell">
          {props.tags.map((t: ITag, i: number) => <Tag tag={t} key={i}/>)}
      </div>
    : null;

interface ITagProps {
    tag: ITag;
};

const Tag = (props: ITagProps) => {
    if (props.tag) {
        const hexColor = kelly_colors_hex[props.tag.id % kelly_colors_hex.length];
        return <span className="badge"
                     style={{
                         backgroundColor: `#${hexColor}`,
                         color: getContrast(hexColor)
                     }}
                     title={props.tag.description}>
                   {props.tag.name}
               </span>;
    } else {
        return null;
    }
};

//https://stackoverflow.com/a/4382138/2343739
const kelly_colors_hex = [
    "FFB300", // Vivid Yellow
    "803E75", // Strong Purple
    "FF6800", // Vivid Orange
    "A6BDD7", // Very Light Blue
    "C10020", // Vivid Red
    "CEA262", // Grayish Yellow
    "817066", // Medium Gray
    "007D34", // Vivid Green
    "F6768E", // Strong Purplish Pink
    "00538A", // Strong Blue
    "FF7A5C", // Strong Yellowish Pink
    "53377A", // Strong Violet
    "FF8E00", // Vivid Orange Yellow
    "B32851", // Strong Purplish Red
    "F4C800", // Vivid Greenish Yellow
    "7F180D", // Strong Reddish Brown
    "93AA00", // Vivid Yellowish Green
    "593315", // Deep Yellowish Brown
    "F13A13", // Vivid Reddish Orange
    "232C16", // Dark Olive Green
    "000000", // Black
    "FFFFFF", // White
    "C2F4BE", // Light Green
    "1EDBB9", // Medium Greenish Blue
    "890000", // Dark Red
    "474747", // Dark Grey
    "BFA125", // Matte Gold
    "A7823C", // Dark Beige
    "035A5C" // Dark Greenish Blue
];
