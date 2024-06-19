# start from official image
FROM node:20-alpine

# create working directory
RUN mkdir -p /code
WORKDIR /code

# copy project code
COPY /bitmex_streamer /code

# install dependencies
RUN npm install npm@latest -g
RUN cd nodejs && npm install
RUN cd delta-server && npm install 

# change to non-root user

# expose port
EXPOSE 4444

# default commands to run when starting the container
CMD ["node", "delta-server/index.js"]
