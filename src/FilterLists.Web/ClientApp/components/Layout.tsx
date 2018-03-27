import * as React from "react";

export interface ILayoutProps {
    children?: React.ReactNode;
}

export class Layout extends React.Component<ILayoutProps, {}> {
    render() {
        return <div className="container">
                   <div className="row">
                       <h1>
                           <a href="./">
                               <img src="logo_filterlists.png" alt="FilterLists" className="img-fluid"/>
                           </a>
                       </h1>
                       <p className="ml-2 mr-2">
                           The independent, comprehensive directory of filter and host lists for advertisements, trackers, malware, and annoyances.
                       </p>
                   </div>
                   <div className="row">
                       <div className="w-100">
                           { this.props.children }
                       </div>
                   </div>
                   <div className="row justify-content-center">
                       <p className="mt-2 ml-1 mr-1">By <a href="https://collinmbarrett.com/">Collin M. Barrett</a> | Contribute on <a href="https://github.com/collinbarrett/FilterLists">GitHub</a></p>
                   </div>
               </div>;
    };
}