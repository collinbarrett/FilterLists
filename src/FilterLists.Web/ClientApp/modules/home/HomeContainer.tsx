import * as React from "react";
import "isomorphic-fetch";
import { ILanguageDto, IListDto, ISoftwareDto } from "./interfaces";
import "../../utils/loader.css";
import { Home } from "./Home";

interface IState {
    languages: ILanguageDto[];
    lists: IListDto[];
    ruleCount: number;
    software: ISoftwareDto[];
}

export class HomeContainer extends React.Component<{}, IState> {
    constructor(props: any) {
        super(props);
        this.state = {
            lists: [],
            languages: [],
            ruleCount: 0,
            software: []
        };
    }

    componentDidMount() {
        fetch("https://filterlists.com/api/v1/lists")
            .then(r => r.json() as Promise<IListDto[]>)
            .then(d => {
                this.setState({
                    lists: d
                });
            });
        fetch("https://filterlists.com/api/v1/rules")
            .then(r => r.json() as Promise<number>)
            .then(d => {
                this.setState({
                    ruleCount: d
                });
            });
        fetch("https://filterlists.com/api/v1/software")
            .then(r => r.json() as Promise<ISoftwareDto[]>)
            .then(d => {
                this.setState({
                    software: d
                });
            });
        fetch("https://filterlists.com/api/v1/languages")
            .then(r => r.json() as Promise<ILanguageDto[]>)
            .then(d => {
                this.setState({
                    languages: d
                });
            });
    }

    render() {
        return this.state.lists.length === 0 ||
                   this.state.ruleCount === 0 ||
                   this.state.software.length === 0 ||
                   this.state.languages.length === 0
                   ? <div className="loader">Loading...</div>
                   : <Home {...this.state}/>;
    }
}