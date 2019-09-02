<p align="center"><img src="https://github.com/collinbarrett/FilterLists/blob/master/imgs/logo_filterlists.png"></p>

<p align="center"><a href="https://hub.filterlists.com"><img alt="Discourse status" src="https://img.shields.io/discourse/https/hub.filterlists.com/status.svg"></a>
<a href="https://github.com/collinbarrett/FilterLists/blob/master/LICENSE"><img alt="License" src="https://img.shields.io/github/license/collinbarrett/filterlists.svg"></a>
<a href="https://builtwithdot.net/project/125/filterlists"><img src="https://builtwithdot.net/project/125/filterlists/badge" alt="BuiltWithDot.Net shield" /></a>
<a href="https://beerpay.io/collinbarrett/FilterLists"><img src="https://beerpay.io/collinbarrett/FilterLists/badge.svg?style=beer-square" alt="Beerpay" /></a>
<a href="https://beerpay.io/collinbarrett/FilterLists?focus=wish"><img src="https://beerpay.io/collinbarrett/FilterLists/make-wish.svg?style=flat-square" alt="Beerpay" /></a></p>

<p align="center">FilterLists is the independent, comprehensive directory of filter and host lists for advertisements, trackers, malware, and annoyances.</p>

<p align="center"><b>API:</b> <a href="https://filterlists.com/api/v1/lists"><img src="https://img.shields.io/website-up-down-green-red/http/shields.io.svg?label=API" alt="API" /></a>
<a href="https://dev.azure.com/collinbarrett/FilterLists/_build/latest?definitionId=3"><img src="https://img.shields.io/azure-devops/build/collinbarrett/FilterLists/3.svg" alt="Azure DevOps builds" /></a>
<a href="https://dev.azure.com/collinbarrett/FilterLists/_test/analytics?definitionId=3&contextType=build"><img alt="Azure DevOps tests" src="https://img.shields.io/azure-devops/tests/collinbarrett/FilterLists/3.svg"></a>
<a href="https://dev.azure.com/collinbarrett/FilterLists/_release?definitionId=3"><img src="https://img.shields.io/azure-devops/release/collinbarrett/b06a3d5c-459e-4789-9735-0f5969006fe8/3/4.svg" alt="Azure DevOps releases" /></a>
<a href="https://hub.docker.com/r/collinbarrett2/filterlists.api"><img src="https://img.shields.io/docker/pulls/collinbarrett/filterlists.api.svg" alt="Docker Pulls" /></a>
<br/>An ASP.NET Core API CRUD-ing with a MariaDB instance via EF Core.</p>

<p align="center"><b>Website:</b> <a href="https://filterlists.com/"><img src="https://img.shields.io/website-up-down-green-red/http/shields.io.svg" alt="Website" /></a>
<a href="https://dev.azure.com/collinbarrett/FilterLists/_build/latest?definitionId=12"><img src="https://img.shields.io/azure-devops/build/collinbarrett/FilterLists/12.svg" alt="Azure DevOps builds" /></a>
<a href="https://dev.azure.com/collinbarrett/FilterLists/_release?definitionId=4"><img src="https://img.shields.io/azure-devops/release/collinbarrett/b06a3d5c-459e-4789-9735-0f5969006fe8/4/5.svg" alt="Azure DevOps releases" /></a>
<a href="https://hub.docker.com/r/collinbarrett2/filterlists.web"><img src="https://img.shields.io/docker/pulls/collinbarrett/filterlists.web.svg" alt="Docker Pulls" /></a>
<br/>A React & TypeScript UI primarily featuring a <a href="https://www.npmjs.com/package/react-table">react-table</a> instance.</p>

