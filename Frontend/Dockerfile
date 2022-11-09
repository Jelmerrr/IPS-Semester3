FROM node:16.9.1

ENV ADB_IP="0.0.0.0"
ENV REACT_NATIVE_PACKAGER_HOSTNAME="0.0.0.0"

ARG PORT=19006
ENV PORT $PORT
EXPOSE $PORT 19001 19002 19000

WORKDIR /app



COPY package.json ./
COPY package-lock.json ./
RUN npm install
RUN npm install react-scripts@3.4.1 -g

COPY . ./
CMD npm start