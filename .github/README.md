<p align="center"><img src="https://github.com/collinbarrett/FilterLists/blob/master/imgs/logo_filterlists.png"></p>

<p align="center"><a href="https://twitter.com/FilterLists"><img alt="Twitter Follow" src="https://img.shields.io/twitter/follow/FilterLists?style=social"></a>
<a href="https://hub.filterlists.com"><img alt="Discourse status" src="https://img.shields.io/discourse/https/hub.filterlists.com/status.svg"></a>
<a href="https://github.com/collinbarrett/FilterLists/blob/master/LICENSE"><img alt="License" src="https://img.shields.io/github/license/collinbarrett/filterlists.svg"></a>
<a href="https://builtwithdot.net/project/125/filterlists"><img src="https://builtwithdot.net/project/125/filterlists/badge" alt="BuiltWithDot.Net shield" /></a>
<a title="MadeWithReactJs.com Shield" href="https://madewithreactjs.com/p/filterlists/shield-link"> <img src="https://madewithreactjs.com/storage/repo-shields/2335-shield.svg"/></a>

<p align="center">FilterLists is the independent, comprehensive directory of filter and host lists for advertisements, trackers, malware, and annoyances.</p>

<p align="center"><b>Website:</b> <a href="https://filterlists.com/"><img src="https://img.shields.io/website-up-down-green-red/http/shields.io.svg?label=Website" alt="Website" /></a>
<a href="https://dev.azure.com/collinbarrett/FilterLists/_build/latest?definitionId=18"><img src="https://dev.azure.com/collinbarrett/FilterLists/_apis/build/status/Web?branchName=master" alt="FilterLists Web - Azure DevOps builds" /></a>
<a href="https://dev.azure.com/collinbarrett/FilterLists/_release?definitionId=4"><img src="https://vsrm.dev.azure.com/collinbarrett/_apis/public/Release/badge/b06a3d5c-459e-4789-9735-0f5969006fe8/4/5" alt="FilterLists Web - Azure DevOps releases" /></a>
<a href="https://github.com/users/collinbarrett/packages/container/package/filterlists-web"><img src="https://img.shields.io/badge/docker%20image-filterlists--web-blue" alt="FilterLists Web - Docker Image" /></a>
<br/>A React & TypeScript UI built with Ant Design.</p>

<p align="center"><b>Directory API:</b> <a href="https://filterlists.com/api"><img src="https://img.shields.io/website-up-down-green-red/http/shields.io.svg?label=Directory%20API" alt="Directory API" /></a>
<a href="https://dev.azure.com/collinbarrett/FilterLists/_build/latest?definitionId=27"><img src="https://dev.azure.com/collinbarrett/FilterLists/_apis/build/status/Directory%20API?branchName=master" alt="FilterLists Directory API - Azure DevOps builds" /></a>
<a href="https://dev.azure.com/collinbarrett/FilterLists/_release?definitionId=3"><img src="https://vsrm.dev.azure.com/collinbarrett/_apis/public/Release/badge/b06a3d5c-459e-4789-9735-0f5969006fe8/3/4" alt="FilterLists Directory API - Azure DevOps releases" /></a>
<a href="https://github.com/users/collinbarrett/packages/container/package/filterlists-directory-api"><img src="https://img.shields.io/badge/docker%20image-filterlists--directory--api-blue" alt="FilterLists Directory API - Docker Image" /></a>
<br/>An ASP.NET Core API CRUD-ing with a Postgres instance via EF Core.</p>

<p align="center"><b>Archival API 🚧:</b>
<a href="https://dev.azure.com/collinbarrett/FilterLists/_build/latest?definitionId=29"><img src="https://dev.azure.com/collinbarrett/FilterLists/_apis/build/status/Archival%20API?branchName=master" alt="FilterLists Archival API - Azure DevOps builds" /></a>
<a href="https://github.com/users/collinbarrett/packages/container/package/filterlists-archival-api"><img src="https://img.shields.io/badge/docker%20image-filterlists--archival--api-blue" alt="FilterLists Archival API - Docker Image" /></a>
<br/>A .NET Core app archiving copies of FilterLists for mirrors and future analysis.</p>

<p align="center"><b>Reverse Proxy:</b>
<a href="https://dev.azure.com/collinbarrett/FilterLists/_build/latest?definitionId=21"><img src="https://dev.azure.com/collinbarrett/FilterLists/_apis/build/status/Reverse%20Proxy?branchName=master" alt="FilterLists Reverse Proxy - Azure DevOps builds" /></a>
<a href="https://dev.azure.com/collinbarrett/FilterLists/_release?definitionId=5"><img src="https://vsrm.dev.azure.com/collinbarrett/_apis/public/Release/badge/b06a3d5c-459e-4789-9735-0f5969006fe8/5/6" alt="FilterLists Reverse Proxy - Azure DevOps releases" /></a>
<br/>An NGINX instance forwarding requests to the respective services above.</p>

# Background

