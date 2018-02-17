![FilterLists](https://github.com/collinbarrett/FilterLists/blob/master/imgs/logo_filterlists.png)

[![Website](https://img.shields.io/website-up-down-green-red/http/shields.io.svg)](https://filterlists.com/)
[![Travis](https://img.shields.io/travis/collinbarrett/FilterLists.svg?label=travis)](https://travis-ci.org/collinbarrett/FilterLists)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](https://github.com/collinbarrett/FilterLists/blob/master/LICENSE)

FilterLists is the independent, comprehensive directory of filter and host lists for advertisements, trackers, malware, and annoyances. [Learn More](https://github.com/collinbarrett/FilterLists/blob/master/About.md).

## Links
| Site                                                | API                                               |
| --------------------------------------------------- | ------------------------------------------------- |
| [v3 (Beta)](https://beta.filterlists.com/)         | [v1 (Beta)](https://api.filterlists.com/v1/lists)|
| [v2 (Stable, Frozen)](https://filterlists.com/)     |                                                   |
| [v1 (Legacy, Frozen)](https://v1.filterlists.com/)  |                                                   |

## Development Notice (Updated February 14, 2018)
FilterLists improvements are slow and tend to be in spurts. I care about this project as both a resource for the community and a learning tool for me. However, my day job comes first which often results in little to no work on the project at times. I happily welcome anyone that wants to contribute.

The immediate projects are converting the data to an actual web application (rather than Google Sheets & WordPress), and then exposing the data via a .Net Core REST API driving a first-party ReactJS UI.

## Adding or Updating Lists

To submit a new list or update data about an existing list, please submit a pull request to [data](https://github.com/collinbarrett/FilterLists/tree/master/data) in conjunction with the data model described [here](https://github.com/collinbarrett/FilterLists/wiki/Data-Model_sidebar). Alternatively, you can [open a new issue](https://github.com/collinbarrett/FilterLists/issues/new) providing information for all of the fields described in the [data model](https://github.com/collinbarrett/FilterLists/wiki/Data-Model_sidebar).
