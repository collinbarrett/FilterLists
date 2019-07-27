import * as React from "react";
import "isomorphic-fetch";
import { ILanguage } from "./interfaces/ILanguage";
import { ILicense } from "./interfaces/ILicense";
import { IList } from "./interfaces/IList";
import { IMaintainer } from "./interfaces/IMaintainer";
import { ISoftware } from "./interfaces/ISoftware";
import { ISyntax } from "./interfaces/ISyntax";
import { ITag } from "./interfaces/ITag";
import { Home } from "./Home";

interface IState {
    languages: ILanguage[];
    licenses: ILicense[];
    lists: IList[];
    maintainers: IMaintainer[];
    ruleCount: number;
    software: ISoftware[];
    syntaxes: ISyntax[];
    tags: ITag[];
};

export class HomeContainer extends React.Component<{}, IState> {
    constructor(props: any) {
        super(props);
        this.state = {
            languages: [],
            licenses: [],
            lists: [],
            maintainers: [],
            ruleCount: 0,
            software: [],
            syntaxes: [],
            tags: []
        };
    }

    componentDidMount() {
        this.fetchLanguages();
        this.fetchLicenses();
        this.fetchLists();
        this.fetchMaintainers();
        this.fetchSoftware();
        this.fetchSyntaxes();
        this.fetchTags();
        // this.fetchRuleCount();
    };

    fetchLanguages() {
        fetch("/api/v1/languages")
            .then(r => r.json() as Promise<ILanguage[]>)
            .then(p => { this.setState({ languages: p }); });
    };

    fetchLicenses() {
        fetch("/api/v1/licenses")
            .then(r => r.json() as Promise<ILicense[]>)
            .then(p => { this.setState({ licenses: p }); });
    };

    fetchLists() {
        fetch("/api/v1/lists")
            .then(r => r.json() as Promise<IList[]>)
            .then(p => { this.setState({ lists: p }); });
    };

    fetchMaintainers() {
        fetch("/api/v1/maintainers")
            .then(r => r.json() as Promise<IMaintainer[]>)
            .then(p => { this.setState({ maintainers: p }); });
    };

    fetchSoftware() {
        fetch("/api/v1/software")
            .then(r => r.json() as Promise<ISoftware[]>)
            .then(p => { this.setState({ software: p }); });
    };

    fetchSyntaxes() {
        fetch("/api/v1/syntaxes")
            .then(r => r.json() as Promise<ISyntax[]>)
            .then(p => { this.setState({ syntaxes: p }); });
    };

    fetchTags() {
        fetch("/api/v1/tags")
            .then(r => r.json() as Promise<ITag[]>)
            .then(p => { this.setState({ tags: p }); });
    };

    fetchRuleCount() {
        fetch("/api/v1/rules")
            .then(r => r.json() as Promise<number>)
            .then(p => { this.setState({ ruleCount: p }); });
    };

    render() {
        return <Home {...this.state} />;
    };
};