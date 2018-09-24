import * as React from "react";
import "isomorphic-fetch";
import { ILanguage, IList, ISoftware, ITag } from "./interfaces";
import { Home } from "./Home";

interface IState {
    languages: ILanguage[];
    lists: IList[];
    ruleCount: number;
    software: ISoftware[];
    tags: ITag[];
};

export class HomeContainer extends React.Component<{}, IState> {
    constructor(props: any) {
        super(props);
        this.state = {
            languages: [],
            lists: [],
            ruleCount: 0,
            software: [],
            tags: []
        };
    }

    componentDidMount() {
        this.fetchLists();
        this.fetchSoftware();
        this.fetchTags();
        this.fetchLanguages();
        this.fetchRuleCount();
    };

    fetchLists() {
        fetch("https://filterlists.com/api/v1/lists/alpha")
            .then(r => r.json() as Promise<IList[]>)
            .then(d => { this.setState({ lists: d }); });
    };

    fetchSoftware() {
        fetch("https://filterlists.com/api/v1/software")
            .then(r => r.json() as Promise<ISoftware[]>)
            .then(d => { this.setState({ software: d }); });
    };

    fetchTags() {
        fetch("https://filterlists.com/api/v1/tags")
            .then(r => r.json() as Promise<ITag[]>)
            .then(d => { this.setState({ tags: d }); });
    };

    fetchLanguages() {
        fetch("https://filterlists.com/api/v1/languages")
            .then(r => r.json() as Promise<ILanguage[]>)
            .then(d => { this.setState({ languages: d }); });
    };

    fetchRuleCount() {
        fetch("https://filterlists.com/api/v1/rules")
            .then(r => r.json() as Promise<number>)
            .then(d => { this.setState({ ruleCount: d }); });
    };

    render() {
        return <Home {...this.state}/>;
    };
};