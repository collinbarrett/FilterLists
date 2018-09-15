import * as React from "react";
import { Layout } from "./Layout";
import { Route } from "react-router-dom";
import { Home } from "./modules";

export const Routes = <Layout>
                          <Route exact path="/" component={ Home }/>
                      </Layout>;