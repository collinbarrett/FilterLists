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
                   </div>
                   <div className="row">
                       <div className="w-100">
                           { this.props.children }
                       </div>
                   </div>
                   <div className="row justify-content-center">
                       <p className="mt-2 ml-1 mr-1">
                           <a href="https://filterlists.com/api/docs/index.html">API</a> | <a href="https://github.com/collinbarrett/FilterLists">GitHub</a> | <a href="https://beerpay.io/collinbarrett/FilterLists">Donate</a> | By <a href="https://collinmbarrett.com/">Collin M. Barrett</a>
                       </p>
                   </div>
               </div>;
    };
}