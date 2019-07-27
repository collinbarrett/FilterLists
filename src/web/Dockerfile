# Context: .
# Command: docker build -f src/FilterLists.Web/Dockerfile .

# init base
FROM node:alpine as final
CMD ["npm", "start"]
EXPOSE 3000
WORKDIR /usr/app/

# install
COPY src/web/package*.json ./
RUN npm install -qy --only=prod

# final
COPY src/web/. ./