<p align="center"><b>Agent:</b> 
<a href="https://dev.azure.com/collinbarrett/FilterLists/_build/latest?definitionId=17"><img src="https://img.shields.io/azure-devops/build/collinbarrett/FilterLists/17.svg" alt="Azure DevOps builds" /></a>
<a href="https://dev.azure.com/collinbarrett/FilterLists/_test/analytics?definitionId=17&contextType=build"><img alt="Azure DevOps tests" src="https://img.shields.io/azure-devops/tests/collinbarrett/FilterLists/17.svg"></a>
<a href="https://dev.azure.com/collinbarrett/FilterLists/_release?definitionId=6"><img src="https://img.shields.io/azure-devops/release/collinbarrett/b06a3d5c-459e-4789-9735-0f5969006fe8/6/7.svg" alt="Azure DevOps releases" /></a>
<a href="https://hub.docker.com/r/collinbarrett2/filterlists.agent"><img src="https://img.shields.io/docker/pulls/collinbarrett/filterlists.agent.svg" alt="Docker Pulls" /></a>
<br/>A .NET Core console application performing crawling, archiving, and URL validation.</p>

# Background

FilterLists helps to protect your privacy and security when using the internet. It provides a comprehensive directory of subscription lists to block advertisements, malware, trackers, and other general annoyances. First, install one of the [software tools](https://github.com/collinbarrett/FilterLists/blob/master/data/Software.json) that supports these lists. Then, you can subscribe to a set of these lists inside of that software. If you need help or have a comment/question, open an [Issue](https://github.com/collinbarrett/FilterLists/issues).

Using a software firewall or adblocker has become a key tool in protecting one's privacy online. While the current business model of the "free" internet relies upon advertising revenue, publishers have become too flippant about tracking users without their consent. Advertising networks track users' browsing habits around the internet building lucrative profiles to exploit for targeted marketing or big data research. Until internet publishers develop more transparency or a new business model, we must continue to take the protection of our privacy into our hands.

Typical adblockers run as an extension in popular web browsers. As we browse the internet, they compare HTTP requests to their list of hosts and filters to selectively block advertisements, trackers, and malware. This filtering helps to protect the surfer's privacy, prevents [malvertising attacks](http://www.wired.com/insights/2014/11/malvertising-is-cybercriminals-latest-sweet-spot/ "Why Malvertising Is Cybercriminals' Latest Sweet Spot - Wired"), and [reduces bandwidth requirements](http://venturebeat.com/2015/07/08/blocking-ads-can-cut-network-traffic-25-to-40-study-shows/ "Blocking Ads Can Cut Network Traffic 25% to 40%, Study Shows - VentureBeat"). Thousands of contributors work hard to maintain these FilterLists for anyone to use. Locating and selecting these lists, however, has not historically been very easy. This project aims to solve that problem.

# Contributing

## Community

<a href="https://hub.filterlists.com"><img alt="Discourse posts" src="https://img.shields.io/discourse/https/hub.filterlists.com/posts.svg"></a>

Check out the <a href="https://hub.filterlists.com">FilterLists Hub</a>, a place for discussing how to write rules, maintain FilterLists, and chat about the state of the adblocking community.

## Adding or Updating Lists

To submit a new list or update data about an existing list, please submit a pull request to [data](https://github.com/collinbarrett/FilterLists/tree/master/data) in conjunction with the data model described [here](https://github.com/collinbarrett/FilterLists/wiki/Data-Model_sidebar). Alternatively, you can [open a new issue](https://github.com/collinbarrett/FilterLists/issues/new) providing information for all of the fields described in the [data model](https://github.com/collinbarrett/FilterLists/wiki/Data-Model_sidebar).

## Adding or Updating Rules

FilterLists does not maintain any of these lists. It serves only as a discovery tool to direct users to lists that they may want to use. If you want to request addition, modification, or removal of a rule from a list, you will need to contact the maintainers of that list directly. FilterLists provides a variety of ways you can get in contact with the maintainers to do so.

## Building and Running Locally

We have containerized FilterLists to make it as easy as possible for contributers to get the project up and running locally.

### Up and Running

1. Install Docker CE for your computer's operating system. [Docs](https://docs.docker.com/install/)
2. Clone the FilterLists git repository to your computer. [Docs](https://help.github.com/en/articles/cloning-a-repository)
3. Navigate to the root directory of your locally cloned FilterLists git repository in a command-line interface.
4. Execute `docker-compose up`. (Optionally, include the `-d` flag to launch in [detached mode](https://docs.docker.com/compose/reference/up/).)
5. After a minute or so, visit the locally running version of FilterLists in a web browser at `http://localhost/`.

### Configuration

The `appsettings*.json` files are only used when debugging in Visual Studio outside of Docker ([they are not copied into the built runtime images](https://github.com/collinbarrett/FilterLists/blob/59a4e067b35110ebda5d5cf1e3ef96cab2fcbfe5/.dockerignore#L28)). When running any of the projects in containers via Docker/Docker Compose, the configuration is passed in as environment variables configured in [`.env`](https://github.com/collinbarrett/FilterLists/blob/master/.env) and `docker-compose*.yml` files.

### Testing changes to the data (.json files)

#### Automated

Execute:

`docker volume create test-data-results && docker-compose -p test-data -f docker-compose.data.tests.yml down -v && docker-compose -f docker-compose.data.tests.yml build api && docker-compose -p test-data -f docker-compose.data.tests.yml run --rm api`

#### Manual

1. Execute `docker-compose up -d --build api`.
2. Verify your changes are properly reflected at `http://localhost/`.

### Testing changes to the `Api`, `Services`, or `Data` projects

#### Automated

- To run `FilterLists.Services.Tests`:

  `docker volume create test-services-results && docker-compose -f docker-compose.services.tests.yml build api && docker-compose -p test-services -f docker-compose.services.tests.yml run --rm api`

- To run `FilterLists.Data.Tests`:

  `docker volume create test-data-results && docker-compose -p test-data -f docker-compose.data.tests.yml down -v && docker-compose -f docker-compose.data.tests.yml build api && docker-compose -p test-data -f docker-compose.data.tests.yml run --rm api`

#### Manual

1. Execute `docker-compose up -d --build api`.
2. Verify your changes are properly reflected at `http://localhost/api`.

### Testing changes to the `Web` project

1. Execute `docker-compose up -d --build web`.
2. Verify your changes are properly reflected at `http://localhost/`.

### Testing changes to the `Agent` project

The Agent takes the following command line arguments:

- `-a` Archive copies of all lists in a git repository.
- `-c` Validate all URLs in the FilterLists database.

#### Automated

- To run `FilterLists.Agent.Tests`:

  `docker volume create test-agent-results && docker-compose -f docker-compose.agent.tests.yml build agent && docker-compose -p test-agent -f docker-compose.agent.tests.yml run --rm agent`

#### Manual

1. Execute `docker-compose build agent && docker-compose run agent [-c] [-v]` (don't include the square brackets, they indicate optional command line arguments).
2. Verify your changes are properly reflected in the console logger.

### Debugging

1. Execute `docker container ls -a` to find the `CONTAINER ID` of the container in question.
2. Execute `docker logs [CONTAINER ID]` replacing `[CONTAINER ID]` with the hash from step 1 to view the logs from that container.

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
- [Docker Hub](https://www.docker.com/legal/docker-privacy-policy)
- [DigitalOcean](https://www.digitalocean.com/legal/privacy-policy/)
- [Application Insights](https://docs.microsoft.com/en-us/azure/application-insights/app-insights-data-retention-privacy)
- [Cloudflare](https://www.cloudflare.com/analytics/)

## Internet Explorer

FilterLists does not support Internet Explorer. To view a smaller, TPL-only archive with subscribable links, right-click on [this link](https://raw.githubusercontent.com/collinbarrett/FilterLists/master/data/TPLSubscriptionAssistant.html), choose to save it as an HTML file, and open it in Internet Explorer ≥9.
