# Context: .
# Command: docker build -f src/FilterLists.Web/Dockerfile .

# init base
FROM node:alpine as base
EXPOSE 3000
WORKDIR /usr/app/
ENTRYPOINT ["serve", "-s"]
RUN npm install -g serve

# init build
FROM node:alpine as build

# install
WORKDIR /usr/src/app/
COPY src/FilterLists.Web/package*.json ./
RUN npm install --only=prod

# build
COPY src/FilterLists.Web/. ./
RUN npm run build

# final
FROM base as final
COPY --from=build /usr/src/app/build ./