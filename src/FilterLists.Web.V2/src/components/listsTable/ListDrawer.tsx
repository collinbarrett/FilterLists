import React from 'react';
import { Redirect, Route, RouteComponentProps, StaticContext } from 'react-router';

import { Language } from '../../interfaces/Language';
import { License } from '../../interfaces/License';
import { List } from '../../interfaces/List';
import { Tag } from '../../interfaces/Tag';
import { ListInfoDrawer } from '../ListInfoDrawer';

interface Props {
    lists: List[];
    languages: Language[];
    licenses: License[];
    tags: Tag[];
};

export const ListDrawer = (props: Props) => {
    const renderDrawer = (rp: RouteComponentProps<any, StaticContext, any>) => {
        const list = props.lists.find(l => l.slug === rp.match.params.listSlug);
        return list
            ? <ListInfoDrawer
                list={list as List}
                languages={list.languageIds && props.languages.filter((l: Language) => list.languageIds.includes(l.id))}
                license={list.licenseId ? props.licenses.find((l: License) => list.licenseId === l.id) : undefined}
                tags={list.tagIds && props.tags.filter((t: Tag) => list.tagIds.includes(t.id))}
                {...rp} />
            : props.lists && props.lists.length && <Redirect to={{ pathname: "/", }} />;
    };
    return <Route path="/lists/:listSlug" render={renderDrawer} />;
};