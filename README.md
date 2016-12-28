# httppipeline
Cross platform HTTP request pipeline built using ASP.Net Core.

This repository contains source code for building HTTP request pipeline which can run on Mac, Windows, Linux or Docker container. To view tutorial on how to build this please visit https://www.codeproject.com/Articles/1158001/Create-HTTP-request-pipeline-using-ASP-NET-Core

You can build Docker image using the dockerfile in the respository or edit the code in dockerfile to suit your your requirements

You can build docker image in Command Line from DemoApp working directory.

  docker build . -t np:demoapp

When  the Docker image is built successfully, spin the Docker  container using below command. Replace -d with -i to run container in interactive mode instead of detach mode (in background).

  docker run -d -p 80:5000 -t np:demoapp

You can see list of all containers with command

  docker ps -a
  
To get to container's shell, try

  $ sudo docker exec -i -t 665b4a1e17b6 /bin/bash #by ID
  
  or
  
  $ sudo docker exec -i -t loving_heisenberg /bin/bash #by Name
  
  $ root@665b4a1e17b6:/#

For more Docker Command Line reference go to https://docs.docker.com/engine/reference/commandline/run/.
