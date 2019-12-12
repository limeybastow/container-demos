```
docker image rm limeybastow/hello-dotnet
docker image rm datalust/seq

dotnet ConsoleApp.dll

docker container rm limeybastow/hello-dotnet -f

docker pull datalust/seq:latest

docker pull limeybastow/hello-dotnet
docker run --rm limeybastow/hello-dotnet

docker network create demo-net
docker volume create seq-data
docker run --rm --name seq-server --mount source=seq-data,target=/data -d -e ACCEPT_EULA=Y -p 5341:80 --net demo-net datalust/seq:latest
docker run --restart on-failure --name hello-dotnet -e SEQ_URL=http://seq-server:5341/ --net demo-net hello-dotnet

docker container rm seq-server –f
docker container rm hello-dotnet –f
docker image rm limeybastow/hello-dotnet
docker image rm datalust/seq
```