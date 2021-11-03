import {
  Redirect,
  Route,
  RouteComponentProps,
  StaticContext,
} from "react-router";
import { List } from "../../interfaces/List";
import { ListInfoDrawer } from "../listInfoDrawer";
import { Language } from "../../interfaces/Language";
import { License } from "../../interfaces/License";
import { Maintainer } from "../../interfaces/Maintainer";
import { Software } from "../../interfaces/Software";
import { Syntax } from "../../interfaces/Syntax";
import { Tag } from "../../interfaces/Tag";

interface Props {
  lists: List[];
  languages: Language[];
  licenses: License[];
  maintainers: Maintainer[];
  software: Software[];
  syntaxes: Syntax[];
  tags: Tag[];
}

export const ListDrawer = (props: Props) => {
  const renderDrawer = (rp: RouteComponentProps<any, StaticContext, any>) => {
    const list = props.lists.find((l) => l.slug === rp.match.params.listSlug);
    return list ? (
      <ListInfoDrawer
        listId={list.id}
        languages={props.languages}
        licenses={props.licenses}
        maintainers={props.maintainers}
        software={props.software}
        syntaxes={props.syntaxes}
        tags={props.tags}
        {...rp}
      />
    ) : props.lists && props.lists.length ? (
      <Redirect to={{ pathname: "/" }} />
    ) : null;
  };
  return <Route path="/lists/:listSlug" render={renderDrawer} />;
};
