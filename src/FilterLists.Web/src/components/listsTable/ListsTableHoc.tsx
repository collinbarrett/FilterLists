import React from 'react';
import { RouteComponentProps } from 'react-router-dom';

import { useLanguages, useLicenses, useLists, useSoftware, useSyntaxes, useTags } from '../../hooks';
import { ListDrawer } from './ListDrawer';
import { ListsTable } from './ListsTable';

export const ListsTableHoc = (props: RouteComponentProps) => {
  const lists = useLists();
  const languages = useLanguages();
  const licenses = useLicenses();
  const software = useSoftware();
  const syntaxes = useSyntaxes();
  const tags = useTags();
  return (
    <>
      <ListsTable
        lists={lists}
        languages={languages}
        licenses={licenses}
        software={software}
        tags={tags}
        {...props} />
      <ListDrawer
        lists={lists}
        languages={languages}
        licenses={licenses}
        software={software}
        syntaxes={syntaxes}
        tags={tags} />
    </>
  );
};