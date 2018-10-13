![FilterLists](https://github.com/collinbarrett/FilterLists/blob/master/imgs/logo_filterlists.png)

[![Website](https://img.shields.io/website-up-down-green-red/http/shields.io.svg)](https://filterlists.com/)
[![API](https://img.shields.io/website-up-down-green-red/http/shields.io.svg?label=API)](https://filterlists.com/api/v1/lists)
[![Travis](https://travis-ci.org/collinbarrett/FilterLists.svg?branch=master)](https://travis-ci.org/collinbarrett/FilterLists)
[![codecov](https://codecov.io/gh/collinbarrett/FilterLists/branch/master/graph/badge.svg)](https://codecov.io/gh/collinbarrett/FilterLists)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](https://github.com/collinbarrett/FilterLists/blob/master/LICENSE)
[![BuitlWithDot.Net shield](https://builtwithdot.net/project/125/filterlists/badge)](https://builtwithdot.net/project/125/filterlists)
[![Beerpay](https://beerpay.io/collinbarrett/FilterLists/badge.svg?style=beer-square)](https://beerpay.io/collinbarrett/FilterLists)
[![Beerpay](https://beerpay.io/collinbarrett/FilterLists/make-wish.svg?style=flat-square)](https://beerpay.io/collinbarrett/FilterLists?focus=wish)

FilterLists is the independent, comprehensive directory of filter and host lists for advertisements, trackers, malware, and annoyances.

## Links
| Site                                                | API                                                            |
| --------------------------------------------------- | -------------------------------------------------------------- |
| [v3 (Live, Beta)](https://filterlists.com/)         | [v1 (Live, Beta)](https://filterlists.com/api/docs/index.html) |
| [v2 (Legacy, Frozen)](https://v2.filterlists.com/)  |                                                                |
| [v1 (Legacy, Frozen)](https://v1.filterlists.com/)  |                                                                |

## Adding or Updating Lists

To submit a new list or update data about an existing list, please submit a pull request to [data](https://github.com/collinbarrett/FilterLists/tree/master/data) in conjunction with the data model described [here](https://github.com/collinbarrett/FilterLists/wiki/Data-Model_sidebar). Alternatively, you can [open a new issue](https://github.com/collinbarrett/FilterLists/issues/new) providing information for all of the fields described in the [data model](https://github.com/collinbarrett/FilterLists/wiki/Data-Model_sidebar).

## Adding or Updating Rules

FilterLists does not maintain any of these lists. It serves only as a discovery tool to direct users to lists that they may want to use. If you want to request addition, modification, or removal of a rule from a list, you will need to contact the maintainers of that list directly. FilterLists provides a variety of ways you can get in contact with the maintainers to do so.

## Background

FilterLists helps to protect your privacy and security when using the internet. It provides a comprehensive directory of subscription lists to block advertisements, malware, trackers, and other general annoyances. First, install one of the [software tools](https://github.com/collinbarrett/FilterLists/blob/master/data/Software.json) that supports these lists. Then, you can subscribe to a set of these lists inside of that software. If you need help or have a comment/question, open an [Issue](https://github.com/collinbarrett/FilterLists/issues).

Using a software firewall or adblocker has become a key tool in protecting one's privacy online. While the current business model of the "free" internet relies upon advertising revenue, publishers have become too flippant about tracking users without their consent. Advertising networks track users' browsing habits around the internet building lucrative profiles to exploit for targeted marketing or big data research. Until internet publishers develop more transparency or a new business model, we must continue to take the protection of our privacy into our hands.

Typical adblockers run as an extension in popular web browsers. As we browse the internet, they compare HTTP requests to their list of hosts and filters to selectively block advertisements, trackers, and malware. This filtering helps to protect the surfer's privacy, prevents [malvertising attacks](http://www.wired.com/insights/2014/11/malvertising-is-cybercriminals-latest-sweet-spot/ "Why Malvertising Is Cybercriminals' Latest Sweet Spot - Wired"), and [reduces bandwidth requirements](http://venturebeat.com/2015/07/08/blocking-ads-can-cut-network-traffic-25-to-40-study-shows/ "Blocking Ads Can Cut Network Traffic 25% to 40%, Study Shows - VentureBeat"). Thousands of contributors work hard to maintain these FilterLists for anyone to use. Locating and selecting these lists, however, has not historically been very easy. This project aims to solve that problem.

## Acknowledgements

  - Imre Kristoffer Eilertsen [@DandelionSprout](https://github.com/DandelionSprout) : major contributor
  - Raymond Hill [@gorhill](https://github.com/gorhill) : uBlock Origin owner, advised on some technical aspects of FilterLists
  - Andrey Meshkov [@ameshkov](https://github.com/ameshkov) : AdGuard CTO, advised on some technical aspects of FilterLists
  - [More Contributors](https://github.com/collinbarrett/FilterLists/graphs/contributors)

## Miscellany

### Disclaimer

FilterLists does not condone or endorse implementing any particular FilterList or blocking any particular advertisement network. Make sure to financially support your favorite sites in some way if you choose to block their advertisements. FilterLists is also in no way officially affiliated with any of the software vendors or list maintainers referenced on this site.

### Privacy

We respect your privacy. That is the whole point of this site. The only minor data we collect about visitors is what [Cloudflare](https://www.cloudflare.com/analytics/), [Application Insights](https://docs.microsoft.com/en-us/azure/application-insights/app-insights-data-retention-privacy), and [GitHub](https://help.github.com/articles/github-privacy-statement/) capture.
