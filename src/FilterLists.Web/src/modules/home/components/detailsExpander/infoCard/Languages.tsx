import * as React from "react";
import { ILanguage } from "../../../interfaces/ILanguage";

interface IProps {
    languages: ILanguage[];
};

export const Languages = (props: IProps) =>
    props.languages && props.languages.length > 0
        ? props.languages.length > 1
            ? <li className="list-group-item">
                <p className="m-0">Languages:</p>
                <ul>
                    {props.languages.map((language: ILanguage, i: number) => <li key={i}>{language.name}</li>)}
                </ul>
            </li>
            : <li className="list-group-item">
                <p>Language: {props.languages[0].name}</p>
            </li>
        : null;