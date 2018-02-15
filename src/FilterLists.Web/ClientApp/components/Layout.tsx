import * as React from "react";

export interface LayoutProps {
    children?: React.ReactNode;
}

export class Layout extends React.Component<LayoutProps, {}> {
    render() {
        return <div className="container-fluid">
                   <div className="row">
                       <h1>FilterLists</h1>
                       <p>The independent and comprehensive directory of all public filter and hosts lists for advertisements, trackers, malware, and annoyances.</p>
                   </div>
                   <div className="row">
                       <div>
                           { this.props.children }
                       </div>
                   </div>
                   <div className="row text-center">
                       A project by <a href="https://collinmbarrett.com/">Collin M. Barrett</a>. | View on <a href="https://github.com/collinbarrett/FilterLists">GitHub</a>.
                   </div>
               </div>;
    }
}