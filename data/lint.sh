#!/bin/bash

jq -S ".|=sort_by(.dependentFilterListId, .dependencyFilterListId)" Dependent.json > Dependent.tmp
mv Dependent.tmp Dependent.json

jq -S ".|=sort_by(.id)" FilterList.json > FilterList.tmp
mv FilterList.tmp FilterList.json

jq -S ".|=sort_by(.filterListId, .languageId)" FilterListLanguage.json > FilterListLanguage.tmp
mv FilterListLanguage.tmp FilterListLanguage.json

jq -S ".|=sort_by(.maintainerId, .filterListId)" FilterListMaintainer.json > FilterListMaintainer.tmp
mv FilterListMaintainer.tmp FilterListMaintainer.json

jq -S ".|=sort_by(.filterListId, .tagId)" FilterListTag.json > FilterListTag.tmp
mv FilterListTag.tmp FilterListTag.json

jq -S ".|=sort_by(.upstreamFilterListId, .forkFilterListId)" Fork.json > Fork.tmp
mv Fork.tmp Fork.json

jq -S ".|=sort_by(.id)" Language.json > Language.tmp
mv Language.tmp Language.json

jq -S ".|=sort_by(.id)" License.json > License.tmp
mv License.tmp License.json
