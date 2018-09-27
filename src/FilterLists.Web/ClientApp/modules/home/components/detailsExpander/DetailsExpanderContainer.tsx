import * as React from "react";
import "isomorphic-fetch";
import "../../../../utils/loader.css";
import { IListDetails } from "./IListDetails";
import { DetailsExpander } from "./DetailsExpander";

interface IProps {
    list: IListDetails;
}

interface IState {
}

export class DetailsExpanderContainer extends React.Component<IProps, IState> {
    constructor(props: IProps) {
        super(props);
        this.state = {};
    }

    render() {
        return this.props.list.name
                   ? <DetailsExpander {...this.props.list}/>
                   : <div className="loader">Loading...</div>;;
    }
}