import * as React from "react";
import "isomorphic-fetch";

export default class ListDetails extends React.Component<any, any> {

    constructor(props: any) {
        super(props);
        this.state = {
            responseLoaded: false,
            listId: props.listId
        };
        this.fetchData();
    }

    fetchData() {
        fetch(`https://filterlists.com/api/v1/lists/${this.state.listId}`)
            .then(response => response.json() as Promise<IFilterListDetailsDto[]>)
            .then(data => {
                this.setState({
                    filterListDetails: data,
                    responseLoaded: true
                });
            });
    }

    render() {
        return this.state.responseLoaded
            ? <div>
                  <FilterListDetails details={this.state.filterListDetails}/>
              </div>
            : <div>Loading...</div>;
    }
}

function FilterListDetails(props: any) {
    return <div className="panel panel-default panel-list-details">
               <Description description={props.details.description} url={props.details.descriptionSourceUrl}/>
               <Languages languages={props.details.languages}/>
               <PublishedDate date={props.details.publishedDate}/>
               <DiscontinuedDate date={props.details.discontinuedDate}/>
               <SubscribeUrl url={props.details.viewUrl} name={props.details.name}/>
               <ViewUrl url={props.details.viewUrl} name={props.details.name}/>
               <HomeUrl url={props.details.homeUrl} name={props.details.name}/>
               <PolicyUrl url={props.details.policyUrl} name={props.details.name}/>
               <DonateUrl url={props.details.donateUrl} name={props.details.name}/>
               <IssuesUrl url={props.details.issuesUrl} name={props.details.name}/>
               <ForumUrl url={props.details.forumUrl} name={props.details.name}/>
               <ChatUrl url={props.details.chatUrl} name={props.details.name}/>
               <SubmissionUrl url={props.details.submissionUrl} name={props.details.name}/>
               <EmailAddress email={props.details.emailAddress} name={props.details.name}/>
               <Maintainers maintainers={props.details.maintainers}/>
           </div>;
}

function Description(props: any) {
    return props.description
        ? (props.url
            ? <blockquote cite={props.url}>{props.description}</blockquote>
            : <p>{props.description}</p>)
        : null;
}

function Languages(props: any) {
    return props.languages.length > 0
        ? props.languages.length > 1
        ? <div>
              <h3>Languages:</h3>
              <ul>
                  {props.languages.map(
                      (language: any) => <li>{language}</li>)}
              </ul>
          </div>
        : <div>
              <h3>Language:</h3>
              <ul>
                  {props.languages.map(
                      (language: any) => <li>{language}</li>)}
              </ul>
          </div>
        : null;
}

function PublishedDate(props: any) {
    return props.date ? <p>Published: {props.date}</p> : null;
}

function DiscontinuedDate(props: any) {
    return props.date ? <p>Discontinued: {props.date}</p> : null;
}

function SubscribeUrl(props: any) {
    return <a href={`abp:subscribe?location=${encodeURIComponent(props.url)}&amp;title=${encodeURIComponent(props.name)}`}
              className="visible-xs btn btn-primary btn-bloc btn-expander-link"
              title={ `Subscribe to ${props.name} with browser extension supporting \"abp:\" protcool (e.g. uBlock Origin, AdBlock Plus).` }>
               Subscribe
           </a >;
}

function ViewUrl(props: any) {
    return <a href={props.url} className="btn btn-primary btn-block btn-expander-link"
              title={`View ${props.name} in its raw format.`}>
               View
           </a>;
}

function HomeUrl(props: any) {
    return props.url
        ? <a href={props.url} className="btn btn-primary btn-block btn-expander-link"
             title={`View the home page for ${props.name}.`}>
              Home
          </a>
        : null;
}

function PolicyUrl(props: any) {
    return props.url
        ? <a href={props.url} className="btn btn-primary btn-block btn-expander-link"
             title={`View the policy for which rules ${props.name} includes.`}>
              Policy
          </a>
        : null;
}

