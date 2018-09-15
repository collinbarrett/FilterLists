import * as React from "react";
import "isomorphic-fetch";
import "../../../../utils/loader.css";
import { IFilterListDetailsDto } from "./IFilterListDetailsDto";
import { DetailsExpander } from "./DetailsExpander";

interface IProps {
    listId: number;
}

interface IState {
    filterListDetails: IFilterListDetailsDto;
}

export class DetailsExpanderContainer extends React.Component<IProps, IState> {
    constructor(props: IProps) {
        super(props);
        this.state = {
            filterListDetails: {} as IFilterListDetailsDto
        };
    }

    componentDidMount() {
        this.fetchFilterListDetails();
    }

    fetchFilterListDetails() {
        fetch(`https://filterlists.com/api/v1/lists/${this.props.listId}`)
            .then(r => r.json() as Promise<IFilterListDetailsDto>)
            .then(d => {
                this.setState({
                    filterListDetails: d
                });
            });
    }

    render() {
        return this.state.filterListDetails.name
                   ? <DetailsExpander {...this.state.filterListDetails}/>
                   : <div className="loader">Loading...</div>;;
    }
}