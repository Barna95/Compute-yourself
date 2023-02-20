# ==== CONFIGURE =====
# Use a Node 16 base image
FROM node
# Set the working directory to /app inside the container
WORKDIR /app
# Copy app files
COPY package*.json ./

# ==== BUILD =====
# Install dependencies (npm ci makes sure the exact versions in the lockfile gets installed)
RUN npm install -g npm@9.5.0
RUN npm install 
COPY . .
# Build the app
RUN npm run build
# ==== RUN =======
# Set the env to "production"
# ENV NODE_ENV production
# Expose the port on which the app will be running (3000 is the default that `serve` uses)
EXPOSE 5173
# Start the app
CMD [ "npm", "start" ]