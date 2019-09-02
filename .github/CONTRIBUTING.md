## Community

<a href="https://hub.filterlists.com"><img alt="Discourse posts" src="https://img.shields.io/discourse/https/hub.filterlists.com/posts.svg"></a>

Check out the <a href="https://hub.filterlists.com">FilterLists Hub</a>, a place for discussing how to write rules, maintain FilterLists, and chat about the state of the adblocking community.

## Adding or Updating Lists

To submit a new list or update data about an existing list, please submit a pull request to [data](https://github.com/collinbarrett/FilterLists/tree/master/data) in conjunction with the data model described [here](https://github.com/collinbarrett/FilterLists/wiki/Data-Model_sidebar). Alternatively, you can [open a new issue](https://github.com/collinbarrett/FilterLists/issues/new) providing information for all of the fields described in the [data model](https://github.com/collinbarrett/FilterLists/wiki/Data-Model_sidebar).

While we are generally very open and welcoming of any new or changed lists, a few conditions apply (although loosely):

* Adding the smaller text files that make up one complete list, e.g. *[EasyList General Block Popup](https://raw.githubusercontent.com/easylist/easylist/master/easylist/easylist_general_block_popup.txt)*, is not usually done. We do however do it for the language files of *[ABP Anti-Circumvention Filter List](https://easylist-downloads.adblockplus.org/abp-filters-anti-cv.txt)*; but due to its often-changing entries, those files should have ≥5 entries that cover ≥3 sites at the time of addition.
* Since `CHEF-KOCH` has a registered history of behaving aggressively and unfairly towards other filterlist makers and the FilterLists.com community, a case to add any of his lists would have had to be very strong, and mass additions are out of the question.

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
