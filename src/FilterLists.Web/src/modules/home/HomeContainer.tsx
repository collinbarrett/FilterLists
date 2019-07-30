import * as React from "react";
import axios from "axios";
import { Language } from "./interfaces/Language";
import { ILicense } from "./interfaces/ILicense";
import { IList } from "./interfaces/IList";
import { IMaintainer } from "./interfaces/IMaintainer";
import { ISoftware } from "./interfaces/ISoftware";
import { ISyntax } from "./interfaces/ISyntax";
import { ITag } from "./interfaces/ITag";
import { Home } from "./Home";

interface IState {
    languages: Language[];
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
        this.fetchLists();
        this.fetchLanguages();
        this.fetchLicenses();
        this.fetchMaintainers();
        this.fetchSoftware();
        this.fetchSyntaxes();
        this.fetchTags();
    };

    fetchLanguages() {
        axios.request<Language[]>({ url: "/api/v1/languages" })
            .then(l => { this.setState({ languages: l.data }); })
    };

    fetchLicenses() {
        axios.request<ILicense[]>({ url: "/api/v1/licenses" })
            .then(l => { this.setState({ licenses: l.data }); })
    };

    fetchLists() {
        axios.request<IList[]>({ url: "/api/v1/lists" })
            .then(l => { this.setState({ lists: l.data }); })
    };

    fetchMaintainers() {
        axios.request<IMaintainer[]>({ url: "/api/v1/maintainers" })
            .then(l => { this.setState({ maintainers: l.data }); })
    };

    fetchSoftware() {
        axios.request<ISoftware[]>({ url: "/api/v1/software" })
            .then(l => { this.setState({ software: l.data }); })
    };

    fetchSyntaxes() {
        axios.request<ISyntax[]>({ url: "/api/v1/syntaxes" })
            .then(l => { this.setState({ syntaxes: l.data }); })
    };

    fetchTags() {
        axios.request<ITag[]>({ url: "/api/v1/tags" })
            .then(l => { this.setState({ tags: l.data }); })
    };

    render() {
        return <Home {...this.state} />;
    };
};