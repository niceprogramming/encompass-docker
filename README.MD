# Running Encompass SDK in Docker

This repo contains an example about how to get the Encompass up and running in Docker. There is a possibility this breaks in the future as the SDK initialization relies heavily on certain registry entries and file paths existing. 

Along with this the SDK no longer checks for the mac addresses and such to validate a license. The only thing that needs to exist is a valid serializable license in the registry. This image is setup with a valid license that was provided in the SDK documentation and not part of any actual companies licensing. You can generate a license through the SDK with your own key but I am unsure if ICE removed the limit on the amount of SDK activations per license so you could look into that as an option as well.

Also provided in a sample application in which you need to fill out the `App.config`.

## Repo Usage

Download and install docker desktop `https://www.docker.com/products/docker-desktop/`

To build the base image with the SDK install and registry entries, open a terminal in the root of the repo and run. 

```
docker build --pull --rm -f "src\Dockerfile" -t encompasssdk:latest "src"
```
Then to build the sample application run


```
cd sample
cd EncompassDockerSample
docker build -t encompasssample .
docker run --rm encompasssample:latest
```

If all goes well it should output your Encompass ID and personas
