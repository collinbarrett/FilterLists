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
                  <button onClick={this.handleCloseModal} className="btn btn-danger btn-block push-to-bottom">Close</button>
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
               <SubscribeUrl url={props.details.viewUrl} name={props.details.name}/>
               <ViewUrl url={props.details.viewUrl}/>
               <HomeUrl url={props.details.homeUrl} />
               <PolicyUrl url={props.details.policyUrl} />
               <DonateUrl url={props.details.donateUrl} />
               <IssuesUrl url={props.details.issuesUrl} />
               <ForumUrl url={props.details.forumUrl} />
               <SubmissionUrl url={props.details.submissionUrl} />
               <EmailAddress email={props.details.emailAddress} />
           </div>;
}

function Name(props: any) {
    return <h1>{props.name}</h1>;
}

function Description(props: any) {
    return props.description ? (props.url ? <blockquote cite={props.url}>{props.description}</blockquote> : <p>{
        props.description}</p>) : null;
}

function PublishedDate(props: any) {
    return props.date ? <p>Published: {props.date}</p> : null;
}

function DiscontinuedDate(props: any) {
    return props.date ? <p>Discontinued: {props.date}</p> : null;
}

function SubscribeUrl(props: any) {
    return <a href={`abp:subscribe?location=${encodeURIComponent(props.url)}&amp;title=${encodeURIComponent(props.name)}`}
              className="btn btn-primary btn-block"
              title={"Subscribe to list with browser extension supporting \"abp:\" protcool (e.g. uBlock Origin, AdBlock Plus)."}>
               Subscribe
           </a>;
}

function ViewUrl(props: any) {
    return <a href={props.url} className="btn btn-primary btn-block" title={"View the raw list."}>
               View
           </a>;
}

function HomeUrl(props: any) {
    return props.url ? <a href={props.url} className="btn btn-primary btn-block" title={"View the project's home page."}>
                           Home
                       </a> : null;
}

function PolicyUrl(props: any) {
    return props.url ? <a href={props.url} className="btn btn-primary btn-block" title={"View the policy for which rules this list includes."}>
                           Policy
                       </a> : null;
}

function DonateUrl(props: any) {
    return props.url ? <a href={props.url} className="btn btn-primary btn-block" title={"Donate to support the list."}>
                           Donate
                       </a> : null;
}

function IssuesUrl(props: any) {
    return props.url ? <a href={props.url} className="btn btn-primary btn-block" title={"View the GitHub Issues for this list."}>
                           GitHub Issues
                       </a> : null;
}

function ForumUrl(props: any) {
    return props.url ? <a href={props.url} className="btn btn-primary btn-block" title={"View the forum for this list."}>
                           Forum
                       </a> : null;
}

function SubmissionUrl(props: any) {
    return props.url ? <a href={props.url} className="btn btn-primary btn-block" title={"Submit a new rule to be included in this list."}>
                           Submit New Rule
                       </a> : null;
}

function EmailAddress(props: any) {
    return props.email ? <a href={`mailto:${props.email}`} className="btn btn-primary btn-block" title={"Email the list."}>
                             Email
                         </a> : null;
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