import React from "react";
import {
  Redirect,
  Route,
  RouteComponentProps,
  StaticContext,
} from "react-router";

import { Language } from "../../interfaces/Language";
import { License } from "../../interfaces/License";
import { List } from "../../interfaces/List";
import { Maintainer } from "../../interfaces/Maintainer";
import { Software } from "../../interfaces/Software";
import { Syntax } from "../../interfaces/Syntax";
import { Tag } from "../../interfaces/Tag";
import { ListInfoDrawer } from "../listInfoDrawer";

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
        list={list as List}
        languages={
          list.languageIso6391s &&
          props.languages.filter((l: Language) =>
            list.languageIso6391s.includes(l.id)
          )
        }
        license={
          list.licenseId
            ? props.licenses.find((l: License) => list.licenseId === l.id)
            : props.licenses.find((l: License) => l.id === 5)
        }
        maintainers={
          list.maintainerIds &&
          props.maintainers.filter((m: Maintainer) =>
            list.maintainerIds.includes(m.id)
          )
        }
        software={
          list.syntaxId
            ? props.software.filter((s: Software) =>
                s.syntaxIds.includes(list.syntaxId)
              )
            : []
        }
        syntax={
          list.syntaxId
            ? props.syntaxes.find((s) => s.id === list.syntaxId)
            : undefined
        }
        tags={
          list.tagIds &&
          props.tags.filter((t: Tag) => list.tagIds.includes(t.id))
        }
        {...rp}
      />
    ) : props.lists && props.lists.length ? (
      <Redirect to={{ pathname: "/" }} />
    ) : null;
  };
  return <Route path="/lists/:listSlug" render={renderDrawer} />;
};