function DonateUrl(props: any) {
    return props.url
        ? <a href={props.url} className="btn btn-primary btn-block btn-expander-link"
             title={`Donate to support ${props.name}.`}>
              Donate
          </a>
        : null;
}

function IssuesUrl(props: any) {
    return props.url
        ? <a href={props.url} className="btn btn-primary btn-block btn-expander-link"
             title={`View the GitHub Issues for ${props.name}.`}>
              GitHub Issues
          </a>
        : null;
}

function ForumUrl(props: any) {
    return props.url
        ? <a href={props.url} className="btn btn-primary btn-block btn-expander-link"
             title={`View the forum for ${props.name}.`}>
              Forum
          </a>
        : null;
}

function ChatUrl(props: any) {
    return props.url
        ? <a href={props.url} className="btn btn-primary btn-block btn-expander-link"
             title={`Enter the chat room for ${props.name}.`}>
              Chat
          </a>
        : null;
}

function SubmissionUrl(props: any) {
    return props.url
        ? <a href={props.url} className="btn btn-primary btn-block btn-expander-link"
             title={`Submit a new rule to be included in ${props.name}.`}>
              Submit New Rule
          </a>
        : null;
}

function EmailAddress(props: any) {
    return props.email
        ? <a href={`mailto:${props.email}`} className="btn btn-primary btn-block btn-expander-link"
             title={`Email ${props.name}.`}>
              Email
          </a>
        : null;
}

function Maintainers(props: any) {
    return props.maintainers.length > 0
        ? <div>
              {props.maintainers.map(
                  (maintainer: any) => <Maintainer maintainer={maintainer} key={maintainer.id.toString()}/>)}
          </div>
        : null;
}

function Maintainer(props: any) {
    return <div className="panel panel-default panel-maintainer">
               <div className="panel-heading">
                   <h4 className="panel-title">Maintained by {props.maintainer.name}</h4>
               </div>
               <div className="panel-body">
                   {props.maintainer.homeUrl
                       ? <p>
                             <a href={props.maintainer.homeUrl} className="btn btn-primary btn-block btn-expander-link"
                                title={`View the home page of ${props.maintainer.name}.`}>
                                 Home
                             </a>
                         </p>
                       : null}
                   {props.maintainer.emailAddress
                       ? <p>
                             <a href={`mailto:${props.maintainer.emailAddress}`}
                                className="btn btn-primary btn-block btn-expander-link"
                                title={`Email ${props.maintainer.name}.`}>
                                 Email
                             </a>
                         </p>
                       : null}
                   {props.maintainer.twitterHandle
                       ? <p>
                             <a href={`https://twitter.com/${props.maintainer.twitterHandle}`}
                                className="btn btn-primary btn-block btn-expander-link"
                                title={`View the Twitter page of ${props.maintainer.name}.`}>
                                 Twitter
                             </a>
                         </p>
                       : null}
                   {props.maintainer.additionalLists.length > 0
                       ? <div>
                             <h5>More by {props.maintainer.name}</h5>
                             <ul>
                                 {props.maintainer.additionalLists.map(
                                     (list: any) => <MaintainerAdditionalList list={list} key={list.id.toString()}/>)}
                             </ul>
                         </div>
                       : null}
               </div>
           </div>;
}

function MaintainerAdditionalList(props: any) {
    return <li>{props.list.name}</li>;
}

interface IFilterListDetailsDto {
    chatUrl: string;
    description: string;
    descriptionSourceUrl: string;
    discontinuedDate: string;
    donateUrl: string;
    emailAddress: string;
    forumUrl: string;
    homeUrl: string;
    issuesUrl: string;
    languages: string[];
    maintainers: IListMaintainerDto[];
    policyUrl: string;
    publishedDate: string;
    submissionUrl: string;
    viewUrl: string;
}

interface IListMaintainerDto {
    id: number;
    emailAddress: string;
    homeUrl: string;
    name: string;
    twitterHandle: string;
    additionalLists: IMaintainerAdditionalListsDto[];
}

interface IMaintainerAdditionalListsDto {
    id: number;
    name: string;
}