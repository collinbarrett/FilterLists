import * as React from "react";
import { Layout } from "./Layout";
import { Route, Redirect, Switch } from "react-router-dom";
import { Home } from "./modules";

export const Routes = <Layout>
                          <Switch>
                              <Route exact path="/" component={Home}/>
                              <Route>
                                  <Redirect to="/"/>
                              </Route>
                          </Switch>
                      </Layout>;