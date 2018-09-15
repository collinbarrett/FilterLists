import * as React from "react";

interface IProps {
    languages: string[];
}

export const Languages = (props: IProps) => {
    return props.languages.length > 0
               ? props.languages.length > 1
                 ? <li className="list-group-item">
                       <p className="m-0">Languages:</p>
                       <ul>
                           {props.languages.map((language: any) => <li>{language}</li>)}
                       </ul>
                   </li>
                 : <li className="list-group-item">
                       <p>Language: {props.languages.map((language: any) => language)}</p>
                   </li>
               : null;
};