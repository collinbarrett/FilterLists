import * as React from "react";
import { ITag } from "../interfaces";
import { getContrast } from "../../../utils";

export const Tag = (props: ITag) => {
    const hexColor = kelly_colors_hex[props.id % kelly_colors_hex.length];
    return <span className="badge"
                 style={{
                     backgroundColor: `#${hexColor}`,
                     color: getContrast(hexColor)
                 }}
                 title={props.description}>
               {props.name}
           </span>;
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
    "232C16" // Dark Olive Green
];