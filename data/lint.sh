#!/bin/bash

jq -S ".|=sort_by(.id)" FilterList.json > FilterList.tmp
mv FilterList.tmp FilterList.json
