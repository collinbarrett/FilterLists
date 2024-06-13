<p align="center"><img src="https://github.com/collinbarrett/FilterLists/blob/main/img/logo_filterlists_outlined.png"></p>

<p align="center"><a href="https://twitter.com/FilterLists"><img alt="Twitter" src="https://img.shields.io/twitter/follow/FilterLists?style=social"></a>
<a href="https://github.com/collinbarrett/FilterLists/blob/main/LICENSE"><img alt="License" src="https://img.shields.io/github/license/collinbarrett/filterlists.svg?label=License"></a>
<a href="https://builtwithdot.net/project/125/filterlists"><img alt="BuiltWithDot.net" src="https://builtwithdot.net/project/125/filterlists/badge" /></a>
<a href="https://madewithreactjs.com/p/filterlists/shield-link"><img alt="MadeWithReactJS.com" src="https://madewithreactjs.com/storage/repo-shields/2335-shield.svg"/></a>
<br/>FilterLists is the independent, comprehensive directory of filter and host lists for advertisements, trackers, malware, and annoyances.</p>

# Background

FilterLists helps to protect your privacy and security when using the internet. It provides a comprehensive directory of subscription lists to block advertisements, malware, trackers, and other general annoyances. First, install one of the software tools that supports these lists. Then you can subscribe to a set of these lists inside of that software. If you need help or have a comment/question, start a [Discussion](https://github.com/collinbarrett/FilterLists/discussions).

Using a software firewall or adblocker has become a key tool in protecting one's privacy online. While the current business model of the "free" internet relies upon advertising revenue, publishers have become too flippant about tracking users without their consent. Advertising networks track users' browsing habits around the internet building lucrative profiles to exploit for targeted marketing or big data research. Until internet publishers develop more transparency or a new business model, we must continue to take the protection of our privacy into our hands.

Typical adblockers run as an extension in popular web browsers. As we browse the internet, they compare HTTP requests to their list of hosts and filters to selectively block advertisements, trackers, and malware. This filtering helps to protect the surfer's privacy, prevents [malvertising attacks](http://www.wired.com/insights/2014/11/malvertising-is-cybercriminals-latest-sweet-spot/ "Why Malvertising Is Cybercriminals' Latest Sweet Spot - Wired"), and [reduces bandwidth requirements](http://venturebeat.com/2015/07/08/blocking-ads-can-cut-network-traffic-25-to-40-study-shows/ 'Blocking Ads Can Cut Network Traffic 25% to 40%, Study Shows - VentureBeat'). Thousands of contributors work hard to maintain these FilterLists for anyone to use. Locating and selecting these lists, however, has not historically been very easy. This project was launched in 2015 to solve that problem.

# Services

| Service       | Description                                                                               | More                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| ------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Website       | A React & TypeScript UI built with Ant Design.                                            | [![Website](https://img.shields.io/website-up-down-green-red/http/shields.io.svg?label=Website)](https://filterlists.com/)                                                                                                                                                                                                                                                                                                                                                                                                               |
| Directory API | An ASP.NET Core API serving the core FilterList information.                              | [![Directory API Swagger UI](https://img.shields.io/website-up-down-green-red/http/shields.io.svg?label=API%20Docs)](https://api.filterlists.com) [![Directory API OpenAPI Specification](https://img.shields.io/swagger/valid/3.0?specUrl=https%3A%2F%2Fapi.filterlists.com%2Fswagger%2Fv1%2Fswagger.json)](https://api.filterlists.com/swagger/v1/swagger.json) [![Directory API Docker Image](https://img.shields.io/badge/docker%20image-directory--api-blue?label=Docker%20Image)](https://github.com/users/collinbarrett/packages/container/package/filterlists-directory-api)

# Contributing

## Adding or Updating Lists

To submit a new list or update data about an existing list, please submit a pull request to [data](https://github.com/collinbarrett/FilterLists/tree/main/services/Directory/data) in conjunction with the data model described [here](https://github.com/collinbarrett/FilterLists/wiki/Data-Model_sidebar). Once you open the pull request, our [Migrate bot](https://github.com/collinbarrett/FilterLists/blob/main/services/Directory/azure-pipelines.migrate.yaml) will create an [Entity Framework Core migration](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli) with your changes and test them. Please ensure to [grant the bot permissions to push to your pull request branch](https://help.github.com/en/github/collaborating-with-issues-and-pull-requests/allowing-changes-to-a-pull-request-branch-created-from-a-fork). You can find more details on this process [here](https://github.com/collinbarrett/FilterLists/issues/1674).

Alternatively, you can [open a new issue](https://github.com/collinbarrett/FilterLists/issues/new) providing information for all of the fields described in the [data model](https://github.com/collinbarrett/FilterLists/wiki/Data-Model_sidebar).

In the future, we hope to have an easier form UI to submit updates. Follow [this issue](https://github.com/collinbarrett/FilterLists/issues/372) for any progress on that feature.

Note: Since the primary FilterLists.com site does not support Internet Explorer, we also have a separate page for tracking protection lists (TPL) [here](https://github.com/collinbarrett/FilterLists/blob/main/web/public/tpl.html) and viewed [here](https://filterlists.com/tpl.html).

## Adding or Updating Rules

FilterLists does not maintain any of these lists. It serves only as a discovery tool to direct users to lists that they may want to use. If you want to request addition, modification, or removal of a rule from a list, you will need to contact the maintainers of that list directly. FilterLists provides a variety of ways you can get in contact with the maintainers to do so.

## Building and Running Locally

FilterLists is build on the .NET Aspire stack. Install the [.NET Aspire prerequisites](https://learn.microsoft.com/en-us/dotnet/aspire/fundamentals/setup-tooling) before proceeding.

### Directory API

#### Prepare Database Volume

So that the database does not need to be re-seeded on every startup, the SQL Server container is configured with a volume mount. Create a persistent password in order for this to be accessed by executing the command below in `services/FilterLists.AppHost` replacing `<password>` with a custom password:

```bash
dotnet user-secrets set Parameters:directorysqlserver-password <password>
```

Alternatively, remove the `.WithDataVolume()` configuration on the `directoryDb` resource in `services/FilterLists.AppHost/Program.cs` to re-seed the database on every startup.

[MS Learn](https://learn.microsoft.com/en-us/dotnet/aspire/fundamentals/persist-data-volumes)

#### Adding EF Core Migrations

Modify the database schema or seed data by adding an EF Core migration. 

1. Install the [EF Core tools](https://learn.microsoft.com/en-us/ef/core/cli/dotnet#installing-the-tools).
2. Modify the `QueryDbContext` EF Core model or the seed data.
3. Execute the command below in the `services/Directory` directory replacing `<MigrationName>` with a meaningful name.

```bash
dotnet ef migrations add <MigrationName> -p FilterLists.Directory.Infrastructure.Migrations -s FilterLists.Directory.Api
```

## Deploying to Production

### Directory API

#### Create and Prepare SQL Server Database

Create an instance of SQL Server containing the users below.

##### Migrations user for applying EF Core migrations

```sql
USE [master];
GO

CREATE LOGIN [Migrations] WITH PASSWORD = 'my_password';
GO

USE [directorydb];
GO

CREATE USER [Migrations] FOR LOGIN [Migrations];
ALTER ROLE [db_ddladmin] ADD MEMBER [Migrations]; -- to apply migrations
ALTER ROLE [db_datareader] ADD MEMBER [Migrations]; -- to read from __EFMigrationsHistory
ALTER ROLE [db_datawriter] ADD MEMBER [Migrations]; -- to insert to __EFMigrationsHistory
```

##### ApiReadonly for API runtime reads

```sql
USE [master];
GO

CREATE LOGIN [ApiReadonly] WITH PASSWORD = 'my_password';
GO

USE [directorydb];
GO

CREATE USER [ApiReadonly] FOR LOGIN [ApiReadonly];
ALTER ROLE [db_datareader] ADD MEMBER [ApiReadonly];
```

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
- [Azure](https://azure.microsoft.com/en-us/explore/trusted-cloud/privacy/)
- [Cloudflare](https://www.cloudflare.com/analytics/)
