# init base
FROM nginx:alpine as base
COPY server/conf.d /etc/nginx/conf.d

# init install
FROM node:alpine as install

# https://github.com/nodejs/docker-node/blob/master/docs/BestPractices.md#node-gyp-alpine
RUN apk add --no-cache python make g++

# install
WORKDIR /usr/src/app/
COPY package*.json ./
RUN npm ci --only=production

# init build
FROM node:alpine as build
WORKDIR /usr/src/app/
COPY --from=install /usr/src/app/node_modules ./node_modules

# build
COPY . .
RUN npm run build

# final
FROM base as final
COPY --from=build /usr/src/app/build /usr/share/nginx/html