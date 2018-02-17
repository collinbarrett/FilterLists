import * as React from "react";
import "isomorphic-fetch";
import * as ReactModal from "react-modal";

export default class ListDetailsModal extends React.Component<any, any> {
    private readonly listId: any;

    constructor(props: any) {
        super(props);
        this.state = { showModal: false, loading: true };
        this.listId = props.listId;
        this.handleOpenModal = this.handleOpenModal.bind(this);
        this.handleCloseModal = this.handleCloseModal.bind(this);
    }

    handleOpenModal() {
        this.setState({ showModal: true });
        fetch(`https://api.filterlists.com/v1/lists/${this.listId}`)
            .then(response => response.json() as Promise<IFilterListDetailsDto[]>)
            .then(data => { this.setState({ filterListDetails: data, loading: false }); });
    }

    handleCloseModal() {
        this.setState({ showModal: false });
    }

    render() {
        const contents = this.state.loading
            ? null
            : <ReactModal
                  isOpen={this.state.showModal}
                  onRequestClose={this.handleCloseModal}
                  shouldCloseOnOverlayClick={true}>
                  <FilterListDetails details={this.state.filterListDetails}/>
                  <button onClick={this.handleCloseModal} className="btn btn-danger btn-block">Close</button>
              </ReactModal>;
        return (
            <div>
                <button onClick={this.handleOpenModal} className="btn btn-primary btn-block">Details</button>
                {contents}
            </div>
        );
    }
}

function FilterListDetails(props: any) {
    return <div>
               <Name name={props.details.name}/>
               <Description description={props.details.description} url={props.details.descriptionSourceUrl}/>
               <PublishedDate date={props.details.publishedDate}/>
               <DiscontinuedDate date={props.details.discontinuedDate}/>
               <ViewUrl url={props.details.viewUrl}/>
               <SubscribeUrl url={props.details.viewUrl} name={props.details.name}/>
           </div>;
}

function Name(props: any) {
    return <h1>{props.name}</h1>;
}

function PublishedDate(props: any) {
    if (props.date) {
        return <p>Published: {props.date}</p>;
    } else {
        return null;
    }
}

function DiscontinuedDate(props: any) {
    if (props.date) {
        return <p>Discontinued: {props.date}</p>;
    } else {
        return null;
    }
}

function Description(props: any) {
    if (props.description) {
        if (props.url) {
            return <p>{props.description}</p>;
        } else {
            return <p>{props.description}</p>;
        }
    } else {
        return null;
    }
}

function ViewUrl(props: any) {
    return <a href={props.url} className="btn btn-primary btn-block" title={"View the raw list."}>
               View
           </a>;
}

function SubscribeUrl(props: any) {
    return <a href={`abp:subscribe?location=${encodeURIComponent(props.url)}&amp;title=${encodeURIComponent(props.name)}`}
              className="btn btn-primary btn-block"
              title={"Subscribe to list with browser extension supporting \"abp:\" protcool (e.g. uBlock Origin, AdBlock Plus)."}>
               Subscribe
           </a>;
}

interface IFilterListDetailsDto {
    description: string;
    descriptionSourceUrl: string;
    discontinuedDate: string;
    donateUrl: string;
    emailAddress: string;
    forumUrl: string;
    homeUrl: string;
    issuesUrl: string;
    name: string;
    policyUrl: string;
    publishedDate: string;
    submissionUrl: string;
    viewUrl: string;
}