import * as React from "react";
import { Link, NavLink } from "react-router-dom";

export class NavMenu extends React.Component<{}, {}> {
    render() {
        return <div className="main-nav">
                   <div className="navbar navbar-inverse">
                       <div className="navbar-header">
                           <Link className="navbar-brand" to={ "/" }>FilterLists</Link>
                       </div>
                       <div className="clearfix"></div>
                       <div className="navbar-collapse collapse">
                           <ul className="nav navbar-nav">
                               <li>
                                   <NavLink to={ "/" } exact activeClassName="active">
                                       <span className="glyphicon glyphicon-home"></span> All
                                   </NavLink>
                               </li>
                           </ul>
                       </div>
                   </div>
               </div>;
    }
}