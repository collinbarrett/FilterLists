import React from "react";
import {
  Redirect,
  Route,
  RouteComponentProps,
  StaticContext,
} from "react-router";

import { List } from "../../interfaces/List";
import { ListInfoDrawer } from "../listInfoDrawer";

interface Props {
  lists: List[];
}

export const ListDrawer = (props: Props) => {
  const renderDrawer = (rp: RouteComponentProps<any, StaticContext, any>) => {
    const list = props.lists.find((l) => l.slug === rp.match.params.listSlug);
    return list ? (
      <ListInfoDrawer listId={list.id} {...rp} />
    ) : props.lists && props.lists.length ? (
      <Redirect to={{ pathname: "/" }} />
    ) : null;
  };
  return <Route path="/lists/:listSlug" render={renderDrawer} />;
};
