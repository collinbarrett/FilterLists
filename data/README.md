## Adding or Updating Lists

To submit a new list or update data about an existing list, please submit a pull request to [data](https://github.com/collinbarrett/FilterLists/tree/master/data) in conjunction with the data model described [here](https://github.com/collinbarrett/FilterLists/wiki/Data-Model_sidebar). Alternatively, you can [open a new issue](https://github.com/collinbarrett/FilterLists/issues/new) providing information for all of the fields described in the [data model](https://github.com/collinbarrett/FilterLists/wiki/Data-Model_sidebar).

## Building and Running Locally

We have containerized FilterLists to make it as easy as possible for contributers to get the project up and running locally.

### Up and Running

1. Install Docker CE for your computer's operating system. [Docs](https://docs.docker.com/install/)
2. Clone the FilterLists git repository to your computer. [Docs](https://help.github.com/en/articles/cloning-a-repository)
3. Navigate to the root directory of your locally cloned FilterLists git repository in a command-line interface.
4. Execute `docker-compose up`.
5. Visit the locally running version of FilterLists in a web browser at `http://localhost/`.

### Testing changes to the data (.json files)

#### Automated

Execute:

`docker-compose -f docker-compose.data.tests.yml down -v && docker-compose -f docker-compose.data.tests.yml build api && docker-compose -f docker-compose.data.tests.yml run api`

#### Manual

1. Execute `docker container ls` to find the `CONTAINER ID` of the `filterlists.api` container.
2. Execute `docker-compose up -d --build [CONTAINER ID]` replacing `[CONTAINER ID]` with the hash from step 1.
3. Verify your changes are properly reflected at `http://localhost/`.
