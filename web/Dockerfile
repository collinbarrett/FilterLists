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
RUN npm install --only=prod

# build
COPY . ./
RUN INLINE_RUNTIME_CHUNK=false npm run build

# final
FROM base as final
COPY --from=build /usr/src/app/build /usr/share/nginx/html