# init base
FROM nginx:alpine as base
COPY server/conf.d /etc/nginx/conf.d

# init build
FROM node:alpine as build

# https://github.com/nodejs/docker-node/blob/master/docs/BestPractices.md#node-gyp-alpine
RUN apk add --no-cache python make g++

# install
WORKDIR /app
COPY package*.json ./
RUN npm ci --only=production

# build
COPY . ./
RUN npm run build

# final
FROM base as final
COPY --from=build /app/build /usr/share/nginx/html