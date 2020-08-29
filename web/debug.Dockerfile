# init
FROM node:alpine
ENV PATH /app/node_modules/.bin:$PATH

# install
RUN npm install react-scripts -g
WORKDIR /usr/src/app/
COPY package*.json ./
RUN npm install

# start
COPY . ./
CMD ["npm", "start"]