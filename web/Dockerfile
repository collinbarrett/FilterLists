# init base
FROM nginx:alpine as base
LABEL org.opencontainers.image.description="filterlists.com | github.com/collinbarrett/filterlists | A React & TypeScript UI built with Ant Design."
COPY server/conf.d /etc/nginx/conf.d

# init build
# https://github.com/facebook/create-react-app/issues/11565
# FROM node:alpine as build
FROM node:lts-alpine3.14 as build

# https://github.com/nodejs/docker-node/blob/master/docs/BestPractices.md#node-gyp-alpine
RUN apk add --no-cache python3 make g++

# install
WORKDIR /app
COPY package*.json ./
RUN npm ci --only=production

# build
COPY . ./
RUN INLINE_RUNTIME_CHUNK=false npm run build

# final
FROM base as final
COPY --from=build /app/build /usr/share/nginx/html
