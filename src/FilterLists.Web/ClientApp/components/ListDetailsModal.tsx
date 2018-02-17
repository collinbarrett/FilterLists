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
            .then(response => response.json() as Promise<IFilterListDetails[]>)
            .then(data => { this.setState({ filterListdetails: data, loading: false }); });
    }

    handleCloseModal() {
        this.setState({ showModal: false });
    }

    render() {
        const contents = this.state.loading
            ? null
            : <ReactModal
                  isOpen={this.state.showModal}
                  contentLabel="onRequestClose Example"
                  onRequestClose={this.handleCloseModal}
                  shouldCloseOnOverlayClick={false}>
                  <h1>{this.state.filterListdetails.name}</h1>
                  <p>{this.state.filterListdetails.description}</p>
                  <a href={this.state.filterListdetails.viewUrl} className="btn btn-primary btn-block"
                     title={"View the raw list. Many are quite large, so be cautious if on metered bandwidth."}>
                      View
                  </a>
                  <a href={`abp:subscribe?location=${encodeURIComponent(this.state.filterListdetails.viewUrl)
                      }&amp;title=${encodeURIComponent(this.state.filterListdetails.name)}`}
                     className="btn btn-primary btn-block"
                     title={
"Subscribe to list with browser extension supporting \"abp:\" protcool (e.g. uBlock Origin, AdBlock Plus)."}>
                      Subscribe
                  </a>
                  <button onClick={this.handleCloseModal} className="btn btn-primary btn-block">Close</button>
              </ReactModal>;
        return (
            <div>
                <button onClick={this.handleOpenModal} className="btn btn-primary btn-block">Details</button>
                {contents}
            </div>
        );
    }

}

interface IFilterListDetails {
    id: number;
    name: string;
    description: string;
    descriptionSourceUrl: string;
    viewUrl: string;
}