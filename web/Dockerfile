# Context: ./web
# Command: docker build ./web

# init base
FROM nginx:alpine as base
COPY nginx/conf.d /etc/nginx/conf.d

# init build
FROM node:alpine as build

# install
WORKDIR /usr/src/app/
COPY package*.json ./
RUN npm ci --only=production

# build
COPY . .
RUN npm run build

# final
FROM base as final
COPY --from=build /usr/src/app/build /usr/share/nginx/html