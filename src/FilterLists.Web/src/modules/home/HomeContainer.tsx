import * as React from "react";
import { Home } from "./Home";
import { ILicense } from "./interfaces/ILicense";
import { IList } from "./interfaces/IList";
import { IMaintainer } from "./interfaces/IMaintainer";
import { ISoftware } from "./interfaces/ISoftware";
import { ISyntax } from "./interfaces/ISyntax";
import { ITag } from "./interfaces/ITag";
import { Language } from "./interfaces/Language";

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
        fetch("/api/v1/languages")
            .then(response => response.json())
            .then(json => { this.setState({ languages: json }); })
    };

    fetchLicenses() {
        fetch("/api/v1/licenses")
            .then(response => response.json())
            .then(json => { this.setState({ licenses: json }); })
    };

    fetchLists() {
        fetch("/api/v1/lists")
            .then(response => response.json())
            .then(json => { this.setState({ lists: json }); })
    };

    fetchMaintainers() {
        fetch("/api/v1/maintainers")
            .then(response => response.json())
            .then(json => { this.setState({ maintainers: json }); })
    };

    fetchSoftware() {
        fetch("/api/v1/software")
            .then(response => response.json())
            .then(json => { this.setState({ software: json }); })
    };

    fetchSyntaxes() {
        fetch("/api/v1/syntaxes")
            .then(response => response.json())
            .then(json => { this.setState({ syntaxes: json }); })
    };

    fetchTags() {
        fetch("/api/v1/tags")
            .then(response => response.json())
            .then(json => { this.setState({ tags: json }); })
    };

    render() {
        return <Home {...this.state} />;
    };
};