FilterLists helps to protect your privacy and security when using the internet. It provides a comprehensive directory of subscription lists to block advertisements, malware, trackers, and other general annoyances. First, install one of the software tools that supports these lists. Then you can subscribe to a set of these lists inside of that software. If you need help or have a comment/question, open an [Issue](https://github.com/collinbarrett/FilterLists/issues).

Using a software firewall or adblocker has become a key tool in protecting one's privacy online. While the current business model of the "free" internet relies upon advertising revenue, publishers have become too flippant about tracking users without their consent. Advertising networks track users' browsing habits around the internet building lucrative profiles to exploit for targeted marketing or big data research. Until internet publishers develop more transparency or a new business model, we must continue to take the protection of our privacy into our hands.

Typical adblockers run as an extension in popular web browsers. As we browse the internet, they compare HTTP requests to their list of hosts and filters to selectively block advertisements, trackers, and malware. This filtering helps to protect the surfer's privacy, prevents [malvertising attacks](http://www.wired.com/insights/2014/11/malvertising-is-cybercriminals-latest-sweet-spot/ "Why Malvertising Is Cybercriminals' Latest Sweet Spot - Wired"), and [reduces bandwidth requirements](http://venturebeat.com/2015/07/08/blocking-ads-can-cut-network-traffic-25-to-40-study-shows/ "Blocking Ads Can Cut Network Traffic 25% to 40%, Study Shows - VentureBeat"). Thousands of contributors work hard to maintain these FilterLists for anyone to use. Locating and selecting these lists, however, has not historically been very easy. This project was launched in 2015 to solve that problem.

# Contributing

## Community

<a href="https://hub.filterlists.com"><img alt="Discourse posts" src="https://img.shields.io/discourse/https/hub.filterlists.com/posts.svg"></a>

Check out the <a href="https://hub.filterlists.com">FilterLists Hub</a>, a forum for discussing how to write rules, maintain FilterLists, and chat about the state of the adblocking community.

## Adding or Updating Lists

To submit a new list or update data about an existing list, please submit a pull request to [data](https://github.com/collinbarrett/FilterLists/tree/master/services/Directory/data) in conjunction with the data model described [here](https://github.com/collinbarrett/FilterLists/wiki/Data-Model_sidebar). Once you open the pull request, our [Migrate bot](https://github.com/collinbarrett/FilterLists/blob/master/services/Directory/azure-pipelines.migrate.yaml) will create an [Entity Framework Core migration](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli) with your changes and test them. Please ensure to [grant the bot permissions to push to your pull request branch](https://help.github.com/en/github/collaborating-with-issues-and-pull-requests/allowing-changes-to-a-pull-request-branch-created-from-a-fork).

Alternatively, you can [open a new issue](https://github.com/collinbarrett/FilterLists/issues/new) providing information for all of the fields described in the [data model](https://github.com/collinbarrett/FilterLists/wiki/Data-Model_sidebar).

Information about tracking protection lists (TPL) for Internet Explorer (☠) are maintained [here](https://github.com/collinbarrett/FilterLists/blob/master/web/public/tpl.html) outside of the standard data model and viewed [here](https://filterlists.com/tpl.html).

## Adding or Updating Rules

FilterLists does not maintain any of these lists. It serves only as a discovery tool to direct users to lists that they may want to use. If you want to request addition, modification, or removal of a rule from a list, you will need to contact the maintainers of that list directly. FilterLists provides a variety of ways you can get in contact with the maintainers to do so.

## Building and Running Locally

We have containerized FilterLists to make it as easy as possible for contributers to get the project up and running locally.

### Up and Running

1. Install Docker CE for your computer's operating system. [Docs](https://docs.docker.com/install/)
2. Clone the FilterLists git repository to your computer. [Docs](https://help.github.com/en/articles/cloning-a-repository)
3. Navigate to the root directory of your locally cloned FilterLists git repository in a command-line interface.
4. TBD...

# Acknowledgements

- Imre Kristoffer Eilertsen [@DandelionSprout](https://github.com/DandelionSprout) : major contributor
- Raymond Hill [@gorhill](https://github.com/gorhill) : uBlock Origin owner, advised on some technical aspects of FilterLists
- Andrey Meshkov [@ameshkov](https://github.com/ameshkov) : AdGuard CTO, advised on some technical aspects of FilterLists
- [More contributors](https://github.com/collinbarrett/FilterLists/graphs/contributors)

# Miscellany

## Disclaimer

FilterLists does not condone subscribing to any particular FilterList or blocking any particular advertisement network. Make sure to financially support your favorite sites in some way if you choose to block their advertisements. FilterLists is also in no way officially affiliated with any of the software vendors or list maintainers referenced on this site.

## Privacy

We respect your privacy. That is the whole point of this project. The only minor data we collect about visitors is what our infrastructure providers collect. These include:

- [GitHub](https://help.github.com/articles/github-privacy-statement/)
- [Azure DevOps](https://docs.microsoft.com/en-us/azure/devops/organizations/security/data-protection?view=azure-devops)
- [Application Insights](https://docs.microsoft.com/en-us/azure/azure-monitor/app/data-retention-privacy)
- [DigitalOcean](https://www.digitalocean.com/legal/privacy-policy/)
- [Cloudflare](https://www.cloudflare.com/analytics/)
