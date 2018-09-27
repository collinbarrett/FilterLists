import * as React from "react";
import "isomorphic-fetch";
import { ILanguage, IList, IMaintainer, ISoftware, ITag } from "./interfaces";
import { Home } from "./Home";

interface IState {
    languages: ILanguage[];
    lists: IList[];
    maintainers: IMaintainer[];
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
            maintainers: [],
            ruleCount: 0,
            software: [],
            tags: []
        };
    }

    componentDidMount() {
        this.fetchLists();
        this.fetchLanguages();
        this.fetchMaintainers();
        this.fetchSoftware();
        this.fetchTags();
        this.fetchRuleCount();
    };

    fetchLists() {
        fetch("https://filterlists.com/api/v1/lists")
            .then(r => r.json() as Promise<IList[]>)
            .then(p => { this.setState({ lists: p }); });
    };

    fetchLanguages() {
        fetch("https://filterlists.com/api/v1/languages")
            .then(r => r.json() as Promise<ILanguage[]>)
            .then(p => { this.setState({ languages: p }); });
    };

    fetchMaintainers() {
        fetch("https://filterlists.com/api/v1/maintainers")
            .then(r => r.json() as Promise<IMaintainer[]>)
            .then(p => { this.setState({ maintainers: p }); });
    };

    fetchSoftware() {
        fetch("https://filterlists.com/api/v1/software")
            .then(r => r.json() as Promise<ISoftware[]>)
            .then(p => { this.setState({ software: p }); });
    };

    fetchTags() {
        fetch("https://filterlists.com/api/v1/tags")
            .then(r => r.json() as Promise<ITag[]>)
            .then(p => { this.setState({ tags: p }); });
    };

    fetchRuleCount() {
        fetch("https://filterlists.com/api/v1/rules")
            .then(r => r.json() as Promise<number>)
            .then(p => { this.setState({ ruleCount: p }); });
    };

    render() {
        return <Home {...this.state}/>;
    };
};