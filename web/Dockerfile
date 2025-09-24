# Multi-stage build for React application

# Build stage
FROM node:18-alpine AS builder
WORKDIR /app

# Copy package files
COPY package*.json ./

# Install dependencies
RUN npm ci --only=production && npm ci

# Copy source code
COPY . .

# Build the application
RUN npm run build

# Production stage
FROM nginx:alpine
# Copy built assets from builder stage
COPY --from=builder /app/build /usr/share/nginx/html

# Create nginx configuration for React Router
RUN echo 'server {\
    listen 80;\
    listen [::]:80;\
    server_name localhost;\
    location / {\
        root /usr/share/nginx/html;\
        index index.html index.htm;\
        try_files $uri $uri/ /index.html;\
    }\
    error_page 500 502 503 504 /50x.html;\
    location = /50x.html {\
        root /usr/share/nginx/html;\
    }\
}' > /etc/nginx/conf.d/default.conf

EXPOSE 80

CMD ["nginx", "-g", "daemon off;"]