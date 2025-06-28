"use client";

import { createColumnHelper } from "@tanstack/react-table";
import { FilterListsTableMeta } from ".";
import { BadgeCloud } from "@/components/badge-cloud";
import { FilterList } from "@/services/get-filterlists";

const columnHelper = createColumnHelper<FilterList>();

export const columns = [
  columnHelper.accessor((row) => row.name, {
    header: "Name",
    size: 200,
    cell: (info) => (
      <div className="line-clamp-3 whitespace-normal">{info.getValue()}</div>
    ),
  }),
  columnHelper.accessor((row) => row.description, {
    header: "Description",
    size: 400,
    cell: (info) => (
      <div className="line-clamp-3 whitespace-normal">{info.getValue()}</div>
    ),
  }),
  columnHelper.accessor((row) => row.syntaxIds, {
    header: "Syntaxes",
    cell: (info) => {
      const meta = info.table.options.meta as FilterListsTableMeta;
      const syntaxes =
        info.getValue()?.flatMap((id) => {
          const syntax = meta.syntaxes.find((s) => s.id === id);
          return syntax
            ? [
                {
                  key: syntax.id,
                  value: syntax.name,
                  tooltip: syntax.description ?? undefined,
                  href: syntax.url ?? undefined,
                },
              ]
            : [];
        }) ?? [];
      return (
        <div className="fade-out-bottom h-full">
          <BadgeCloud items={syntaxes} />
        </div>
      );
    },
    size: 150,
  }),
  columnHelper.accessor((row) => row.languageIds, {
    header: "Languages",
    cell: (info) => {
      const meta = info.table.options.meta as FilterListsTableMeta;
      const languages =
        info.getValue()?.flatMap((id) => {
          const language = meta.languages.find((l) => l.id === id);
          return language
            ? [
                {
                  key: language.id,
                  value: language.iso6391,
                  tooltip: language.name,
                },
              ]
            : [];
        }) ?? [];
      return (
        <div className="fade-out-bottom h-full">
          <BadgeCloud items={languages} />
        </div>
      );
    },
    size: 150,
  }),
  columnHelper.accessor((row) => row.tagIds, {
    header: "Tags",
    cell: (info) => {
      const meta = info.table.options.meta as FilterListsTableMeta;
      const tags =
        info.getValue()?.flatMap((id) => {
          const tag = meta.tags.find((s) => s.id === id);
          return tag
            ? [
                {
                  key: tag.id,
                  value: tag.name,
                  tooltip: tag.description ?? undefined,
                },
              ]
            : [];
        }) ?? [];
      return (
        <div className="fade-out-bottom h-full">
          <BadgeCloud items={tags} />
        </div>
      );
    },
    size: 200,
  }),
  columnHelper.accessor((row) => row.licenseId, {
    header: "License",
    cell: (info) => {
      const meta = info.table.options.meta as FilterListsTableMeta;
      const license = meta.licenses.find((l) => l.id === info.getValue());
      return license ? (
        <div className="fade-out-bottom h-full">
          <BadgeCloud
            items={[
              {
                key: license.id,
                value: license.name,
                href: license.url ?? undefined,
              },
            ]}
          />
        </div>
      ) : null;
    },
    size: 150,
  }),
  columnHelper.accessor((row) => row.maintainerIds, {
    header: "Maintainers",
    cell: (info) => {
      const meta = info.table.options.meta as FilterListsTableMeta;
      const maintainers =
        info.getValue()?.flatMap((id) => {
          const maintainer = meta.maintainers.find((s) => s.id === id);
          return maintainer
            ? [
                {
                  key: maintainer.id,
                  value: maintainer.name,
                  href: maintainer.url ?? undefined,
                },
              ]
            : [];
        }) ?? [];
      return (
        <div className="fade-out-bottom h-full">
          <BadgeCloud items={maintainers} />
        </div>
      );
    },
    size: 200,
  }),
];
