import * as React from "react";
import { BrowserRouter, Redirect, Route, Switch } from "react-router-dom";
import { Home } from "./modules";

const Routes =
    <Switch>
        <Route exact path="/" component={Home} />
        <Route>
            <Redirect to="/" />
        </Route>
    </Switch>;

export const Router = () => <BrowserRouter children={Routes} />