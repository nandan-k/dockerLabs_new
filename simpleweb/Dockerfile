#base
from node:latest
#dependencies
workdir /usr/app
copy ./package.json ./
run npm install
copy ./ ./
#run
cmd ["npm","start"]