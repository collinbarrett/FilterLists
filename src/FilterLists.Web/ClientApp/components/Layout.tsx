import * as React from "react";

export interface ILayoutProps {
    children?: React.ReactNode;
}

export class Layout extends React.Component<ILayoutProps, {}> {
    render() {
        return <div className="container">
                   <div className="row">
                       <h1>
                           <a href="./" style={{ display: "inline-block" }}>
                               <img src="logo_filterlists.png" alt="FilterLists" className="img-fluid"/>
                           </a>
                       </h1>
                       <p id="fl-tagline">
                           The independent, comprehensive directory of filter and host lists for advertisements, trackers, malware, and annoyances.
                       </p>
                   </div>
                   <div className="row">
                       <div className="w-100">
                           { this.props.children }
                       </div>
                   </div>
                   <div className="row justify-content-center">
                       <p>A project by <a href="https://collinmbarrett.com/">Collin M. Barrett</a>. | Contribute on <a href="https://github.com/collinbarrett/FilterLists">GitHub</a>.</p>
                   </div>
               </div>;
    };
}