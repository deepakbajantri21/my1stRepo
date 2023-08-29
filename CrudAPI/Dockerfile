FROM node:14.17.3
COPY package*.json ./
RUN npm install -g @angular/cli
RUN npm install --only=production
COPY . ./
RUN ng serve
EXPOSE 8080
CMD ["node", "server.js"]