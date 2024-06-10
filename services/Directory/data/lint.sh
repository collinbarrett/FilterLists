#!/bin/bash
# Sorts json files by FilterLists conventions documented in Wiki.

jq -S ".|=sort_by(.dependencyFilterListId, .dependentFilterListId)" Dependent.json > Dependent.tmp
mv Dependent.tmp Dependent.json

jq -S ".|=sort_by(.id)" FilterList.json > FilterList.tmp
mv FilterList.tmp FilterList.json

jq -S ".|=sort_by(.filterListId, .languageId)" FilterListLanguage.json > FilterListLanguage.tmp
mv FilterListLanguage.tmp FilterListLanguage.json

jq -S ".|=sort_by(.filterListId, .maintainerId)" FilterListMaintainer.json > FilterListMaintainer.tmp
mv FilterListMaintainer.tmp FilterListMaintainer.json

jq -S ".|=sort_by(.filterListId, .syntaxId)" FilterListSyntax.json > FilterListSyntax.tmp
mv FilterListSyntax.tmp FilterListSyntax.json

jq -S ".|=sort_by(.filterListId, .tagId)" FilterListTag.json > FilterListTag.tmp
mv FilterListTag.tmp FilterListTag.json

jq -S ".|=sort_by(.id)" FilterListViewUrl.json > FilterListViewUrl.tmp
mv FilterListViewUrl.tmp FilterListViewUrl.json

jq -S ".|=sort_by(.upstreamFilterListId, .forkFilterListId)" Fork.json > Fork.tmp
mv Fork.tmp Fork.json

jq -S ".|=sort_by(.iso6391)" Language.json > Language.tmp
mv Language.tmp Language.json

jq -S ".|=sort_by(.id)" License.json > License.tmp
mv License.tmp License.json

jq -S ".|=sort_by(.id)" Maintainer.json > Maintainer.tmp
mv Maintainer.tmp Maintainer.json

jq -S ".|=sort_by(.includedInFilterListId, .includesFilterListId)" Merge.json > Merge.tmp
mv Merge.tmp Merge.json

jq -S ".|=sort_by(.id)" Software.json > Software.tmp
mv Software.tmp Software.json

jq -S ".|=sort_by(.softwareId, .syntaxId)" SoftwareSyntax.json > SoftwareSyntax.tmp
mv SoftwareSyntax.tmp SoftwareSyntax.json

jq -S ".|=sort_by(.id)" Syntax.json > Syntax.tmp
mv Syntax.tmp Syntax.json

jq -S ".|=sort_by(.id)" Tag.json > Tag.tmp
mv Tag.tmp Tag.json
