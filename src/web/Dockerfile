FROM node:alpine
CMD ["npm", "start"]
EXPOSE 3000
WORKDIR /usr/app/
COPY src/web/package*.json ./
RUN npm install -qy
COPY src/web/. ./